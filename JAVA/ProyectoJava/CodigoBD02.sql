-- MySQL Script generated by MySQL Workbench
-- 12/01/15 19:38:44
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='TRADITIONAL,ALLOW_INVALID_DATES';

-- -----------------------------------------------------
-- Schema ProyectoJava01
-- -----------------------------------------------------

-- -----------------------------------------------------
-- Table `Persona`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Persona` ;

CREATE TABLE IF NOT EXISTS `Persona` (
  `PERSONA_ID` INT NOT NULL,
  `PERS_FECHA_NACIMIENTO` DATE NOT NULL,
  `PERS_SEXO` VARCHAR(45) NOT NULL,
  `PERS_NOMBRE` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`PERSONA_ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Domicilio`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Domicilio` ;

CREATE TABLE IF NOT EXISTS `Domicilio` (
  `DOMICILIO_ID` INT NOT NULL,
  `DOMI_COLONIA` VARCHAR(45) NOT NULL,
  `DOMI_ENTIDAD_FEDERATIVA` VARCHAR(45) NOT NULL,
  `DOMI_MUNICIPIO` VARCHAR(45) NOT NULL,
  `DOMI_CP` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`DOMICILIO_ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `DomicilioFiscal`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `DomicilioFiscal` ;

CREATE TABLE IF NOT EXISTS `DomicilioFiscal` (
  `DOMICILIO_ID` INT NOT NULL,
  `DOMI_COLONIA` VARCHAR(45) NOT NULL,
  `DOMI_ENTIDAD_FEDERATIVA` VARCHAR(45) NOT NULL,
  `DOMI_MUNICIPIO` VARCHAR(45) NOT NULL,
  `DOMI_CP` VARCHAR(45) NOT NULL,
  PRIMARY KEY (`DOMICILIO_ID`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Empleado`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Empleado` ;

CREATE TABLE IF NOT EXISTS `Empleado` (
  `EMPLEADO_ID` INT NOT NULL,
  `EMPL_SUELDO` DOUBLE NOT NULL,
  `EMPL_NSS` VARCHAR(45) NULL,
  `EMPL_PERSONA_ID` INT NOT NULL,
  `EMPL_DOMICILIO_ID` INT NOT NULL,
  `DomicilioFiscal_DOMICILIO_ID` INT NOT NULL,
  PRIMARY KEY (`EMPLEADO_ID`, `EMPL_DOMICILIO_ID`, `DomicilioFiscal_DOMICILIO_ID`),
  INDEX `fk_Empleado_Persona1_idx` (`EMPL_PERSONA_ID` ASC),
  INDEX `fk_Empleado_Domicilio1_idx` (`EMPL_DOMICILIO_ID` ASC),
  INDEX `fk_Empleado_DomicilioFiscal1_idx` (`DomicilioFiscal_DOMICILIO_ID` ASC),
  CONSTRAINT `fk_Empleado_Persona1`
    FOREIGN KEY (`EMPL_PERSONA_ID`)
    REFERENCES `Persona` (`PERSONA_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Empleado_Domicilio1`
    FOREIGN KEY (`EMPL_DOMICILIO_ID`)
    REFERENCES `Domicilio` (`DOMICILIO_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Empleado_DomicilioFiscal1`
    FOREIGN KEY (`DomicilioFiscal_DOMICILIO_ID`)
    REFERENCES `DomicilioFiscal` (`DOMICILIO_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Ejecutivo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Ejecutivo` ;

CREATE TABLE IF NOT EXISTS `Ejecutivo` (
  `EJECUTIVO_ID` INT NOT NULL,
  `EJEC_BONO` DOUBLE NOT NULL,
  `EJEC_EMPLEADO_ID` INT NOT NULL,
  PRIMARY KEY (`EJECUTIVO_ID`, `EJEC_EMPLEADO_ID`),
  INDEX `fk_Ejecutivo_Empleado1_idx` (`EJEC_EMPLEADO_ID` ASC),
  CONSTRAINT `fk_Ejecutivo_Empleado1`
    FOREIGN KEY (`EJEC_EMPLEADO_ID`)
    REFERENCES `Empleado` (`EMPLEADO_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Directivo`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Directivo` ;

CREATE TABLE IF NOT EXISTS `Directivo` (
  `DIRECTIVO_ID` INT NOT NULL,
  `DIRE_ACCION` DOUBLE NOT NULL,
  `DIRE_EMPLEADO_ID` INT NOT NULL,
  PRIMARY KEY (`DIRECTIVO_ID`, `DIRE_EMPLEADO_ID`),
  INDEX `fk_Directivo_Empleado1_idx` (`DIRE_EMPLEADO_ID` ASC),
  CONSTRAINT `fk_Directivo_Empleado1`
    FOREIGN KEY (`DIRE_EMPLEADO_ID`)
    REFERENCES `Empleado` (`EMPLEADO_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Perfil`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Perfil` ;

CREATE TABLE IF NOT EXISTS `Perfil` (
  `ID_PERFIL` INT NOT NULL,
  `PERF_FECHA_ALTA` DATE NOT NULL,
  PRIMARY KEY (`ID_PERFIL`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Cuenta`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Cuenta` ;

CREATE TABLE IF NOT EXISTS `Cuenta` (
  `CUENTA_ID` INT NOT NULL,
  `CUEN_USUARIO` VARCHAR(45) NOT NULL,
  `CUEN_CONTRASENA` VARCHAR(45) NOT NULL,
  `CUEN_FECHA_CREACION` DATE NOT NULL,
  `CUEN_PERSONA_ID` INT NOT NULL,
  `CUEN_PERFIL_ID` INT NOT NULL,
  PRIMARY KEY (`CUENTA_ID`, `CUEN_PERFIL_ID`),
  INDEX `fk_Cuenta_Persona1_idx` (`CUEN_PERSONA_ID` ASC),
  INDEX `fk_Cuenta_Perfil1_idx` (`CUEN_PERFIL_ID` ASC),
  CONSTRAINT `fk_Cuenta_Persona1`
    FOREIGN KEY (`CUEN_PERSONA_ID`)
    REFERENCES `Persona` (`PERSONA_ID`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION,
  CONSTRAINT `fk_Cuenta_Perfil1`
    FOREIGN KEY (`CUEN_PERFIL_ID`)
    REFERENCES `Perfil` (`ID_PERFIL`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;
