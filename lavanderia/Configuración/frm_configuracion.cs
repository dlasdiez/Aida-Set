using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using lavanderia;
namespace Configuración
{
    public partial class frm_config : Form
    {
        public frm_config()
        {
            InitializeComponent();
        }

        private void frm_config_Load(object sender, EventArgs e)
        {
            this.lbl_runtime.Text = "Ruta RunTime";
            this.lbl_path_datos.Text = "Ruta Datos";
            this.lbl_path_webservices.Text = "Ruta WebServices";
            this.lbl_color.Text = "Color";
            this.lbl_terminal.Text = "Terminal";

            this.btn_guardar.Text = "Guardar";
            this.btn_seleccionar_color.Text = "Seleccionar";
            this.Text = "Configuración";

            if (!Config.ReadConfig())
            {
                Config.SaveConfig();
                MessageBox.Show("Se ha guardado el fichero de configuración por defecto", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

            this.txt_runtime.Text = Config.Runtime;
            this.txt_path_datos.Text = Config.PathDatos;
            this.txt_path_webservices.Text = Config.PathWebServices;
            this.txt_color.BackColor = ColorTranslator.FromHtml(Config.Color);
            this.txt_terminal.Text = Config.Terminal;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txt_runtime.Text) || String.IsNullOrEmpty(this.txt_path_datos.Text) || String.IsNullOrEmpty(this.txt_path_webservices.Text))
            {
                MessageBox.Show("Debe indicar todos los campos");

                return;
            }

            Config.SaveConfig(this.txt_runtime.Text, this.txt_path_datos.Text, this.txt_path_webservices.Text, ColorTranslator.ToHtml(this.txt_color.BackColor), this.txt_terminal.Text);

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