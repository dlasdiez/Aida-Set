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
  public partial class frm_evaluacion_muestras_report : frm_maestro
  {
    public frm_evaluacion_muestras_report()
    {
      InitializeComponent();
    }

    private void frm_evaluacion_muestras_report_Load(object sender, EventArgs e)
    {
      this.Text = "Report evaluación de muestras";
    }
  }
}
