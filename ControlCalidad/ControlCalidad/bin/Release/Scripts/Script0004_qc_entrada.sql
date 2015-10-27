USE Metalcaucho;

CREATE TABLE IF NOT EXISTS `qc_entrada` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `fecha_creacion` datetime NULL,
  `fecha_modificacion` datetime NULL,
  `fecha_revision` datetime NULL,
  `usuario_creacion_id` bigint(20),
  `usuario_creacion_nombre` varchar(255),
  `proveedor_id` bigint(20),
  `proveedor_nombre` varchar(255),
  `ref_metalcaucho` bigint(20),
  `numero_lote` bigint(20),
  `numero_plano` bigint(20),
  `unidades_recibidas` int,
  `unidades_verificadas` int,
  `valor_muestreo` int,
  `usuario_verificado_id` bigint(20),
  `usuario_verificado_nombre` varchar(255),
  `almacen` int,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;
