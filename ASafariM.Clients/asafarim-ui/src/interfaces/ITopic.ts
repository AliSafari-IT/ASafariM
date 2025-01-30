import { IPost } from "./post-types";

export interface ITopic {
  id: string;
  title: string;
  to?: string;
  icon?: React.ReactElement;
  name: string;
  description?: string;
  technologyCategory?: string;
  difficultyLevel?: string;
  relatedPosts?: IPost[];
  updatedAt: Date;
  createdAt: Date;
};

