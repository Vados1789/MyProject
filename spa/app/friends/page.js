'use client'; // Add this line to mark the component for client-side execution

import React, { useEffect, useState } from 'react';

function Friends() {
  const [profiles, setProfiles] = useState([]);

  useEffect(() => {
    const fetchProfiles = async () => {
      try {
        const response = await fetch('http://localhost:5271/profile');
        if (!response.ok) {
          throw new Error('Network response was not ok');
        }
        const data = await response.json();
        console.log(data);
        setProfiles(data);
      } catch (error) {
        console.error('There was a problem with your fetch operation:', error);
      }
    };

    fetchProfiles();
  }, []);

  return (
    <div>
      <h1>Profiles</h1>
      <table>
        <thead>
          <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>Address</th>
            <th>City</th>
            <th>Post Code</th>
            <th>Image</th>
          </tr>
        </thead>
        <tbody>
          {profiles.map(profile => (
            <tr key={profile.id}>
              <td>{profile.first_Name}</td>
              <td>{profile.last_Name}</td>
              <td>{profile.email}</td>
              <td>{profile.address}</td>
              <td>{profile.city}</td>
              <td>{profile.post_Code}</td>
              <td>
                <img src={profile.image} alt={`${profile.first_Name} ${profile.last_Name}`} style={{ width: '50px', height: '50px' }} />
              </td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default Friends;
