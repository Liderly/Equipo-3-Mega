import { TechListResponse } from "../../interfaces/techniciansListResponse.interface";

export const data:TechListResponse = {
technitians:[
  {
    NumTech: "ABC1234567",
    name: 'Juan Pérez',
    address: '123 Main St, Anytown USA',
    crew: 'Crew A',
    tasks: [
      { desc: "Instalación línea telefónica", Client: "Maria Gomez", status: 'Completada', fecha: '2024-09-18', puntos: 50 },
      { desc: "Instalación de Internet", Client: "Juan Marquez", status: 'Pendiente', fecha: '2024-09-17', puntos: 30 },
      { desc: "Mantenimiento de Internet", Client: "Raul Gutierrez", status: 'Completada', fecha: '2024-09-16', puntos: 45 },
      { desc: "Instalación de TV Premium", Client: "Marco Morales", status: 'Pendiente', fecha: '2024-09-15', puntos: 25 }
    ]
  },
  {
    NumTech: "DEF2345678",
    name: 'Luis Martínez',
    address: '456 Oak Rd, Anytown USA',
    crew: 'Crew B',
    tasks: [
      { desc: "Reparación de fibra óptica", Client: "Ana López", status: 'Completada', fecha: '2024-09-20', puntos: 60 },
      { desc: "Instalación de router", Client: "Carlos Sánchez", status: 'Pendiente', fecha: '2024-09-19', puntos: 35 },
      { desc: "Mantenimiento de red", Client: "Daniela Torres", status: 'Completada', fecha: '2024-09-18', puntos: 40 }
    ]
  },
  {
    NumTech: "GHI3456789",
    name: 'María Fernández',
    address: '789 Pine St, Anytown USA',
    crew: 'Crew A',
    tasks: [
      { desc: "Configuración de Smart TV", Client: "José Ramírez", status: 'Completada', fecha: '2024-09-21', puntos: 55 },
      { desc: "Instalación de línea telefónica", Client: "Gabriela Flores", status: 'Pendiente', fecha: '2024-09-20', puntos: 30 },
      { desc: "Mantenimiento de equipos", Client: "Ricardo Díaz", status: 'Completada', fecha: '2024-09-19', puntos: 50 }
    ]
  },
  {
    NumTech: "PED1234567",
    name: 'Pedro García',
    address: '789 Pine St, Anytown USA',
    crew: 'Crew B',
    tasks: [
      { desc: "Instalación de antena", Client: "Elena Pérez", status: 'Completada', fecha: '2024-09-22', puntos: 65 },
      { desc: "Instalación de Internet", Client: "Fernando Rodríguez", status: 'Pendiente', fecha: '2024-09-21', puntos: 35 },
      { desc: "Mantenimiento de red", Client: "Lucía Hernández", status: 'Completada', fecha: '2024-09-20', puntos: 45 }
    ]
  },
  {
    NumTech: "ANA2345678",
    name: 'Ana Gómez',
    address: '456 Oak Rd, Anytown USA',
    crew: 'Crew A',
    tasks: [
      { desc: "Configuración de red doméstica", Client: "Laura Villanueva", status: 'Completada', fecha: '2024-09-23', puntos: 70 },
      { desc: "Revisión de conexión", Client: "Miguel Castro", status: 'Pendiente', fecha: '2024-09-22', puntos: 30 },
      { desc: "Instalación de WiFi extender", Client: "Sofía Hernández", status: 'Completada', fecha: '2024-09-21', puntos: 40 }
    ]
  },
  {
    NumTech: "CAR3456789",
    name: 'Carlos López',
    address: '123 Main St, Anytown USA',
    crew: 'Crew C',
    tasks: [
      { desc: "Instalación de TV", Client: "Andrés González", status: 'Completada', fecha: '2024-09-24', puntos: 80 },
      { desc: "Reparación de cableado", Client: "Esteban Torres", status: 'Pendiente', fecha: '2024-09-23', puntos: 35 },
      { desc: "Instalación de cámara de seguridad", Client: "Julieta Ríos", status: 'Completada', fecha: '2024-09-22', puntos: 50 }
    ]
  },
  {
    NumTech: "PAT4567890",
    name: 'Patricia Martínez',
    address: '789 Pine St, Anytown USA',
    crew: 'Crew B',
    tasks: [
      { desc: "Revisión de sistema de alarma", Client: "Isabel Romero", status: 'Completada', fecha: '2024-09-25', puntos: 75 },
      { desc: "Mantenimiento de red", Client: "David Álvarez", status: 'Pendiente', fecha: '2024-09-24', puntos: 30 },
      { desc: "Configuración de router", Client: "Cristina Flores", status: 'Completada', fecha: '2024-09-23', puntos: 45 }
    ]
  },
  {
    NumTech: "ROB5678901",
    name: 'Roberto Silva',
    address: '456 Oak Rd, Anytown USA',
    crew: 'Crew C',
    tasks: [
      { desc: "Instalación de fibra óptica", Client: "Francisco Pérez", status: 'Completada', fecha: '2024-09-26', puntos: 90 },
      { desc: "Instalación de punto de acceso", Client: "Claudia Ortiz", status: 'Pendiente', fecha: '2024-09-25', puntos: 40 },
      { desc: "Mantenimiento de Internet", Client: "Elena Cruz", status: 'Completada', fecha: '2024-09-24', puntos: 55 }
    ]
  },
  {
    NumTech: "SOF6789012",
    name: 'Sofía Ramírez',
    address: '123 Main St, Anytown USA',
    crew: 'Crew A',
    tasks: [
      { desc: "Instalación de sistema de cámaras", Client: "Diego Rodríguez", status: 'Completada', fecha: '2024-09-27', puntos: 100 },
      { desc: "Revisión de antena satelital", Client: "Gloria Jiménez", status: 'Pendiente', fecha: '2024-09-26', puntos: 35 },
      { desc: "Instalación de red doméstica", Client: "Tomás Navarro", status: 'Completada', fecha: '2024-09-25', puntos: 65 }
    ]
  },
  {
    NumTech: "LAU7890123",
    name: 'Laura Torres',
    address: '789 Pine St, Anytown USA',
    crew: 'Crew B',
    tasks: [
      { desc: "Configuración de Smart Home", Client: "Oscar Salinas", status: 'Completada', fecha: '2024-09-28', puntos: 85 },
      { desc: "Instalación de antena de TV", Client: "Manuel Díaz", status: 'Pendiente', fecha: '2024-09-27', puntos: 30 },
      { desc: "Mantenimiento de sistema de seguridad", Client: "Valeria Ruiz", status: 'Completada', fecha: '2024-09-26', puntos: 55 }
    ]
  },
  {
    NumTech: "MAR8901234",
    name: 'Maria Munguia',
    address: '456 Oak Rd, Anytown USA',
    crew: 'Crew A',
    tasks: [
      { desc: "Configuración de Smart Home", Client: "Oscar Salinas", status: 'Completada', fecha: '2024-09-28', puntos: 85 },
      { desc: "Instalación de antena de TV", Client: "Manuel Díaz", status: 'Pendiente', fecha: '2024-09-27', puntos: 30 },
      { desc: "Mantenimiento de sistema de seguridad", Client: "Valeria Ruiz", status: 'Completada', fecha: '2024-09-26', puntos: 55 }
    ]
  }
],
totalTechs:11
}
