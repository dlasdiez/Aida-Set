using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace lavanderia
{
    public partial class frm_main : Form
    {
        frm_keypad m_keypad;
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            this.txt_fecha.Text = DateTime.Now.ToShortDateString();
            this.lbl_fecha.Text = "Fecha:";

            this.btn_set_operator.Text = "Buscar";
            this.btn_customer.Text = "Buscar";

            this.lbl_terminal_code.Text = "Código Terminal";
            this.lbl_cod_operario.Text = "Código Operario";
            this.lbl_cod_cliente.Text = "Código Cliente";
            this.lbl_terminals_family.Text = "";

            this.btn_sel_art_1.Text = "Buscar";
            this.btn_sel_art_2.Text = "Buscar";
            this.btn_sel_art_3.Text = "Buscar";
            this.btn_sel_art_4.Text = "Buscar";
            this.lbl_art1.Text = "Art.";
            this.lbl_art2.Text = "Art.";
            this.lbl_art3.Text = "Art.";
            this.lbl_art4.Text = "Art.";

            this.lbl_uni_art1.Text = "Unid.";
            this.lbl_uni_art2.Text = "Unid.";
            this.lbl_uni_art3.Text = "Unid.";
            this.lbl_uni_art4.Text = "Unid.";

            this.btn_voucher1.Text = "F1";
            this.btn_voucher2.Text = "F2";
            this.btn_voucher3.Text = "F3";
            this.btn_voucher4.Text = "F4";

            this.reloj.Enabled = true;

            if (!Config.ReadConfig())
            {
                MessageBox.Show("Error al cargar el fichero de configuración", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            ReadTerminalInfo();
            this.BackColor = ColorTranslator.FromHtml(Config.Color);

            m_keypad = new frm_keypad();
        }

        private void ReadTerminalInfo()
        {
            DataTable _terminals;
            DataTable _terminals_family;
            String _families;

            this.errorProvider1.Clear();

            _terminals = Cobol_Converter.GetTerminals();

            if (String.IsNullOrEmpty(Config.Terminal))
            {
                return;
            }

            this.txt_cod_terminal.Text = Config.Terminal;
            foreach (DataRow _row in _terminals.Rows)
            {
                if (_row[0].ToString() == Config.Terminal)
                {
                    this.txt_terminal_name.Text = _row[1].ToString();
                    break;
                }
            }

            _terminals_family = Cobol_Converter.GetTerminalsFamily(Config.Terminal);
            _families = "";

            foreach (DataRow _dr in _terminals_family.Rows)
            {
                _families += _dr[0].ToString() + "    ";
            }

            if (!String.IsNullOrEmpty(_families))
            {
                this.lbl_terminals_family.Text = _families;
            }
            else
            {
                this.lbl_terminals_family.Text = "No hay familias asignadas al terminal";
            }
        }

        private void reloj_Tick(object sender, EventArgs e)
        {
            DateTime _now = DateTime.Now;
            this.txt_clock.Text = _now.ToShortDateString() + "       " + _now.ToLongTimeString();
        }

        private void btn_set_operator_Click(object sender, EventArgs e)
        {
            DataTable _operators;

            errorProvider1.Clear();

            _operators = Cobol_Converter.GetOperators();
            frm_list _list = new frm_list(Definitions.FormType.Operator, _operators);
            _list.ShowDialog();

            this.txt_cod_operario.Text = "";
            this.txt_cod_operator_name.Text = "";
            if (String.IsNullOrEmpty(_list.ID))
            {
                return;
            }
            this.txt_cod_operario.Text = _list.ID;
            this.txt_cod_operator_name.Text = _list.Name;
        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            DataTable _customers;

            errorProvider1.Clear();

            if (String.IsNullOrEmpty(this.txt_cod_operario.Text))
            {
                MessageBox.Show("Debe seleccionar el operario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(this.btn_set_operator, "Seleccione el operario");
                return;
            }

            _customers = Cobol_Converter.GetCustomers(this.txt_cod_terminal.Text);
            frm_list _list = new frm_list(Definitions.FormType.Customer, _customers);
            _list.ShowDialog();

            this.txt_cod_customer.Text = "";
            this.txt_customer_name.Text = "";

            if (String.IsNullOrEmpty(_list.ID))
            {
                return;
            }
            this.txt_cod_customer.Text = _list.ID;
            this.txt_customer_name.Text = _list.Name;

            this.m_keypad.Amount = 0;

            this.txt_cod_art1.Text = "";
            this.txt_cod_art2.Text = "";
            this.txt_cod_art3.Text = "";
            this.txt_cod_art4.Text = "";

            this.txt_units1.Text = "";
            this.txt_units2.Text = "";
            this.txt_units3.Text = "";
            this.txt_units4.Text = "";
        }


        private void btn_sel_art_1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (String.IsNullOrEmpty(this.txt_cod_operario.Text))
            {
                MessageBox.Show("Debe seleccionar el operario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(this.btn_set_operator, "Seleccione el operario");
                return;
            }

            if (String.IsNullOrEmpty(this.txt_cod_customer.Text))
            {
                MessageBox.Show("Debe seleccionar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(this.btn_customer, "Seleccione el cliente");
                return;
            }

            this.txt_cod_art1.Text = GetArticle();
            if (!Cobol_Converter.IsDataOK(this.txt_cod_art1.Text, this.txt_cod_customer.Text))
            {
                errorProvider1.SetError(this.txt_cod_art1, "La familia no pertenece al cliente");
            }
        }

        private void btn_sel_art_2_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (String.IsNullOrEmpty(this.txt_cod_operario.Text))
            {
                MessageBox.Show("Debe seleccionar el operario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(this.btn_set_operator, "Seleccione el operario");
                return;
            }

            if (String.IsNullOrEmpty(this.txt_cod_customer.Text))
            {
                MessageBox.Show("Debe seleccionar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(this.btn_customer, "Seleccione el cliente");
                return;
            }

            this.txt_cod_art2.Text = GetArticle();
            if (!Cobol_Converter.IsDataOK(this.txt_cod_art2.Text, this.txt_cod_customer.Text))
            {
                errorProvider1.SetError(this.txt_cod_art2, "La familia no pertenece al cliente");
            }
        }

        private void btn_sel_art_3_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (String.IsNullOrEmpty(this.txt_cod_operario.Text))
            {
                MessageBox.Show("Debe seleccionar el operario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(this.btn_set_operator, "Seleccione el operario");
                return;
            }

            if (String.IsNullOrEmpty(this.txt_cod_customer.Text))
            {
                MessageBox.Show("Debe seleccionar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(this.btn_customer, "Seleccione el cliente");
                return;
            }

            this.txt_cod_art3.Text = GetArticle();
            if (!Cobol_Converter.IsDataOK(this.txt_cod_art3.Text, this.txt_cod_customer.Text))
            {
                errorProvider1.SetError(this.txt_cod_art3, "La familia no pertenece al cliente");
            }
        }

        private void btn_sel_art_4_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (String.IsNullOrEmpty(this.txt_cod_operario.Text))
            {
                MessageBox.Show("Debe seleccionar el operario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(this.btn_set_operator, "Seleccione el operario");
                return;
            }

            if (String.IsNullOrEmpty(this.txt_cod_customer.Text))
            {
                MessageBox.Show("Debe seleccionar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider1.SetError(this.btn_customer, "Seleccione el cliente");
                return;
            }

            this.txt_cod_art4.Text = GetArticle();
            if (!Cobol_Converter.IsDataOK(this.txt_cod_art4.Text, this.txt_cod_customer.Text))
            {
                errorProvider1.SetError(this.txt_cod_art4, "La familia no pertenece al cliente");
            }
        }


        private void btn_voucher1_Click(object sender, EventArgs e)
        {
            this.PrintVoucher(1);
        }

        private void btn_voucher2_Click(object sender, EventArgs e)
        {
            this.PrintVoucher(2);
        }

        private void btn_voucher3_Click(object sender, EventArgs e)
        {
            this.PrintVoucher(3);
        }

        private void btn_voucher4_Click(object sender, EventArgs e)
        {
            this.PrintVoucher(4);
        }

        private String GetArticle()
        {
            DataTable _articles;
            frm_list _frm;

            _articles = Cobol_Converter.GetTerminalsFamily(this.txt_cod_terminal.Text);
            _frm = new frm_list(Definitions.FormType.Families, _articles);
            _frm.ShowDialog();

            errorProvider1.Clear();
            return _frm.ID;
        }

        private void PrintVoucher(Int32 VoucherNum)
        {
            String _id_terminal;
            String _id_operator;
            String _cod_customer;
            String _cod_family;
            String _quantity;
            String _text;
            String _caption;
            MessageBoxIcon _icon;
            TextBox _ctl = this.txt_cod_art1;

            _id_terminal = this.txt_cod_terminal.Text.Trim();
            _id_operator = this.txt_cod_operario.Text.Trim();
            _cod_customer = this.txt_cod_customer.Text.Trim();
            _cod_family = "";
            _quantity = "";
            switch (VoucherNum)
            {
                case 1:
                    _cod_family = this.txt_cod_art1.Text;
                    _quantity = this.txt_units1.Text;
                    _ctl = this.txt_cod_art1;
                    break;
                case 2:
                    _cod_family = this.txt_cod_art2.Text;
                    _quantity = this.txt_units2.Text;
                    _ctl = this.txt_cod_art2;
                    break;
                case 3:
                    _cod_family = this.txt_cod_art3.Text;
                    _quantity = this.txt_units3.Text;
                    _ctl = this.txt_cod_art3;
                    break;
                case 4:
                    _cod_family = this.txt_cod_art4.Text;
                    _quantity = this.txt_units4.Text;
                    _ctl = this.txt_cod_art4;
                    break;
            }

            if (!Cobol_Converter.IsDataOK(_ctl.Text, this.txt_cod_customer.Text))
            {
                errorProvider1.SetError(_ctl, "La familia no pertenece al cliente");

                return;
            }

            if (String.IsNullOrEmpty(_quantity))
            {
                MessageBox.Show("Debe introducir una cantidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            if (Cobol_Converter.PrintVoucher(_id_terminal, _id_operator, _cod_customer, _cod_family.Trim(), _quantity.Trim()))
            {
                _text = "Etiqueta impresa";
                _caption = "Info";
                _icon = MessageBoxIcon.Information;
            }
            else
            {
                _text = "Fallo al imprimir etiqueta";
                _caption = "Error";
                _icon = MessageBoxIcon.Error;
            }

            MessageBox.Show(_text, _caption, MessageBoxButtons.OK, _icon);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Process.Start("shutdown", "/s /t 0");
            this.Close();
        }

        private void txt_units_MouseClick(object sender, MouseEventArgs e)
        {
            Int32 _amount = 0;

            if (((TextBox)sender).Name == this.txt_units1.Name)
            {
                if (String.IsNullOrWhiteSpace(this.txt_cod_art1.Text))
                {
                    return;
                }
            }
            else if (((TextBox)sender).Name == this.txt_units2.Name)
            {
                if (String.IsNullOrWhiteSpace(this.txt_cod_art2.Text))
                {
                    return;
                }
            }
            else if (((TextBox)sender).Name == this.txt_units3.Name)
            {
                if (String.IsNullOrWhiteSpace(this.txt_cod_art3.Text))
                {
                    return;
                }
            }
            else if (((TextBox)sender).Name == this.txt_units4.Name)
            {
                if (String.IsNullOrWhiteSpace(this.txt_cod_art4.Text))
                {
                    return;
                }
            }

            this.m_keypad.Amount = 0;

            if (m_keypad.ShowDialog() == DialogResult.OK)
            {
                ((TextBox)sender).Text = this.m_keypad.Amount.ToString();
            }
        }
    }
}
