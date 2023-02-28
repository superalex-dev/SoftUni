// Initialize Firebase
const firebaseConfig = {
  apiKey: "API_KEY_HERE",
  authDomain: "AUTH_DOMAIN_HERE",
  projectId: "PROJECT_ID_HERE",
  storageBucket: "STORAGE_BUCKET_HERE",
  messagingSenderId: "MESSAGING_SENDER_ID_HERE",
  appId: "APP_ID_HERE"
};


firebase.initializeApp(firebaseConfig);

const app = {};

const routes = {
  '/': home,
  '/login': login,
  '/register': register,
  '/catalog': catalog,
  '/edit/:id': edit
};

app.init = function() {
  // Initialize the router
  const router = new Router(routes);
  router.init();
};

window.addEventListener('DOMContentLoaded', () => {
  app.init();
});
