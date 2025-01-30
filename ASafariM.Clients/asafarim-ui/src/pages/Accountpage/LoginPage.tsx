import { useState } from 'react';
import Wrapper from '../../layout/Wrapper/Wrapper';
import { useNavigate } from 'react-router-dom';
import { login } from '../../api/authapi';
import { isAxiosError } from 'axios';
import DeletedAccountMessage from '../../components/DeletedAccountMessage';

const LoginPage = () => {
  const [email, setEmail] = useState('');
  const [password, setPassword] = useState('');
  const [error, setError] = useState<string | null>(null);
  const [loading, setLoading] = useState(false);
  const [showDeletedMessage, setShowDeletedMessage] = useState(false);
  const navigate = useNavigate();

  const handleLogin = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();

    if (!email || !password) {
      setError('Email and password are required');
      return;
    }

    setError(null);
    setLoading(true);

    try {
      const auth = await login({ email, password });
      if (auth.token) {
        localStorage.setItem('auth', JSON.stringify(auth));
        const returnTo = localStorage.getItem('returnTo') || '/';
        localStorage.removeItem('returnTo');
        navigate(returnTo);
      }
    } catch (err: unknown) {
      console.error('Login error:', err);

      // Check if err is an AxiosError
      if (isAxiosError(err)) {
        // Check for status codes and set appropriate error messages
        if (err.response) {
          const { status, data } = err.response;
          if (status === 401) {
            setError(data?.message || 'Invalid credentials.');
          } else if (status === 403) {
            setError(data?.message || 'Your account is locked. Try again later.');
          } else {
            setError('An unexpected error occurred.');
          }
        } else {
          setError('Network error. Please try again.');
        }
      } else {
        setError('An unexpected error occurred.');
      }
    } finally {
      setLoading(false);
    }
  };

  if (showDeletedMessage) {
    return (
      <Wrapper header={<div className="w-full text-center py-8 text-2xl text-primary border-b border-primary z-10">Account Deleted</div>}>
        <DeletedAccountMessage email={email} onClose={() => setShowDeletedMessage(false)} />
      </Wrapper>
    );
  }

  return (
    <Wrapper header={<div className="w-full text-center py-8 text-2xl text-primary border-b border-primary z-10">Login</div>}>
      <div className="flex items-center justify-center min-h-[calc(100vh-var(--navbar-height)-200px)]">
        <form
          onSubmit={handleLogin}
          className="login-form flex flex-col items-center justify-center space-y-6 w-full max-w-md mx-auto px-4 py-8 bg-white dark:bg-gray-800 shadow-md rounded-lg"
        >
          <div className="w-full">
            <label htmlFor="email" className="block mb-2 font-semibold text-gray-700 dark:text-gray-300">
              Email:
            </label>
            <input
              type="email"
              id="email"
              value={email}
              onChange={(e) => setEmail(e.target.value)}
              placeholder="Enter your email"
              className="w-xs px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
              required
            />
          </div>

          <div className="w-full">
            <label htmlFor="password" className="block mb-2 font-semibold text-gray-700 dark:text-gray-300">
              Password:
            </label>
            <input
              type="password"
              id="password"
              value={password}
              onChange={(e) => setPassword(e.target.value)}
              placeholder="Enter your password"
              className="w-xs px-4 py-3 rounded-md border border-gray-300 dark:border-gray-600 bg-gray-50 dark:bg-gray-700 text-gray-700 dark:text-gray-300 placeholder-gray-400 dark:placeholder-gray-500 focus:outline-none focus:ring-2 focus:ring-blue-500 dark:focus:ring-blue-400 transition-colors"
              autoComplete="current-password"
              required
            />
          </div>

          {error && (
            <div className="w-full p-4 bg-red-50 dark:bg-red-900 border border-red-300 dark:border-red-700 rounded-lg text-red-700 dark:text-red-300">
              <p className="text-sm font-medium">{error}</p>
            </div>
          )}

          <button
            type="submit"
            disabled={loading}
            className="w-full py-3 bg-blue-500 text-white rounded-lg hover:bg-blue-600 transition-colors disabled:opacity-50"
          >
            {loading ? 'Logging in...' : 'Login'}
          </button>
        </form>
      </div>
    </Wrapper>
  );
};

export default LoginPage;
