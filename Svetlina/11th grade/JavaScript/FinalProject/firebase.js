// Import the functions you need from the SDKs you need
import { initializeApp } from "firebase/app";
import { getAuth } from "firebase/auth";
import { getFirestore } from "firebase/firestore";


// Your web app's Firebase configuration
const firebaseConfig = {
  apiKey: "AIzaSyAdwaLRiIUlYbsLay0_Vp8_DDj4g_xP6sM",
  authDomain: "flightfusion-71265.firebaseapp.com",
  projectId: "flightfusion-71265",
  storageBucket: "flightfusion-71265.appspot.com",
  messagingSenderId: "1029145289240",
  appId: "1:1029145289240:web:bb6b413e7d983e48ead96d"
};

// Initialize Firebase
const app = initializeApp(firebaseConfig);

// Get Firebase authentication and Firestore instances
export const auth = getAuth(app);
export const firestore = getFirestore(app);
