import { User } from "./user";
import { Specializations } from "./specializations";

export class Professional extends User{
    constructor(

     
        public  ProfessionalId?: number,
        public BussName?:string,
        public  FirstName?: string,
        public  LastName?: string,
        public  Street?: string,
        public  NumHouse?: number,
        public  DescriptionOn?: string,
        public  professions?:Specializations[]
    )
    {   
        super();
    }
     
}
