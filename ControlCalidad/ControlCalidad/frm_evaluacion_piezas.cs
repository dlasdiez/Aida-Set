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
  public partial class frm_evaluacion_piezas : Form
  {
    public frm_evaluacion_piezas()
    {
      InitializeComponent();
    }

    private void frm_evaluacion_piezas_Load(object sender, EventArgs e)
    {

      this.dtp_entregado_en_fecha.Value = DateTime.Now;
      this.dtp_fecha_creacion.Value = DateTime.Now;
      this.dtp_fecha_lineas.Value = DateTime.Now;
      this.dtp_fecha_recepcion.Value = DateTime.Now;

      this.cmb_informe.DisplayMember = "Text";
      this.cmb_informe.ValueMember = "Value";
      this.cmb_informe.Items.Add(new { Text = "No", Value = 0 });
      this.cmb_informe.Items.Add(new { Text = "Si", Value = 1 });
      this.cmb_informe.SelectedIndex = 0;

      this.cmb_abonar.DisplayMember = "Text";
      this.cmb_abonar.ValueMember = "Value";
      this.cmb_abonar.Items.Add(new { Text = "No", Value = 0 });
      this.cmb_abonar.Items.Add(new { Text = "Si", Value = 1 });
      this.cmb_abonar.SelectedIndex = 0;

      this.cmb_analisis_ot.DisplayMember = "Text";
      this.cmb_analisis_ot.ValueMember = "Value";
      this.cmb_analisis_ot.Items.Add(new { Text = "No", Value = 0 });
      this.cmb_analisis_ot.Items.Add(new { Text = "Si", Value = 1 });
      this.cmb_analisis_ot.SelectedIndex = 0;

      this.cmb_doc_cliente.DisplayMember = "Text";
      this.cmb_doc_cliente.ValueMember = "Value";
      this.cmb_doc_cliente.Items.Add(new { Text = "No", Value = 0 });
      this.cmb_doc_cliente.Items.Add(new { Text = "Si", Value = 1 });
      this.cmb_doc_cliente.SelectedIndex = 0;

      this.cmb_informe_ot.DisplayMember = "Text";
      this.cmb_informe_ot.ValueMember = "Value";
      this.cmb_informe_ot.Items.Add(new { Text = "No", Value = 0 });
      this.cmb_informe_ot.Items.Add(new { Text = "Si", Value = 1 });
      this.cmb_informe_ot.SelectedIndex = 0;

      this.cmb_via.DisplayMember = "Text";
      this.cmb_via.ValueMember = "Value";
      this.cmb_via.Items.Add(new { Text = "Interna", Value = 0 });
      this.cmb_via.Items.Add(new { Text = "Externa", Value = 1 });
      this.cmb_via.Items.Add(new { Text = "Ambas", Value = 2 });
      this.cmb_via.SelectedIndex = 0;

      this.cmb_estado.DisplayMember = "Text";
      this.cmb_estado.ValueMember = "Value";
      this.cmb_estado.Items.Add(new { Text = "Pendiente", Value = 0 });
      this.cmb_estado.Items.Add(new { Text = "Proceso", Value = 1 });
      this.cmb_estado.Items.Add(new { Text = "Finalizado", Value = 2 });
      this.cmb_estado.SelectedIndex = 0;

    }
  }
}
