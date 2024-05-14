import Image from "next/image";
import styles from "./page.module.css";
import Profile from "./profile/page";
import Login from "./login/page";

export default function Home() {
  return (
    <div>
      <Profile />
      <Login />
    </div>
  )
}
