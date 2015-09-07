using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OBJ;
using MySql.Data.MySqlClient;

namespace DAL
{
  public class DalExpediente
  {
    private DBConnect m_connection;

    public DalExpediente(DBConnect _connection)
    {
      this.m_connection = _connection;
    }

    public Boolean Select(Int64 Id, out ObjExpediente ObjExpediente)
    {
      ObjExpediente = new ObjExpediente();

      StringBuilder _sb;

      _sb = new StringBuilder();

      _sb.AppendLine("SELECT   Id ");
      _sb.AppendLine("       , fecha_creacion ");
      _sb.AppendLine("       , fecha_modificacion ");
      _sb.AppendLine("       , fecha_expedicion ");
      _sb.AppendLine("       , usuario_id ");
      _sb.AppendLine("       , usuario_nombre ");
      _sb.AppendLine("       , cliente_id ");
      _sb.AppendLine("       , cliente_nombre ");
      _sb.AppendLine("       , cliente_email ");
      _sb.AppendLine("       , cli_referencia ");
      _sb.AppendLine("       , ref_metalcaucho ");
      _sb.AppendLine("       , observaciones ");
      _sb.AppendLine("       , cli_SDC ");
      _sb.AppendLine("       , cli_DC ");
      _sb.AppendLine("       , cliente_email ");
      _sb.AppendLine(" WHERE   Id = @pId ");
      try
      {
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = this.m_connection.m_Msqlconnection;

        cmd.CommandText = _sb.ToString();
        cmd.Parameters.Add("@pId", MySqlDbType.DateTime).Value = Id;

        MySqlDataReader _reader = cmd.ExecuteReader();

        if (_reader != null)
        {
          ObjExpediente.Id = _reader.GetInt64(0);
          ObjExpediente.FechaCreacion = _reader.GetDateTime(1);
          ObjExpediente.FechaModificacion = _reader.GetDateTime(2);
          ObjExpediente.FechaExpedicion = _reader.GetDateTime(3);
          ObjExpediente.UsuarioId = _reader.GetInt64(4);
          ObjExpediente.UsuarioNombre = _reader.GetString(5);
          ObjExpediente.ClienteId = _reader.GetInt64(6);
          ObjExpediente.ClienteNombre = _reader.GetString(7);
          ObjExpediente.ClienteEmail = _reader.GetString(8);
          ObjExpediente.CliReferencia = _reader.GetString(9);
          ObjExpediente.RefMetalcaucho = _reader.GetInt64(10);
          ObjExpediente.Observaciones = _reader.GetString(11);
          ObjExpediente.CliSdc = _reader.GetBoolean(12);
          ObjExpediente.CliDc = _reader.GetBoolean(13);
          ObjExpediente.MotivoDenegacion = _reader.GetString(14);
        }

        return true;
      }
      catch (Exception ex)
      {
        //TODO: LOG
      }

      return false;
    }

    public Boolean Insert(ObjExpediente ObjExpediente)
    {
      StringBuilder _sb;

      _sb = new StringBuilder();

      _sb.AppendLine(" INSERT INTO   expediente");
      _sb.AppendLine("           (   ");
      _sb.AppendLine("                fecha_creacion ");
      _sb.AppendLine("              , fecha_modificacion ");
      _sb.AppendLine("              , fecha_expedicion ");
      _sb.AppendLine("              , usuario_id ");
      _sb.AppendLine("              , usuario_nombre ");
      _sb.AppendLine("              , cliente_id ");
      _sb.AppendLine("              , cliente_nombre ");
      _sb.AppendLine("              , cliente_email ");
      _sb.AppendLine("              , cli_referencia ");
      _sb.AppendLine("              , ref_metalcaucho ");
      _sb.AppendLine("              , observaciones ");
      _sb.AppendLine("              , cli_SDC ");
      _sb.AppendLine("              , cli_DC ");
      _sb.AppendLine("              , motivo_denegacion ");
      _sb.AppendLine("           )  ");
      _sb.AppendLine("      VALUES  ");
      _sb.AppendLine("           (  ");
      _sb.AppendLine("                NOW() ");
      _sb.AppendLine("              , NOW()  ");
      _sb.AppendLine("              , @pFechaExpedicion  ");
      _sb.AppendLine("              , @pUser_id  ");
      _sb.AppendLine("              , @pUser_name  ");
      _sb.AppendLine("              , @pCliente_id  ");
      _sb.AppendLine("              , @pCliente_nombre  ");
      _sb.AppendLine("              , @pCliente_email  ");
      _sb.AppendLine("              , @pCliente_ref  ");
      _sb.AppendLine("              , @pRef_metalcaucho  ");
      _sb.AppendLine("              , @pObservaciones  ");
      _sb.AppendLine("              , @pCli_SDC  ");
      _sb.AppendLine("              , @pCli_DC  ");
      _sb.AppendLine("              , @pMotivo_denegacion  ");
      _sb.AppendLine("           )  ");
      try
      {
        
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = this.m_connection.m_Msqlconnection;

        cmd.CommandText = _sb.ToString();
        cmd.Parameters.Add("@pFechaExpedicion", MySqlDbType.DateTime).Value = ObjExpediente.FechaExpedicion;
        cmd.Parameters.Add("@pUser_id", MySqlDbType.Int64).Value = ObjExpediente.UsuarioId;
        cmd.Parameters.Add("@pUser_name", MySqlDbType.VarChar).Value = ObjExpediente.UsuarioNombre;
        cmd.Parameters.Add("@pCliente_id", MySqlDbType.Int64).Value = ObjExpediente.ClienteId;
        cmd.Parameters.Add("@pCliente_nombre", MySqlDbType.VarChar).Value = ObjExpediente.ClienteNombre;
        cmd.Parameters.Add("@pCliente_email", MySqlDbType.VarChar).Value = ObjExpediente.ClienteEmail;
        cmd.Parameters.Add("@pCliente_ref", MySqlDbType.VarChar).Value = ObjExpediente.CliReferencia;
        cmd.Parameters.Add("@pRef_metalcaucho", MySqlDbType.Int64).Value = ObjExpediente.RefMetalcaucho;
        cmd.Parameters.Add("@pObservaciones", MySqlDbType.Text).Value = ObjExpediente.Observaciones;
        cmd.Parameters.Add("@pCli_SDC", MySqlDbType.Bit).Value = ObjExpediente.CliSdc;
        cmd.Parameters.Add("@pCli_DC", MySqlDbType.Bit).Value = ObjExpediente.CliDc;
        cmd.Parameters.Add("@pMotivo_denegacion", MySqlDbType.Text).Value = ObjExpediente.MotivoDenegacion;
        
        cmd.ExecuteNonQuery();

        return true;
      }
      catch (Exception ex)
      {
        //TODO: LOG
      }

      return false;
    }

    public Boolean Update(ObjExpediente ObjExpediente)
    {
      StringBuilder _sb;

      _sb = new StringBuilder();

      _sb.AppendLine(" UPDATE     expediente");
      _sb.AppendLine("    SET     fecha_modificacion = NOW() ");
      _sb.AppendLine("          , fecha_expedicion = @pFechaExpedicion ");
      _sb.AppendLine("          , usuario_id = @pUser_id   ");
      _sb.AppendLine("          , usuario_nombre = @pUser_name   ");
      _sb.AppendLine("          , cliente_id = @pCliente_id ");
      _sb.AppendLine("          , cliente_nombre = @pCliente_nombre ");
      _sb.AppendLine("          , cliente_email = @pCliente_email ");
      _sb.AppendLine("          , cli_referencia = @pCliente_ref ");
      _sb.AppendLine("          , ref_metalcaucho = @pRef_metalcaucho ");
      _sb.AppendLine("          , observaciones = @pObservaciones ");
      _sb.AppendLine("          , cli_SDC = @pCli_SDC ");
      _sb.AppendLine("          , cli_DC = @pCli_DC ");
      _sb.AppendLine("          , motivo_denegacion = @pMotivo_denegacion ");
      _sb.AppendLine("  WHERE     id = @pId ");
      try
      {
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = this.m_connection.m_Msqlconnection;

        cmd.CommandText = _sb.ToString();
        cmd.Parameters.Add("@pId", MySqlDbType.Int64).Value = ObjExpediente.Id;
        cmd.Parameters.Add("@pFechaExpedicion", MySqlDbType.DateTime).Value = ObjExpediente.FechaExpedicion;
        cmd.Parameters.Add("@pUser_id", MySqlDbType.Int64).Value = ObjExpediente.UsuarioId;
        cmd.Parameters.Add("@pUser_name", MySqlDbType.VarChar).Value = ObjExpediente.UsuarioNombre;
        cmd.Parameters.Add("@pCliente_id", MySqlDbType.Int64).Value = ObjExpediente.ClienteId;
        cmd.Parameters.Add("@pCliente_nombre", MySqlDbType.VarChar).Value = ObjExpediente.ClienteNombre;
        cmd.Parameters.Add("@pCliente_email", MySqlDbType.VarChar).Value = ObjExpediente.ClienteEmail;
        cmd.Parameters.Add("@pCliente_ref", MySqlDbType.VarChar).Value = ObjExpediente.CliReferencia;
        cmd.Parameters.Add("@pRef_metalcaucho", MySqlDbType.Int64).Value = ObjExpediente.RefMetalcaucho;
        cmd.Parameters.Add("@pObservaciones", MySqlDbType.Text).Value = ObjExpediente.Observaciones;
        cmd.Parameters.Add("@pCli_SDC", MySqlDbType.Bit).Value = ObjExpediente.CliSdc;
        cmd.Parameters.Add("@pCli_DC", MySqlDbType.Bit).Value = ObjExpediente.CliDc;
        cmd.Parameters.Add("@pMotivo_denegacion", MySqlDbType.Text).Value = ObjExpediente.MotivoDenegacion;
        return true;
      }
      catch (Exception ex)
      {
        //TODO: LOG
      }

      return false;
    }

    public Boolean Delete(ObjExpediente ObjExpediente)
    {
      try
      {

        return true;
      }
      catch (Exception ex)
      {
        //TODO: LOG
      }

      return false;
    }

  }


}
