import { html, render } from 'https://unpkg.com/lit-html?module';

const homeTemplate = () => html`
  <section id="home">
    <h2>Welcome to the Home Page</h2>
    <p>This is the home page for logged-in users.</p>
  </section>
`;

export const renderHome = () => {
  const appContainer = document.getElementById('app-container');
  render(homeTemplate(), appContainer);
};
