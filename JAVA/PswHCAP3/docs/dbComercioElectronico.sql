--
-- Creando la base de datos
--
CREATE DATABASE IF NOT EXISTS comercio_electronico;
USE comercio_electronico;

--
-- Creando la tabla `producto`
--
DROP TABLE IF EXISTS `producto`;
CREATE TABLE `producto` (
  `codigoProducto` int(11) NOT NULL,
  `nombre` varchar(100) NOT NULL,
  `precio` decimal(18,2) NOT NULL,
  PRIMARY KEY  (`codigoProducto`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Procedimiento almacenado para insertar un producto
--
DROP PROCEDURE IF EXISTS `spI_producto`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `spI_producto`(
   INOUT _codigoProducto  int ,
   _nombre  varchar(100) ,
   _precio  decimal(18, 2)
)
BEGIN
-- incremento controlado
SELECT IFNULL(MAX(codigoProducto),0)+1 into _codigoProducto FROM `producto`;
INSERT INTO `producto`(
   `codigoProducto`,
   `nombre`,
   `precio`
)
VALUES (
   _codigoProducto,
   _nombre,
   _precio
);
END $$
DELIMITER ;

--
-- Procedimiento almacenado para obtener todos los productos
--
DROP PROCEDURE IF EXISTS `spF_producto_all`;
DELIMITER $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `spF_producto_all`(
)
BEGIN

SELECT
    p.codigoProducto,
    p.nombre,
    p.precio
FROM
    producto p
ORDER BY
    P.nombre

;
END $$
DELIMITER ;
