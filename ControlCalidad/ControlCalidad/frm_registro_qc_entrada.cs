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
  public partial class frm_registro_qc_entrada : frm_maestro
  {
    public frm_registro_qc_entrada()
    {
      InitializeComponent();
    }

    private void frm_registro_qc_entrada_Load(object sender, EventArgs e)
    {
      this.m_modulo = Constantes.Modulo.REGISTRO_QC_ENTRADA;
      this.Text = Constantes.REGISTRO_QC_ENTRADA;

      this.dtp_fecha_revision.Value = DateTime.Now;
      this.dtp_fecha_calidad.Value = DateTime.Now;

    }
  }
}
