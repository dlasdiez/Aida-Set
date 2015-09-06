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
  public partial class frm_expediente : frm_maestro
  {
    public frm_expediente()
    {
      InitializeComponent();
    }

    public virtual void frm_expediente_Load(object sender, EventArgs e)
    {
      this.m_modulo = Constantes.Modulo.EXPEDIENTES;

      this.dtp_fecha_creacion.Value = DateTime.Now;
      this.dtp_fecha_expedicion.Value = DateTime.Now;

      this.Text = Constantes.EXPEDIENTES;
    }
  }
}
