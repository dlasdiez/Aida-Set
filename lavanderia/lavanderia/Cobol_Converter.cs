using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace lavanderia
{
    public static class Cobol_Converter
    {
        private static String ExecuteCobol(String WS_Name, List<String> Parameters = null)
        {
            String _result;
            String _command = Config.PathWebServices + WS_Name;
            String _cmd;
            String _parametros;

            _parametros = "";
            if (Parameters == null)
            {
                Parameters = new List<String>();
            }

            foreach (String _str in Parameters)
            {
                _parametros += " " + _str;
            }

            _cmd = Config.Runtime + " " + _command + " " + Config.PathDatos + " " + _parametros;

            System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo("cmd", "/C " + _cmd);
            procStartInfo.RedirectStandardOutput = true;
            procStartInfo.UseShellExecute = false;
            procStartInfo.CreateNoWindow = false;
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo = procStartInfo;
            proc.Start();
            //Consigue la salida de la Consola(Stream) y devuelve una cadena de texto
            _result = proc.StandardOutput.ReadToEnd();

            return _result;
        }

        public static DataTable GetTerminals()
        {
            return ConvertData(ExecuteCobol(Definitions.TERMINALS));
        }

        public static DataTable GetTerminalsFamily(String IdTerminal)
        {
            List<String> _parametros = new List<String>();
            _parametros.Add(IdTerminal);

            return ConvertData(ExecuteCobol(Definitions.TERMINAL_FAMILIES, _parametros));
        }

        public static DataTable GetOperators()
        {
            return ConvertData(ExecuteCobol(Definitions.OPERATORS));
        }

        public static DataTable GetCustomers(String IdTerminal)
        {
            List<String> _parametros = new List<String>();
            _parametros.Add(IdTerminal);

            return ConvertData(ExecuteCobol(Definitions.CLIENTS, _parametros));
        }

        public static Boolean IsDataOK(String IdFamily, String IdCustomer)
        {
            List<String> _parametros = new List<String>();
            _parametros.Add(IdCustomer);
            _parametros.Add(IdFamily);

            return (ExecuteCobol(Definitions.CHECK_DATA, _parametros).Contains("OK"));
        }

        public static Boolean PrintVoucher(String IdTerminal, String IdOperator, String IdCustomer, String IdFamily, String Quantity)
        {
            List<String> _parametros = new List<String>();
            _parametros.Add(IdTerminal);
            _parametros.Add(IdOperator);
            _parametros.Add(IdCustomer);
            _parametros.Add(IdFamily);
            _parametros.Add(Quantity);

            return (ExecuteCobol(Definitions.PRINT_VOUCHER, _parametros).Contains("OK"));
        }

        private static DataTable ConvertData(String Values)
        {
            DataTable _dt_values = new DataTable();
            String[] _separator_rows = { "\r\n" };
            String[] _separator_columns = { "#" };
            String[] _array_rows;
            String[] _array_columns;

            _array_rows = Values.Split(_separator_rows, StringSplitOptions.RemoveEmptyEntries);

            if (_array_rows.Length > 0)
            {
                foreach (String _rows in _array_rows)
                {
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
                    for (Int32 _idx = 0; _idx < _array_columns.Length; _idx++)
                    {
                        _dt_values.Rows[_dt_values.Rows.Count - 1][_idx] = _array_columns[_idx];
                    }

                }
            }

            return _dt_values;
        }
    }
}