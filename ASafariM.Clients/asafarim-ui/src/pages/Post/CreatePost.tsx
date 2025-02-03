import React, { useEffect, useState } from 'react';
import { Stack, TextField, PrimaryButton, MessageBar, MessageBarType } from '@fluentui/react';
import Wrapper from '@/layout/Wrapper/Wrapper';
import useAuth from '@/hooks/useAuth';
import Header from '@/layout/Header/Header';

const CreatePost: React.FC = () => {
    const { authenticatedUser } = useAuth();
    const [title, setTitle] = useState('');
    const [author, setAuthor] = useState(authenticatedUser?.fullName || '');
    const [content, setContent] = useState('');
    const [error, setError] = useState<string | null>(null);
    const [success, setSuccess] = useState(false);

    useEffect(() => {
        if (!authenticatedUser) {
            setError('User is not authenticated!');
            return;
        }
        setError(null);
        setAuthor(authenticatedUser?.firstName + ' ' + authenticatedUser?.lastName);
    }, [authenticatedUser]);



    const handleSubmit = async (e: React.FormEvent) => {
        e.preventDefault();
        if (!authenticatedUser) {
            setError('User is not authenticated!');
            return;
        }
        setError(null);
        setSuccess(false);

        try {
            const response = await fetch('https://localhost:5001/api/Posts', {
                method: 'POST',
                headers: { 'Content-Type': 'application/json' },
                body: JSON.stringify({ title, authorId: authenticatedUser?.id, content }),
            });

            if (!response.ok) {
                throw new Error('Failed to create post');
            }

            setSuccess(true);
            setAuthor(authenticatedUser?.firstName + ' ' + authenticatedUser?.lastName);
            setContent('');
        } catch (err) {
            setError(err instanceof Error ? err.message : 'An error occurred while creating the post');
        }
    };

    return (
        <Wrapper>
            <Stack tokens={{ padding: 20 }}>
                <Header size="text-3xl" key={'display-posts'}>Create New Post</Header>
                {error && <MessageBar messageBarType={MessageBarType.error}>{error}
                </MessageBar>}
                {success && <MessageBar messageBarType={MessageBarType.success}>Post created successfully!</MessageBar>}
                <form onSubmit={handleSubmit}>
                    <Stack tokens={{ childrenGap: 10 }}>
                        <TextField label="Title" value={title} onChange={(e, newValue) => setTitle(newValue || '')} required />
                        <TextField label="Author" value={author} readOnly required />
                        <TextField label="Content" multiline rows={5} value={content} onChange={(e, newValue) => setContent(newValue || '')} required />
                        <PrimaryButton text="Submit" type="submit" />
                    </Stack>
                </form>
            </Stack>
        </Wrapper>
    );
};

export default CreatePost;