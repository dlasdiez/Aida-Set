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
  public partial class frm_evaluacion_piezas : frm_maestro
  {
    public frm_evaluacion_piezas()
    {
      InitializeComponent();
    }

    private void frm_evaluacion_piezas_Load(object sender, EventArgs e)
    {
      this.m_modulo = Constantes.Modulo.REPORT_EVALUACION_PIEZAS_GARANTIA;
      this.Text = "Report evaluación piezas en garantia";
    }
  }
}
