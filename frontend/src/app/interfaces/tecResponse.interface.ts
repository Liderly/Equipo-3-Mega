import { Technitian } from "./techniciansListResponse.interface";

export interface TechInfo extends Pick<Technitian, 'numTech' | 'name'> {
tasks:Service[];
}
export interface Service{
  assigmentId: string;
  client_address:string,
  client_name:string,
  description:string,
  status:string,
  assigned_date:Date,
}
