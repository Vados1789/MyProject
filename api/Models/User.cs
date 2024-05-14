using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class User
    {
        [Key]
        [Column("id")] // Указываем соответствие между свойством Id и столбцом 'id'
        public int Id { get; set; }

        [Column("first_name")] // Указываем соответствие между свойством First_Name и столбцом 'first_name'
        public string First_Name { get; set; }

        [Column("last_name")] // Указываем соответствие между свойством Last_Name и столбцом 'last_name'
        public string Last_Name { get; set; }

        [Column("email")] // Указываем соответствие между свойством Email и столбцом 'email'
        public string Email { get; set; }

        [Column("created_at")] // Указываем соответствие между свойством Created_At и столбцом 'created_at'
        public DateTime Created_At { get; set; }
    }
}

