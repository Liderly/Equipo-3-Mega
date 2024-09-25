export interface TechListResponse {
  technitians: Technitian[];
  totalTechs: number;
}
export interface Technitian {
  NumTech: string;
  name: string;
  address: string;
  crew: string;
  tasks: Task[];
}
interface Task {
  desc: string;
  Client: string;
  status: string;
  fecha: string;
  puntos: number;
}
