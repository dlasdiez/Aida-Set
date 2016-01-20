using System;
using System.Net;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using Configuracion;
using System.IO;

namespace CobolConverter
{
	public static class Cobol_Converter
	{
		private static String ExecuteCobol(String WS_Name, List<String> Parameters = null)
		{
			String _result;
			String _command;
			String _cmd;
			String _parametros;
			String Usuario = "AIDA";

			_parametros = "";
			if (Parameters == null)
			{
				Parameters = new List<String>();
			}

			if (Parameters.Count > 0)
			{
				_parametros = "&parametres=";
				foreach (String _str in Parameters)
				{
					_parametros += _str + "+";
				}
				_parametros = _parametros.TrimEnd('+');
			}

			WebRequest request = WebRequest.Create("http://2.139.183.118:9000/webservices/getcobol.php?user=f9faacf8958798fa686a4cce5f2a2c2726e41b02&password=d916d9ede51571932a81d5e6629586c35daad063&brand=METALCAUCHO&nomscript=" + WS_Name + _parametros + "&envia=Enviar");

			request.Credentials = CredentialCache.DefaultCredentials;

			WebResponse _response = request.GetResponse();

			WebResponse response = request.GetResponse();
			// Display the status.
			Console.WriteLine(((HttpWebResponse)response).StatusDescription);
			// Get the stream containing content returned by the server.
			Stream dataStream = response.GetResponseStream();
			// Open the stream using a StreamReader for easy access.
			StreamReader reader = new StreamReader(dataStream);
			// Read the content.
			_result = reader.ReadToEnd();
			// Display the content.
			//Console.WriteLine(responseFromServer);
			// Clean up the streams and the response.
			reader.Close();
			response.Close();

			return _result;
		}

		public static DataTable GetArticulo(List<String> Parametros)
		{
			return ConvertData(ExecuteCobol(Definitions.ARTICULO, Parametros));
		}

		public static DataTable GetCuentas(List<string> Parametros)
		{
			return ConvertData(ExecuteCobol(Definitions.CUENTA, Parametros));
		}

		//public static DataTable GetTerminals()
		//{
		//    return ConvertData(ExecuteCobol(Definitions.TERMINALS));
		//}

		//public static DataTable GetTerminalsFamily(String IdTerminal)
		//{
		//    List<String> _parametros = new List<String>();
		//    _parametros.Add(IdTerminal);

		//    return ConvertData(ExecuteCobol(Definitions.TERMINAL_FAMILIES, _parametros));
		//}

		//public static DataTable GetOperators()
		//{
		//    return ConvertData(ExecuteCobol(Definitions.OPERATORS));
		//}

		//public static DataTable GetCustomers(String IdTerminal)
		//{
		//    List<String> _parametros = new List<String>();
		//    _parametros.Add(IdTerminal);

		//    return ConvertData(ExecuteCobol(Definitions.CLIENTS, _parametros));
		//}

		//public static Boolean IsDataOK(String IdFamily, String IdCustomer)
		//{
		//    List<String> _parametros = new List<String>();
		//    _parametros.Add(IdCustomer);
		//    _parametros.Add(IdFamily);

		//    return (ExecuteCobol(Definitions.CHECK_DATA, _parametros).Contains("OK"));
		//}

		//public static Boolean PrintVoucher(String IdTerminal, String IdOperator, String IdCustomer, String IdFamily, String Quantity)
		//{
		//    List<String> _parametros = new List<String>();
		//    _parametros.Add(IdTerminal);
		//    _parametros.Add(IdOperator);
		//    _parametros.Add(IdCustomer);
		//    _parametros.Add(IdFamily);
		//    _parametros.Add(Quantity);

		//    return (ExecuteCobol(Definitions.PRINT_VOUCHER, _parametros).Contains("OK"));
		//}

		private static DataTable ConvertData(String Values)
		{
			DataTable _dt_values = new DataTable();
			String[] _separator_rows = { "\r\n" };
			String[] _separator_columns = { "#" };
			String[] _array_rows;
			String[] _array_columns;
			Int16 _count = 0;

			_array_rows = Values.Split(_separator_rows, StringSplitOptions.RemoveEmptyEntries);

			if (_array_rows.Length > 0)
			{
				foreach (String _rows in _array_rows)
				{
					if (_count == 0)
					{
						_count++;

						continue;
					}

					_array_columns = _rows.Split(_separator_columns, StringSplitOptions.RemoveEmptyEntries);
					if (_array_columns.Length == 0)
					{
						continue;
					}

					if (_dt_values.Columns.Count == 0)
					{
						for (Int32 _idx = 0; _idx < _array_columns.Length; _idx++)
						{
							_dt_values.Columns.Add();
						}
					}

					_dt_values.Rows.Add();
					for (Int32 _idx = 0; _idx < _dt_values.Columns.Count; _idx++)
					{
						_dt_values.Rows[_dt_values.Rows.Count - 1][_idx] = _array_columns[_idx];
					}

				}
			}

			return _dt_values;
		}
	}
}