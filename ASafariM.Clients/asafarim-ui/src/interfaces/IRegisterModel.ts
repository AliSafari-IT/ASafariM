export interface IRegisterModel {
  email: string;
  password: string;
  firstName: string;
  lastName: string;
  userName?: string; // Optional username
  isAdmin?: boolean; // Optional admin flag
  dateOfBirth?: string; // Optional date of birth
  profilePicture?: string; // Optional profile picture URL
}

