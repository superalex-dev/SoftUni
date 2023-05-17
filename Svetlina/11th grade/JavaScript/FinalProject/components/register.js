import { html, render } from 'https://unpkg.com/lit-html?module';
import { auth } from '../firebase.js';

const registerTemplate = () => html`
  <section id="register">
    <h2>Register</h2>
    <form @submit=${registerUser}>
      <label for="email">Email:</label>
      <input type="email" id="email" name="email" required>
      <label for="password">Password:</label>
      <input type="password" id="password" name="password" required>
      <button type="submit">Register</button>
    </form>
  </section>
`;

const registerUser = async (e) => {
  e.preventDefault();

  const form = e.target;
  const email = form.email.value;
  const password = form.password.value;

  try {
    const userCredential = await auth.createUserWithEmailAndPassword(email, password);
    console.log('Registration successful:', userCredential.user);
    // Optionally, you can redirect to a different page after successful registration
    // window.location.href = '#home';
  } catch (error) {
    console.error('Registration error:', error.message);
  }
};

export const renderRegister = () => {
  const appContainer = document.getElementById('app-container');
  render(registerTemplate(), appContainer);
};
