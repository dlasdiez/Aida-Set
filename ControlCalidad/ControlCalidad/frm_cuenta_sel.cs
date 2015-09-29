using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CobolConverter;

namespace ControlCalidad
{
  public partial class frm_cuenta_sel : frm_maestro_list
  {
    public String Codigo;
    public String Nombre;
    public String Referencia;
    public String Email;

    private Enumerados.CUENTA m_tipo_cuenta;

    public frm_cuenta_sel(Enumerados.CUENTA TipoCuenta)
    {
      InitializeComponent();

      m_tipo_cuenta = TipoCuenta;
    }

    public override void InitForm()
    {
      switch (m_tipo_cuenta)
      {
        case Enumerados.CUENTA.CLIENTE:
          this.Text = "Listado de Clientes";
          break;

        case Enumerados.CUENTA.PROVEEDOR:
          this.Text = "Listado de Proveedores";
          break;
      }

      this.btn_new.Visible = false;
    }

    public override void CreateColumns()
    {
      switch (m_tipo_cuenta)
      {
        case Enumerados.CUENTA.CLIENTE:
          this.dgv_list.Columns.Add("cod_cliente", "Cod. Cliente");
          this.dgv_list.Columns["cod_cliente"].Width = 150;

          this.dgv_list.Columns.Add("nombre", "Nombre");
          this.dgv_list.Columns["nombre"].Width = 200;

          this.dgv_list.Columns.Add("referencia", "Referencia");
          this.dgv_list.Columns["referencia"].Visible = false;

          this.dgv_list.Columns.Add("email", "Email");
          this.dgv_list.Columns["email"].Visible = false;
          break;

        case Enumerados.CUENTA.PROVEEDOR:
          this.dgv_list.Columns.Add("cod_proveedor", "Cod. Proveedor");
          this.dgv_list.Columns["cod_proveedor"].Width = 150;

          this.dgv_list.Columns.Add("nombre", "Nombre");
          this.dgv_list.Columns["nombre"].Width = 200;
          break;
      }
    }

    public override void FillGrid()
    {
      DataTable _cuentas;

      List<String> _parametros = new List<String>();

      switch (m_tipo_cuenta)
      {
        case Enumerados.CUENTA.CLIENTE:
          _parametros.Add("430000000");
          _parametros.Add("439999999");
          break;

        case Enumerados.CUENTA.PROVEEDOR:
          _parametros.Add("400000000");
          _parametros.Add("409999999");
          break;
      }

      _cuentas = Cobol_Converter.GetCuentas(_parametros);

      foreach (DataRow _dr in _cuentas.Rows)
      {
        this.dgv_list.Rows.Add(_dr[0], _dr[1], _dr[3], _dr[11]);
      }
    }

    public override void CellDobleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == -1 && e.RowIndex == -1)
      {

        return;
      }

      switch (m_tipo_cuenta)
      {
        case Enumerados.CUENTA.CLIENTE:
          this.Codigo = this.dgv_list.Rows[e.RowIndex].Cells["cod_cliente"].Value.ToString();
          this.Nombre = this.dgv_list.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
          this.Referencia = this.dgv_list.Rows[e.RowIndex].Cells["referencia"].Value.ToString();
          this.Email = this.dgv_list.Rows[e.RowIndex].Cells["email"].Value.ToString();
          break;

        case Enumerados.CUENTA.PROVEEDOR:
          this.Codigo = this.dgv_list.Rows[e.RowIndex].Cells["cod_proveedor"].Value.ToString();
          this.Nombre = this.dgv_list.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
          break;
      }

      this.Close();
    }
  }
}
