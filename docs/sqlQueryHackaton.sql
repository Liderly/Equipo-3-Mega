CREATE DATABASE MEGAHACK;
USE MEGAHACK;

CREATE TABLE Subscriptor (
    id INT PRIMARY KEY,
    name varchar(100),
    last_name varchar(255),
    street varchar(255),
post_Code int,
zone_sub varchar(250),  
);

CREATE TABLE Quadrille (
    id INT PRIMARY KEY,
    quadrille_number INT NOT NULL,
    region VARCHAR(100) NOT NULL,
    branch_office VARCHAR(100) NOT NULL,
    state_quadrille VARCHAR(100) NOT NULL,
);


CREATE TABLE Technicians (
    id INT  PRIMARY KEY,
    name varchar(100),
    last_name varchar(255),
    employee_number INT NOT NULL UNIQUE,
    quadrille_id INT,
    FOREIGN KEY (quadrille_id) REFERENCES Quadrille(id) ON DELETE SET NULL
);

CREATE TABLE ServiceCatalog (
    id INT PRIMARY KEY,
    service_name VARCHAR(100) NOT NULL,
    duration INT NOT NULL,
    description_service VARCHAR(100) NOT NULL,
    points INT NOT NULL,
);


CREATE TABLE Assignments (
    id INT PRIMARY KEY,
    technician_id INT,
    subscriber_id INT,
    service_id INT,
    status_assigment VARCHAR(100) NOT NULL,
    FOREIGN KEY (technician_id) REFERENCES Technicians(id) ,
    FOREIGN KEY (subscriber_id) REFERENCES Subscriptor(id) ,
    FOREIGN KEY (service_id) REFERENCES ServiceCatalog(id)
);

INSERT INTO Subscriptor (id, name, last_name, street, post_Code, zone_sub)
VALUES 
(1, 'Juan', 'Garc�a', 'Av. Revoluci�n 123', 44600, 'Zona Norte'),
(2, 'Mar�a', 'Hern�ndez', 'Calle Ju�rez 456', 44780, 'Zona Sur'),
(3, 'Jos�', 'L�pez', 'Av. Insurgentes 789', 44100, 'Zona Centro'),
(4, 'Ana', 'Mart�nez', 'Calle Hidalgo 321', 44890, 'Zona Este'),
(5, 'Carlos', 'Gonz�lez', 'Av. Patria 654', 44210, 'Zona Oeste'),
(6, 'Luisa', 'Rodr�guez', 'Calle Morelos 987', 44350, 'Zona Norte'),
(7, 'Pedro', 'P�rez', 'Av. Vallarta 741', 44560, 'Zona Centro'),
(8, 'Laura', 'S�nchez', 'Calle Col�n 852', 44770, 'Zona Sur'),
(9, 'Miguel', 'Ram�rez', 'Av. Chapultepec 963', 44020, 'Zona Este'),
(10, 'Elena', 'Fern�ndez', 'Calle Allende 369', 44900, 'Zona Oeste');


INSERT INTO Quadrille (id, quadrille_number, region, branch_office, state_quadrille)
VALUES 
(1, 201, 'Norte', 'Sucursal Monterrey', 'Nuevo Le�n'),
(2, 202, 'Sur', 'Sucursal Oaxaca', 'Oaxaca'),
(3, 203, 'Este', 'Sucursal Veracruz', 'Veracruz'),
(4, 204, 'Oeste', 'Sucursal Guadalajara', 'Jalisco'),
(5, 205, 'Centro', 'Sucursal Ciudad de M�xico', 'Ciudad de M�xico'),
(6, 206, 'Noreste', 'Sucursal Tampico', 'Tamaulipas'),
(7, 207, 'Noroeste', 'Sucursal Tijuana', 'Baja California'),
(8, 208, 'Sureste', 'Sucursal M�rida', 'Yucat�n'),
(9, 209, 'Suroeste', 'Sucursal Acapulco', 'Guerrero'),
(10, 210, 'Norte', 'Sucursal Saltillo', 'Coahuila');

INSERT INTO Technicians (id, name, last_name, employee_number, quadrille_id)
VALUES 
(1, 'Luis', 'Garc�a', 1001, 201),
(2, 'Mar�a', 'L�pez', 1002, 202),
(3, 'Jos�', 'Mart�nez', 1003, 203),
(4, 'Ana', 'Hern�ndez', 1004, 204),
(5, 'Carlos', 'P�rez', 1005, 205),
(6, 'Elena', 'Ram�rez', 1006, 206),
(7, 'Jorge', 'Gonz�lez', 1007, 207),
(8, 'Claudia', 'S�nchez', 1008, 208),
(9, 'Pedro', 'Ruiz', 1009, 209),
(10, 'Laura', 'Mendoza', 1010, 210);