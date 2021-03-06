USE Metalcaucho;

CREATE TABLE IF NOT EXISTS `garantias_entrada` (
  `Id` bigint(20) NOT NULL AUTO_INCREMENT,
  `fecha_creacion` datetime NULL,
  `fecha_modificacion` datetime NULL,
  `fecha_recepcion` datetime NULL,
  `usuario_creacion_id` bigint(20),
  `usuario_creacion_nombre` varchar(255),
  `proveedor_id` bigint(20),
  `proveedor_nombre` varchar(255),
  `ref_metalcaucho` bigint(20),
  `descripcion` varchar(255),
  `codigo_acceso_alternativo` varchar(255),
  `referencia_proveedor` varchar(255),
  `numero_lote` bigint(20),
  `numero_expediente` bigint(20),
  `cliente_id` bigint(20),
  `cliente_nombre` varchar(255),
  `descripcion_problema` varchar(255),
  `observaciones` varchar(255),
  `cli_informe` bit,
  `numero_informe` varchar(255),
  `mc_abonar` bit,
  `mc_analisis` bit,
  `adm_documentacion_entregada` bit,
  `adm_fecha` datetime NULL,
  `responsable_zona_id` bigint(20),
  `responsable_zona` varchar(255),
  `doc_cliente` bit,
  `doc_informe_ot` TinyInt,
  `doc_nombre_registro` varchar(255),
  `doc_lugar_registro` varchar(255),
  `estado` TinyInt,
  `solicitud_banco_pruebas` bit,
  `via_interna_externa` bit,  
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;
