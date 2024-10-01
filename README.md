# Hackathon "Equipo 3"

## Descripción General
Bienvenido al proyecto del Hackathon. Este repositorio contiene una solución integral para la gestión de reportes de empleados, desarrollada con Angular para el frontend y .NET para la API backend. El sistema permite a los administradores visualizar registros de empleados, gestionar tareas, y optimizar el rendimiento del equipo. La aplicación está diseñada para ejecutarse localmente, proporcionando una experiencia completa de desarrollo tanto para el frontend como para el backend.

## Resumen del Proyecto

Este proyecto es un sistema de gestión de reportes para un acceso administrativo que permite visualizar registros de empleados, incluyendo datos de su cuadrilla, tareas asignadas y los puntos obtenidos en cada tarea, lo cual influye en su bono. Los administradores pueden filtrar reportes por diferentes criterios y generar PDFs de los reportes para su uso. Este sistema busca optimizar la gestión del rendimiento de los empleados y facilitar la toma de decisiones basada en datos.


## Estructura del Repositorio

```plaintext
hackathon-proyecto/
│
├── frontend/                     # Código fuente del frontend (Angular)
│   ├── src/                      # Componentes, servicios, y módulos de Angular
│   ├── README.md                 # Instrucciones específicas del frontend
│
├── backend/                      # Código fuente del backend (API .NET)
│   ├── src/                      # Controladores, modelos y servicios de la API
│   ├── README.md                 # Instrucciones específicas del backend
│
├── docs/                         # Documentación adicional del proyecto
│   ├── frontend-docs/            # Documentación específica del frontend
│   ├── backend-docs/             # Documentación específica del backend
│   └── README.md                 # Descripción de la arquitectura del proyecto
│
├── docker-compose.yml            # Configuración para contenedores en local (opcional)
├── .gitignore                    # Archivos y carpetas a ignorar por Git
├── README.md                     # Documentación general del proyecto (este archivo)
```

## Arquitectura del Proyecto

La arquitectura del sistema está diseñada siguiendo el patrón de **arquitectura de microservicios**, separando claramente las responsabilidades entre el frontend y el backend. Esto permite una mayor escalabilidad y mantenimiento, facilitando futuras actualizaciones y mejoras. A continuación, se describen los componentes clave:

### 1. Frontend
- **Angular**: Se encarga de la interfaz de usuario, ofreciendo una experiencia interactiva. La arquitectura está basada en componentes, lo que facilita la reutilización y organización del código. Utiliza servicios para manejar la comunicación con la API backend, asegurando una separación clara entre la lógica de presentación y la lógica de negocio.

### 2. Backend
- **API REST con .NET**: La API está diseñada para manejar todas las operaciones relacionadas con los datos de empleados, tareas y reportes. Se basa en controladores y servicios que interactúan con la base de datos mediante Entity Framework Core. Este enfoque promueve la separación de preocupaciones y facilita las pruebas unitarias y la mantenibilidad.
- **Entity Framework Core**: Actúa como el ORM (Object-Relational Mapper) para interactuar con SQL Server, simplificando las consultas y manipulaciones de datos.

### 3. Base de Datos
- **SQL Server**: Se utiliza para almacenar todos los datos relacionados con empleados, tareas y reportes. La base de datos está estructurada de manera que se optimiza la consulta y la integridad de los datos.

### 4. Comunicación entre Componentes
- El frontend se comunica con el backend a través de solicitudes HTTP, utilizando métodos como GET, POST, PUT y DELETE para realizar operaciones CRUD (Crear, Leer, Actualizar, Borrar) en los datos.

### 5. Diagrama de Arquitectura
- Para una mejor visualización de la arquitectura del sistema, consulta el archivo `README.md` en la carpeta `docs`, donde se incluye un diagrama que ilustra la relación entre los diferentes componentes del sistema.

Este enfoque modular no solo mejora la calidad del software, sino que también permite una rápida adaptación a cambios en los requisitos del negocio.

## Tecnologías Utilizadas

### Frontend
- Angular 18: Framework para construir aplicaciones web dinámicas y responsivas.
- Tailwind CSS: Framework de diseño que permite una estilización rápida y personalizada.
- PrimeNG: Conjunto de componentes UI que facilita la creación de interfaces modernas.

### Backend
- .NET 8.0: Plataforma para desarrollar APIs robustas y escalables.
- Entity Framework Core 8.0.7: ORM que simplifica la interacción con bases de datos.
- SQL Server 2019: Sistema de gestión de bases de datos que garantiza la integridad y seguridad de los datos.

## Tecnologías Utilizadas
- **Arquitectura y funcionalidades**:
- Diagrama entidad-relación bases de datos:
![BD](/Equipo-3-Mega/imagenes/bdimg.jpg)

- Diagrama de flujo del sistema:
![BD](/Equipo-3-Mega/imagenes/diagramaflujo.jpegpg)

## ¿Por qué se eligieron estas herramientas?

- Angular 18:
Elegido por su capacidad para construir aplicaciones web de una sola página (SPA), lo que facilita una experiencia de usuario fluida y rápida.

- Tailwind CSS:
Permite un diseño responsivo y personalizable, optimizando el tiempo de desarrollo sin salir del flujo de trabajo.

- PrimeNG:
Proporciona una amplia gama de componentes listos para usar, acelerando el desarrollo y mejorando la consistencia de la interfaz.

- .NET:
Ofrece un alto rendimiento y una rica biblioteca, asegurando que la API sea rápida y segura.

- Entity Framework Core:
Simplifica el desarrollo al permitir la manipulación de datos mediante un enfoque orientado a objetos.

- SQL Server:
Proporciona un entorno seguro y confiable para el almacenamiento y gestión de datos.

## Futuras Mejoras

- Integración con API Externas: Posibilidad de integrar datos de otras aplicaciones para un análisis más completo.
- Módulo de Feedback: Implementar un sistema de retroalimentación que permita a los empleados evaluar sus tareas y proporcionar comentarios.
- Optimización de Rendimiento: Continuar mejorando el rendimiento de la aplicación, asegurando tiempos de carga rápidos y una experiencia de usuario óptima.
- Interfaz de Usuario Mejorada: Recoger retroalimentación de usuarios para hacer mejoras continuas en la UI.
- Análisis de Datos Avanzados: Desarrollar funcionalidades que permitan análisis de tendencias en el rendimiento de los técnicos.

## Instalación

### Frontend
1. Clona el repositorio:
`
git clone https://github.com/Liderly/Equipo-3-Mega.git
cd frontend
`
2. Instala las dependencias
`
npm install
`
3. Inicia la aplicación:
`
npm star
`
La aplicación estará disponible en http://localhost:4200.

Aquí tienes el contenido traducido al español:

# Configuración del Backend

Sigue estos pasos para configurar y ejecutar el backend:

1. Clona el repositorio:
   ```bash
   git clone https://github.com/Liderly/Equipo-3-Mega.git
   cd backend
   ```

2. Restaura las dependencias:
   ```bash
   dotnet restore
   ```

3. Compila el proyecto:
   ```bash
   dotnet build
   ```

4. Configura y ejecuta el contenedor de Redis:
   1. Crea un volumen para la persistencia de datos:
      ```bash
      docker volume create redis-data
      ```
   2. Ejecuta el contenedor de Redis con el volumen creado:
      ```bash
      docker run -d --name redis-container -v redis-data:/data -p 6379:6379 redis redis-server --appendonly yes
      ```

5. Ejecuta la API:
   ```bash
   dotnet run
   ```

## Notas
- Asegúrate de tener Docker instalado y en funcionamiento para el paso 4.
- La API estará disponible en `http://localhost:5000` por defecto (o en otro puerto si se configuró de manera diferente).

### Documentación API

Consulta el README.md en la carpeta backend para más detalles sobre las rutas y cómo interactuar con la API.
