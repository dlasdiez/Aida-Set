using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DAL;
using OBJ;

namespace ControlCalidad
{
  public partial class frm_expediente : frm_maestro_edit
  {
    public frm_expediente()
    {
      InitializeComponent();
    }

    public virtual void frm_expediente_Load(object sender, EventArgs e)
    {
      this.m_modulo = Constantes.Modulo.EXPEDIENTES;

      this.dtp_fecha_creacion.Value = DateTime.Now;
      this.dtp_fecha_expedicion.Value = DateTime.Now;

      this.Text = Constantes.EXPEDIENTES;
    }

    #region Overrides
    public override void Guardar()
    {
      ObjExpediente _expediente = new ObjExpediente();
      DalExpediente _dExpediente = new DalExpediente(this.m_connection);
      Int64 _value;

      Int64.TryParse(this.txt_num_registro.Text, out _value);
      _value = _expediente.Id;
      _expediente.FechaExpedicion = this.dtp_fecha_expedicion.Value;
      //_expediente.UsuarioId = this.txt_usuario.Text;
      _expediente.UsuarioNombre = this.txt_usuario.Text;
      //_expediente.ClienteId = this.txt_cli_nombre.Text;
      _expediente.ClienteNombre = this.txt_cli_nombre.Text;
      _expediente.ClienteEmail = this.txt_cli_email.Text;
      _expediente.CliReferencia = this.txt_cli_referencia.Text;

      Int64.TryParse(this.txt_ref_metalcaucho.Text, out _value);
      _expediente.RefMetalcaucho = _value;

      _expediente.Observaciones = this.txt_observaciones.Text;
      _expediente.CliSdc = this.ch_cli_SDC.Checked;
      _expediente.CliDc = this.ch_cli_DC.Checked;
      _expediente.MotivoDenegacion = this.txt_motivo_denegacion.Text;

      if (this.m_new_value)
      {
        _dExpediente.Insert(_expediente);
      }
      else
      {
        _dExpediente.Update(_expediente);
      }
    }
    #endregion
  }
}
