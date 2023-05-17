import { html, render } from 'https://unpkg.com/lit-html?module';

// Add the necessary Firebase imports
import { auth } from '../firebase.js';

const logoutTemplate = () => html`
  <section id="logout">
    <button @click=${handleLogout}>Logout</button>
  </section>
`;

const handleLogout = async () => {
  try {
    // Sign out the user
    await auth.signOut();
    
    // Redirect the user to the login page after successful logout
    window.location.hash = '#login';
  } catch (error) {
    console.log('Error:', error.message);
  }
};

export const renderLogout = () => {
  const appContainer = document.getElementById('app-container');
  render(logoutTemplate(), appContainer);
};
