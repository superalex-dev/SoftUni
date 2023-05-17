import { renderHome } from './components/home.js';
import { renderRegister } from './components/register.js';
import { renderLogin } from './components/login.js';
import { renderCatalog } from './components/catalog.js';
import { renderEdit } from './components/edit.js';
import { renderLogout } from './components/logout.js';


const routes = {
  '#home': renderHome,
  '#login': renderLogin,
  '#register': renderRegister,
  '#catalog': renderCatalog,
  '#edit': renderEdit,
  '#logout': renderLogout,
};





const handleRoute = () => {
  const currentRoute = window.location.hash;
  const renderFunction = routes[currentRoute] || renderHome;
  renderFunction();
};

window.addEventListener('hashchange', handleRoute);
window.addEventListener('DOMContentLoaded', handleRoute);
