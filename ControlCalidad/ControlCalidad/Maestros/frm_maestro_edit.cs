using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;
using MySql.Data.MySqlClient;

namespace ControlCalidad
{
  public partial class frm_maestro_edit : Form
  {
    public DBConnect m_connection;
    public ControlCalidad.Constantes.Modulo m_modulo;

    public frm_maestro_edit()
    {
      InitializeComponent();
      this.pb_logo.Image = null;
    }

    public void frm_maestro_edit_Load(object sender, EventArgs e)
    {
      Color _color;

      if (Configuracion.Config.ValueConfig == null)
      {
        Configuracion.Config.ValueConfig = new Configuracion.ConfigValues();
      }

      _color = ColorTranslator.FromHtml(Configuracion.Config.ValueConfig.Color);

      this.BackColor = _color;
      //Cargamos Color
      foreach (Control _controls in this.Controls)
      {
        foreach (Control _ctr in _controls.Controls)
        {
          if (_ctr.GetType() != typeof(Button) && _ctr.GetType() != typeof(TextBox) && _ctr.GetType() != typeof(PictureBox) &&
             _ctr.GetType() != typeof(ComboBox))
          {
            _ctr.BackColor = _color;
          }
        }
      }

      //Cargamos logo
      if (!String.IsNullOrEmpty(Configuracion.Config.ValueConfig.PathLogo))
      {
        this.pb_logo.Image = Image.FromFile(Configuracion.Config.ValueConfig.PathLogo);
      }
    }

    private void btn_guardar_Click(object sender, EventArgs e)
    {
      if (this.IsDataOk())
      {
        this.m_connection = new DBConnect(Configuracion.Config.ValueConfig.Servidor_BD, Configuracion.Config.ValueConfig.Database, Configuracion.Config.ValueConfig.Puerto, Configuracion.Config.ValueConfig.Usuario_BD, Configuracion.Config.ValueConfig.Password_BD);
        this.Guardar();
        this.Close();

        return;
      }

      MessageBox.Show("Hay errores en los datos insertados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    private void btn_salir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    public virtual void Guardar()
    {
      
    }

    public virtual Boolean IsDataOk()
    {
      return true;
    }
  }
}
