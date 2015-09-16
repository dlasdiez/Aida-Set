using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OBJ
{
  public class ObjExpediente
  {
    public long Id { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }
    public DateTime FechaExpedicion { get; set; }
    public long UsuarioId { get; set; }
    public String UsuarioNombre { get; set; }
    public String CodArticulo { get; set; }
    public String ArticuloNombre { get; set; }
    public String ClienteId { get; set; }
    public String ClienteNombre { get; set; }
    public String ClienteEmail { get; set; }
    public String CliReferencia { get; set; }
    public long RefMetalcaucho { get; set; }
    public String Observaciones { get; set; }
    public bool CliSdc { get; set; }
    public bool CliDc { get; set; }
    public String MotivoDenegacion { get; set; }
    public String Notas { get; set; }
    public List<ObjExpedienteLinea> Lineas { get; set; }
  }

  public class ObjExpedienteLinea
  {
    public long Id { get; set; }
    public long IdExpediente { get; set; }
    public DateTime FechaCreacion { get; set; }
    public DateTime FechaModificacion { get; set; }
    public long UsuarioCreacion { get; set; }
    public String IdProveedor { get; set; }
    public String ProveedorNombre { get; set; }
    public String ProveedorReferencia { get; set; }
    public String NumLote { get; set; }
    public Int32 Unidades { get; set; }
  }
}
