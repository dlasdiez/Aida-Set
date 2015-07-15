using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Configuracion;
namespace ControlCalidad
{
  public partial class frm_configuracion : Form
  {
    public frm_configuracion()
    {
      InitializeComponent();
    }

    private void frm_configuracion_Load(object sender, EventArgs e)
    {
      this.lbl_color.Text = "Color";

      this.btn_guardar.Text = "Guardar";
      this.btn_seleccionar_color.Text = "Seleccionar";
      this.Text = "Configuración";

      if (!Config.ReadConfig())
      {
        
      }

      this.txt_color.BackColor = ColorTranslator.FromHtml(Config.ValueConfig.Color);
    }

    private void btn_guardar_Click(object sender, EventArgs e)
    {
      ConfigValues _values = new ConfigValues();

      _values.Color = ColorTranslator.ToHtml(this.txt_color.BackColor);
      Config.SaveConfig(ref _values);

      if (MessageBox.Show("Se ha guardado la configuración, ¿Desea salir?", "Cerrar aplicación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
      {
        this.Close();
      }
    }

    private void btn_seleccionar_color_Click(object sender, EventArgs e)
    {
      DialogResult result = colorDialog1.ShowDialog();

      if (result == DialogResult.OK)
      {
        // Set form background to the selected color.
        this.txt_color.BackColor = colorDialog1.Color;
      }
    }
  }
}