import { html, render } from 'https://unpkg.com/lit-html?module';

// Add the necessary Firebase imports
import { auth } from '../firebase.js';

const registerTemplate = () => html`
  <section id="register">
    <h2>Register</h2>
    <form @submit=${handleSubmit}>
      <label for="email">Email:</label>
      <input type="email" id="email" name="email" required><br>
      <label for="password">Password:</label>
      <input type="password" id="password" name="password" required><br>
      <button type="submit">Register</button>
    </form>
  </section>
`;

const handleSubmit = async (event) => {
  event.preventDefault();

  const formData = new FormData(event.target);
  const email = formData.get('email');
  const password = formData.get('password');

  try {
    // Create a new user with email and password
    await auth.createUserWithEmailAndPassword(email, password);
    
    // Redirect the user to the home page after successful registration
    window.location.hash = '#home';
  } catch (error) {
    console.log('Error:', error.message);
  }

  // Clear form fields
  event.target.reset();
};

export const renderRegister = () => {
  const appContainer = document.getElementById('app-container');
  render(registerTemplate(), appContainer);
};
