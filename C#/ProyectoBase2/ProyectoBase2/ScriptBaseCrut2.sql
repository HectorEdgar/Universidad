/*
Created		17/04/2016
Modified		04/05/2016
Project		
Model		
Company		
Author		
Version		
Database		mySQL 5 
*/


drop table IF EXISTS Domicilio;
drop table IF EXISTS Prestamo;
drop table IF EXISTS Solicitante;
drop table IF EXISTS Material;


Create table Material (
	Mate_Codigo Int NOT NULL,
	Mate_Nombre Varchar(30) NOT NULL,
	Mate_Modelo Varchar(40) NOT NULL,
	Mate_Marca Varchar(30) NOT NULL,
	Mate_FechaAdquisicion Date NOT NULL,
    Mate_disponible Bool NOT NULL DEFAULT True,
	Mate_Eliminado Bool NOT NULL,
	
 Primary Key (Mate_Codigo)) ENGINE = MyISAM;

Create table Solicitante (
	Soli_Codigo Int NOT NULL,
	Soli_Nombre Char(20) NOT NULL,
	Soli_Apellido_Pate Varchar(20) NOT NULL,
	Soli_Apellido_Mate Varchar(20) NOT NULL,
	Domi_Id Int NOT NULL,
	Soli_Eliminado Bool NOT NULL,
	Soli_Sexo Varchar(20) NOT NULL,
	Soli_FechaNacimiento Varchar(30) NOT NULL,
 Primary Key (Soli_Codigo)) ENGINE = MyISAM;

Create table Prestamo (
	Pres_Codigo Int NOT NULL,
	Pres_FechaPrestamo Date NOT NULL,
	Pres_CatidadMaterial Int NOT NULL,
	Pres_FechaEntrega Date NOT NULL,
	Mate_Codigo Int NOT NULL,
	Soli_Codigo Int NOT NULL,
	Pres_Eliminado Bool NOT NULL,
 Primary Key (Pres_Codigo)) ENGINE = MyISAM;

Create table Domicilio (
	Domi_Id Int NOT NULL,
	Domi_Calle Varchar(30) NOT NULL,
	Domi_Colonia Varchar(20) NOT NULL,
	Domi_Municipio Varchar(30) NOT NULL,
	Domi_CodigoPostal Varchar(20) NOT NULL,
	Domi_Eliminado Bool NOT NULL,
 Primary Key (Domi_Id)) ENGINE = MyISAM;


Alter table Prestamo add Foreign Key (Mate_Codigo) references Material (Mate_Codigo) on delete  restrict on update  restrict;
Alter table Prestamo add Foreign Key (Soli_Codigo) references Solicitante (Soli_Codigo) on delete  restrict on update  restrict;
Alter table Solicitante add Foreign Key (Domi_Id) references Domicilio (Domi_Id) on delete  restrict on update  restrict;


/* Users permissions */

INSERT INTO MATERIAL(Mate_Codigo,Mate_Nombre,Mate_Modelo,Mate_Marca,Mate_FechaAdquisicion,Mate_disponible,Mate_Eliminado) values(1,'fd','asdfa','fa3','1996-11-11',true,false);
INSERT INTO MATERIAL(Mate_Codigo,Mate_Nombre,Mate_Modelo,Mate_Marca,Mate_FechaAdquisicion,Mate_disponible,Mate_Eliminado) values(2,'fsdd','asdf','fasf3','1996-11-11',true,false);

select * from material;
delete from material where Mate_Codigo=2;
update material set Mate_Codigo=3 ,Mate_Nombre='Edgar',Mate_Modelo='das', Mate_Marca='sadf', Mate_FechaAdquisicion='1932-02-11',Mate_disponible=false,Mate_Eliminado=false where Mate_Codigo=3;



CREATE TABLE persona(
	persona_id INT PRIMARY KEY,
	nombre VARCHAR(50),
	estado VARCHAR(20)
);

CREATE TABLE perfil(
	perfil_id INT PRIMARY KEY,
	nombre VARCHAR(50),
	descripcion VARCHAR(50),
	estado VARCHAR(20)


);
CREATE TABLE cuenta(
	cuenta_id INT PRIMARY KEY,
	usuario VARCHAR(50),
	contrasena VARCHAR(50),
	correoelectronico VARCHAR(50),
	estado VARCHAR(20),

	persona_id INT NOT NULL, 
	perfil_id INT NOT NULL

);





ALTER TABLE cuenta
ADD FOREIGN KEY (persona_id)
REFERENCES persona (persona_id);

ALTER TABLE cuenta
ADD FOREIGN KEY (perfil_id)
REFERENCES perfil (perfil_id);

ALTER TABLE cuenta 
CHARSET=latin1 COLLATE=latin1_bin;

ALTER TABLE cuenta 
CHANGE usuario usuario VARCHAR( 50 ) 
CHARACTER SET latin1 COLLATE latin1_bin;

ALTER TABLE cuenta 
CHANGE contrasena contrasena VARCHAR( 50 ) 
CHARACTER SET latin1 COLLATE latin1_bin;

drop table cuenta;
drop table perfil;
drop table persona;

INSERT INTO persona(persona_id,nombre,estado)
VALUES
(14,'Hector Edgar','01'),
(2,'Jair Cristhian','01'),
(3,'Yu ban','01');
INSERT INTO persona(persona_id,nombre,estado)
VALUES
(4,'Pedro antonio','01'),
(5,'Juan Perez','01'),
(6,'Eduardo Luis','01'),
(7,'Luis Antonio','01'),
(8,'Angel Fernando','01'),
(9,'Angel Daniel','01'),
(10,'Luis Paulo','01'),
(11,'Roberto Zuñiga','01'),
(12,'Ricardo','01');



INSERT INTO perfil(perfil_id,nombre,descripcion,estado)
VALUES 
(4,'Administrador','admin','01'),
(2,'CHINO','DESCRIPCION','01'),
(3,'YU','DESCRIPCION','01');


INSERT INTO cuenta(cuenta_id,usuario,contrasena,correoelectronico,estado,persona_id,perfil_id)
VALUES
(4,'root','root','hetorb@gmail.com','01',1,1),
(2,'chino65','123ds45','jair@gmail.com','01',2,2),
(3,'yu66','123sdfad45','yu@gmail.com','01',3,3);


SELECT * FROM perfil;
SELECT * FROM cuenta;
SELECT * FROM persona;

SELECT * FROM PERSONA WHERE NOMBRE LIKE '%he%';

SELECT * FROM CUENTA as c, persona AS pers, perfil as perf WHERE c.USUARIO="root" AND c.CONTRASENA="root" AND pers.persona_id=c.persona_id AND perf.perfil_id = c.perfil_id;


SELECT * FROM CUENTA INNER JOIN PERSONA on 	PERSONA.persona_id = CUENTA.persona_id INNER JOIN PERFIL ON PERFIL.perfil_id = CUENTA.perfil_id where cuenta.usuario='root';

SELECT cuenta.cuenta_id as CuentaCuenta_id,
cuenta.usuario as CuentaUsuario,
cuenta.contrasena as CuentaContrasena,
cuenta.correoelectronico as CuentaCorreoElectronico,
cuenta.estado as CuentaEstado,
persona.persona_id as PersonaPersona_id,
persona.nombre as PersonaNombre,
persona.estado as PersonaEstado,
perfil.perfil_id as PerfilPerfil_id,
perfil.nombre as PerfilNombre,
perfil.descripcion as PerfilDescripcion,
perfil.estado as PerfilEstado
FROM CUENTA INNER JOIN PERSONA on 	PERSONA.persona_id = CUENTA.persona_id INNER JOIN PERFIL ON PERFIL.perfil_id = CUENTA.perfil_id where cuenta.usuario='root';

SELECT cuenta.cuenta_id as CuentaCuenta_id,cuenta.usuario as CuentaUsuario,cuenta.contrasena as CuentaContrasena,cuenta.correoelectronico as CuentaCorreoElectronico,cuenta.estado as CuentaEstado,persona.persona_id as PersonaPersona_id,persona.nombre as PersonaNombre,persona.estado as PersonaEstado,perfil.perfil_id as PerfilPerfil_id,perfil.nombre as PerfilNombre,perfil.descripcion as PerfilDescripcion,perfil.estado as PerfilEstado FROM CUENTA INNER JOIN PERSONA on  PERSONA.persona_id = CUENTA.persona_id INNER JOIN PERFIL ON PERFIL.perfil_id = CUENTA.perfil_id where cuenta.usuario LIKE '%r%'; 

SELECT * FROM CUENTA INNER JOIN PERSONA on 	PERSONA.persona_id = CUENTA.persona_id INNER JOIN PERFIL ON PERFIL.perfil_id = CUENTA.perfil_id;