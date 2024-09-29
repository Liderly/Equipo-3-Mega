# Documentación API

## Rutas

### Suscriptores

- **[GET] /api/Suscribers**
  - **Descripción**: Obtiene una lista paginada de suscriptores registrados en el sistema.
  - **Parámetros de Consulta**:
    - `page`: (opcional) Número de la página a recuperar.
    - `pageSize`: (opcional) Número de suscriptores por página.
  - **Respuesta**:
    - Código 200: Retorna un objeto JSON con la lista de suscriptores y la información de paginación.
    - Código 404: No se encontraron suscriptores.

- **[GET] /api/Suscribers/{id}**
  - **Descripción**: Obtiene la información detallada de un suscriptor específico utilizando su ID.
  - **Parámetros**:
    - `id`: Identificador único del suscriptor.
  - **Respuesta**:
    - Código 200: Retorna un objeto JSON con los detalles del suscriptor.
    - Código 404: Suscriptor no encontrado.

### Tareas

- **[GET] /api/Tasks**
  - **Descripción**: Obtiene todas las tareas realizadas, permitiendo a los administradores revisar el historial de trabajo de los técnicos.
  - **Parámetros de Consulta**:
    - `filter`: (opcional) Parámetro para filtrar tareas por estado (completadas, pendientes, etc.).
    - `startDate`: (opcional) Fecha de inicio para filtrar tareas.
    - `endDate`: (opcional) Fecha de finalización para filtrar tareas.
  - **Respuesta**:
    - Código 200: Retorna un objeto JSON con la lista de tareas y detalles como tipo de trabajo, puntos, y estado.
    - Código 204: No se encontraron tareas.

- **[GET] /api/Tasks/{id}**
  - **Descripción**: Obtiene una tarea específica utilizando su ID.
  - **Parámetros**:
    - `id`: Identificador único de la tarea.
  - **Respuesta**:
    - Código 200: Retorna un objeto JSON con los detalles de la tarea.
    - Código 404: Tarea no encontrada.

## Ejemplo de Respuestas

### Ejemplo de Respuesta para `GET /api/Suscribers`
```json
{
  "currentPage": 1,
  "totalPages": 3,
  "totalCount": 25,
  "items": [
    {
      "id": 1,
      "name": "Juan Pérez",
      "email": "juan@example.com",
      "pointsAccumulated": 150
    },
    {
      "id": 2,
      "name": "María García",
      "email": "maria@example.com",
      "pointsAccumulated": 200
    }
  ]
}
```
### Ejemplo de Respuesta para GET /api/Tasks/{id}
``` json
{
  "id": 1,
  "subscriberId": 2,
  "workType": "Instalación de acomida",
  "points": 5,
  "date": "2024-09-01T12:00:00Z",
  "status": "Completada"
}
```
