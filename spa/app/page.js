'use client';
import Image from "next/image";
import styles from "./page.module.css";
import Profile from "./profile/page";
import Login from "./login/page";
import { useState } from 'react';

export default function Home() {
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  const [profileData, setProfileData] = useState(null);

  console.log('login', isLoggedIn);
  console.log('profileData', profileData);
  return (
    <>
      {isLoggedIn ? <Profile profileData={profileData} /> : <Login setIsLoggedIn={setIsLoggedIn} setProfileData={setProfileData} />}
    </>
  )
}
