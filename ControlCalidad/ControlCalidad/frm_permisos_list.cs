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
  public partial class frm_permisos_list : frm_maestro_list
  {

    #region Public
    public frm_permisos_list()
    {
      InitializeComponent();
    }
    #endregion

    #region Overrides
    
    public override void InitForm()
    {
      this.Text = "Listado de permisos";
    }

    public override void CreateColumns()
    {
      this.dgv_list.Columns.Add("usuario", "Usuario");
      this.dgv_list.Columns["usuario"].ReadOnly = true;
    }

    public override void FillGrid()
    {
      DataTable _permisos;
      cls_permisos _perm = new cls_permisos();

      _permisos = _perm.GetUserPermisos();

      foreach (DataRow _dr in _permisos.Rows)
      {
        this.dgv_list.Rows.Add(_dr["pa_user"]);
      }
    }

    public override void CellDobleClick(object sender, DataGridViewCellEventArgs e)
    {
      String _usuario = "";
      if (e.ColumnIndex == -1 && e.RowIndex == -1)
      {

        return;
      }

      _usuario = (String)this.dgv_list.Rows[e.RowIndex].Cells["usuario"].Value;

      frm_permisos_edit _frm = new frm_permisos_edit(_usuario);
      _frm.ShowDialog();
    }

    public override void NuevoRegistro()
    {
      frm_permisos_edit _frm = new frm_permisos_edit();
      _frm.ShowDialog();

      this.dgv_list.Rows.Clear();
      this.FillGrid();
    }
    #endregion
  }
}
