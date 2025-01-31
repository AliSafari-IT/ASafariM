import React, { useState, useEffect } from 'react';
import { Button, makeStyles } from '@fluentui/react-components';
import { useNavigate, useParams } from 'react-router-dom';
import { TextField, Dropdown, IDropdownOption } from '@fluentui/react';
import Wrapper from '../../layout/Wrapper/Wrapper';
import dashboardServices from '../../api/entityServices';
import { isAxiosError } from 'axios';
import { IPost } from '@/interfaces/post-types';
import { DifficultyLevelEnum } from '@/interfaces/DifficultyLevelEnum';

const useStyles = makeStyles({
    formContainer: {
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        gap: '10px',
        padding: '20px',
    },
    formField: {
        width: '100%',
        maxWidth: '600px',
        marginBottom: '15px',
    },
});

const difficultyOptions: IDropdownOption[] = [
    { key: DifficultyLevelEnum.Easy, text: 'Easy' },
    { key: DifficultyLevelEnum.Medium, text: 'Medium' },
    { key: DifficultyLevelEnum.Hard, text: 'Hard' },
];

const EditPostForm: React.FC = () => {
    const classes = useStyles();
    const navigate = useNavigate();
    const { id } = useParams<{ id: string }>();

    const [post, setPost] = useState<IPost>({
        id: '',
        name: '',
        title: '',
        content: '',
        summary: '',
        author: '',
        slug: '',
        excerpt: '',
        difficultyLevel: DifficultyLevelEnum.UNKNOWN,
        topicId: '',
        isPublished: false,
        imageUrl: '',
        metaDescription: '',
        tags: [],
        createdAt: new Date(),
    });
    
    const [error, setError] = useState<string>('');
    const [loading, setLoading] = useState<boolean>(true);

    useEffect(() => {
        const fetchPost = async () => {
            if (!id) return;
            
            try {
                const data = await dashboardServices.fetchEntityById('posts', id) as IPost;
                setPost(data);
                setLoading(false);
            } catch (error) {
                console.error('Error fetching post:', error);
                if (isAxiosError(error)) {
                    setError(error.response?.data.message || 'Failed to fetch the post. Please try again.');
                } else {
                    setError('An unexpected error occurred. Please try again later.');
                }
                setLoading(false);
            }
        };

        fetchPost();
    }, [id]);

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        setError('');

        try {
            await dashboardServices.updateEntity('posts', id!, {
                name: post.name,
                title: post.title,
                content: post.content,
                summary: post.summary,
                author: post.author,
                slug: post.slug,
                excerpt: post.excerpt,
                difficultyLevel: post.difficultyLevel,
                topicId: post.topicId,
                isPublished: post.isPublished,
                imageUrl: post.imageUrl,
                metaDescription: post.metaDescription,
                tags: post.tags,
            });
            alert('Post updated successfully!');
            navigate('/dashboard');
        } catch (error) {
            console.error('Error updating post:', error);
            if (isAxiosError(error)) {
                setError(error.response?.data.message || 'Failed to update the post. Please try again.');
            } else {
                setError('An unexpected error occurred. Please try again later.');
            }
        }
    };

    const handleInputChange = (e: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>) => {
        const { name, value } = e.target as HTMLInputElement;
        setPost(prev => ({
            ...prev,
            [name]: value
        }));
    };

    const handleDifficultyChange = (_: React.FormEvent<HTMLDivElement>, option?: IDropdownOption) => {
        if (option) {
            setPost(prev => ({
                ...prev,
                difficultyLevel: option.key as DifficultyLevelEnum
            }));
        }
    };

    // const handlePublishedChange = (_: React.FormEvent<HTMLDivElement>, checked?: boolean) => {
    //     setPost(prev => ({
    //         ...prev,
    //         isPublished: checked || false
    //     }));
    // };

    if (loading) {
        return <Wrapper header={<h1>Loading...</h1>} />;
    }

    return (
        <Wrapper header={<h1 className="text-3xl font-bold text-center">Edit Post</h1>} error={error}>
            <div className={classes.formContainer}>
                <form onSubmit={handleSubmit}>
                    <TextField
                        label="Post Name"
                        name="name"
                        className={classes.formField}
                        value={post.name}
                        onChange={handleInputChange}
                        required
                    />
                    <TextField
                        label="Title"
                        name="title"
                        className={classes.formField}
                        value={post.title || ''}
                        onChange={handleInputChange}
                    />
                    <TextField
                        label="Content"
                        name="content"
                        className={classes.formField}
                        value={post.content}
                        onChange={handleInputChange}
                        multiline
                        rows={8}
                        required
                    />
                    <TextField
                        label="Summary"
                        name="summary"
                        className={classes.formField}
                        value={post.summary || ''}
                        onChange={handleInputChange}
                        multiline
                        rows={3}
                    />
                    <TextField
                        label="Author"
                        name="author"
                        className={classes.formField}
                        value={post.author}
                        onChange={handleInputChange}
                        required
                    />
                    <TextField
                        label="Slug"
                        name="slug"
                        className={classes.formField}
                        value={post.slug || ''}
                        onChange={handleInputChange}
                    />
                    <TextField
                        label="Excerpt"
                        name="excerpt"
                        className={classes.formField}
                        value={post.excerpt || ''}
                        onChange={handleInputChange}
                        multiline
                        rows={2}
                    />
                    <Dropdown
                        label="Difficulty Level"
                        selectedKey={post.difficultyLevel}
                        options={difficultyOptions}
                        onChange={handleDifficultyChange}
                        className={classes.formField}
                    />
                    <TextField
                        label="Topic ID"
                        name="topicId"
                        className={classes.formField}
                        value={post.topicId || ''}
                        onChange={handleInputChange}
                    />
                    <TextField
                        label="Image URL"
                        name="imageUrl"
                        className={classes.formField}
                        value={post.imageUrl || ''}
                        onChange={handleInputChange}
                    />
                    <TextField
                        label="Meta Description"
                        name="metaDescription"
                        className={classes.formField}
                        value={post.metaDescription || ''}
                        onChange={handleInputChange}
                        multiline
                        rows={2}
                    />
                    <TextField
                        label="Tags (comma-separated)"
                        name="tags"
                        className={classes.formField}
                        value={post.tags?.join(', ') || ''}
                        onChange={(e) => {
                            const value = (e.target as HTMLInputElement).value;
                            setPost(prev => ({
                                ...prev,
                                tags: value.split(',').map(tag => tag.trim()).filter(tag => tag)
                            }));
                        }}
                    />

                    <Button type="submit" style={{ float: 'right', marginTop: '10px' }}>Update Post</Button>
                </form>
            </div>
        </Wrapper>
    );
};

export default EditPostForm;