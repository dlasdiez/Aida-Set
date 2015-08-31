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
      Configuracion.Config.ReadConfig();
    }

    private void btn_registro_qc_entrada_Click(object sender, EventArgs e)
    {
      frm_registro_qc_entrada _frm;

      _frm = new frm_registro_qc_entrada();
      _frm.ShowDialog();
    }

    private void btn_registro_garantia_tramite_Click(object sender, EventArgs e)
    {
      frm_registro_garantias_tramite _frm;

      _frm = new frm_registro_garantias_tramite();
      _frm.ShowDialog();

    }

    private void btn_expediente_Click(object sender, EventArgs e)
    {
      frm_expediente _frm;

      _frm = new frm_expediente();
      _frm.ShowDialog();
    }

    private void btn_evaluacion_piezas_Click(object sender, EventArgs e)
    {
      frm_evaluacion_piezas _frm;

      _frm = new frm_evaluacion_piezas();
      _frm.ShowDialog();
    }

    private void btn_evaluacion_muestras_report_Click(object sender, EventArgs e)
    {
      frm_evaluacion_muestras_report _frm;

      _frm = new frm_evaluacion_muestras_report();
      _frm.ShowDialog();
    }

    private void btn_evaluacion_muestras_garantia_stock_report_Click(object sender, EventArgs e)
    {
      frm_evaluacion_muestras_garantia_stock_report _frm;

      _frm = new frm_evaluacion_muestras_garantia_stock_report();
      _frm.ShowDialog();
    }

    private void btn_configuracion_Click(object sender, EventArgs e)
    {
      frm_configuracion _frm;

      _frm = new frm_configuracion();
      _frm.ShowDialog();
    }

    private void btn_permisos_Click(object sender, EventArgs e)
    {
      frm_permisos_list _frm;

      _frm = new frm_permisos_list();
      _frm.ShowDialog();
    }
  }
}
