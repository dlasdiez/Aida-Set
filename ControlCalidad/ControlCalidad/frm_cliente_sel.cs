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
  public partial class frm_cliente_sel : frm_maestro_list
  {
    public String Codigo;
    public String Nombre;
    public String Referencia;
    public String Email;

    public frm_cliente_sel()
    {
      InitializeComponent();
    }

    public override void InitForm()
    {
      this.Text = "Listado de Clientes";
      this.btn_new.Visible = false;
    }

    public override void CreateColumns()
    {
      this.dgv_list.Columns.Add("cod_cliente", "Cod. Cliente");
      this.dgv_list.Columns["cod_cliente"].Width = 150;
      this.dgv_list.Columns.Add("nombre", "Nombre");
      this.dgv_list.Columns["nombre"].Width = 200;

      this.dgv_list.Columns.Add("referencia", "Referencia");
      this.dgv_list.Columns["referencia"].Visible = false;

      this.dgv_list.Columns.Add("email", "Email");
      this.dgv_list.Columns["email"].Visible = false;

    }

    public override void FillGrid()
    {
      DataTable _clientes;

      List<String> _parametros = new List<String>();

      _parametros.Add("430000000");
      _parametros.Add("439999999");

      _clientes = Cobol_Converter.GetClientes(_parametros);

      foreach (DataRow _dr in _clientes.Rows)
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

      this.Codigo = this.dgv_list.Rows[e.RowIndex].Cells["cod_cliente"].Value.ToString();
      this.Nombre = this.dgv_list.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
      this.Referencia = this.dgv_list.Rows[e.RowIndex].Cells["referencia"].Value.ToString();
      this.Email = this.dgv_list.Rows[e.RowIndex].Cells["email"].Value.ToString();

      this.Close();
    }
  }
}
