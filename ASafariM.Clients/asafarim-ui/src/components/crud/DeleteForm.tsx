// DeleteForm.tsx
import React, { useEffect, useState } from 'react';
import { Button, FluentProvider, makeStyles, webDarkTheme, webLightTheme } from '@fluentui/react-components';
import { useNavigate, useParams } from 'react-router-dom';
import Wrapper from '../../layout/Wrapper/Wrapper';
import dashboardServices from '../../api/entityServices';
import { useTheme } from '@/contexts/ThemeContext';
import { Text } from '@fluentui/react';
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


interface DeleteFormProps {
    entity: string;
}

const DeleteForm: React.FC<DeleteFormProps> = ({ entity }) => {
    const classes = useStyles();
    const navigate = useNavigate();
    const theme = useTheme().theme === 'dark' ? webDarkTheme : webLightTheme;
    const [id, setId] = useState<string>('');
    const [error, setError] = useState<string>('');
    const [loading, setLoading] = useState<boolean>(false);

    const param = useParams<{ id: string }>();
    useEffect(() => {
        if (param.id) {
            setId(param.id);
        }
    }, [param.id]);

    const handleDelete = async () => {
        if (!id) {
            setError('No ID provided');
            return;
        }
        console.log(`Starting delete operation for ID: ${id} of entity: ${entity}`);
        setLoading(true);
        try {
            await dashboardServices.deleteEntity(entity, id);
            console.log(`Successfully deleted entity: ${entity} with ID: ${id}`);
            //success message
            setError('');
            navigate(`/dashboard`);
        } catch (error) {
            console.error('Error deleting entity:', error);
            //error message
            setError('Failed to delete entity');
        } finally {
            setLoading(false);
        }
    };

    return (
        <Wrapper header={`Are you sure you want to delete this ${entity}?   `}>
            <FluentProvider theme={theme}>
                {error && <Text variant="medium" color="error">{error}</Text>}
                <div className={classes.formContainer}>
                    <Text variant="medium" color="primary">Are you sure you want to delete this {entity}?</Text>
                    <Button
                        aria-label="Delete"
                        type="button"
                        onClick={handleDelete}
                        disabled={loading}
                        className={classes.formField}
                    >
                        {loading ? 'Deleting...' : 'Delete'}
                    </Button>
                </div>
            </FluentProvider>
        </Wrapper>
    );
};

export default DeleteForm;