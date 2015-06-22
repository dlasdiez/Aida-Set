using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lavanderia
{
    public partial class frm_keypad : Form
    {
        private Int32 m_amount;

        public Int32 Amount
        {
            set { m_amount = value; }
            get { return m_amount; }
        }


        public frm_keypad()
        {
            InitializeComponent();
        }

        private void frm_keypad_Load(object sender, EventArgs e)
        {
            this.lbl_title.Text = "Introduzca Cantidad";
            this.btn_0.Text = "0";
            this.btn_1.Text = "1";
            this.btn_2.Text = "2";
            this.btn_3.Text = "3";
            this.btn_4.Text = "4";
            this.btn_5.Text = "5";
            this.btn_6.Text = "6";
            this.btn_7.Text = "7";
            this.btn_8.Text = "8";
            this.btn_9.Text = "9";

            this.btn_ok.Text = "OK";
            this.btn_cancel.Text = "Cancelar";

            if (this.m_amount > 0)
            {
                this.txt_amount.Text = m_amount.ToString();
            }
            else
            {
                this.txt_amount.Text = "";
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Int32 _value;

            if (Int32.TryParse(((Button)sender).Text, out _value))
            {
                this.txt_amount.Text += ((Button)sender).Text;
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            Int32 _amount = 0;

            Int32.TryParse(this.txt_amount.Text, out _amount);
            if (_amount >= 20)
            {
                return;
            }

            m_amount = _amount;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btn_sup_Click(object sender, EventArgs e)
        {
            Int32 _value;

            if (Int32.TryParse(this.txt_amount.Text, out _value))
            {
                this.txt_amount.Text = this.txt_amount.Text.Remove(this.txt_amount.Text.Length - 1);
            }
        }
    }
}
