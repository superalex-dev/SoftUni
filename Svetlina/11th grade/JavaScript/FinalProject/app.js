import { renderHome } from './components/home.js';
import { renderRegister } from './components/register.js';
import { renderLogin } from './components/login.js';
import { renderCatalog } from './components/catalog.js';

const routes = {
  '#home': renderHome,
  '#login': renderLogin,
  '#register': renderRegister,
  '#catalog': renderCatalog,
  // Add other routes for edit and logout
};



const handleRoute = () => {
  const currentRoute = window.location.hash;
  const renderFunction = routes[currentRoute] || renderHome;
  renderFunction();
};

window.addEventListener('hashchange', handleRoute);
window.addEventListener('DOMContentLoaded', handleRoute);
