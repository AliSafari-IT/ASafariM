// apps/frontends/asafarim-client/src/api/authapi.ts
// 
import axios, { AxiosError } from 'axios';
import { ILoginModel } from '../interfaces/ILoginModel';
import { IRegisterModel } from '../interfaces/IRegisterModel';
import { IErrorData } from '@/interfaces/IErrorData';
const isDevelopment = import.meta.env.VITE_ENVIRONMENT === 'development';

const BASE_URL = isDevelopment ? 'https://localhost:5001' : 'https://asafarim.com';
const API_Auth_URL = isDevelopment ? BASE_URL + '/api/Auth' : 'https://asafarim.com/api/auth';
const API_URL = isDevelopment ? BASE_URL + '/api' : 'https://asafarim.com/api';
console.log("API_URL is:", API_Auth_URL);
console.log("BASE_URL is:", BASE_URL);
console.log("API_URL is:", API_URL);

const api = axios.create({
  baseURL: API_Auth_URL,
  headers: {
    'Content-Type': 'application/json',
  },
});

export const register = async (model: IRegisterModel) => {
  try {
    console.log("authapi: register is:", model);
    const response = await api.post('/register', model);
    console.log("authapi: response is:", response);
    return response.data;
  } catch (error) {
    const err = error as AxiosError;
    if (!err.response) {
      throw new Error('Network error occurred');
    }

    const errorData = err.response?.data as IErrorData | undefined;

    if (!errorData) {
      throw new Error('Unknown error occurred');
    }

    if (Array.isArray(errorData)) {
      throw new Error(errorData[0]?.description || 'Registration failed');
    }

    if (errorData.errors && Array.isArray(errorData.errors)) {
      throw new Error(errorData.errors[0]?.description || 'Registration failed');
    }

    throw new Error(errorData.error || errorData.message || 'Registration failed');
  }
};

export const login = async (credentials: ILoginModel) => {
  console.log("Login request payload:", credentials);
  const response = await api.post('/login', credentials, {
      headers: { 'Content-Type': 'application/json' },
  });
  return response.data;
};

export const requestAccountReactivation = async (email: string) => {
  try {
    const response = await axios.post(`${API_URL}/Users/request-reactivation`, { email });
    return response.data;
  } catch (error) {
    const err = error as AxiosError;
    if (err.message) {
      throw err.message;
    }
    const errorData = err.response?.data as { error?: string };
    throw errorData.error || 'Failed to send reactivation request.';
  }
};
