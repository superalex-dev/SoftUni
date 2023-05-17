import { renderHome } from './components/home.js';
import { renderRegister } from './components/register.js';
import { renderLogin } from './components/login.js';

const routes = {
  '#home': renderHome,
  '#login': renderLogin,
  '#register': renderRegister,
  // Add other routes for catalog, edit, and logout
};


const handleRoute = () => {
  const currentRoute = window.location.hash;
  const renderFunction = routes[currentRoute] || renderHome;
  renderFunction();
};

window.addEventListener('hashchange', handleRoute);
window.addEventListener('DOMContentLoaded', handleRoute);
