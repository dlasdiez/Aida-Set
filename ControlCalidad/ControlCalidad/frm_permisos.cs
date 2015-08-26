using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;
using MySql.Data.MySqlClient;

namespace ControlCalidad
{
  public partial class frm_permisos : frm_maestro
  {
    public frm_permisos()
    {
      InitializeComponent();
    }

    private void frm_permisos_Load(object sender, EventArgs e)
    {
      this.Text = "Permisos";

      FillPermisos();
    }

    private void FillPermisos()
    {
      this.dgv_permisos.Rows.Add("", Constantes.Modulo.EXPEDICIONES, "Expediciones");
      this.dgv_permisos.Rows.Add("", Constantes.Modulo.REGISTRO_QC_ENTRADA, "Registro Q.C. Entrada");
      this.dgv_permisos.Rows.Add("", Constantes.Modulo.REGISTRO_QC_ENTRADA_CALIDAD, "Registro Q.C. Entrada Calidad");
      this.dgv_permisos.Rows.Add("", Constantes.Modulo.REPORT_EVALUACION_MUESTRAS, "Report Evaluación de muestras");
      this.dgv_permisos.Rows.Add("", Constantes.Modulo.REPORT_EVALUACION_MUESTRAS_GARANTIA_STOCK, "Report Evaluación de muestras Garantía/Stock");
      this.dgv_permisos.Rows.Add("", Constantes.Modulo.REGISTRO_GARANTIA_TRAMITE_OT, "Registro en Garantías en tramite O.T.");
    }

    public override void Guardar()
    {
      StringBuilder _sb;

      _sb = new StringBuilder();

      _sb.AppendLine(" INSERT INTO   permiso_aplicacion");
      _sb.AppendLine("           (   ");
      _sb.AppendLine("                pa_modulo ");
      _sb.AppendLine("              , pa_user ");
      _sb.AppendLine("              , pa_modificacion ");
      _sb.AppendLine("              , pa_baja ");
      _sb.AppendLine("              , pa_lectura ");
      _sb.AppendLine("           )  ");
      _sb.AppendLine("      VALUES  ");
      _sb.AppendLine("           (  ");
      _sb.AppendLine("                @pModulo ");
      _sb.AppendLine("              , @pUser  ");
      _sb.AppendLine("              , @pModificacion  ");
      _sb.AppendLine("              , @pBaja  ");
      _sb.AppendLine("              , @pLectura  ");
      _sb.AppendLine("           )  ");
      _sb.AppendLine("ON DUPLICATE    KEY UPDATE   ");
      _sb.AppendLine("                pa_modulo = @pModulo   ");
      _sb.AppendLine("              , pa_user = @pUser   ");
      _sb.AppendLine("              , pa_modificacion = @pModificacion   ");
      _sb.AppendLine("              , pa_baja = @pBaja   ");
      _sb.AppendLine("              , pa_lectura = @pLectura   ");
      _sb.AppendLine("       WHERE    pa_id = @Id ");


      foreach (DataGridViewRow _dgvr in this.dgv_permisos.Rows)
      {
        List<MySqlParameter> _collection = new List<MySqlParameter>();
        _collection.Add(new MySqlParameter("@pId", _dgvr.Cells["id"].Value));
        _collection.Add(new MySqlParameter("@pModulo", _dgvr.Cells["id_modulo"].Value));
        _collection.Add(new MySqlParameter("@pUser", this.txt_usuario.Text));
        _collection.Add(new MySqlParameter("@pModificacion", _dgvr.Cells["modificar"].EditedFormattedValue));
        _collection.Add(new MySqlParameter("@pBaja", _dgvr.Cells["baja"].EditedFormattedValue));
        _collection.Add(new MySqlParameter("@pLectura", _dgvr.Cells["lectura"].EditedFormattedValue));

        this.m_connection.Insert(_sb.ToString(), _collection); 
      }
    }

    public override Boolean IsDataOk()
    {
      Boolean _error = false;

      if (String.IsNullOrEmpty(this.txt_usuario.Text))
      {
        _error = true;
        Error.SetError(this.txt_usuario, "El valor no puede estar vacio");
      }

      return !_error;
    }
  }
}
