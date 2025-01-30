import { IMarkdownFile } from "./IMarkdownFile";

export interface IUser {
    id: string;
    userName?: string;
    normalizedUserName?: string;
    email: string;
    normalizedEmail?: string;
    firstName: string;
    lastName: string;
    biography?: string;
    password?: string;
    isAdmin: boolean;
    userId?: string;
    createdAt?: string;
    updatedAt?: string;
    isDeleted?: boolean;
    deletedAt?: string;
    profilePicture?: string;
    createdBy?: string;
    updatedBy?: string;
    deletedBy?: string;
    isActive?: boolean;
    dateOfBirth?: string;
    lastLogin?: string;
    failedLoginAttempts?: number;
    isLockedOut?: boolean;
    lockoutEnd?: string;
    securityStamp?: string;
    concurrencyStamp?: string;
    phoneNumber?: string;
    phoneNumberConfirmed?: boolean;
    emailConfirmed?: boolean;
    roles?: string[];
    remark?: string;
    markdownFiles?: IMarkdownFile[];
    dateJoined?: string;
    isSuperAdmin?: boolean;
    lastPasswordChangeDate?: string;
    isOnline?: boolean;
    
}
