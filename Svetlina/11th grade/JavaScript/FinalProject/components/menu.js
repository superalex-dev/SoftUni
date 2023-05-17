import { html, render } from 'https://unpkg.com/lit-html?module';

const menuTemplate = () => html`
  <nav>
    <ul>
      <li><a href="#home">Home</a></li>
      <li><a href="#catalog">Catalog</a></li>
      <li><a href="#edit">Edit</a></li>
      <li><a href="#logout">Logout</a></li>
    </ul>
  </nav>
`;

export const renderMenu = () => {
  const menuContainer = document.getElementById('menu-container');
  render(menuTemplate(), menuContainer);
};
