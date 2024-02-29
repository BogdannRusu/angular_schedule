export interface IProfesori{
    "id_prof": number;
    "nume": string; 
    "prenum": string;  
    "data_angajarii"?: Date;
    "end_data_angajarii"?: Date;
    "is_active": boolean;
    "functia": string;
}