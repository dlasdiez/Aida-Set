using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace ControlCalidad
{
  public partial class frm_expedientes_sel : frm_maestro_list
  {
    public frm_expedientes_sel()
    {
      InitializeComponent();
    }

    public override void InitForm()
    {
      this.Text = "Listado de Expedientes";
    }

    public override void CreateColumns()
    {
      this.dgv_list.Columns.Add("id_expediente", "Expediente");
    }

    public override void FillGrid()
    {
      DataTable _expedientes;

      DalExpediente _dExpediente = new DalExpediente(this.m_connection);

      if (_dExpediente.Select(out _expedientes))
      {
        foreach (DataRow _dr in _expedientes.Rows)
        {
          this.dgv_list.Rows.Add(_dr["Id"]);
        }
      }
    }

    public override void CellDobleClick(object sender, DataGridViewCellEventArgs e)
    {
      Int64 _id_expediente;

      if (e.ColumnIndex == -1 && e.RowIndex == -1)
      {

        return;
      }

      _id_expediente = (Int64)this.dgv_list.Rows[e.RowIndex].Cells["id_expediente"].Value;

      frm_expediente_edit _frm = new frm_expediente_edit(_id_expediente);
      _frm.ShowDialog();
    }

    public override void NuevoRegistro()
    {
      frm_expediente_edit _frm = new frm_expediente_edit();
      _frm.ShowDialog();

      this.dgv_list.Rows.Clear();
      this.FillGrid();
    }
  }
}
