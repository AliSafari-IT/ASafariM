// E:\asm-fs\apps\frontends\asafarim-client\src\api\userService.ts 
import axios from 'axios';
import { IUser } from '../interfaces/IUser';
import { IUserModel } from '../interfaces/IUserModel';
import { IRole, IUserModelUpdate, IUserRole } from '@/interfaces';

// in development mode use https://localhost:5001/api/users
// in production mode use https://asafarim.com/api/users
const isDevelopment = import.meta.env.VITE_ENVIRONMENT === 'development';
const BASE_API_URL = isDevelopment ? 'https://localhost:5001/api' : 'https://asafarim.com/api';
const USERS_URL = `${BASE_API_URL}/users`;  // Changed to lowercase to match backend route
const ROLES_URL = `${BASE_API_URL}/roles`;  // Changed to lowercase to match backend route
const USER_ROLES_URL = `${BASE_API_URL}/userroles`;  // Added URL for user roles
const auth = localStorage.getItem('auth') ? JSON.parse(localStorage.getItem('auth') || '{}') : null;
const api = axios.create({
  baseURL: BASE_API_URL,
});

api.defaults.headers.common['Accept'] = 'application/json';
api.defaults.headers.common['Content-Type'] = 'application/json';
api.defaults.headers.common['Authorization'] = `Bearer ${auth?.token}`;

// Enhanced type for user update validation
interface UserUpdateValidation {
  isValid: boolean;
  errors: string[];
}

// Validate user update data
// Validate user update data
const validateUserUpdate = (user: IUserModelUpdate): UserUpdateValidation => {
  const errors: string[] = [];

  // Validate ID
  if (!user.id) {
    errors.push('User ID is required');
  }

  // Validate firstName
  if (user.firstName !== undefined) {
    if (typeof user.firstName !== 'string') {
      errors.push('First name must be a string');
    } else if (user.firstName.trim().length === 0) {
      errors.push('First name cannot be empty');
    } else if (user.firstName.trim().length < 2) {
      errors.push('First name must be at least 2 characters long');
    } else if (user.firstName.trim().length > 50) {
      errors.push('First name cannot exceed 50 characters');
    }
  }

  // Log validation results for debugging
  console.log('Validation results:', {
    user,
    errors,
    isValid: errors.length === 0
  });

  return {
    isValid: errors.length === 0,
    errors
  };
};


// Add axios interceptor for handling network errors
api.interceptors.response.use(
  (response) => response,
  (error) => {
    if (error.message === 'Network Error') {
      console.error('Network error occurred:', error);
      // Only remove auth if it's a 401 or 403
      if (error.response?.status === 401 || error.response?.status === 403) {
        localStorage.removeItem('auth');
        window.dispatchEvent(new Event('authStateChange'));
      }
    }
    return Promise.reject(error);
  }
);

// Get all users
export const getUsers = async (): Promise<IUser[]> => {
  try {
    console.log('Fetching users from:', USERS_URL);
    const response = await api.get(USERS_URL);
    console.log('Users API response:', response);

    if (!response.data) {
      console.error('No data received from users API');
      return [];
    }

    const users = response.data;
    console.log('Parsed users:', users);
    return users;
  } catch (error) {
    if (axios.isAxiosError(error)) {
      console.error('Axios error fetching users:', {
        message: error.message,
        status: error.response?.status,
        statusText: error.response?.statusText,
        data: error.response?.data
      });
    } else {
      console.error('Unknown error fetching users:', error);
    }
    throw error;
  }
};

// Get a single user by ID
export const getUserById = async (id: string): Promise<IUser> => {
  try {
    const response = await api.get(`/users/${id}`);
    console.log("userService => getUserById: response.data", response.data);
    return response.data;
  } catch (error) {
    console.error('Error fetching user by ID:', error);
    // Trigger auth state change
    if (axios.isAxiosError(error) && error.response?.status === 404) {
      console.error("User not found:", id);
      throw new Error("User not found.");
    }
    throw error;
  }
};

// Get roles
export const getRoles = async (): Promise<IRole[]> => {
  const response = await api.get(ROLES_URL);
  console.log("userService => getRoles: response.data", response.data);
  return response.data;
};

// Get user roles getRolesByUserId
export const getRolesByUserId = async (userId: string): Promise<IUserRole[]> => {
  try {
    const response = await api.get(`${USER_ROLES_URL}/${userId}/roles`);
    console.log('Get roles response:', response.data);
    return response.data;
  } catch (error) {
    console.error(`Failed to fetch roles for user ${userId}:`, error);
    return [];
  }
};

// Get user's full information including the correct ID from AspNetUsers
export const getUserByEmail = async (email: string): Promise<IUser> => {
  // First, get the AspNetUsers ID for this email
  const response = await axios.get(`${USERS_URL}/by-email/${email}`);
  const aspNetUser = response.data;

  // Then get the full user info using the AspNetUsers ID
  const userResponse = await axios.get(`${USERS_URL}/${aspNetUser.id}`);
  return userResponse.data;
};

// Create a new user
export const createUser = async (user: IUserModel): Promise<IUser> => {
  console.log("createUser", user);
  const response = await axios.post(USERS_URL, user);
  return response.data;
};

// Update an existing user
export const updateUser = async (user: IUserModelUpdate): Promise<IUserModelUpdate> => {
  console.log("updateUser - Starting update with data:", user);
  const validation = validateUserUpdate(user);
  if (!validation.isValid) {
    console.error("Validation failed:", validation.errors);
    throw new Error(`Validation failed: ${validation.errors.join(', ')}`);
  }

  const targetUserUrl = `/users/${user.id}`;
  console.log("targetUserUrl for updateUser:", targetUserUrl);

  try {
    const response = await api.put(targetUserUrl, user);
    console.log("Update successful:", response.data);
    return response.data;
  } catch (error) {
    console.error('Error updating user:', error);
    throw error;
  }
};

// Create a new user by admin
export const addUserByAdmin = async (user: IUserModelUpdate): Promise<IUserModelUpdate> => {
  console.log("addUserByAdmin - User data:", user);
  const targetUserUrl = `${USERS_URL}/admin`;
  console.log("targetUserUrl for addUserByAdmin:", targetUserUrl);
  try {
    const response = await api.post(targetUserUrl, user);
    console.log("userService => addUserByAdmin with success: response.data", response.data);

    return response.data;
  } catch (error) {
    if (axios.isAxiosError(error) && error.response) {
      console.error('Error adding user:', error.response.data);
      throw new Error(error.response.data?.message || 'Failed to add user.');
    }
    throw error;
  }
}

// Update an existing user by admin
export const updateUserByAdmin = async (user: IUserModelUpdate): Promise<IUserModelUpdate> => {
  console.log("updateUserByAdmin - User data:", user);
  const targetUserUrl = `${USERS_URL}/admin/${user.id}`;
  console.log("targetUserUrl for updateUserByAdmin:", targetUserUrl);
  try {
    const response = await api.put(targetUserUrl, user);
    console.log("userService => updateUserByAdmin with success: response.data", response.data);

    return response.data;
  } catch (error) {
    if (axios.isAxiosError(error) && error.response) {
      console.error('Error updating user:', error.response.data);
      throw new Error(error.response.data?.message || 'Failed to update user.');
    }
    throw error;
  }
};

// Delete a user by ID
export const deleteUser = async (id: string): Promise<void> => {
  const deleteUrl = `${USERS_URL}/${id}`;
  console.log("deleteUser - URL:", deleteUrl);
  try {
    const response = await api.delete(deleteUrl, {
      headers: {
        'Content-Type': 'application/json'
      },
      data: {
        id
      } // Send an empty object as the body
    });
    if (response.status !== 204) { // NoContent status code
      throw new Error('Failed to delete user');
    }
  } catch (error) {
    console.error('Error deleting user:', error);
    throw error;
  }
};

// Admin can Delete a user by ID 
export const deleteUserByAdmin = async (id: string, isAdmin: boolean): Promise<void> => {
  const deleteUrl = `${USERS_URL}/admin/${id}`;
  console.log("deleteUserByAdmin - URL:", deleteUrl);
  try {
    const response = await api.delete(deleteUrl, {
      headers: {
        'Content-Type': 'application/json'
      },
      data: {
        isAdmin
      } // Send an empty object as the body
    });
    if (response.status !== 204) { // NoContent status code
      throw new Error('Failed to delete user');
    }
  } catch (error) {
    console.error('Error deleting user:', error);
    throw error;
  }
};

// Get user's full information including the correct ID from AspNetUsers
export const getUserInfo = async (userId: string) => {
  try {
    const response = await api.get(`${USERS_URL}/${userId}`);
    return response.data; // Return the user data from the response
  } catch (error) {
    console.error('Error fetching user info:', error);
    throw new Error('Error fetching user info.');
  }
};

// Assign roles to a user
export const assignRolesToUser = async (userId: string, roleIds: string[]) => {
  console.log('Assigning roles to user:', userId, 'with roles:', roleIds);
  try {
    const response = await api.post(`${USER_ROLES_URL}/${userId}/roles`, roleIds);
    console.log('Assigned roles response:', response.data);
    return response.data;
  } catch (error) {
    console.error('Error assigning roles:', error);
    throw error;
  }
};

// Remove roles from a user
export const removeRolesFromUser = async (userId: string, roleIds: string[]) => {
  console.log('Removing roles from user:', userId, 'with roles:', roleIds);
  try {
    const response = await api.delete(`${USER_ROLES_URL}/${userId}/roles`, { data: roleIds });
    console.log('Removed roles response:', response.data);
    return response.data;
  } catch (error) {
    console.error('Error removing roles:', error);
    throw error;
  }
};

// Check if a user has a role
export const userHasRole = async (userId: string, roleId: string) => {
  const response = await api.get(`${USER_ROLES_URL}/${userId}/roles/${roleId}`);
  return response.data;
};
