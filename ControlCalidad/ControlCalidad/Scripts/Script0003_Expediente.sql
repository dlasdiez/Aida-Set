USE Metalcaucho;

CREATE TABLE IF NOT EXISTS `expediente` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `fecha_creacion` datetime NULL,
  `fecha_modificacion` datetime NULL,
  `fecha_expedicion` datetime NULL,
  `cod_articulo` varchar(22),
  `articulo_nombre` varchar(255),
  `usuario_id` bigint(20),
  `usuario_nombre` varchar(255),
  `cliente_id` varchar(9),
  `cliente_nombre` varchar(255),
  `cliente_email` varchar(255),
  `cli_referencia` varchar(255),
  `ref_metalcaucho` bigint(20),
  `observaciones` text,
  `cli_SDC` bit,
  `cli_DC` bit,
  `motivo_denegacion` text,
  `notas` text,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;
