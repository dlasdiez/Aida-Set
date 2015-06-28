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
    public partial class frm_registro_qc_entrada : Form
    {
        public frm_registro_qc_entrada()
        {
            InitializeComponent();
        }

        private void frm_registro_qc_entrada_Load(object sender, EventArgs e)
        {
            this.dtp_fecha_revision.Value = DateTime.Now;
            this.dtp_fecha_calidad.Value = DateTime.Now;
        }
    }
}
