### Equipo 3 MEGAWINNERS

## Descripción de la problemática
Dentro de la empresa se cuenta con diferentes procesos de pago de acuerdo a las áreas en las que se encuentra, una de ellas es el área de técnico y el proceso de pago de puntos.
El pago de puntos se realiza a cada técnico de manera mensual (cada quince días), este pago de puntos se realiza de acuerdo al nivel de dificultad que tenga la tarea, por ejemplo:
- Instalación de acomida --> 5 puntos
- Instalación de equipo --> 2 puntos

La cantidad de puntos reunida por cada técnico es comparada con una tabla de puntos la cual es la siguiente:
- De 0 a 8 = 0 pesos
- De 81 a 150 = 300 pesos
- De 151 a 210 = 500 pesos
- De 211 en adelante = 650 pesos

Por ejemplo: Si un técnico realiza 15 servicios de instalación de acomida y 12 de instalación de equipos, estaría acumulando por:
- Servicio de instalación: 15 servicios * 5 puntos = 75 puntos
- Instalación de equipos: 12 instalaciones * 2 puntos = 24 puntos
Lo cual nos daría el total de 99 puntos y le correspondería un total de 300 pesos de bono.

Al consultar los bonos correspondientes a cada técnico es necesario que se reflejen reportes los cuales contengan de manera detallada cada una de las órdenes realizadas con detalles como tipo de trabajo, puntos, fecha, importe, etc.

De acuerdo a lo anterior se requiere desarrollar un sistema de generación de reportes automatizado que visualize los puntos generados (por ende el pago correspondiente) a cada técnico y pueda ser consultado en cualquier momento por quien lo requiera.

## Requerimientos técnicos
Para la realización del frontend se utilizaron las siguientes tecnologías:
- Angular v 17
Por otro lado, para el backend se utilizaron las siguientes:
- ASP.NET  v8.0
- Entity framework
Para la elaboración de la base de datos se utilizó SQL SERVER 2019.

## ¿Cómo utilizar este repositorio?



## Objetivos
- General
Realizar un reporte automatizado para el pago de puntos, el cual contenga por lo menos lo siguiente:
  - Trabajo realizado
  - Puntos generados
  - Suscriptor
  - Fecha
  - Total de puntos obtenidos
  - Importe del bono a pagar

- Específicos
 - Elaborar una base de datos adecuada para desarrollar el proyecto.
 - Diseñar una interfaz atractiva e intuitiva para el usuario que le permita desarrollar funciones como filtrar por técnico (PREGUNTAR FILTROS).
 - Diseñar y elaborar una API REST con .NET de manera adecuada y rápida, y consumirla en nuestro frontend.

## Alcance del proyecto
Este proyecto consiste en la creación de una plataforma que permita a los usuarios consultar la cantidad de puntos, incluída la cantidad a pagar de bono al técnico correspondiente, así como la generación de reportes con campos que especifican lo siguiente:
  - Trabajo realizado
  - Puntos generados
  - Suscriptor
  - Fecha
  - Total de puntos obtenidos
  - Importe del bono a pagar
Así como la filtración de datos con criterios específicos, filtración de tareas completadas.
No se encuentra dentro del alcance del proyecto:
 - Creación de nuevas órdenes y actualización de puntos conforme se añaden nuevas órdenes.

## Descripción de la solución
La solución propuesta para la problemática dada es el desarrollo de una plataforma en la cual se pueda consultar y visualizar de manera rápida, mediante reportes, la cantidad de puntos generados así como del monto a otorgar a cada técnico de acuerdo a los trabajos realizados de manera semanal en un desglose que contenga campos como los siguientes:
  - Trabajo realizado
  - Puntos generados
  - Suscriptor
  - Fecha
  - Total de puntos obtenidos
  - Importe del bono a pagar

Lo anterior visualizado a manera de tabla.

## Diagrama de la base de datos
 - Diagrama normalizado de la base de datos
 -
