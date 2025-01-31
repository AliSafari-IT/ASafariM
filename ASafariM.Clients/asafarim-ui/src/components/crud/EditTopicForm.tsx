import React, { useState, useEffect } from 'react';
import { Button, makeStyles } from '@fluentui/react-components';
import { useNavigate, useParams } from 'react-router-dom';
import { TextField } from '@fluentui/react';
import Wrapper from '../../layout/Wrapper/Wrapper';
import dashboardServices from '../../api/entityServices';
import { isAxiosError } from 'axios';
import { ITopic } from '@/interfaces/ITopic';

const useStyles = makeStyles({
    formContainer: {
        display: 'flex',
        flexDirection: 'column',
        alignItems: 'center',
        gap: '10px',
        padding: '20px',
    },
    formField: {
        width: '300px',
        marginBottom: '15px',
    },
});

const EditTopicForm: React.FC = () => {
    const classes = useStyles();
    const navigate = useNavigate();
    const { id } = useParams<{ id: string }>();

    const [topic, setTopic] = useState<ITopic>({
        id: '',
        name: '',
        title: '',
        description: '',
        difficultyLevel: '',
        technologyCategory: '',
        updatedAt: new Date(),
        createdAt: new Date(),
    });
    
    const [error, setError] = useState<string>('');
    const [loading, setLoading] = useState<boolean>(true);

    useEffect(() => {
        const fetchTopic = async () => {
            if (!id) return;
            
            try {
                const data = await dashboardServices.fetchEntityById('topics', id) as ITopic;
                setTopic(data);
                setLoading(false);
            } catch (error) {
                console.error('Error fetching topic:', error);
                if (isAxiosError(error)) {
                    setError(error.response?.data.message || 'Failed to fetch the topic. Please try again.');
                } else {
                    setError('An unexpected error occurred. Please try again later.');
                }
                setLoading(false);
            }
        };

        fetchTopic();
    }, [id]);

    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        setError('');

        try {
            await dashboardServices.updateEntity('topics', id!, {
                name: topic.name,
                title: topic.title,
                description: topic.description,
                difficultyLevel: topic.difficultyLevel,
                technologyCategory: topic.technologyCategory,
            });
            alert('Topic updated successfully!');
            navigate('/dashboard');
        } catch (error) {
            console.error('Error updating topic:', error);
            if (isAxiosError(error)) {
                setError(error.response?.data.message || 'Failed to update the topic. Please try again.');
            } else {
                setError('An unexpected error occurred. Please try again later.');
            }
        }
    };

    const handleInputChange = (e: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>) => {
        const { name, value } = e.target as HTMLInputElement;
        setTopic(prev => ({
            ...prev,
            [name]: value
        }));
    };

    if (loading) {
        return <Wrapper header={<h1>Loading...</h1>} />;
    }

    return (
        <Wrapper header={<h1 className="text-3xl font-bold text-center">Edit Topic</h1>} error={error}>
            <div className={classes.formContainer}>
                <form onSubmit={handleSubmit}>
                    <TextField
                        label="Topic Name"
                        name="name"
                        className={classes.formField}
                        value={topic.name}
                        onChange={handleInputChange}
                        required
                    />
                    <TextField
                        label="Title"
                        name="title"
                        className={classes.formField}
                        value={topic.title}
                        onChange={handleInputChange}
                        required
                    />
                    <TextField
                        label="Description"
                        name="description"
                        className={classes.formField}
                        value={topic.description || ''}
                        onChange={handleInputChange}
                        multiline
                        rows={4}
                    />
                    <TextField
                        label="Difficulty Level"
                        name="difficultyLevel"
                        className={classes.formField}
                        value={topic.difficultyLevel || ''}
                        onChange={handleInputChange}
                    />
                    <TextField
                        label="Technology Category"
                        name="technologyCategory"
                        className={classes.formField}
                        value={topic.technologyCategory || ''}
                        onChange={handleInputChange}
                    />

                    <Button type="submit" style={{ float: 'right', marginTop: '10px' }}>Update Topic</Button>
                </form>
            </div>
        </Wrapper>
    );
};

export default EditTopicForm;