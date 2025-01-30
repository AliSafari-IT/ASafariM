import { FC, useState } from "react";
import { IField } from "@/interfaces/IField";
import axios from "axios";
import { ITopic } from "@/interfaces/ITopic";
import API_URL from "@/api/getApiUrls";
const topicUrl = API_URL + '/topics';

export const AddTopicForm: FC = () => {
  const [topic, setTopic] = useState<ITopic>({
    id: '',
    name: '',
    title: '',
    description: '',
    difficultyLevel: '',
    technologyCategory: '',
    updatedAt:  new Date(),
    createdAt: new Date(),
});

  const fields: IField[] = [
    {
      name: 'name',
      label: 'Name',
      type: 'text',
      value: topic.name,
      onChange: (e) => setTopic({ ...topic, name: e.target.value }),
    },
    {
      name: 'title',
      label: 'Title',
      type: 'text',
      value: topic.title,
      onChange: (e) => setTopic({ ...topic, title: e.target.value }),
    },
    {
      name: 'description',
      label: 'Description',
      type: 'text',
      value: topic.description,
      onChange: (e) => setTopic({ ...topic, description: e.target.value }),
    },
    {
      name: 'difficulty',
      label: 'Difficulty',
      type: 'number',
      value: topic.difficultyLevel,
      onChange: (e) => setTopic({ ...topic, difficultyLevel: e.target.value }),
    },
  ];

  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    try {
      const response = await axios.post(topicUrl, topic);
      console.log(response.data);
    } catch (error) {
      console.log(error);
    }
  };

  return (
    <form onSubmit={handleSubmit}>
      {fields.map((field) => (
        <div key={field.name}>
          <label>
            {field.label}
            <input
              type={field.type}
              value={field.value}
              onChange={field.onChange}
            />
          </label>
        </div>
      ))}
      <button type="submit">Add Topic</button>
    </form>
  );
};

export default AddTopicForm;