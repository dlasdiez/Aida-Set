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
  public partial class frm_permisos_edit : frm_maestro_edit
  {
    String m_usuario;
    Boolean m_new_user = true;

    public frm_permisos_edit(String Usuario)
    {
      if (!String.IsNullOrEmpty(Usuario))
      {
        this.m_usuario = Usuario;
        this.m_new_user = false;
      }

      InitializeComponent();
    }

    public frm_permisos_edit()
    {
      InitializeComponent();
    }

    private void frm_permisos_Load(object sender, EventArgs e)
    {
      this.Text = "Permisos";

      FillPermisos();
    }

    private void AddRow(Constantes.Modulo Modulo, String TextoModulo)
    {
      Int32 _modulo;
      Boolean _lectura;
      Boolean _escritura;
      Boolean _borrar;
      ControlCalidad.cls_permisos.PermisosModulo _permisos;

      cls_permisos _cls_permisos = new cls_permisos();
      _permisos = _cls_permisos.GetPermisos(this.m_usuario);

      _modulo = (Int32)Modulo;
      _lectura = _permisos.Modulos[_modulo].Lectura;
      _escritura = _permisos.Modulos[_modulo].Escritura;
      _borrar = _permisos.Modulos[_modulo].Borrar;

      this.dgv_permisos.Rows.Add(_permisos.Modulos[_modulo].Id, _modulo, TextoModulo, _lectura, _borrar, _escritura);

    }

    private void FillPermisos()
    {

      if (!this.m_new_user)
      {
        this.txt_usuario.Text = this.m_usuario;

        this.AddRow(Constantes.Modulo.EXPEDIENTES, Constantes.EXPEDIENTES);
        this.AddRow(Constantes.Modulo.REGISTRO_QC_ENTRADA, Constantes.REGISTRO_QC_ENTRADA);
        this.AddRow(Constantes.Modulo.REPORT_EVALUACION_PIEZAS_GARANTIA, Constantes.REPORT_EVALUACION_PIEZAS_GARANTIA);
        this.AddRow(Constantes.Modulo.REPORT_EVALUACION_MUESTRAS, Constantes.REPORTE_EVALUACION_MUESTRAS);
        this.AddRow(Constantes.Modulo.REPORT_EVALUACION_MUESTRAS_GARANTIA_STOCK, Constantes.REPORT_EVALUACION_MUESTRAS_GARANTIA_STOCK);
        this.AddRow(Constantes.Modulo.REGISTRO_GARANTIA_TRAMITE_OT, Constantes.REGISTRO_GARANTIA_TRAMITE_OT);
      }
      else
      {
        this.dgv_permisos.Rows.Add("", Constantes.Modulo.EXPEDIENTES, Constantes.EXPEDIENTES);
        this.dgv_permisos.Rows.Add("", Constantes.Modulo.REGISTRO_QC_ENTRADA, Constantes.REGISTRO_QC_ENTRADA);
        this.dgv_permisos.Rows.Add("", Constantes.Modulo.REPORT_EVALUACION_PIEZAS_GARANTIA, Constantes.REPORT_EVALUACION_PIEZAS_GARANTIA);
        this.dgv_permisos.Rows.Add("", Constantes.Modulo.REPORT_EVALUACION_MUESTRAS, Constantes.REPORTE_EVALUACION_MUESTRAS);
        this.dgv_permisos.Rows.Add("", Constantes.Modulo.REPORT_EVALUACION_MUESTRAS_GARANTIA_STOCK, Constantes.REPORT_EVALUACION_MUESTRAS_GARANTIA_STOCK);
        this.dgv_permisos.Rows.Add("", Constantes.Modulo.REGISTRO_GARANTIA_TRAMITE_OT, Constantes.REGISTRO_GARANTIA_TRAMITE_OT);
      }
    }

    public override void Guardar()
    {
      StringBuilder _sb;

      _sb = new StringBuilder();

      if (this.m_new_user)
      {
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
      }
      else
      {
        _sb.AppendLine(" UPDATE     permiso_aplicacion");
        _sb.AppendLine("    SET     pa_modulo = @pModulo ");
        _sb.AppendLine("          , pa_user = @pUser   ");
        _sb.AppendLine("          , pa_modificacion = @pModificacion   ");
        _sb.AppendLine("          , pa_baja = @pBaja   ");
        _sb.AppendLine("          , pa_lectura = @pLectura ");
        _sb.AppendLine("  WHERE     pa_id = @pId ");
      }

      foreach (DataGridViewRow _dgvr in this.dgv_permisos.Rows)
      {
        List<MySqlParameter> _collection = new List<MySqlParameter>();
        if (!this.m_new_user)
        {
          _collection.Add(new MySqlParameter("@pId", _dgvr.Cells["id"].Value));
        }
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
