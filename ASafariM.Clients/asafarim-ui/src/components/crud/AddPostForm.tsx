import dashboardServices from "../../api/entityServices";
import { useNavigate } from "react-router-dom";

const AddPostForm: React.FC = () => {
  const navigator = useNavigate();
  const handleSubmit = async (e: React.FormEvent<HTMLFormElement>) => {
    e.preventDefault();
    const formData = new FormData(e.currentTarget);
    const title = formData.get('title') as string;
    const content = formData.get('content') as string;
    const difficultyLevel = formData.get('difficultyLevel') as string;
    const topicId = formData.get('topicId') as string;

    try {
      await dashboardServices.addEntity('posts', { title, content, difficultyLevel, topicId });
     
      navigator('/dashboard');
    } catch (error) {
      console.error('Error adding post:', error);

    }
  };

  return (
    <form onSubmit={handleSubmit} className="space-y-4 p-4">
      <div>
        <label htmlFor="title" className="block text-sm font-medium text-gray-700">Title</label>
        <input
          type="text"
          name="title"
          id="title"
          required
          className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
        />
      </div>
      <div>
        <label htmlFor="content" className="block text-sm font-medium text-gray-700">Content</label>
        <textarea
          name="content"
          id="content"
          required
          rows={4}
          className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
        />
      </div>
      <div>
        <label htmlFor="difficultyLevel" className="block text-sm font-medium text-gray-700">Difficulty Level</label>
        <select
          name="difficultyLevel"
          id="difficultyLevel"
          required
          className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
        >
          <option value="Easy">Easy</option>
          <option value="Medium">Medium</option>
          <option value="Hard">Hard</option>
        </select>
      </div>
      <div>
        <label htmlFor="topicId" className="block text-sm font-medium text-gray-700">Topic ID</label>
        <input
          type="text"
          name="topicId"
          id="topicId"
          required
          className="mt-1 block w-full rounded-md border-gray-300 shadow-sm"
        />
      </div>
      <button
        type="submit"
        className="inline-flex justify-center py-2 px-4 border border-transparent shadow-sm text-sm font-medium rounded-md text-white bg-blue-600 hover:bg-blue-700"
      >
        Add Post
      </button>
    </form>
  );
};

export default AddPostForm;