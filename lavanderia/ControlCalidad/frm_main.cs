using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControlCalidad
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void btn_registro_qc_entrada_Click(object sender, EventArgs e)
        {
            frm_registro_qc_entrada _frm;

            _frm = new frm_registro_qc_entrada();
            _frm.ShowDialog();
        }
    }
}
