using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace OBJ
{
	public class ObjRegistroQCEntrada
	{
		public long Id { get; set; }
		public DateTime FechaCreacion { get; set; }
		public DateTime FechaRevision { get; set; }
		public DateTime FechaCalidad { get; set; }
		public long ProveedorId { get; set; }
		public String ProveedorNombre { get; set; }
		public Int32 ResultadoQC { get; set; }
		public long NumLote { get; set; }
		public long UsuarioId { get; set; }
		public String UsuarioNombre { get; set; }
		public long RefMetalcaucho { get; set; }
		public long NumPlano { get; set; }
		public Int32 UnidadesRecibidas { get; set; }
		public Int32 UnidadesVerificadas { get; set; }
		public long UsuarioVerificadoId { get; set; }
		public String UsuarioVerificadoNombre { get; set; }
		public Int32 Almacen { get; set; }
		public String Observaciones { get; set; }
		public Boolean RevisarCalidad { get; set; }
		public Boolean VisualizarPautasAutocontrol { get; set; }
		public Boolean SolicitarBancoPruebas { get; set; }
		public Image Imagen1 { get; set; }
		public Image Imagen2 { get; set; }
		public Image Imagen3 { get; set; }
		public Image Imagen4 { get; set; }
		public Image Imagen5 { get; set; }
		public String Acciones { get; set; }
		public String UbicacionCertificado { get; set; }

	}
}
//2.139.183.118:9000\webservices
//metalcaucho

//13612