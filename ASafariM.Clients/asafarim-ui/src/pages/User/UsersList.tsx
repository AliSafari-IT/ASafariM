// E:\asm-fs\apps\frontends\asafarim-client\src\pages\User\UsersList.tsx
import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import { IUser } from '../../interfaces/IUser';
import { deleteUserByAdmin, getUsers, getRolesByUserId, getRoles } from '../../api/userService';
import Wrapper from '../../layout/Wrapper/Wrapper';
import Footer from '../../layout/Footer/Footer';
import Header from '@/layout/Header/Header';
import { EditSvgIcon } from '@/assets/SvgIcons/EditSvgIcon';
import { DeleteSvgIcon } from '@/assets/SvgIcons/DeleteSvgIcon';
import { ViewSvgIcon } from '@/assets/SvgIcons/ViewSvgIcon';
import useAuth from '@/hooks/useAuth';
import axios from 'axios'; // Import axios

const UsersList: React.FC = () => {
  const [users, setUsers] = useState<IUser[]>([]);
  const [error, setError] = useState<string | null>(null); // Error state
  const [userRoles, setUserRoles] = useState<Record<string, string[]>>({});
  const [roleNamesMap, setRoleNamesMap] = useState<Record<string, string>>({});
  const { authenticatedUser } = useAuth();

  // Fetch users only once on mount
  useEffect(() => {
    const fetchUsers = async () => {
      console.log('Fetching users!');
      try {
        console.log('Starting to fetch users...');
        const users = await getUsers();
        console.log('Successfully fetched users:', users);
        setUsers(users);
      } catch (err) {
        console.error('Error in UsersList component:', err);
        if (axios.isAxiosError(err)) {
          setError(`Failed to load users: ${err.response?.data || err.message}`);
        } else {
          setError('An unexpected error occurred while loading users.');
        }
      }
    };
    fetchUsers();
  }, []);

  useEffect(() => {
    console.log("UsersList => users", users);
  }, [users]);

  const fetchUserRoles = async (userId: string) => {
    try {
      const roles = await getRolesByUserId(userId);
      const roleNames = roles.map(role => role.roleId);
      setUserRoles(prev => ({...prev, [userId]: roleNames}));
    } catch (err) {
      console.error('Error fetching roles for user', userId, err);
    }
  };

  useEffect(() => {
    users.forEach(user => {
      fetchUserRoles(user.id);
    });
  }, [users]);

  const fetchRoleNames = async () => {
    try {
      const roles = await getRoles(); // Assuming getRoles returns all roles with id and name
      const newRoleNames = roles.reduce((acc, role) => {
        acc[role.id] = role.name;
        return acc;
      }, {} as Record<string, string>);
      setRoleNamesMap(prev => ({...prev, ...newRoleNames}));
    } catch (err) {
      console.error('Error fetching role names:', err);
    }
  };

  useEffect(() => {
    fetchRoleNames();
  }, [userRoles]);

  // Handle delete user
  const handleDelete = async (id: string) => {
    if (!authenticatedUser?.isAdmin) {
      setError('Access Denied: You do not have permission to delete this user.');
      return;
    }

    if (window.confirm('Are you sure you want to delete this user?')) {
      try {
        await deleteUserByAdmin(id, authenticatedUser?.isAdmin || false);
        setUsers(prevUsers => prevUsers.filter(user => user.id !== id));
      } catch (err) {
        setError('Failed to delete the user.');
        console.error(err);
      }
    }
  };

  return (
    <Wrapper
      header={<Header children={<h1 className="text-2xl font-semibold text-[var(--text-info)]">Users List</h1>} />}
      footer={<Footer />}
    >
      <div className="max-w-6xl mx-auto p-6 rounded-lg shadow-lg">
        <h1 className="text-2xl font-semibold text-center text-[var(--text-warning)] mb-6">User Management</h1>
        <Link
          to="/users/create"
          className="btn-info py-2 px-4 rounded-lg hover:bg-blue-700 mb-4 inline-block"
        >
          {/* Add Icon for "Create User" */}
          <svg
            xmlns="http://www.w3.org/2000/svg"
            className="h-6 w-6 inline-block"
            fill="none"
            viewBox="0 0 24 24"
            stroke="currentColor"
          >
            <path
              strokeLinecap="round"
              strokeLinejoin="round"
              strokeWidth={2}
              d="M12 9v3m0 0v3m0-3h3m-3 0H9m12 0a9 9 0 11-18 0 9 9 0 0118 0z"
            />
          </svg>
          <span className="ml-2">Create User</span>
        </Link>

        {error && (
          <div className="bg-red-100 border border-red-400 text-red-700 px-4 py-3 rounded relative" role="alert">
            <span className="block sm:inline">{error}</span>
            <button
              className="absolute top-0 bottom-0 right-0 px-4 py-3"
              onClick={() => setError(null)}
            >
              <span className="sr-only">Dismiss</span>
              <svg className="h-6 w-6 text-red-500" role="button" xmlns="http://www.w3.org/2000/svg" viewBox="0 0 20 20">
                <title>Close</title>
                <path d="M14.348 14.849a1.2 1.2 0 0 1-1.697 0L10 11.819l-2.651 3.029a1.2 1.2 0 1 1-1.697-1.697l2.758-3.15-2.759-3.152a1.2 1.2 0 1 1 1.697-1.697L10 8.183l2.651-3.031a1.2 1.2 0 1 1 1.697 1.697l-2.758 3.152 2.758 3.15a1.2 1.2 0 0 1 0 1.698z" />
              </svg>
            </button>
          </div>
        )}
        <table className="min-w-full shadow-md rounded-lg">
          <thead>
            <tr>
              <th className="px-6 py-3 text-left text-info">First Name</th>
              <th className="px-6 py-3 text-left text-info">Last Name</th>
              <th className="px-6 py-3 text-left text-info">UserName</th>
              <th className="px-6 py-3 text-left text-info">Roles</th>
              <th className="px-6 py-3 text-left text-info">Actions</th>
            </tr>
          </thead>
          <tbody>
            {users?.map((user) => (
              <tr key={user.id}>
                <td className="px-6 py-3">{user.firstName}</td>
                <td className="px-6 py-3">{user.lastName}</td>
                <td className="px-6 py-3">{user.userName}</td>
                <td className="px-6 py-3">
                  {userRoles[user.id]?.map((roleId, index) => (
                    <span key={`${user.id}-${roleId}`} className="inline-block bg-blue-100 text-blue-800 text-xs px-2 py-1 rounded mr-1 mb-1">
                      {roleNamesMap[roleId] || roleId}
                      {index < (userRoles[user.id]?.length || 0) - 1 ? ', ' : ''}
                    </span>
                  )) || 'No roles assigned'}
                </td>
                <td className="px-6 py-3">
                  <Link
                    to={`/users/view/${user.id}`}
                    className="cursor-pointer mr-2 inline-block"
                    title='View User'
                  >
                    {ViewSvgIcon}
                  </Link>
                  <Link
                    to={`/users/edit/${user.id}`}
                    className="cursor-pointer mr-2 inline-block"
                    title='Edit User'
                  >
                    {EditSvgIcon}
                  </Link>
                  <button
                    onClick={() => handleDelete(user.id)}
                    className="cursor-pointer mr-2 inline-block text-danger"
                    title='Delete User'
                  >
                    {DeleteSvgIcon}
                  </button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </Wrapper>);
};

export default UsersList;
