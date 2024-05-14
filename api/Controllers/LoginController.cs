using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using api.Models;
using api.Data;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login([FromBody] LoginDto loginDto)
        {
            System.Console.WriteLine($"bob {loginDto}");
            // Check if the provided username exists in the database
            var login = _context.Logins
                .Include(l => l.Profile)
                .FirstOrDefault(l => l.Username == loginDto.Username);

            if (login == null)
            {
                return BadRequest("Invalid username or password.");
            }

            // Verify the password
            if (login.Password != loginDto.Password)
            {
                return BadRequest("Invalid username or password.");
            }

            // If login successful, return profile data
            return Ok(new
            {
                login.Profile.Id,
                login.Profile.First_Name,
                login.Profile.Last_Name,
                login.Profile.Email,
                login.Profile.Image,
                login.Profile.Post_Code,
                login.Profile.City,
                login.Profile.Address
            });
        }
    }
}
