using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;

namespace ControlCalidad
{
  public partial class frm_maestro_list : Form
  {
    #region Miembros
    public DBConnect m_connection;
    #endregion

    #region Public
    
    public frm_maestro_list()
    {
      InitializeComponent();
      this.pb_logo.Image = null;
    }

    #endregion

    #region Private
    private void frm_maestro_list_Load(object sender, EventArgs e)
    {
      Color _color;

      if (Configuracion.Config.ValueConfig == null)
      {
        Configuracion.Config.ValueConfig = new Configuracion.ConfigValues();
      }

      _color = ColorTranslator.FromHtml(Configuracion.Config.ValueConfig.Color);

      m_connection = new DBConnect(Configuracion.Config.ValueConfig.Servidor_BD, Configuracion.Config.ValueConfig.Database, Configuracion.Config.ValueConfig.Puerto, Configuracion.Config.ValueConfig.Usuario_BD, Configuracion.Config.ValueConfig.Password_BD);

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

      this.InitForm();

      this.CreateColumns();

      this.FillGrid();
    }

    #endregion

    #region Virtual
    
    public virtual void InitForm()
    {
      
    }

    public virtual void FillGrid()
    {

    }

    public virtual void CreateColumns()
    {

    }

    public virtual void CellDobleClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    public virtual void NuevoRegistro()
    {
      
    }
    #endregion

    #region Eventos
    private void btn_salir_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void dgv_list_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
      this.CellDobleClick(sender, e);
    }

    private void btn_new_Click(object sender, EventArgs e)
    {
      this.NuevoRegistro();
    }
    #endregion

  }
}
