create database if not exists REI;

create table REI.Cliente (
	IdCliente int not null, 
	Email varchar(45) not null,
	Nombre varchar(45) not null,
    Apellido varchar(45) not null,
    Contrasenia varchar (45) not null,
    Nacimiento date not null,
    Primary key(Email)
     
);
create table REI.Dispositivo (
	IdDispositivo int not null,
    NumSerie int not null,
	Modelo varchar(45) not null,
    primary key(IdDispositivo)
   
);
create table REI.Medicion (
	IdMedicion int not null, 
	IdDispositivo int not null,
    Unidad varchar(45) not null,
    Valor int not null,
    FechaHora datetime not null,
    constraint FK_Medicion_Dispositivo foreign key(IdDispositivo)
    references REI.Dispositivo (IdDispositivo)
);

create table REI.Notificacion (
	IdNotificacion int not null, 
	IdDispositivo int not null,
    Mensaje varchar(45) not null,
    FechaHora datetime not null,
    constraint FK_Notificacion_Dispositivo foreign key(IdDispositivo)
    references REI.Dispositivo  (IdDispositivo)
);
create table REI.Falta  (
	IdFalta int not null, 
	IdDispositivo int not null,
    Mensaje varchar (45) not null,
    constraint FK_Falta_Dispositivo  foreign key (IdDispositivo)
    references REI.Dispositivo (IdDispositivo)
);