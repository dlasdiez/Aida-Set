using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using OBJ;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using Common;

namespace DAL
{
	class DalRegistroQCEntrada
	{
		private DBConnect m_connection;

		public DalRegistroQCEntrada(DBConnect _connection)
		{
			this.m_connection = _connection;
		}
		public Boolean Select(out DataTable QCEntrada)
		{
			StringBuilder _sb;

			QCEntrada = new DataTable();
			_sb = new StringBuilder();

			_sb.AppendLine("SELECT   Id ");
			_sb.AppendLine("  FROM   qc_entrada ");
			try
			{
				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = this.m_connection.m_Msqlconnection;
				this.m_connection.m_Msqlconnection.Open();

				cmd.CommandText = _sb.ToString();

				MySqlDataAdapter _adapter = new MySqlDataAdapter(cmd);
				_adapter.Fill(QCEntrada);

				this.m_connection.m_Msqlconnection.Close();

				return true;
			}
			catch (Exception ex)
			{
				//TODO: LOG
			}

			return false;
		}

		public Boolean Select(Int64 Id, out ObjRegistroQCEntrada ObjRegistroQCEntrada)
		{
			ObjRegistroQCEntrada = new ObjRegistroQCEntrada();
			Int32 bufferSize = 100;
			byte[] bin = new byte[bufferSize];
			long retval = 0;
			StringBuilder _sb;

			_sb = new StringBuilder();

			_sb.AppendLine("SELECT   Id ");
			_sb.AppendLine("       , fecha_creacion ");
			_sb.AppendLine("       , fecha_revision ");
			_sb.AppendLine("       , fecha_calidad ");
			_sb.AppendLine("       , proveedor_id ");
			_sb.AppendLine("       , proveedor_nombre ");
			_sb.AppendLine("       , resultado_qc ");
			_sb.AppendLine("       , numero_lote ");
			_sb.AppendLine("       , usuario_creacion_id ");
			_sb.AppendLine("       , usuario_creacion_nombre ");
			_sb.AppendLine("       , ref_metalcaucho ");
			_sb.AppendLine("       , numero_plano ");
			_sb.AppendLine("       , unidades_recibidas ");
			_sb.AppendLine("       , unidades_verificadas ");
			_sb.AppendLine("       , usuario_verificado_id ");
			_sb.AppendLine("       , usuario_verificado_nombre ");
			_sb.AppendLine("       , almacen ");
			_sb.AppendLine("       , observaciones ");
			_sb.AppendLine("       , revisar_calidad ");
			_sb.AppendLine("       , visualizar_pautas_autocontrol ");
			_sb.AppendLine("       , solicitar_banco_pruebas ");
			_sb.AppendLine("       , imagen_1 ");
			_sb.AppendLine("       , imagen_2 ");
			_sb.AppendLine("       , imagen_3 ");
			_sb.AppendLine("       , imagen_4 ");
			_sb.AppendLine("       , imagen_5 ");
			_sb.AppendLine("       , acciones ");
			_sb.AppendLine("       , ubicacion_certificado ");
			_sb.AppendLine("  FROM   qc_entrada ");
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
					ObjRegistroQCEntrada.Id = _reader.GetInt64(0);
					ObjRegistroQCEntrada.FechaCreacion = _reader.GetDateTime(1);
					ObjRegistroQCEntrada.FechaRevision = _reader.GetDateTime(2);
					ObjRegistroQCEntrada.FechaCalidad = _reader.GetDateTime(3);
					ObjRegistroQCEntrada.ProveedorId = _reader.GetInt64(4);
					ObjRegistroQCEntrada.ProveedorNombre = _reader.GetString(5);
					ObjRegistroQCEntrada.ResultadoQC = _reader.GetInt32(6);
					ObjRegistroQCEntrada.NumLote = _reader.GetInt64(7);
					ObjRegistroQCEntrada.UsuarioId = _reader.GetInt64(8);
					ObjRegistroQCEntrada.UsuarioNombre = _reader.GetString(9);
					ObjRegistroQCEntrada.RefMetalcaucho = _reader.GetInt64(10);
					ObjRegistroQCEntrada.NumPlano = _reader.GetInt64(11);
					ObjRegistroQCEntrada.UnidadesRecibidas = _reader.GetInt32(12);
					ObjRegistroQCEntrada.UnidadesVerificadas = _reader.GetInt32(13);
					ObjRegistroQCEntrada.UsuarioVerificadoId = _reader.GetInt64(14);
					ObjRegistroQCEntrada.UsuarioVerificadoNombre = _reader.GetString(15);
					ObjRegistroQCEntrada.Almacen = _reader.GetInt32(16);
					ObjRegistroQCEntrada.Observaciones = _reader.GetString(17);
					ObjRegistroQCEntrada.RevisarCalidad = _reader.GetBoolean(18);
					ObjRegistroQCEntrada.VisualizarPautasAutocontrol = _reader.GetBoolean(19);
					ObjRegistroQCEntrada.SolicitarBancoPruebas = _reader.GetBoolean(20);

					bin = new byte[bufferSize];
					retval = _reader.GetBytes(21, 0, bin, 0, bufferSize);
					ObjRegistroQCEntrada.Imagen1 = Image.FromStream(new MemoryStream(bin));

					bin = new byte[bufferSize];
					retval = _reader.GetBytes(22, 0, bin, 0, bufferSize);
					ObjRegistroQCEntrada.Imagen2 = Image.FromStream(new MemoryStream(bin));

					bin = new byte[bufferSize];
					retval = _reader.GetBytes(23, 0, bin, 0, bufferSize);
					ObjRegistroQCEntrada.Imagen3 = Image.FromStream(new MemoryStream(bin));

					bin = new byte[bufferSize];
					retval = _reader.GetBytes(24, 0, bin, 0, bufferSize);
					ObjRegistroQCEntrada.Imagen4 = Image.FromStream(new MemoryStream(bin));

					bin = new byte[bufferSize];
					retval = _reader.GetBytes(25, 0, bin, 0, bufferSize);
					ObjRegistroQCEntrada.Imagen5 = Image.FromStream(new MemoryStream(bin));

					ObjRegistroQCEntrada.Acciones = _reader.GetString(26);
					ObjRegistroQCEntrada.UbicacionCertificado = _reader.GetString(27);
					_reader.Close();
				}

				this.m_connection.m_Msqlconnection.Close();

				return true;
			}
			catch (Exception ex)
			{
				//TODO: LOG
			}

			return false;
		}

		public Boolean Insert(ObjRegistroQCEntrada ObjRegistroQCEntrada)
		{
			StringBuilder _sb;

			_sb = new StringBuilder();

			_sb.AppendLine(" INSERT INTO   expediente");
			_sb.AppendLine("           (   ");
			_sb.AppendLine("					   , fecha_creacion ");
			_sb.AppendLine("					   , fecha_revision ");
			_sb.AppendLine("					   , fecha_calidad ");
			_sb.AppendLine("					   , proveedor_id ");
			_sb.AppendLine("					   , proveedor_nombre ");
			_sb.AppendLine("					   , resultado_qc ");
			_sb.AppendLine("					   , numero_lote ");
			_sb.AppendLine("					   , usuario_creacion_id ");
			_sb.AppendLine("					   , usuario_creacion_nombre ");
			_sb.AppendLine("					   , ref_metalcaucho ");
			_sb.AppendLine("					   , numero_plano ");
			_sb.AppendLine("					   , unidades_recibidas ");
			_sb.AppendLine("					   , unidades_verificadas ");
			_sb.AppendLine("					   , usuario_verificado_id ");
			_sb.AppendLine("					   , usuario_verificado_nombre ");
			_sb.AppendLine("					   , almacen ");
			_sb.AppendLine("					   , observaciones ");
			_sb.AppendLine("					   , revisar_calidad ");
			_sb.AppendLine("					   , visualizar_pautas_autocontrol ");
			_sb.AppendLine("					   , solicitar_banco_pruebas ");
			_sb.AppendLine("					   , imagen_1 ");
			_sb.AppendLine("					   , imagen_2 ");
			_sb.AppendLine("					   , imagen_3 ");
			_sb.AppendLine("					   , imagen_4 ");
			_sb.AppendLine("					   , imagen_5 ");
			_sb.AppendLine("					   , acciones ");
			_sb.AppendLine("					   , ubicacion_certificado ");
			_sb.AppendLine("           )  ");
			_sb.AppendLine("      VALUES  ");
			_sb.AppendLine("           (  ");
			_sb.AppendLine("                NOW() ");
			_sb.AppendLine("              , NOW()  ");
			_sb.AppendLine("              , @pFechaCalidad  ");
			_sb.AppendLine("              , @pProveedor_id  ");
			_sb.AppendLine("              , @pProveedor_nombre  ");
			_sb.AppendLine("              , @pResultado_qc  ");
			_sb.AppendLine("              , @pNum_lote  ");
			_sb.AppendLine("              , @pUsuario_id  ");
			_sb.AppendLine("              , @pUsuario_nombre  ");
			_sb.AppendLine("              , @pRef_metalcaucho  ");
			_sb.AppendLine("              , @pNum_plano  ");
			_sb.AppendLine("              , @pUnidades_recibidas  ");
			_sb.AppendLine("              , @pUnidades_verificadas  ");
			_sb.AppendLine("              , @pUsuario_verificado_id  ");
			_sb.AppendLine("              , @pUsuario_verificado_nombre  ");
			_sb.AppendLine("              , @pAlmacen  ");
			_sb.AppendLine("              , @pObservaciones  ");
			_sb.AppendLine("              , @pRevisar_calidad  ");
			_sb.AppendLine("              , @pVisualizar_pautas_autocontrol  ");
			_sb.AppendLine("              , @pSolicitar_banco_pruebas  ");
			_sb.AppendLine("              , @pImagen1  ");
			_sb.AppendLine("              , @pImagen2  ");
			_sb.AppendLine("              , @pImagen3  ");
			_sb.AppendLine("              , @pImagen4  ");
			_sb.AppendLine("              , @pImagen5  ");
			_sb.AppendLine("              , @pAcciones  ");
			_sb.AppendLine("              , @pUbicacion_certificado  ");
			_sb.AppendLine("           )  ");
			try
			{

				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = this.m_connection.m_Msqlconnection;
				this.m_connection.m_Msqlconnection.Open();

				cmd.CommandText = _sb.ToString();
				cmd.Parameters.Add("@pFechaCalidad", MySqlDbType.DateTime).Value = ObjRegistroQCEntrada.FechaCalidad;
				cmd.Parameters.Add("@pProveedor_id", MySqlDbType.Int64).Value = ObjRegistroQCEntrada.ProveedorId;
				cmd.Parameters.Add("@pProveedor_nombre", MySqlDbType.VarChar).Value = ObjRegistroQCEntrada.ProveedorNombre;
				cmd.Parameters.Add("@pResultado_qc", MySqlDbType.Int32).Value = ObjRegistroQCEntrada.ResultadoQC;
				cmd.Parameters.Add("@pNum_lote", MySqlDbType.VarChar).Value = ObjRegistroQCEntrada.NumLote;
				cmd.Parameters.Add("@pUsuario_id", MySqlDbType.Int64).Value = ObjRegistroQCEntrada.UsuarioId;
				cmd.Parameters.Add("@pUsuario_nombre", MySqlDbType.VarChar).Value = ObjRegistroQCEntrada.UsuarioNombre;
				cmd.Parameters.Add("@pRef_metalcaucho", MySqlDbType.Int64).Value = ObjRegistroQCEntrada.RefMetalcaucho;
				cmd.Parameters.Add("@pNum_plano", MySqlDbType.Int64).Value = ObjRegistroQCEntrada.NumPlano;
				cmd.Parameters.Add("@pUnidades_recibidas", MySqlDbType.Int32).Value = ObjRegistroQCEntrada.UnidadesRecibidas;
				cmd.Parameters.Add("@pUnidades_verificadas", MySqlDbType.Int32).Value = ObjRegistroQCEntrada.UnidadesVerificadas;
				cmd.Parameters.Add("@pUsuario_verificado_id", MySqlDbType.Int64).Value = ObjRegistroQCEntrada.UsuarioVerificadoId;
				cmd.Parameters.Add("@pUsuario_verificado_nombre", MySqlDbType.VarChar).Value = ObjRegistroQCEntrada.UsuarioVerificadoNombre;
				cmd.Parameters.Add("@pAlmacen", MySqlDbType.Int32).Value = ObjRegistroQCEntrada.Almacen;
				cmd.Parameters.Add("@pObservaciones", MySqlDbType.Text).Value = ObjRegistroQCEntrada.Observaciones;
				cmd.Parameters.Add("@pRevisar_calidad", MySqlDbType.Bit).Value = ObjRegistroQCEntrada.RevisarCalidad;
				cmd.Parameters.Add("@pVisualizar_pautas_autocontrol", MySqlDbType.Bit).Value = ObjRegistroQCEntrada.VisualizarPautasAutocontrol;
				cmd.Parameters.Add("@pSolicitar_banco_pruebas", MySqlDbType.Bit).Value = ObjRegistroQCEntrada.SolicitarBancoPruebas;
				cmd.Parameters.Add("@pImagen1", MySqlDbType.Byte).Value = FuncionesGenerales.ConvertImageBite(ObjRegistroQCEntrada.Imagen1);
				cmd.Parameters.Add("@pImagen2", MySqlDbType.Byte).Value = FuncionesGenerales.ConvertImageBite(ObjRegistroQCEntrada.Imagen2);
				cmd.Parameters.Add("@pImagen3", MySqlDbType.Byte).Value = FuncionesGenerales.ConvertImageBite(ObjRegistroQCEntrada.Imagen3);
				cmd.Parameters.Add("@pImagen4", MySqlDbType.Byte).Value = FuncionesGenerales.ConvertImageBite(ObjRegistroQCEntrada.Imagen4);
				cmd.Parameters.Add("@pImagen5", MySqlDbType.Byte).Value = FuncionesGenerales.ConvertImageBite(ObjRegistroQCEntrada.Imagen5);
				cmd.Parameters.Add("@pAcciones", MySqlDbType.Text).Value = ObjRegistroQCEntrada.Acciones;
				cmd.Parameters.Add("@pUbicacion_certificado", MySqlDbType.Text).Value = ObjRegistroQCEntrada.UbicacionCertificado;

				cmd.ExecuteNonQuery();

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
}
