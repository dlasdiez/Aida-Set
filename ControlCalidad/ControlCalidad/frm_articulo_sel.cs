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
  public partial class frm_articulo_sel : frm_maestro_list
  {
    public String CodArticulo;
    public String NombreArticulo;

    public frm_articulo_sel()
    {
      InitializeComponent();
    }

    public override void InitForm()
    {
      this.Text = "Listado de Articulos";
      this.btn_new.Visible = false;
    }

    public override void CreateColumns()
    {
      this.dgv_list.Columns.Add("cod_articulo", "Cod. Articulo");
      this.dgv_list.Columns.Add("nombre", "Nombre");
      this.dgv_list.Columns["nombre"].Width = 200;
    }

    public override void FillGrid()
    {
      DataTable _articulos;

      List<String> _parametros = new List<String>();

      _parametros.Add("0");
      _parametros.Add("ZZZZZZZZZZZZZZZZZZZZZZ");
      _parametros.Add("0");
      _parametros.Add("ZZZZZZZZZZZZZZZZZZZZZZ");
      _parametros.Add("0");
      _parametros.Add("ZZZZZZZZZZZZZZZZZZZZZZ");
      _parametros.Add("0");
      _parametros.Add("ZZZZZZZZZZZZZZZZZZZZZZ");
      _parametros.Add("0");
      _parametros.Add("ZZZZZZZZZZZZZZZZZZZZZZ");

      _articulos = Cobol_Converter.GetArticulo(_parametros);

      foreach (DataRow _dr in _articulos.Rows)
      {
        this.dgv_list.Rows.Add(_dr[2], _dr[3]);
      }
    }

    public override void CellDobleClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.ColumnIndex == -1 && e.RowIndex == -1)
      {

        return;
      }

      this.CodArticulo = this.dgv_list.Rows[e.RowIndex].Cells["cod_articulo"].Value.ToString();
      this.NombreArticulo = this.dgv_list.Rows[e.RowIndex].Cells["nombre"].Value.ToString();

      this.Close();
    }
  }
}
