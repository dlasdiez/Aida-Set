using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using DAL;
using System.Data;

namespace ControlCalidad
{
  public class cls_permisos
  {
    DataTable m_permisos;

    PermisosModulo Permisos;

    public class PermisosModulo
    {
      public Dictionary<Int32, Datos> Modulos = new Dictionary<Int32, Datos>();
    }

    public class Datos
    {
      public Int32 Id;
      public Boolean Lectura;
      public Boolean Escritura;
      public Boolean Borrar;
    }

    private void ReadPermisos(String Usuario)
    {
      DBConnect _connection;

      _connection = new DBConnect(Configuracion.Config.ValueConfig.Servidor_BD, Configuracion.Config.ValueConfig.Database, Configuracion.Config.ValueConfig.Puerto, Configuracion.Config.ValueConfig.Usuario_BD, Configuracion.Config.ValueConfig.Password_BD);

      this.DB_ReadPermisos(Usuario, _connection);
    }

    public DataTable GetUserPermisos()
    {

      this.ReadPermisos("");

      return m_permisos;
    }

    public PermisosModulo GetPermisos(String Usuario)
    {
      this.ReadPermisos(Usuario);

      FillEstruct();

      return Permisos;
    }

    private void FillEstruct()
    {
      Int32 _modulo = -1;

      Permisos = new PermisosModulo();
      Datos _datos = new Datos();

      foreach (DataRow _dr in this.m_permisos.Rows)
      {
        _datos.Id = (Int32)_dr["pa_id"];
        _datos.Lectura = (Boolean)_dr["pa_lectura"];
        _datos.Escritura = (Boolean)_dr["pa_modificacion"];
        _datos.Borrar = (Boolean)_dr["pa_baja"];
        _modulo = (Int32)_dr["pa_modulo"];

        Permisos.Modulos.Add(_modulo, _datos);
        _datos = new Datos();
      }
    }

    private void DB_ReadPermisos(String Usuario, DBConnect Connect)
    {
      StringBuilder _sb;
      List<MySqlParameter> _collection = new List<MySqlParameter>();

      _sb = new StringBuilder();
      if (Usuario != "")
      {
        _sb.AppendLine(" SELECT     pa_id  ");
        _sb.AppendLine("          , pa_modulo ");
        _sb.AppendLine("          , pa_user ");
        _sb.AppendLine("          , pa_modificacion ");
        _sb.AppendLine("          , pa_baja ");
        _sb.AppendLine("          , pa_lectura ");
        _sb.AppendLine("   FROM     permiso_aplicacion ");

        _sb.AppendLine("  WHERE   pa_user = @pUser ");
        _collection.Add(new MySqlParameter("@pUser", Usuario));
      }
      else
      {
        _sb.AppendLine(" SELECT  DISTINCT pa_user ");
        _sb.AppendLine("   FROM     permiso_aplicacion ");
      }

      m_permisos = Connect.Select(_sb.ToString(), _collection);
    }
  }
}
