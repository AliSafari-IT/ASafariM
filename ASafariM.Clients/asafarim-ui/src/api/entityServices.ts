// E:\asm\apps\dashboard-client\src\api\dashboardServices.ts
import axios, { AxiosError } from "axios";
import apiUrls from "./getApiUrls";

const api = axios.create({
    baseURL: apiUrls(window.location.hostname)
});

// Add request interceptor to include auth token
api.interceptors.request.use((config) => {
    const {auth} = JSON.parse(localStorage.getItem('auth') || '{}');
    if (auth?.token) {
        config.headers.Authorization = `Bearer ${auth.token}`;
    }
    return config;
}, (error) => {
    return Promise.reject(error);
});

api.defaults.headers.post['Content-Type'] = 'application/json';
api.defaults.headers.put['Content-Type'] = 'application/json';
api.defaults.headers.patch['Content-Type'] = 'application/json';
api.defaults.headers.delete['Content-Type'] = 'application/json';
api.defaults.headers.get['Content-Type'] = 'application/json';



const tableExistsInDb = async (tableName: string): Promise<boolean> => {
    console.info(`Checking table existence: ${tableName} in ${apiUrls(window.location.hostname)}`);
    try {
        const response = await api.get(`${tableName}`);
        return response.status === 200;
    } catch {
        return false;
    }
}
// CRUD operations for entities from the API
const fetchEntities = async (entityTableName: string) => {
    // Validate the entity table name
    if (!tableExistsInDb(`${entityTableName}`)) {
        throw new Error(`Entity does not exist: ${entityTableName}`);
    }
    try {
        // Convert singular to plural for API endpoints
        const endpoint = entityTableName.endsWith('s') ? entityTableName : `${entityTableName}s`;
        console.log(`Fetching entities from endpoint: /${endpoint}`);
        
        const response = await api.get(`/${endpoint}`);
        console.log(`Response from ${endpoint}:`, response.data);
        
        return {
            success: true,
            data: response.data
        };
    } catch (error) {
        console.error(`Error fetching ${entityTableName}:`, error);
        throw error;
    }
};

/**
 * Fetch a single entity by its ID from the specified table in the API.
 * @param {string} entityTableName The name of the table in the API to fetch the entity from.
 * @param {string} id The ID of the entity to fetch.
 * @returns {Promise<any>} A promise that resolves to the fetched entity.
 * @throws {Error} If the fetch operation fails, an error is thrown with a message indicating the failure.
 */
const fetchEntityById = async (entityTableName: string, id: string): Promise<unknown> => {
    // Validate the entity table name
    if (!tableExistsInDb(`${entityTableName}`)) {
        throw new Error(`Entity does not exist: ${entityTableName}`);
    }

    if (!id) {
        throw new Error('No ID provided');
    }

    const url = `/${entityTableName}/${id}`;

    console.log(`Fetching entity by ID from ${entityTableName}`, id);
    return api.get(url)
        .then(response => {
            console.log(`Fetched entity by ID from ${entityTableName}`, response.data);
            return response.data;
        })
        .catch(error => {
            console.error(`Error fetching entity by ID from ${entityTableName}`, error);
            throw new Error('Failed to fetch entity: ' + entityTableName);
        });
}

const addEntity = async (entityTableName: string, data: Record<string, unknown>) => {
    console.debug(`Initiating addEntity function for table: ${entityTableName} with data:`, data);

    // Validate the entity table name
    if (!await tableExistsInDb(entityTableName)) {
        console.error(`Entity table does not exist: ${entityTableName}`);
        throw new Error(`Entity does not exist: ${entityTableName}`);
    }

    const url = `/${entityTableName}`;
    console.debug(`Constructed URL for adding entity: ${url}`);

    const sanitizedData = { ...data, id: undefined };
    console.debug(`Sanitized data for POST request:`, sanitizedData);

    try {
        const response = await api.post(url, sanitizedData);
        console.info(`Successfully added entity to ${entityTableName}`, response.data);
        return response.data;
    } catch (error) {
        console.error(`Error adding entity to ${entityTableName}`, error);
        throw new Error(`Failed to add entity: ${entityTableName}`);
    }
}


const updateEntity = async (entityTableName: string, id: string, data: Record<string, unknown>) => {
    try {
        const endpoint = entityTableName.endsWith('s') ? entityTableName : `${entityTableName}s`;
        console.log(`Updating entity in ${endpoint}:`, { id, data });
        
        const url = `/${endpoint}/${id}`;
        console.debug(`Constructed URL for updating entity: ${url}`);
    
        const sanitizedData= { ...data };
        delete sanitizedData.id;
                
        console.debug(`Sanitized data for PUT request:`, sanitizedData);

        // Send the PUT request to update the entity
        const response = await api.put(url, sanitizedData);
        console.info(`Successfully updated entity in ${endpoint}:`, response.data);
        
        return {
            success: true,
            data: response.data
        };
    } catch (error: unknown) {
        if (error instanceof AxiosError) {
            console.error(`Error updating entity in ${entityTableName}:`, error.response?.data);
            throw error;
        }
        console.error('An error occurred while updating the entity.');
        throw new Error('An error occurred while updating the entity.');
    }
}

const deleteEntity = async (entityTableName: string, id: string) => {
    return api.delete(`/${entityTableName}/${id}`)
        .catch(error => {
            console.error('Error deleting entity:', error);
            throw new Error('Failed to delete entity: ' + entityTableName);
        });
}

const dashboardServices = {
    fetchEntities, fetchEntityById, addEntity, updateEntity, deleteEntity,
}

export default dashboardServices;
