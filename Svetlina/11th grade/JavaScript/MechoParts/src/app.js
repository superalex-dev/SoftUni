import { html, render } from 'lit-html';
import page from 'page';
import firebase from 'firebase/app';
import 'firebase/auth';
import 'firebase/firestore';

// Initialize Firebase app and auth
const firebaseConfig = {

  //firebase config

};

const app = firebase.initializeApp(firebaseConfig);
const auth = firebase.auth();
const db = firebase.firestore();

// Define the home page template
const homePageTemplate = () => html`
  <div class="flex flex-col items-center justify-center h-screen bg-gray-100">
    <h1 class="text-3xl font-bold mb-4">Welcome to the Car Parts Website</h1>
    <p class="text-lg">Please log in or register to access the catalog and more.</p>
    <div class="mt-4">
      <a href="/login" class="text-blue-500 font-semibold hover:underline">Login</a>
      <span class="mx-2 text-gray-500">|</span>
      <a href="/register" class="text-blue-500 font-semibold hover:underline">Register</a>
    </div>
  </div>
`;

// Define the login page template
const loginPageTemplate = () => html`
  <div class="flex flex-col items-center justify-center h-screen bg-gray-100">
    <h2 class="text-2xl font-bold mb-4">Login</h2>
    <form class="w-1/3" id="loginForm">
      <div class="mb-4">
        <label for="email" class="block text-gray-700 font-semibold">Email</label>
        <input type="email" id="email" name="email" class="w-full border border-gray-300 rounded px-3 py-2">
      </div>
      <div class="mb-4">
        <label for="password" class="block text-gray-700 font-semibold">Password</label>
        <input type="password" id="password" name="password" class="w-full border border-gray-300 rounded px-3 py-2">
      </div>
      <button type="submit" class="bg-blue-500 text-white font-semibold px-4 py-2 rounded">Login</button>
    </form>
  </div>
`;

// Define the registration page template
const registerPageTemplate = () => html`
  <div class="flex flex-col items-center justify-center h-screen bg-gray-100">
    <h2 class="text-2xl font-bold mb-4">Register</h2>
    <form class="w-1/3" id="registerForm">
      <div class="mb-4">
        <label for="email" class="block text-gray-700 font-semibold">Email</label>
        <input type="email" id="email" name="email" class="w-full border border-gray-300 rounded px-3 py-2">
      </div>
      <div class="mb-4">
        <label for="password" class="block text-gray-700 font-semibold">Password</label>
        <input type="password" id="password" name="password" class="w-full border border-gray-300 rounded px-3 py-2">
      </div>
      <div class="mb-4">
        <label for="confirmPassword" class="block text-gray-700 font-semibold">Confirm Password</label>
        <input type="password" id="confirmPassword" name="confirmPassword" class="w-full border border-gray-300 rounded px-3 py-2">
      </div>
      <button type="submit" class="bg-blue-500 text-white font-semibold px-4 py-2 rounded">Register</button>
    </form>
  </div>
`;

// Define the catalog page template
const catalogPageTemplate = (products) => html`
  <div class="container mx-auto mt-8">
    <h2 class="text-2xl font-bold mb-4">Car Parts Catalog</h2>
    <div class="grid grid-cols-2 gap-4">
      ${products.map((product) => html`
        <div class="bg-white border rounded p-4 shadow">
          <h3 class="text-lg font-semibold">${product.name}</h3>
          <p class="text-gray-700">${product.description}</p>
        </div>
      `)}
    </div>
  </div>
`;

// Render the home page template
const renderHomePage = () => {
  const appContainer = document.getElementById('app');
  render(homePageTemplate(), appContainer);
};

// Render the login page template
const renderLoginPage = () => {
  const appContainer = document.getElementById('app');
  render(loginPageTemplate(), appContainer);
};

// Render the registration page template
const renderRegisterPage = () => {
  const appContainer = document.getElementById('app');
  render(registerPageTemplate(), appContainer);
};

// Render the catalog page template with the provided products
const renderCatalogPage = (products) => {
  const appContainer = document.getElementById('app');
  render(catalogPageTemplate(products), appContainer);
};

// Define the route for the home page
page('/', renderHomePage);

// Define the route for the login page
page('/login', renderLoginPage);

// Define the route for the registration page
page('/register', renderRegisterPage);

// Define the route for the catalog page
page('/catalog', async () => {
  const querySnapshot = await db.collection('products').get();
  const products = querySnapshot.docs.map((doc) => doc.data());
  renderCatalogPage(products);
});

// Start the page.js router
page();

// Attach event listeners for Firebase authentication state changes
auth.onAuthStateChanged((user) => {
  if (user) {
    // Redirect to the catalog page if the user is logged in
    page('/catalog');
  } else {
    // Render the home page for non-logged-in users
    renderHomePage();
  }
});

// Handle login form submission
document.addEventListener('submit', async (event) => {
  event.preventDefault();

  const form = event.target;
  const email = form.email.value;
  const password = form.password.value;

  try {
    await auth.signInWithEmailAndPassword(email, password);
  } catch (error) {
    console.error(error);
  }
});

// Handle registration form submission
document.addEventListener('submit', async (event) => {
  event.preventDefault();

  const form = event.target;
  const email = form.email.value;
  const password = form.password.value;
  const confirmPassword = form.confirmPassword.value;

  if (password !== confirmPassword) {
    console.log("Passwords don't match");
    return;
  }

  try {
    await auth.createUserWithEmailAndPassword(email, password);
  } catch (error) {
    console.error(error);
  }
});
