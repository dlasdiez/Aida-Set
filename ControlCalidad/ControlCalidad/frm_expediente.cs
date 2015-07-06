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
  public partial class frm_expediente : Form
  {
    public frm_expediente()
    {
      InitializeComponent();
    }

    private void frm_expediente_Load(object sender, EventArgs e)
    {
      this.dtp_fecha_expedicion.Value = DateTime.Now;
      this.dtp_fecha_calidad.Value = DateTime.Now;
    }
  }
}
