import { html, render } from 'lit-html';
import page from 'page';

// Define the home page template
const homePageTemplate = () => html`
  <h1>Welcome to the Car Parts Website</h1>
  <p>Please log in or register to access the catalog and more.</p>
  <div>
    <a href="/login">Login</a> | <a href="/register">Register</a>
  </div>
`;

// Render the home page template
const renderHomePage = () => {
  const appContainer = document.getElementById('app');
  render(homePageTemplate(), appContainer);
};

// Define the route for the home page
page('/', renderHomePage);

export default renderHomePage;