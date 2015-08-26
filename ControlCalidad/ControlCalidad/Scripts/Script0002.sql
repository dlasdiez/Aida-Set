
USE Metalcaucho;

CREATE TABLE IF NOT EXISTS permiso_aplicacion (
	pa_id           INT AUTO_INCREMENT,
	pa_modulo       INT NOT NULL,
	pa_user         VARCHAR (50) NOT NULL,
	pa_modificacion BOOLEAN DEFAULT 0,
	pa_baja         BOOLEAN DEFAULT 0,
	pa_lectura      BOOLEAN DEFAULT 0,
	PRIMARY KEY (pa_id)
);