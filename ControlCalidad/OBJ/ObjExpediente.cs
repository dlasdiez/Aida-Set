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
    public string UsuarioNombre { get; set; }
    public long ClienteId { get; set; }
    public string ClienteNombre { get; set; }
    public string ClienteEmail { get; set; }
    public string CliReferencia { get; set; }
    public long RefMetalcaucho { get; set; }
    public string Observaciones { get; set; }
    public bool CliSdc { get; set; }
    public bool CliDc { get; set; }
    public string MotivoDenegacion { get; set; }
  }
}
