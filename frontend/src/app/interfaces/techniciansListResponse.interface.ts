export interface BonusListResponse {
  technitians: Technitian[];
  total_Technicians: number;
}
export interface Technitian {
  numTech: number;
  name: string;
  crew: string;
  totalBonus: number;
  totalPoints: number;
  tasks: Task[];
}
interface Task {
  assigmentId: string;
  description: string;
  client_name: string;
  client_address: string;
  status: string;
  assigned_date: string;
  points: number;
}


