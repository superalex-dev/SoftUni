import { html, render } from 'lit-html';
import page from 'page';
import firebase from 'firebase/app';
import 'firebase/firestore';
import 'firebase/auth';

const firebaseConfig = {

  //firebase config

};

firebase.initializeApp(firebaseConfig);

const db = firebase.firestore();
const auth = firebase.auth();

// Define your application's routes using Page.js
page('/', homePage);
page('/login', loginPage);
page('/register', registerPage);
page('/catalog', catalogPage);
// Add more routes as needed

page();

// Page rendering functions using Lit-html
function homePage() {
  const template = html`
    <!-- Your home page HTML content here -->
  `;
  render(template, document.body);
}

function loginPage() {
  const template = html`
    <!-- Your login page HTML content here -->
  `;
  render(template, document.body);
}

function registerPage() {
  const template = html`
    <!-- Your register page HTML content here -->
  `;
  render(template, document.body);
}

function catalogPage() {
  const template = html`
    <!-- Your catalog page HTML content here -->
  `;
  render(template, document.body);
}
