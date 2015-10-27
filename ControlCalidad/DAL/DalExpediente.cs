using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OBJ;
using MySql.Data.MySqlClient;
using System.Data;

namespace DAL
{
  public class DalExpediente
  {
    private DBConnect m_connection;

    public DalExpediente(DBConnect _connection)
    {
      this.m_connection = _connection;
    }

    public Boolean Select(out DataTable Expediente)
    {
      StringBuilder _sb;

      Expediente = new DataTable();
      _sb = new StringBuilder();

      _sb.AppendLine("SELECT   Id ");
      _sb.AppendLine("  FROM   expediente ");
      try
      {
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = this.m_connection.m_Msqlconnection;
        this.m_connection.m_Msqlconnection.Open();

        cmd.CommandText = _sb.ToString();

        MySqlDataAdapter _adapter = new MySqlDataAdapter(cmd);
        _adapter.Fill(Expediente);

        this.m_connection.m_Msqlconnection.Close();


        return true;
      }
      catch (Exception ex)
      {
        //TODO: LOG
      }

      return false;
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
      _sb.AppendLine("       , cod_articulo ");
      _sb.AppendLine("       , articulo_nombre ");
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
      _sb.AppendLine("       , notas ");
      _sb.AppendLine("  FROM   expediente ");
      _sb.AppendLine(" WHERE   Id = @pId ");
      try
      {
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = this.m_connection.m_Msqlconnection;
        this.m_connection.m_Msqlconnection.Open();

        cmd.CommandText = _sb.ToString();
        cmd.Parameters.Add("@pId", MySqlDbType.Int64).Value = Id;

        MySqlDataReader _reader = cmd.ExecuteReader();

        if (_reader != null)
        {
          _reader.Read();
          ObjExpediente.Id = _reader.GetInt64(0);
          ObjExpediente.FechaCreacion = _reader.GetDateTime(1);
          ObjExpediente.FechaModificacion = _reader.GetDateTime(2);
          ObjExpediente.FechaExpedicion = _reader.GetDateTime(3);
          ObjExpediente.CodArticulo = _reader.GetString(4);
          ObjExpediente.ArticuloNombre = _reader.GetString(5);
          ObjExpediente.UsuarioId = _reader.GetInt64(6);
          ObjExpediente.UsuarioNombre = _reader.GetString(7);
          ObjExpediente.ClienteId = _reader.GetString(8);
          ObjExpediente.ClienteNombre = _reader.GetString(9);
          ObjExpediente.ClienteEmail = _reader.GetString(10);
          ObjExpediente.CliReferencia = _reader.GetString(11);
          ObjExpediente.RefMetalcaucho = _reader.GetInt64(12);
          ObjExpediente.Observaciones = _reader.GetString(13);
          ObjExpediente.CliSdc = _reader.GetBoolean(14);
          ObjExpediente.CliDc = _reader.GetBoolean(15);
          ObjExpediente.MotivoDenegacion = _reader.GetString(16);
          ObjExpediente.Notas = _reader.GetString(17);
          _reader.Close();
        }

        List<ObjExpedienteLinea> _lineas = new List<ObjExpedienteLinea>();

        DalExpedienteLineas _dal_expediente_lineas = new DalExpedienteLineas();
        _dal_expediente_lineas.Select(Id, out _lineas, this.m_connection);

        ObjExpediente.Lineas = _lineas;
        this.m_connection.m_Msqlconnection.Close();


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
      _sb.AppendLine("              , cod_articulo ");
      _sb.AppendLine("              , articulo_nombre ");
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
      _sb.AppendLine("              , notas ");
      _sb.AppendLine("           )  ");
      _sb.AppendLine("      VALUES  ");
      _sb.AppendLine("           (  ");
      _sb.AppendLine("                NOW() ");
      _sb.AppendLine("              , NOW()  ");
      _sb.AppendLine("              , @pFechaExpedicion  ");
      _sb.AppendLine("              , @pCod_articulo  ");
      _sb.AppendLine("              , @pArticulo_nombre  ");
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
      _sb.AppendLine("              , @pNotas  ");
      _sb.AppendLine("           )  ");
      try
      {

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = this.m_connection.m_Msqlconnection;
        this.m_connection.m_Msqlconnection.Open();

        cmd.CommandText = _sb.ToString();
        cmd.Parameters.Add("@pFechaExpedicion", MySqlDbType.DateTime).Value = ObjExpediente.FechaExpedicion;
        cmd.Parameters.Add("@pCod_articulo", MySqlDbType.Int64).Value = ObjExpediente.CodArticulo;
        cmd.Parameters.Add("@pArticulo_nombre", MySqlDbType.VarChar).Value = ObjExpediente.ArticuloNombre;
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
        cmd.Parameters.Add("@pNotas", MySqlDbType.Text).Value = ObjExpediente.Notas;

        //cmd.BeginExecuteNonQuery();

        cmd.ExecuteNonQuery();

        Int64 _id_expediente = cmd.LastInsertedId;
        DalExpedienteLineas _dal_expediente_lineas = new DalExpedienteLineas();

        foreach (ObjExpedienteLinea _lineas in ObjExpediente.Lineas)
        {
          _lineas.IdExpediente = _id_expediente;
          _dal_expediente_lineas.Insert(_lineas, this.m_connection);
        }

        //cmd.EndExecuteNonQuery();

        this.m_connection.m_Msqlconnection.Close();

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
      _sb.AppendLine("          , cod_articulo = @pCod_articulo   ");
      _sb.AppendLine("          , articulo_nombre = @pArticulo_nombre   ");
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
      _sb.AppendLine("          , motivo_denegacion = @pNotas ");
      _sb.AppendLine("  WHERE     id = @pId ");
      try
      {
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = this.m_connection.m_Msqlconnection;

        this.m_connection.m_Msqlconnection.Open();

        cmd.CommandText = _sb.ToString();
        cmd.Parameters.Add("@pId", MySqlDbType.Int64).Value = ObjExpediente.Id;
        cmd.Parameters.Add("@pFechaExpedicion", MySqlDbType.DateTime).Value = ObjExpediente.FechaExpedicion;
        cmd.Parameters.Add("@pCod_articulo", MySqlDbType.Int64).Value = ObjExpediente.CodArticulo;
        cmd.Parameters.Add("@pArticulo_nombre", MySqlDbType.VarChar).Value = ObjExpediente.ArticuloNombre;
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
        cmd.Parameters.Add("@pNotas", MySqlDbType.Text).Value = ObjExpediente.Notas;

        cmd.ExecuteNonQuery();

        //cmd.BeginExecuteNonQuery();

        cmd.ExecuteNonQuery();

        DalExpedienteLineas _dal_expediente_lineas = new DalExpedienteLineas();

        foreach (ObjExpedienteLinea _lineas in ObjExpediente.Lineas)
        {
          _lineas.IdExpediente = ObjExpediente.Id;
          if (_lineas.Id == -1)
          {
            _dal_expediente_lineas.Insert(_lineas, this.m_connection);
          }
          else
          {
            _dal_expediente_lineas.Update(_lineas, this.m_connection);
          }
        }

        //cmd.EndExecuteNonQuery();

        this.m_connection.m_Msqlconnection.Close();

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


  public class DalExpedienteLineas
  {
    public Boolean Select(Int64 Id, out List<ObjExpedienteLinea> Lineas, DBConnect Conexion)
    {
      DataTable _lineas;
      ObjExpedienteLinea _obj_expediente_linea;
      Lineas = new List<ObjExpedienteLinea>();

      StringBuilder _sb;

      _sb = new StringBuilder();

      _sb.AppendLine("SELECT   Id ");
      _sb.AppendLine("       , Id_expediente ");
      _sb.AppendLine("       , fecha_creacion ");
      _sb.AppendLine("       , fecha_modificacion ");
      _sb.AppendLine("       , usuario_creacion_id ");
      _sb.AppendLine("       , proveedor_id ");
      _sb.AppendLine("       , proveedor_nombre ");
      _sb.AppendLine("       , referencia_proveedor ");
      _sb.AppendLine("       , num_lote ");
      _sb.AppendLine("       , unidades ");
      _sb.AppendLine("  FROM   expediente_lineas ");
      _sb.AppendLine(" WHERE   Id_expediente = @pId ");
      try
      {
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = Conexion.m_Msqlconnection;

        cmd.CommandText = _sb.ToString();
        cmd.Parameters.Add("@pId", MySqlDbType.Int64).Value = Id;

        MySqlDataReader _reader = cmd.ExecuteReader();

        _lineas = new DataTable();
        _lineas.Load(_reader);

        foreach (DataRow _dr in _lineas.Rows)
        {
          _obj_expediente_linea = new ObjExpedienteLinea();

          _obj_expediente_linea.Id = (long)_dr[0];
          _obj_expediente_linea.IdExpediente = (long)_dr[1];
          _obj_expediente_linea.FechaCreacion = (DateTime)_dr[2];
          _obj_expediente_linea.FechaModificacion = (DateTime)_dr[3];
          _obj_expediente_linea.UsuarioCreacion = (long)_dr[4];
          _obj_expediente_linea.IdProveedor = (String)_dr[5];
          _obj_expediente_linea.ProveedorNombre = (String)_dr[6];
          _obj_expediente_linea.ProveedorReferencia = (String)_dr[7];
          _obj_expediente_linea.NumLote = (String)_dr[8];
          _obj_expediente_linea.Unidades = Convert.ToInt32(_dr[9]);

          Lineas.Add(_obj_expediente_linea);
        }

        return true;
      }
      catch (Exception ex)
      {
        //TODO: LOG
      }

      return false;
    }

    public Boolean Insert(ObjExpedienteLinea ObjExpedienteLineas, DBConnect Conexion)
    {
      StringBuilder _sb;

      _sb = new StringBuilder();

      _sb.AppendLine(" INSERT INTO   expediente_lineas");
      _sb.AppendLine("           (   ");
      _sb.AppendLine("                Id_expediente ");
      _sb.AppendLine("              , fecha_creacion ");
      _sb.AppendLine("              , fecha_modificacion ");
      _sb.AppendLine("              , usuario_creacion_id ");
      _sb.AppendLine("              , proveedor_id ");
      _sb.AppendLine("              , proveedor_nombre ");
      _sb.AppendLine("              , referencia_proveedor ");
      _sb.AppendLine("              , num_lote ");
      _sb.AppendLine("              , unidades ");
      _sb.AppendLine("           )  ");
      _sb.AppendLine("      VALUES  ");
      _sb.AppendLine("           (  ");
      _sb.AppendLine("                @pIdExpediente ");
      _sb.AppendLine("              , NOW() ");
      _sb.AppendLine("              , NOW()  ");
      _sb.AppendLine("              , @pUsuarioCreacion  ");
      _sb.AppendLine("              , @pIdProveedor  ");
      _sb.AppendLine("              , @pProveedorNombre  ");
      _sb.AppendLine("              , @pReferenciaProveedor  ");
      _sb.AppendLine("              , @pNumLote  ");
      _sb.AppendLine("              , @pUnidades  ");
      _sb.AppendLine("           )  ");
      try
      {

        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = Conexion.m_Msqlconnection;

        cmd.CommandText = _sb.ToString();
        cmd.Parameters.Add("@pIdExpediente", MySqlDbType.Int64).Value = ObjExpedienteLineas.IdExpediente;
        cmd.Parameters.Add("@pUsuarioCreacion", MySqlDbType.Int64).Value = ObjExpedienteLineas.UsuarioCreacion;
        cmd.Parameters.Add("@pIdProveedor", MySqlDbType.VarChar).Value = ObjExpedienteLineas.IdProveedor;
        cmd.Parameters.Add("@pProveedorNombre", MySqlDbType.VarChar).Value = ObjExpedienteLineas.ProveedorNombre;
        cmd.Parameters.Add("@pReferenciaProveedor", MySqlDbType.VarChar).Value = ObjExpedienteLineas.ProveedorReferencia;
        cmd.Parameters.Add("@pNumLote", MySqlDbType.VarChar).Value = ObjExpedienteLineas.NumLote;
        cmd.Parameters.Add("@pUnidades", MySqlDbType.Int64).Value = ObjExpedienteLineas.Unidades;

        cmd.ExecuteNonQuery();

        return true;
      }
      catch (Exception ex)
      {
        //TODO: LOG
      }

      return false;
    }

    public Boolean Update(ObjExpedienteLinea ObjExpedienteLinea, DBConnect Conexion)
    {
      StringBuilder _sb;

      _sb = new StringBuilder();

      _sb.AppendLine(" UPDATE     expediente_lineas");
      _sb.AppendLine("    SET     fecha_modificacion = NOW() ");
      _sb.AppendLine("          , proveedor_id = @pIdProveedor   ");
      _sb.AppendLine("          , proveedor_nombre = @pProveedorNombre   ");
      _sb.AppendLine("          , referencia_proveedor = @pReferenciaProveedor   ");
      _sb.AppendLine("          , num_lote = @pNumLote   ");
      _sb.AppendLine("          , unidades = @pUnidades ");
      _sb.AppendLine("  WHERE     id = @pId ");
      _sb.AppendLine("    AND     id_expediente = @pIdExpediente ");
      try
      {
        MySqlCommand cmd = new MySqlCommand();
        cmd.Connection = Conexion.m_Msqlconnection;

        cmd.CommandText = _sb.ToString();
        cmd.Parameters.Add("@pId", MySqlDbType.Int64).Value = ObjExpedienteLinea.Id;
        cmd.Parameters.Add("@pIdExpediente", MySqlDbType.Int64).Value = ObjExpedienteLinea.IdExpediente;
        cmd.Parameters.Add("@pIdProveedor", MySqlDbType.VarChar).Value = ObjExpedienteLinea.IdProveedor;
        cmd.Parameters.Add("@pProveedorNombre", MySqlDbType.VarChar).Value = ObjExpedienteLinea.ProveedorNombre;
        cmd.Parameters.Add("@pReferenciaProveedor", MySqlDbType.VarChar).Value = ObjExpedienteLinea.ProveedorReferencia;
        cmd.Parameters.Add("@pNumLote", MySqlDbType.Int64).Value = ObjExpedienteLinea.NumLote;
        cmd.Parameters.Add("@pUnidades", MySqlDbType.VarChar).Value = ObjExpedienteLinea.Unidades;

        cmd.ExecuteNonQuery();

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
