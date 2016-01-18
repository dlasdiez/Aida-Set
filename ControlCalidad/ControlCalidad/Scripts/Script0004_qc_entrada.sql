USE Metalcaucho;

CREATE TABLE IF NOT EXISTS `qc_entrada` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `fecha_creacion` datetime NULL,
  `fecha_revision` datetime NULL,
  `fecha_calidad` datetime NULL,
  `proveedor_id` varchar(20),
  `proveedor_nombre` varchar(255),
  `resultado_qc` int,
	`numero_lote` varchar(22),
  `usuario_creacion_id` bigint(20),
  `usuario_creacion_nombre` varchar(255),
  `ref_metalcaucho` bigint(20),
  `numero_plano` bigint(20),  
	`unidades_recibidas` int,
  `unidades_verificadas` int,
	`usuario_verificado_id` bigint(20),
  `usuario_verificado_nombre` varchar(255),
  `almacen` int,
  `observaciones` text,
	`revisar_calidad` bit,
  `visualizar_pautas_autocontrol` bit,
  `solicitar_banco_pruebas` bit,
  `imagen_1` blob,
  `imagen_2` blob,
  `imagen_3` blob,
  `imagen_4` blob,
  `imagen_5` blob,
	`acciones` text,
  `ubicacion_certificado` varchar(255),  
 
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;
