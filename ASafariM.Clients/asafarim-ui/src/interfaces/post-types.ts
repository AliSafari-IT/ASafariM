import { DifficultyLevelEnum } from "./DifficultyLevelEnum";

export interface IPost {
    difficultyLevel?: DifficultyLevelEnum;
    id: string;
    name: string;
    title?: string;
    content: string;
    summary?: string;
    publishedDate?: string;
    author: string;
    slug?: string;
    excerpt?: string;
    viewCount?: number;
    topicId?: string;
    lastUpdated?: string;
    isPublished?: boolean;
    imageUrl?: string;
    metaDescription?: string;
    tags?: string[]; // tagIds
    topic?: string; // topicId
    createdAt: Date;
    updatedAt?: Date;
  }
