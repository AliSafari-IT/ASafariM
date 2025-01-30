import React from 'react';

interface NotificationProps {
    type: 'success' | 'warning' | 'error' | string;
    text: string;
    onClose: () => void;
}

const Notification: React.FC<NotificationProps> = ({ type, text, onClose }) => {
    const bgColor = type === 'success' ? 'bg-green-100 dark:bg-green-800' : 'bg-red-100 dark:bg-red-800';
    const textColor = type === 'success' ? 'text-green-800 dark:text-green-100' : 'text-red-800 dark:text-red-100';

    return (
        <div
            className={`flex items-center justify-between p-4 mb-4 rounded-lg shadow-md ${bgColor} ${textColor}`}
        >
            <p className="text-sm font-medium">{text}</p>
            <button
                onClick={onClose}
                className="ml-4 px-3 py-1 rounded-md text-sm font-semibold bg-transparent hover:bg-opacity-20"
            >
                ✕
            </button>
        </div>
    );
};

export default Notification;
