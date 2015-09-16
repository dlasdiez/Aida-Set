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
  public partial class frm_expediente_edit : frm_maestro_edit
  {

    #region Constantes
    private String COLUMN_PROVEEDOR_ID = "0";
    private String COLUMN_PROVEEDOR_NOMBRE = "1";
    private String COLUMN_REFERENCIA_PROVEEDOR = "2";
    private String COLUMN_NUM_LOTE = "3";
    private String COLUMN_UNIDADES = "4";

    #endregion

    Int64 m_expediente;

    public frm_expediente_edit(Int64 Expediente)
    {
      this.m_expediente = Expediente;
      this.m_new_value = false;

      InitializeComponent();
    }

    public frm_expediente_edit()
    {
      InitializeComponent();
    }

    #region Overrides

    public override void Init()
    {
      this.m_modulo = Constantes.Modulo.EXPEDIENTES;

      this.dtp_fecha_creacion.Value = DateTime.Now;
      this.dtp_fecha_expedicion.Value = DateTime.Now;
      this.dtp_fecha_modificacion.Value = DateTime.Now;

      this.CreareColumns();

      this.Text = Constantes.EXPEDIENTES;

      if (!this.m_new_value)
      {
        ObjExpediente _expediente = new ObjExpediente();
        DalExpediente _dExpediente = new DalExpediente(this.m_connection);

        _dExpediente.Select(this.m_expediente, out _expediente);

        this.txt_cod_articulo.Text = _expediente.CodArticulo.ToString();
        this.txt_nombre_articulo.Text = _expediente.ArticuloNombre;
        this.txt_num_registro.Text = _expediente.Id.ToString();
        this.txt_usuario_id.Text = _expediente.UsuarioId.ToString();
        this.txt_usuario.Text = _expediente.UsuarioNombre;
        this.txt_cliente_id.Text = _expediente.ClienteId.ToString();
        this.txt_cli_nombre.Text = _expediente.ClienteNombre;
        this.txt_cli_email.Text = _expediente.ClienteEmail;
        this.txt_cli_referencia.Text = _expediente.CliReferencia;
        this.txt_ref_metalcaucho.Text = _expediente.RefMetalcaucho.ToString();
        this.txt_observaciones.Text = _expediente.Observaciones;
        this.ch_cli_SDC.Checked = _expediente.CliSdc;
        this.ch_cli_DC.Checked = _expediente.CliDc;
        this.txt_motivo_denegacion.Text = _expediente.MotivoDenegacion;
        this.dtp_fecha_creacion.Value = _expediente.FechaCreacion;
        this.dtp_fecha_expedicion.Value = _expediente.FechaExpedicion;
        this.dtp_fecha_modificacion.Value = _expediente.FechaModificacion;
        this.txt_notas.Text = _expediente.Notas;

        this.FillGrid(_expediente.Lineas);
      }
    }

    public override void Guardar()
    {
      ObjExpediente _expediente = new ObjExpediente();
      DalExpediente _dExpediente = new DalExpediente(this.m_connection);
      ObjExpedienteLinea _linea;

      Int64 _value;
      Int32 _unidades;

      Int64.TryParse(this.txt_num_registro.Text, out _value);
      _expediente.Id = _value;
      _expediente.FechaExpedicion = this.dtp_fecha_expedicion.Value;

      _expediente.CodArticulo = this.txt_cod_articulo.Text;
      _expediente.ArticuloNombre = this.txt_nombre_articulo.Text;

      Int64.TryParse(this.txt_usuario_id.Text, out _value);
      _expediente.UsuarioId = _value;
      _expediente.UsuarioNombre = this.txt_usuario.Text;

      _expediente.ClienteId = this.txt_cliente_id.Text;

      _expediente.ClienteNombre = this.txt_cli_nombre.Text;
      _expediente.ClienteEmail = this.txt_cli_email.Text;
      _expediente.CliReferencia = this.txt_cli_referencia.Text;

      Int64.TryParse(this.txt_ref_metalcaucho.Text, out _value);
      _expediente.RefMetalcaucho = _value;

      _expediente.Observaciones = this.txt_observaciones.Text;
      _expediente.CliSdc = this.ch_cli_SDC.Checked;
      _expediente.CliDc = this.ch_cli_DC.Checked;
      _expediente.MotivoDenegacion = this.txt_motivo_denegacion.Text;
      _expediente.Notas = this.txt_notas.Text;

      _expediente.Lineas = new List<ObjExpedienteLinea>();
      foreach (DataGridViewRow _dr in this.dgv_verificacion.Rows)
      {
        _linea = new ObjExpedienteLinea();

        _linea.IdProveedor = (String)_dr.Cells[COLUMN_PROVEEDOR_ID].Value;
        _linea.ProveedorNombre = (String)_dr.Cells[COLUMN_PROVEEDOR_NOMBRE].Value;
        _linea.ProveedorReferencia = (String)_dr.Cells[COLUMN_REFERENCIA_PROVEEDOR].Value;
        _linea.NumLote = (String)_dr.Cells[COLUMN_NUM_LOTE].Value;

        Int32.TryParse(_dr.Cells[COLUMN_UNIDADES].Value.ToString(), out _unidades);
        _linea.Unidades = _unidades;

        _expediente.Lineas.Add(_linea);
      }

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

    private void CreareColumns()
    {
      this.dgv_verificacion.Columns.Add(COLUMN_PROVEEDOR_ID, "Proveedor");
      this.dgv_verificacion.Columns[COLUMN_PROVEEDOR_ID].Width = 100;

      this.dgv_verificacion.Columns.Add(COLUMN_PROVEEDOR_NOMBRE, "Nombre");
      this.dgv_verificacion.Columns[COLUMN_PROVEEDOR_NOMBRE].Width = 100;

      this.dgv_verificacion.Columns.Add(COLUMN_REFERENCIA_PROVEEDOR, "Referencia");
      this.dgv_verificacion.Columns[COLUMN_REFERENCIA_PROVEEDOR].Width = 100;

      this.dgv_verificacion.Columns.Add(COLUMN_NUM_LOTE, "Lote");
      this.dgv_verificacion.Columns[COLUMN_NUM_LOTE].Width = 100;

      this.dgv_verificacion.Columns.Add(COLUMN_UNIDADES, "Unidades");
      this.dgv_verificacion.Columns[COLUMN_UNIDADES].Width = 100;

    }

    private void btn_añadir_verificacion_Click(object sender, EventArgs e)
    {
      Boolean _error = false;
      Int32 _value = 0;

      Error.Clear();

      if (String.IsNullOrEmpty(this.txt_proveedor_id.Text))
      {
        _error = true;
        Error.SetError(this.txt_proveedor_id, "El campo no puede estar en blanco");
      }
      if (String.IsNullOrEmpty(this.txt_num_lote.Text))
      {
        _error = true;
        Error.SetError(this.txt_num_lote, "El campo no puede estar en blanco");
      }

      if (String.IsNullOrEmpty(this.txt_unidades.Text) || !Int32.TryParse(this.txt_unidades.Text, out _value))
      {
        _error = true;
        Error.SetError(this.txt_unidades, "El campo no puede estar en blanco");
      }

      if (!_error)
      {
        this.dgv_verificacion.Rows.Add(this.txt_proveedor_id.Text, this.txt_nombre_proveedor.Text, "", this.txt_num_lote.Text, this.txt_unidades.Text);

        this.txt_proveedor_id.Text = "";
        this.txt_nombre_proveedor.Text = "";
        this.txt_num_lote.Text = "";
        this.txt_unidades.Text = "";
      }

    }

    private void dgv_verificacion_SelectionChanged(object sender, EventArgs e)
    {
      if (this.dgv_verificacion.SelectedRows.Count > 0)
      {
        this.txt_proveedor_id.Text = (String)this.dgv_verificacion.SelectedRows[0].Cells[COLUMN_PROVEEDOR_ID].Value;
        this.txt_nombre_proveedor.Text = (String)this.dgv_verificacion.SelectedRows[0].Cells[COLUMN_PROVEEDOR_NOMBRE].Value;
        this.txt_num_lote.Text = (String)this.dgv_verificacion.SelectedRows[0].Cells[COLUMN_NUM_LOTE].Value;
        this.txt_unidades.Text = (String)this.dgv_verificacion.SelectedRows[0].Cells[COLUMN_UNIDADES].Value;
      }
    }

    private void FillGrid(List<ObjExpedienteLinea> ExpedienteLineas)
    {
      Int32 _index = 0;

      foreach (ObjExpedienteLinea _linea in ExpedienteLineas)
      {
        this.dgv_verificacion.Rows.Add();

        this.dgv_verificacion.Rows[_index].Cells[COLUMN_PROVEEDOR_ID].Value = _linea.IdProveedor;
        this.dgv_verificacion.Rows[_index].Cells[COLUMN_PROVEEDOR_NOMBRE].Value = _linea.ProveedorNombre;
        this.dgv_verificacion.Rows[_index].Cells[COLUMN_REFERENCIA_PROVEEDOR].Value = _linea.ProveedorReferencia;
        this.dgv_verificacion.Rows[_index].Cells[COLUMN_NUM_LOTE].Value = _linea.NumLote;
        this.dgv_verificacion.Rows[_index].Cells[COLUMN_UNIDADES].Value = _linea.Unidades;

        _index++;
      }
    }
  }
}
