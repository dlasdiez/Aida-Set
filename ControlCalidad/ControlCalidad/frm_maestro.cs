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
  public partial class frm_maestro : Form
  {
    public frm_maestro()
    {
      InitializeComponent();
    }

    public void frm_maestro_Load(object sender, EventArgs e)
    {
      Color _color;

      if (Configuracion.Config.ValueConfig == null)
      {
        Configuracion.Config.ValueConfig = new Configuracion.ConfigValues();
      }

      _color = ColorTranslator.FromHtml(Configuracion.Config.ValueConfig.Color);

      this.BackColor = _color;
      foreach (Control _controls in this.Controls)
      {
        foreach (Control _ctr in _controls.Controls)
        {
          if (_ctr.GetType() != typeof(Button) && _ctr.GetType() != typeof(TextBox) && _ctr.GetType() != typeof(PictureBox))
          {
            _ctr.BackColor = _color;
          }
        }
      }
    }

    public virtual void btn_guardar_Click(object sender, EventArgs e)
    {

    }

    public virtual void btn_salir_Click(object sender, EventArgs e)
    {

    }
  }
}
