import { FC, useState, FormEvent, useEffect } from "react";
import axios from "axios";
import { ITopic } from "@/interfaces/ITopic";
import { apiUrls } from "@/api/getApiUrls";
import { TextField, Dropdown, IDropdownOption, PrimaryButton, Stack, Label } from "@fluentui/react";
import Wrapper from "@/layout/Wrapper/Wrapper";
import { makeStyles } from "@fluentui/react-components";

const topicUrl = apiUrls(window.location.hostname) + '/topics';

const useStyles = makeStyles({
    inputField: {
        width: '350px',
    },
    formContainer: {
        width: '500px',
        display: 'flex',
        justifyContent: 'center',
        alignItems: 'center',
        flexDirection: 'column',
        gap: '20px',
        padding: '40px',
        backgroundColor: 'var(--bg-primary)',
        borderRadius: '10px',
        boxShadow: '0 4px 8px rgba(0, 0, 0, 0.2)',
        margin: '0 auto',
    },
    label: {
        color: 'var(--text-primary)',
        fontWeight: 'bold',
        fontSize: '16px',
    },
    dropdown: {
        backgroundColor: 'var(--bg-secondary)',
    },
    submitButton: {
        width: '100%',
        backgroundColor: 'var(--button-primary)',
        color: 'var(--button-primary-text)',
        '&:hover': {
            backgroundColor: 'var(--button-primary-hover)'
        }
    },
});

export const AddTopicForm: FC = () => {
    const classes = useStyles();
    const [parentTopicId, setParentTopicId] = useState<string | undefined>(undefined);
    const [parentTopics, setParentTopics] = useState<ITopic[]>([]);
    const [topic, setTopic] = useState<ITopic>({
        id: '',
        name: '',
        slug: '',
        description: '',
        parentTopicId: undefined,
    });

    useEffect(() => {
        const fetchTopics = async () => {
            try {
                const response = await axios.get(topicUrl);
                setParentTopics(response.data);
            } catch (error) {
                console.error('Error fetching topics:', error);
            }
        };
        fetchTopics();
    }, []);

    const handleSubmit = async (e: FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        try {
            await axios.post(topicUrl, { ...topic, parentTopicId });
        } catch (error) {
            console.error('Error adding topic:', error);
        }
    };

    const handleChange = (event: React.FormEvent<HTMLInputElement | HTMLTextAreaElement>, newValue?: string) => {
        const target = event.target as HTMLInputElement | HTMLTextAreaElement;
        setTopic(prev => ({ ...prev, [target.name]: newValue !== undefined ? newValue : target.value }));
    };

    const handleDropdownChange = (_: React.FormEvent<HTMLDivElement>, option?: IDropdownOption) => {
        setParentTopicId(option?.key as string);
    };

    return (
        <Wrapper header={<h1 className="text-3xl font-bold text-center mb-8">Add New Topic</h1>}>
            <Stack tokens={{ childrenGap: 20 }} className={classes.formContainer}>
                <form onSubmit={handleSubmit}>
                    <Stack tokens={{ childrenGap: 10 }}>
                        <Label className={classes.label}>Name</Label>
                        <TextField name="name" onChange={handleChange} value={topic.name} required className={classes.inputField} />
                        <Label className={classes.label}>Slug</Label>
                        <TextField name="slug" onChange={handleChange} value={topic.slug} required className={classes.inputField} />
                        <Label className={classes.label}>Description</Label>
                        <TextField name="description" onChange={handleChange} multiline rows={3} value={topic.description} required className={classes.inputField} />
                        {parentTopics.length > 0 && (
                            <>
                                <Label className={classes.label}>Parent Topic</Label>
                                <Dropdown
                                    selectedKey={parentTopicId || ''}
                                    onChange={handleDropdownChange}
                                    options={parentTopics.map(topic => ({ key: topic.id, text: topic.name }))}
                                    className={classes.dropdown}
                                />
                            </>
                        )}
                        <PrimaryButton type="submit" className={classes.submitButton}>Add Topic</PrimaryButton>
                    </Stack>
                </form>
            </Stack>
        </Wrapper>
    );
};

export default AddTopicForm;
