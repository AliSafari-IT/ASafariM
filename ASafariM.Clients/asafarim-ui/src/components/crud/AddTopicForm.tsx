import { FC, useState, FormEvent } from "react";
import { IField } from "@/interfaces/IField";
import axios from "axios";
import { ITopic } from "@/interfaces/ITopic";
import API_URL from "@/api/getApiUrls";
import { TextField } from '@fluentui/react';
import Wrapper from "@/layout/Wrapper/Wrapper";
import { makeStyles } from "@fluentui/react-components";

const topicUrl = API_URL + '/topics';

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
    },
});

export const AddTopicForm: FC = () => {
    const classes = useStyles();
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
        },
        {
            name: 'title',
            label: 'Title',
            type: 'text',
            value: topic.title,
        },
        {
            name: 'description',
            label: 'Description',
            type: 'text',
            value: topic.description,
        },
        {
            name: 'difficulty',
            label: 'Difficulty',
            type: 'number',
            value: topic.difficultyLevel,
        },
    ];

    const handleSubmit = async (e: FormEvent<HTMLFormElement>) => {
        e.preventDefault();
        try {
          // Send a POST request to the API to add the new topic
          console.log('Topic data:', topic);
            const response = await axios.post(topicUrl, topic);
            console.log(response.data);
        } catch (error) {
            console.error('Error adding topic:', error);
            console.log(error);
        }
    };

    const handleChange = (event: FormEvent<HTMLInputElement | HTMLTextAreaElement>) => {
        const target = event.target as HTMLInputElement;
        setTopic(prev => ({ ...prev, [target.name]: target.value }));
    };

    return (
        <Wrapper header={<h1 className="text-3xl font-bold text-center">Add New Topic</h1>} >
            <div className={classes.formContainer}>
                <form onSubmit={handleSubmit}>
                    {fields?.map((field) => (
                        <TextField
                            key={field.name}
                            label={field.label} 
                            name={field.name}
                            onChange={handleChange}
                            className={classes.formField}
                            value={field.value}
                            required={false}
                            placeholder={field.placeholder}
                                type={field.type}
                            />
                    ))}
                    <button type="submit" style={{ float: 'right', marginTop: '10px' }}>Add Topic</button>
                </form>
            </div>
        </Wrapper>
    );
};

export default AddTopicForm;