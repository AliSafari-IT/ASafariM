import React from 'react';
import ReactDOM from 'react-dom/client';
import { BrowserRouter as Router } from 'react-router-dom';
import App from './App';
import './index.css';
import { initializeIcons } from '@fluentui/font-icons-mdl2';

initializeIcons();

const AppWithRouter = () => (
  <Router>
    <App />
  </Router>
)

ReactDOM.createRoot(document.getElementById('root')!).render(
  <React.StrictMode>
    <AppWithRouter />
  </React.StrictMode>
);
