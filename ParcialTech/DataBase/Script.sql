create table Retenciones(
RetencionesId int identity(1,1)primary key,
Descripcion varchar(255),
Valor varchar(10),
);

create table TiposEmail(
TiposEmailId int identity(1,1) primary key,
Descripcion varchar(255),
);

create table Empleados(
EmpleadoId int identity(1,1)primary key,
Nombes varchar(50),
FechaNacimiento datetime,
Sueldo float
);

create table EmpleadosDescuentos(
Id int identity(1,1) primary key,
EmpleadoId int,
RetencionId int
);

create table EmpleadosEmails(
Id int identity(1,1) primary key,
EmpleadoId int,
TipoId int,
Email varchar(50)
);