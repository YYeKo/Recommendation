import { User } from "./user";
import { Professions } from "./professions";

export class Professional extends User{
    constructor(

     
        public  ProfessionalId?: number,
        public BussName?:string,
        public  FirstName?: string,
        public  LastName?: string,
        public  Street?: string,
        public  NumHouse?: number,
        public  DescriptionOn?: string,
        public  professions?:Professions[]
    )
    {   
        super();
    }
     
}
