using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlCalidad
{
  public partial class frm_permisos_list : Form
  {
    public frm_permisos_list()
    {
      InitializeComponent();
    }

    private void frm_permisos_list_Load(object sender, EventArgs e)
    {
      this.Text = "Listado de permisos";

      this.dgv_permisos.Columns.Add("usuario", "Usuario");
      this.dgv_permisos.Columns["usuario"].ReadOnly = true;

      this.FillGrid();
    }

    private void FillGrid()
    {
      DataTable _permisos;
      cls_permisos _perm = new cls_permisos();

      _permisos = _perm.GetUserPermisos();

      foreach (DataRow _dr in _permisos.Rows)
      {
        this.dgv_permisos.Rows.Add(_dr["pa_user"]);
      }
    }

    private void btn_new_Click(object sender, EventArgs e)
    {
      frm_permisos_edit _frm = new frm_permisos_edit();
      _frm.ShowDialog();

      this.dgv_permisos.Rows.Clear();
      this.FillGrid();
    }

    private void dgv_permisos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      String _usuario = "";
      if (e.ColumnIndex == -1 && e.RowIndex == -1)
      {

        return;
      }

      _usuario = (String)this.dgv_permisos.Rows[e.RowIndex].Cells["usuario"].Value;

      frm_permisos_edit _frm = new frm_permisos_edit(_usuario);
      _frm.ShowDialog();
    }
  }
}
