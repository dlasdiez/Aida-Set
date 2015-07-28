using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Configuracion;
using DAL;
using System.IO;
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
      this.lbl_servidor_bd.Text = "Servidor BD";
      this.lbl_database.Text = "Base de datos";
      this.lbl_puerto.Text = "Puerto";
      this.lbl_usuario_bd.Text = "Usuario";
      this.lbl_password_bd.Text = "Password";

      this.lbl_user_admin.Text = "Usuario Admin.";
      this.lbl_password_admin.Text = "Password Admin.";
      this.btn_crear_bd.Text = "Crear BD";

      this.lbl_runtime.Text = "Ruta RunTime";
      this.lbl_path_datos.Text = "Ruta Datos";
      this.lbl_path_webservices.Text = "WebServices";

      this.btn_guardar.Text = "Guardar";
      this.btn_test.Text = "Test";
      this.btn_seleccionar_color.Text = "Seleccionar";
      this.Text = "Configuración";

      if (!Config.ReadConfig())
      {

      }

      this.txt_color.BackColor = ColorTranslator.FromHtml(Config.ValueConfig.Color);
      this.txt_servidor_bd.Text = Config.ValueConfig.Servidor_BD;
      this.txt_database.Text = Config.ValueConfig.Database;
      this.txt_puerto_BD.Text = Config.ValueConfig.Puerto;
      this.txt_usuario_bd.Text = Config.ValueConfig.Usuario_BD;
      this.txt_password_bd.Text = Config.ValueConfig.Password_BD;
      this.txt_user_admin.Text = Config.ValueConfig.Usuario_Admin;
      this.txt_password_admin.Text = Config.ValueConfig.Password_Admin;

      this.txt_runtime.Text = Config.ValueConfig.Runtime;
      this.txt_path_datos.Text = Config.ValueConfig.PathDatos;
      this.txt_path_webservices.Text = Config.ValueConfig.PathWebServices;
    }

    private void btn_guardar_Click(object sender, EventArgs e)
    {
      ConfigValues _values = new ConfigValues();

      _values.Color = ColorTranslator.ToHtml(this.txt_color.BackColor);
      _values.Servidor_BD = this.txt_servidor_bd.Text;
      _values.Database = this.txt_database.Text;
      _values.Puerto = this.txt_puerto_BD.Text;
      _values.Usuario_BD = this.txt_usuario_bd.Text;
      _values.Password_BD = this.txt_password_bd.Text;
      _values.Usuario_Admin = this.txt_user_admin.Text;
      _values.Password_Admin = this.txt_password_admin.Text;
      _values.Runtime = this.txt_runtime.Text;
      _values.PathDatos = this.txt_path_datos.Text;
      _values.PathWebServices = this.txt_path_webservices.Text;


      Config.SaveConfig(ref _values);

      MessageBox.Show("Se ha guardado la configuración", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
      this.Close();

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

    private void btn_test_Click(object sender, EventArgs e)
    {
      String _msg = "";
      String _caption = "";
      MessageBoxIcon _icon;
      Boolean _connection_ok;

      _connection_ok = this.testConection(this.txt_servidor_bd.Text, this.txt_database.Text, this.txt_puerto_BD.Text, this.txt_usuario_bd.Text, this.txt_password_bd.Text, ref _msg);

      _icon = MessageBoxIcon.Error;
      _caption = "Error";
      if (_connection_ok)
      {
        _caption = "";
        _icon = MessageBoxIcon.Exclamation;
      }

      MessageBox.Show(_msg, _caption, MessageBoxButtons.OK, _icon);
    }

    private void btn_crear_bd_Click(object sender, EventArgs e)
    {
      String _msg = "";
      Boolean _connection_ok;

      _connection_ok = this.testConection(this.txt_servidor_bd.Text, "", this.txt_puerto_BD.Text, this.txt_usuario_bd.Text, this.txt_password_bd.Text, ref _msg);

      if (!_connection_ok)
      {
        MessageBox.Show(_msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }

      if (CreateDB(this.txt_servidor_bd.Text, "", this.txt_puerto_BD.Text, this.txt_user_admin.Text, this.txt_password_admin.Text))
      {
        MessageBox.Show("Base de datos creada correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      else
      {
        MessageBox.Show("Se ha producido un error al crear la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private Boolean testConection(String Server, String Database, String Port, String User, String Pwd, ref String Msg)
    {
      Msg = "";

      DBConnect _db = new DBConnect(Server, Database, Port, User, Pwd);

      try
      {
        if (_db.IsOpen())
        {
          _db.Close();

          Msg = "Conexión establecida con el servidor";
        }
      }
      catch (Exception ex)
      {
        Msg = ex.Message;

        return false;
      }

      return true;
    }

    private Boolean CreateDB(String Server, String Database, String Port, String User, String Pwd)
    {
      String _path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Scripts");
      String[] _files;
      String _command;

      DBConnect _db;


      if (Directory.Exists(_path))
      {

        _db = new DBConnect(Server, Database, Port, User, Pwd);
        _files = Directory.GetFiles(_path);

        foreach (String _file in _files) 
        {
          _command = File.ReadAllText(_file);

          _db.ExecuteCreateDataBaseCommand(_command);
        }

        _db.Close();
      }
      else
      {

        return false;
      }

      return true;
    }
  }
}