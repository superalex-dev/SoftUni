import { html, render } from 'https://unpkg.com/lit-html?module';

// Add the necessary Firebase imports
import { auth } from '../firebase.js';

const loginTemplate = () => html`
  <section id="login">
    <h2>Login</h2>
    <form @submit=${handleSubmit}>
      <label for="email">Email:</label>
      <input type="email" id="email" name="email" required><br>
      <label for="password">Password:</label>
      <input type="password" id="password" name="password" required><br>
      <button type="submit">Login</button>
    </form>
  </section>
`;

const handleSubmit = async (event) => {
  event.preventDefault();

  const formData = new FormData(event.target);
  const email = formData.get('email');
  const password = formData.get('password');

  try {
    // Sign in the user with email and password
    await auth.signInWithEmailAndPassword(email, password);
    
    // Redirect the user to the home page after successful login
    window.location.hash = '#home';
  } catch (error) {
    console.log('Error:', error.message);
  }

  // Clear form fields
  event.target.reset();
};

export const renderLogin = () => {
  const appContainer = document.getElementById('app-container');
  render(loginTemplate(), appContainer);
};
