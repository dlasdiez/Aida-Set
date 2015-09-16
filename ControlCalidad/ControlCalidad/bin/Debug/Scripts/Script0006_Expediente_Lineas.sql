USE Metalcaucho;

CREATE TABLE IF NOT EXISTS `expediente_lineas` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `Id_expediente` bigint(20) NOT NULL,
  `fecha_creacion` datetime NULL,
  `fecha_modificacion` datetime NULL,
  `usuario_creacion_id` bigint(20),
  `proveedor_id` varchar(9),
  `proveedor_nombre` varchar(255),
  `referencia_proveedor` varchar(255),
  `num_lote` varchar(22),
  `unidades` bigint(20),
  PRIMARY KEY (`Id`,`Id_expediente`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

ALTER TABLE  `metalcaucho`.`expediente_lineas` ADD INDEX  `Expediente` (  `Id_expediente` );
