﻿namespace ControlCalidad
{
  partial class frm_registro_qc_entrada_edit
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
			this.txt_num_registro = new System.Windows.Forms.TextBox();
			this.lbl_num_registro = new System.Windows.Forms.Label();
			this.lbl_date_revision = new System.Windows.Forms.Label();
			this.dtp_fecha_revision = new System.Windows.Forms.DateTimePicker();
			this.lbl_ref_metalcaucho = new System.Windows.Forms.Label();
			this.txt_ref_metalcaucho = new System.Windows.Forms.TextBox();
			this.lbl_proveedor = new System.Windows.Forms.Label();
			this.txt_proveedor = new System.Windows.Forms.TextBox();
			this.lbl_num_lote = new System.Windows.Forms.Label();
			this.txt_num_lote = new System.Windows.Forms.TextBox();
			this.lbl_num_pl = new System.Windows.Forms.Label();
			this.txt_num_pl = new System.Windows.Forms.TextBox();
			this.lbl_num_recibidas = new System.Windows.Forms.Label();
			this.txt_num_recibidas = new System.Windows.Forms.TextBox();
			this.gb_resultado = new System.Windows.Forms.GroupBox();
			this.ch_rj = new System.Windows.Forms.CheckBox();
			this.ch_hl = new System.Windows.Forms.CheckBox();
			this.ch_ok = new System.Windows.Forms.CheckBox();
			this.lbl_verificador = new System.Windows.Forms.Label();
			this.txt_verificador = new System.Windows.Forms.TextBox();
			this.lbl_almacen = new System.Windows.Forms.Label();
			this.txt_almacen = new System.Windows.Forms.TextBox();
			this.dgv_verificacion = new System.Windows.Forms.DataGridView();
			this.txt_observaciones = new System.Windows.Forms.TextBox();
			this.lbl_observaciones = new System.Windows.Forms.Label();
			this.ch_revisar_qa = new System.Windows.Forms.CheckBox();
			this.lbl_num_verificadas = new System.Windows.Forms.Label();
			this.txt_num_verificadas = new System.Windows.Forms.TextBox();
			this.ch_visualizar_pautas_autocontrol = new System.Windows.Forms.CheckBox();
			this.ch_banco_pruebas = new System.Windows.Forms.CheckBox();
			this.gb_muestreo = new System.Windows.Forms.GroupBox();
			this.tc_datos = new System.Windows.Forms.TabControl();
			this.tp_entradas = new System.Windows.Forms.TabPage();
			this.gb_metodo_verificacion = new System.Windows.Forms.GroupBox();
			this.btn_eliminar_verificacion = new System.Windows.Forms.Button();
			this.btn_añadir_verificacion = new System.Windows.Forms.Button();
			this.tp_images = new System.Windows.Forms.TabPage();
			this.btn_borrar_ruta_doc = new System.Windows.Forms.Button();
			this.btn_añadir_ruta_doc = new System.Windows.Forms.Button();
			this.txt_documento = new System.Windows.Forms.TextBox();
			this.lbl_documento = new System.Windows.Forms.Label();
			this.pb5 = new System.Windows.Forms.PictureBox();
			this.pb4 = new System.Windows.Forms.PictureBox();
			this.pb2 = new System.Windows.Forms.PictureBox();
			this.pb3 = new System.Windows.Forms.PictureBox();
			this.pb1 = new System.Windows.Forms.PictureBox();
			this.tp_calidad = new System.Windows.Forms.TabPage();
			this.btn_eliminar_certificado = new System.Windows.Forms.Button();
			this.btn_añadir_certificado = new System.Windows.Forms.Button();
			this.lbl_certificados = new System.Windows.Forms.Label();
			this.dtp_fecha_calidad = new System.Windows.Forms.DateTimePicker();
			this.txt_certificados = new System.Windows.Forms.TextBox();
			this.lbl_fecha_calidad = new System.Windows.Forms.Label();
			this.lbl_accion_realizada = new System.Windows.Forms.Label();
			this.txt_acciones = new System.Windows.Forms.TextBox();
			this.dtp_fecha_creacion = new System.Windows.Forms.DateTimePicker();
			this.lbl_fecha_creacion = new System.Windows.Forms.Label();
			this.lbl_usuario = new System.Windows.Forms.Label();
			this.txt_usuario = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
			this.gb_resultado.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_verificacion)).BeginInit();
			this.gb_muestreo.SuspendLayout();
			this.tc_datos.SuspendLayout();
			this.tp_entradas.SuspendLayout();
			this.gb_metodo_verificacion.SuspendLayout();
			this.tp_images.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
			this.tp_calidad.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_salir
			// 
			this.btn_salir.Location = new System.Drawing.Point(13, 364);
			// 
			// btn_guardar
			// 
			this.btn_guardar.Location = new System.Drawing.Point(13, 313);
			// 
			// pnl_contenedor
			// 
			this.pnl_contenedor.Size = new System.Drawing.Size(810, 424);
			// 
			// txt_num_registro
			// 
			this.txt_num_registro.Location = new System.Drawing.Point(84, 28);
			this.txt_num_registro.Name = "txt_num_registro";
			this.txt_num_registro.Size = new System.Drawing.Size(100, 20);
			this.txt_num_registro.TabIndex = 0;
			// 
			// lbl_num_registro
			// 
			this.lbl_num_registro.AutoSize = true;
			this.lbl_num_registro.Location = new System.Drawing.Point(17, 31);
			this.lbl_num_registro.Name = "lbl_num_registro";
			this.lbl_num_registro.Size = new System.Drawing.Size(61, 13);
			this.lbl_num_registro.TabIndex = 1;
			this.lbl_num_registro.Text = "Nº Registro";
			// 
			// lbl_date_revision
			// 
			this.lbl_date_revision.AutoSize = true;
			this.lbl_date_revision.Location = new System.Drawing.Point(200, 54);
			this.lbl_date_revision.Name = "lbl_date_revision";
			this.lbl_date_revision.Size = new System.Drawing.Size(81, 13);
			this.lbl_date_revision.TabIndex = 2;
			this.lbl_date_revision.Text = "Fecha Revision";
			// 
			// dtp_fecha_revision
			// 
			this.dtp_fecha_revision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_fecha_revision.Location = new System.Drawing.Point(287, 51);
			this.dtp_fecha_revision.Name = "dtp_fecha_revision";
			this.dtp_fecha_revision.Size = new System.Drawing.Size(100, 20);
			this.dtp_fecha_revision.TabIndex = 3;
			// 
			// lbl_ref_metalcaucho
			// 
			this.lbl_ref_metalcaucho.AutoSize = true;
			this.lbl_ref_metalcaucho.Location = new System.Drawing.Point(410, 58);
			this.lbl_ref_metalcaucho.Name = "lbl_ref_metalcaucho";
			this.lbl_ref_metalcaucho.Size = new System.Drawing.Size(43, 13);
			this.lbl_ref_metalcaucho.TabIndex = 5;
			this.lbl_ref_metalcaucho.Text = "Ref MC";
			// 
			// txt_ref_metalcaucho
			// 
			this.txt_ref_metalcaucho.Location = new System.Drawing.Point(459, 51);
			this.txt_ref_metalcaucho.Name = "txt_ref_metalcaucho";
			this.txt_ref_metalcaucho.Size = new System.Drawing.Size(100, 20);
			this.txt_ref_metalcaucho.TabIndex = 4;
			// 
			// lbl_proveedor
			// 
			this.lbl_proveedor.AutoSize = true;
			this.lbl_proveedor.Location = new System.Drawing.Point(22, 57);
			this.lbl_proveedor.Name = "lbl_proveedor";
			this.lbl_proveedor.Size = new System.Drawing.Size(56, 13);
			this.lbl_proveedor.TabIndex = 7;
			this.lbl_proveedor.Text = "Proveedor";
			// 
			// txt_proveedor
			// 
			this.txt_proveedor.Location = new System.Drawing.Point(84, 54);
			this.txt_proveedor.Name = "txt_proveedor";
			this.txt_proveedor.Size = new System.Drawing.Size(100, 20);
			this.txt_proveedor.TabIndex = 6;
			// 
			// lbl_num_lote
			// 
			this.lbl_num_lote.AutoSize = true;
			this.lbl_num_lote.Location = new System.Drawing.Point(238, 80);
			this.lbl_num_lote.Name = "lbl_num_lote";
			this.lbl_num_lote.Size = new System.Drawing.Size(43, 13);
			this.lbl_num_lote.TabIndex = 9;
			this.lbl_num_lote.Text = "Nº Lote";
			// 
			// txt_num_lote
			// 
			this.txt_num_lote.Location = new System.Drawing.Point(287, 77);
			this.txt_num_lote.Name = "txt_num_lote";
			this.txt_num_lote.Size = new System.Drawing.Size(100, 20);
			this.txt_num_lote.TabIndex = 8;
			// 
			// lbl_num_pl
			// 
			this.lbl_num_pl.AutoSize = true;
			this.lbl_num_pl.Location = new System.Drawing.Point(415, 80);
			this.lbl_num_pl.Name = "lbl_num_pl";
			this.lbl_num_pl.Size = new System.Drawing.Size(38, 13);
			this.lbl_num_pl.TabIndex = 11;
			this.lbl_num_pl.Text = "Nº P.L";
			// 
			// txt_num_pl
			// 
			this.txt_num_pl.Location = new System.Drawing.Point(459, 77);
			this.txt_num_pl.Name = "txt_num_pl";
			this.txt_num_pl.Size = new System.Drawing.Size(100, 20);
			this.txt_num_pl.TabIndex = 10;
			// 
			// lbl_num_recibidas
			// 
			this.lbl_num_recibidas.AutoSize = true;
			this.lbl_num_recibidas.Location = new System.Drawing.Point(14, 19);
			this.lbl_num_recibidas.Name = "lbl_num_recibidas";
			this.lbl_num_recibidas.Size = new System.Drawing.Size(82, 13);
			this.lbl_num_recibidas.TabIndex = 13;
			this.lbl_num_recibidas.Text = "Num. Recibidos";
			// 
			// txt_num_recibidas
			// 
			this.txt_num_recibidas.Location = new System.Drawing.Point(102, 16);
			this.txt_num_recibidas.Name = "txt_num_recibidas";
			this.txt_num_recibidas.Size = new System.Drawing.Size(100, 20);
			this.txt_num_recibidas.TabIndex = 12;
			// 
			// gb_resultado
			// 
			this.gb_resultado.Controls.Add(this.ch_rj);
			this.gb_resultado.Controls.Add(this.ch_hl);
			this.gb_resultado.Controls.Add(this.ch_ok);
			this.gb_resultado.Location = new System.Drawing.Point(25, 80);
			this.gb_resultado.Name = "gb_resultado";
			this.gb_resultado.Size = new System.Drawing.Size(149, 50);
			this.gb_resultado.TabIndex = 14;
			this.gb_resultado.TabStop = false;
			this.gb_resultado.Text = "Resultado";
			// 
			// ch_rj
			// 
			this.ch_rj.AutoSize = true;
			this.ch_rj.Location = new System.Drawing.Point(99, 19);
			this.ch_rj.Name = "ch_rj";
			this.ch_rj.Size = new System.Drawing.Size(39, 17);
			this.ch_rj.TabIndex = 2;
			this.ch_rj.Text = "RJ";
			this.ch_rj.UseVisualStyleBackColor = true;
			// 
			// ch_hl
			// 
			this.ch_hl.AutoSize = true;
			this.ch_hl.Location = new System.Drawing.Point(53, 19);
			this.ch_hl.Name = "ch_hl";
			this.ch_hl.Size = new System.Drawing.Size(40, 17);
			this.ch_hl.TabIndex = 1;
			this.ch_hl.Text = "HL";
			this.ch_hl.UseVisualStyleBackColor = true;
			// 
			// ch_ok
			// 
			this.ch_ok.AutoSize = true;
			this.ch_ok.Location = new System.Drawing.Point(6, 19);
			this.ch_ok.Name = "ch_ok";
			this.ch_ok.Size = new System.Drawing.Size(41, 17);
			this.ch_ok.TabIndex = 0;
			this.ch_ok.Text = "OK";
			this.ch_ok.UseVisualStyleBackColor = true;
			// 
			// lbl_verificador
			// 
			this.lbl_verificador.AutoSize = true;
			this.lbl_verificador.Location = new System.Drawing.Point(18, 18);
			this.lbl_verificador.Name = "lbl_verificador";
			this.lbl_verificador.Size = new System.Drawing.Size(57, 13);
			this.lbl_verificador.TabIndex = 16;
			this.lbl_verificador.Text = "Verificador";
			// 
			// txt_verificador
			// 
			this.txt_verificador.Location = new System.Drawing.Point(81, 15);
			this.txt_verificador.Name = "txt_verificador";
			this.txt_verificador.Size = new System.Drawing.Size(100, 20);
			this.txt_verificador.TabIndex = 15;
			// 
			// lbl_almacen
			// 
			this.lbl_almacen.AutoSize = true;
			this.lbl_almacen.Location = new System.Drawing.Point(236, 18);
			this.lbl_almacen.Name = "lbl_almacen";
			this.lbl_almacen.Size = new System.Drawing.Size(48, 13);
			this.lbl_almacen.TabIndex = 18;
			this.lbl_almacen.Text = "Almacén";
			// 
			// txt_almacen
			// 
			this.txt_almacen.Location = new System.Drawing.Point(290, 15);
			this.txt_almacen.Name = "txt_almacen";
			this.txt_almacen.Size = new System.Drawing.Size(100, 20);
			this.txt_almacen.TabIndex = 17;
			// 
			// dgv_verificacion
			// 
			this.dgv_verificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_verificacion.Location = new System.Drawing.Point(16, 19);
			this.dgv_verificacion.Name = "dgv_verificacion";
			this.dgv_verificacion.Size = new System.Drawing.Size(178, 102);
			this.dgv_verificacion.TabIndex = 21;
			// 
			// txt_observaciones
			// 
			this.txt_observaciones.Location = new System.Drawing.Point(54, 89);
			this.txt_observaciones.Multiline = true;
			this.txt_observaciones.Name = "txt_observaciones";
			this.txt_observaciones.Size = new System.Drawing.Size(366, 103);
			this.txt_observaciones.TabIndex = 22;
			// 
			// lbl_observaciones
			// 
			this.lbl_observaciones.AutoSize = true;
			this.lbl_observaciones.Location = new System.Drawing.Point(193, 68);
			this.lbl_observaciones.Name = "lbl_observaciones";
			this.lbl_observaciones.Size = new System.Drawing.Size(78, 13);
			this.lbl_observaciones.TabIndex = 23;
			this.lbl_observaciones.Text = "Observaciones";
			// 
			// ch_revisar_qa
			// 
			this.ch_revisar_qa.AutoSize = true;
			this.ch_revisar_qa.Location = new System.Drawing.Point(127, 221);
			this.ch_revisar_qa.Name = "ch_revisar_qa";
			this.ch_revisar_qa.Size = new System.Drawing.Size(100, 17);
			this.ch_revisar_qa.TabIndex = 3;
			this.ch_revisar_qa.Text = "Revisar Calidad";
			this.ch_revisar_qa.UseVisualStyleBackColor = true;
			// 
			// lbl_num_verificadas
			// 
			this.lbl_num_verificadas.AutoSize = true;
			this.lbl_num_verificadas.Location = new System.Drawing.Point(14, 45);
			this.lbl_num_verificadas.Name = "lbl_num_verificadas";
			this.lbl_num_verificadas.Size = new System.Drawing.Size(87, 13);
			this.lbl_num_verificadas.TabIndex = 25;
			this.lbl_num_verificadas.Text = "Num. Verificadas";
			// 
			// txt_num_verificadas
			// 
			this.txt_num_verificadas.Location = new System.Drawing.Point(102, 42);
			this.txt_num_verificadas.Name = "txt_num_verificadas";
			this.txt_num_verificadas.Size = new System.Drawing.Size(100, 20);
			this.txt_num_verificadas.TabIndex = 24;
			// 
			// ch_visualizar_pautas_autocontrol
			// 
			this.ch_visualizar_pautas_autocontrol.AutoSize = true;
			this.ch_visualizar_pautas_autocontrol.Location = new System.Drawing.Point(290, 221);
			this.ch_visualizar_pautas_autocontrol.Name = "ch_visualizar_pautas_autocontrol";
			this.ch_visualizar_pautas_autocontrol.Size = new System.Drawing.Size(161, 17);
			this.ch_visualizar_pautas_autocontrol.TabIndex = 26;
			this.ch_visualizar_pautas_autocontrol.Text = "Visualizar pautas autocontrol";
			this.ch_visualizar_pautas_autocontrol.UseVisualStyleBackColor = true;
			// 
			// ch_banco_pruebas
			// 
			this.ch_banco_pruebas.AutoSize = true;
			this.ch_banco_pruebas.Location = new System.Drawing.Point(486, 221);
			this.ch_banco_pruebas.Name = "ch_banco_pruebas";
			this.ch_banco_pruebas.Size = new System.Drawing.Size(150, 17);
			this.ch_banco_pruebas.TabIndex = 27;
			this.ch_banco_pruebas.Text = "Solicitud banco de prueba";
			this.ch_banco_pruebas.UseVisualStyleBackColor = true;
			// 
			// gb_muestreo
			// 
			this.gb_muestreo.Controls.Add(this.lbl_num_recibidas);
			this.gb_muestreo.Controls.Add(this.txt_num_recibidas);
			this.gb_muestreo.Controls.Add(this.lbl_num_verificadas);
			this.gb_muestreo.Controls.Add(this.txt_num_verificadas);
			this.gb_muestreo.Location = new System.Drawing.Point(586, 12);
			this.gb_muestreo.Name = "gb_muestreo";
			this.gb_muestreo.Size = new System.Drawing.Size(217, 75);
			this.gb_muestreo.TabIndex = 28;
			this.gb_muestreo.TabStop = false;
			this.gb_muestreo.Text = "Muestreo";
			// 
			// tc_datos
			// 
			this.tc_datos.Controls.Add(this.tp_entradas);
			this.tc_datos.Controls.Add(this.tp_images);
			this.tc_datos.Controls.Add(this.tp_calidad);
			this.tc_datos.Location = new System.Drawing.Point(20, 136);
			this.tc_datos.Name = "tc_datos";
			this.tc_datos.SelectedIndex = 0;
			this.tc_datos.Size = new System.Drawing.Size(783, 280);
			this.tc_datos.TabIndex = 29;
			// 
			// tp_entradas
			// 
			this.tp_entradas.BackColor = System.Drawing.Color.RoyalBlue;
			this.tp_entradas.Controls.Add(this.gb_metodo_verificacion);
			this.tp_entradas.Controls.Add(this.txt_verificador);
			this.tp_entradas.Controls.Add(this.ch_banco_pruebas);
			this.tp_entradas.Controls.Add(this.lbl_verificador);
			this.tp_entradas.Controls.Add(this.ch_visualizar_pautas_autocontrol);
			this.tp_entradas.Controls.Add(this.ch_revisar_qa);
			this.tp_entradas.Controls.Add(this.txt_almacen);
			this.tp_entradas.Controls.Add(this.lbl_almacen);
			this.tp_entradas.Controls.Add(this.lbl_observaciones);
			this.tp_entradas.Controls.Add(this.txt_observaciones);
			this.tp_entradas.Location = new System.Drawing.Point(4, 22);
			this.tp_entradas.Name = "tp_entradas";
			this.tp_entradas.Padding = new System.Windows.Forms.Padding(3);
			this.tp_entradas.Size = new System.Drawing.Size(775, 254);
			this.tp_entradas.TabIndex = 0;
			this.tp_entradas.Text = "Entradas";
			// 
			// gb_metodo_verificacion
			// 
			this.gb_metodo_verificacion.Controls.Add(this.dgv_verificacion);
			this.gb_metodo_verificacion.Controls.Add(this.btn_eliminar_verificacion);
			this.gb_metodo_verificacion.Controls.Add(this.btn_añadir_verificacion);
			this.gb_metodo_verificacion.Location = new System.Drawing.Point(459, 15);
			this.gb_metodo_verificacion.Name = "gb_metodo_verificacion";
			this.gb_metodo_verificacion.Size = new System.Drawing.Size(286, 146);
			this.gb_metodo_verificacion.TabIndex = 24;
			this.gb_metodo_verificacion.TabStop = false;
			this.gb_metodo_verificacion.Text = "Método verificación";
			this.gb_metodo_verificacion.Visible = false;
			// 
			// btn_eliminar_verificacion
			// 
			this.btn_eliminar_verificacion.Location = new System.Drawing.Point(200, 48);
			this.btn_eliminar_verificacion.Name = "btn_eliminar_verificacion";
			this.btn_eliminar_verificacion.Size = new System.Drawing.Size(75, 23);
			this.btn_eliminar_verificacion.TabIndex = 23;
			this.btn_eliminar_verificacion.Text = "Eliminar";
			this.btn_eliminar_verificacion.UseVisualStyleBackColor = true;
			// 
			// btn_añadir_verificacion
			// 
			this.btn_añadir_verificacion.Location = new System.Drawing.Point(200, 19);
			this.btn_añadir_verificacion.Name = "btn_añadir_verificacion";
			this.btn_añadir_verificacion.Size = new System.Drawing.Size(75, 23);
			this.btn_añadir_verificacion.TabIndex = 22;
			this.btn_añadir_verificacion.Text = "Añadir";
			this.btn_añadir_verificacion.UseVisualStyleBackColor = true;
			// 
			// tp_images
			// 
			this.tp_images.BackColor = System.Drawing.Color.RoyalBlue;
			this.tp_images.Controls.Add(this.btn_borrar_ruta_doc);
			this.tp_images.Controls.Add(this.btn_añadir_ruta_doc);
			this.tp_images.Controls.Add(this.txt_documento);
			this.tp_images.Controls.Add(this.lbl_documento);
			this.tp_images.Controls.Add(this.pb5);
			this.tp_images.Controls.Add(this.pb4);
			this.tp_images.Controls.Add(this.pb2);
			this.tp_images.Controls.Add(this.pb3);
			this.tp_images.Controls.Add(this.pb1);
			this.tp_images.Location = new System.Drawing.Point(4, 22);
			this.tp_images.Name = "tp_images";
			this.tp_images.Padding = new System.Windows.Forms.Padding(3);
			this.tp_images.Size = new System.Drawing.Size(775, 254);
			this.tp_images.TabIndex = 1;
			this.tp_images.Text = "Imagenes";
			// 
			// btn_borrar_ruta_doc
			// 
			this.btn_borrar_ruta_doc.Location = new System.Drawing.Point(335, 202);
			this.btn_borrar_ruta_doc.Name = "btn_borrar_ruta_doc";
			this.btn_borrar_ruta_doc.Size = new System.Drawing.Size(75, 23);
			this.btn_borrar_ruta_doc.TabIndex = 70;
			this.btn_borrar_ruta_doc.Text = "Eliminar";
			this.btn_borrar_ruta_doc.UseVisualStyleBackColor = true;
			this.btn_borrar_ruta_doc.Visible = false;
			// 
			// btn_añadir_ruta_doc
			// 
			this.btn_añadir_ruta_doc.Location = new System.Drawing.Point(335, 173);
			this.btn_añadir_ruta_doc.Name = "btn_añadir_ruta_doc";
			this.btn_añadir_ruta_doc.Size = new System.Drawing.Size(75, 23);
			this.btn_añadir_ruta_doc.TabIndex = 69;
			this.btn_añadir_ruta_doc.Text = "Añadir";
			this.btn_añadir_ruta_doc.UseVisualStyleBackColor = true;
			this.btn_añadir_ruta_doc.Visible = false;
			// 
			// txt_documento
			// 
			this.txt_documento.Location = new System.Drawing.Point(83, 173);
			this.txt_documento.Name = "txt_documento";
			this.txt_documento.Size = new System.Drawing.Size(246, 20);
			this.txt_documento.TabIndex = 67;
			this.txt_documento.Visible = false;
			// 
			// lbl_documento
			// 
			this.lbl_documento.AutoSize = true;
			this.lbl_documento.Location = new System.Drawing.Point(14, 176);
			this.lbl_documento.Name = "lbl_documento";
			this.lbl_documento.Size = new System.Drawing.Size(62, 13);
			this.lbl_documento.TabIndex = 68;
			this.lbl_documento.Text = "Documento";
			this.lbl_documento.Visible = false;
			// 
			// pb5
			// 
			this.pb5.Location = new System.Drawing.Point(629, 19);
			this.pb5.Name = "pb5";
			this.pb5.Size = new System.Drawing.Size(135, 93);
			this.pb5.TabIndex = 4;
			this.pb5.TabStop = false;
			// 
			// pb4
			// 
			this.pb4.Location = new System.Drawing.Point(477, 19);
			this.pb4.Name = "pb4";
			this.pb4.Size = new System.Drawing.Size(135, 93);
			this.pb4.TabIndex = 3;
			this.pb4.TabStop = false;
			// 
			// pb2
			// 
			this.pb2.Location = new System.Drawing.Point(166, 19);
			this.pb2.Name = "pb2";
			this.pb2.Size = new System.Drawing.Size(135, 93);
			this.pb2.TabIndex = 2;
			this.pb2.TabStop = false;
			// 
			// pb3
			// 
			this.pb3.Location = new System.Drawing.Point(321, 19);
			this.pb3.Name = "pb3";
			this.pb3.Size = new System.Drawing.Size(135, 93);
			this.pb3.TabIndex = 1;
			this.pb3.TabStop = false;
			// 
			// pb1
			// 
			this.pb1.Location = new System.Drawing.Point(14, 19);
			this.pb1.Name = "pb1";
			this.pb1.Size = new System.Drawing.Size(135, 93);
			this.pb1.TabIndex = 0;
			this.pb1.TabStop = false;
			// 
			// tp_calidad
			// 
			this.tp_calidad.BackColor = System.Drawing.Color.RoyalBlue;
			this.tp_calidad.Controls.Add(this.btn_eliminar_certificado);
			this.tp_calidad.Controls.Add(this.btn_añadir_certificado);
			this.tp_calidad.Controls.Add(this.lbl_certificados);
			this.tp_calidad.Controls.Add(this.dtp_fecha_calidad);
			this.tp_calidad.Controls.Add(this.txt_certificados);
			this.tp_calidad.Controls.Add(this.lbl_fecha_calidad);
			this.tp_calidad.Controls.Add(this.lbl_accion_realizada);
			this.tp_calidad.Controls.Add(this.txt_acciones);
			this.tp_calidad.Location = new System.Drawing.Point(4, 22);
			this.tp_calidad.Name = "tp_calidad";
			this.tp_calidad.Padding = new System.Windows.Forms.Padding(3);
			this.tp_calidad.Size = new System.Drawing.Size(775, 254);
			this.tp_calidad.TabIndex = 2;
			this.tp_calidad.Text = "Calidad";
			// 
			// btn_eliminar_certificado
			// 
			this.btn_eliminar_certificado.Location = new System.Drawing.Point(605, 187);
			this.btn_eliminar_certificado.Name = "btn_eliminar_certificado";
			this.btn_eliminar_certificado.Size = new System.Drawing.Size(75, 23);
			this.btn_eliminar_certificado.TabIndex = 72;
			this.btn_eliminar_certificado.Text = "Eliminar";
			this.btn_eliminar_certificado.UseVisualStyleBackColor = true;
			// 
			// btn_añadir_certificado
			// 
			this.btn_añadir_certificado.Location = new System.Drawing.Point(605, 158);
			this.btn_añadir_certificado.Name = "btn_añadir_certificado";
			this.btn_añadir_certificado.Size = new System.Drawing.Size(75, 23);
			this.btn_añadir_certificado.TabIndex = 71;
			this.btn_añadir_certificado.Text = "Añadir";
			this.btn_añadir_certificado.UseVisualStyleBackColor = true;
			// 
			// lbl_certificados
			// 
			this.lbl_certificados.AutoSize = true;
			this.lbl_certificados.Location = new System.Drawing.Point(18, 163);
			this.lbl_certificados.Name = "lbl_certificados";
			this.lbl_certificados.Size = new System.Drawing.Size(113, 13);
			this.lbl_certificados.TabIndex = 32;
			this.lbl_certificados.Text = "Ubicación Certificados";
			// 
			// dtp_fecha_calidad
			// 
			this.dtp_fecha_calidad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_fecha_calidad.Location = new System.Drawing.Point(137, 115);
			this.dtp_fecha_calidad.Name = "dtp_fecha_calidad";
			this.dtp_fecha_calidad.Size = new System.Drawing.Size(100, 20);
			this.dtp_fecha_calidad.TabIndex = 32;
			// 
			// txt_certificados
			// 
			this.txt_certificados.Location = new System.Drawing.Point(137, 160);
			this.txt_certificados.Name = "txt_certificados";
			this.txt_certificados.Size = new System.Drawing.Size(462, 20);
			this.txt_certificados.TabIndex = 31;
			// 
			// lbl_fecha_calidad
			// 
			this.lbl_fecha_calidad.AutoSize = true;
			this.lbl_fecha_calidad.Location = new System.Drawing.Point(57, 118);
			this.lbl_fecha_calidad.Name = "lbl_fecha_calidad";
			this.lbl_fecha_calidad.Size = new System.Drawing.Size(75, 13);
			this.lbl_fecha_calidad.TabIndex = 31;
			this.lbl_fecha_calidad.Text = "Fecha Calidad";
			// 
			// lbl_accion_realizada
			// 
			this.lbl_accion_realizada.AutoSize = true;
			this.lbl_accion_realizada.Location = new System.Drawing.Point(80, 9);
			this.lbl_accion_realizada.Name = "lbl_accion_realizada";
			this.lbl_accion_realizada.Size = new System.Drawing.Size(51, 13);
			this.lbl_accion_realizada.TabIndex = 31;
			this.lbl_accion_realizada.Text = "Acciones";
			// 
			// txt_acciones
			// 
			this.txt_acciones.Location = new System.Drawing.Point(137, 6);
			this.txt_acciones.Multiline = true;
			this.txt_acciones.Name = "txt_acciones";
			this.txt_acciones.Size = new System.Drawing.Size(627, 103);
			this.txt_acciones.TabIndex = 23;
			// 
			// dtp_fecha_creacion
			// 
			this.dtp_fecha_creacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_fecha_creacion.Location = new System.Drawing.Point(287, 25);
			this.dtp_fecha_creacion.Name = "dtp_fecha_creacion";
			this.dtp_fecha_creacion.Size = new System.Drawing.Size(100, 20);
			this.dtp_fecha_creacion.TabIndex = 33;
			// 
			// lbl_fecha_creacion
			// 
			this.lbl_fecha_creacion.AutoSize = true;
			this.lbl_fecha_creacion.Location = new System.Drawing.Point(199, 28);
			this.lbl_fecha_creacion.Name = "lbl_fecha_creacion";
			this.lbl_fecha_creacion.Size = new System.Drawing.Size(82, 13);
			this.lbl_fecha_creacion.TabIndex = 32;
			this.lbl_fecha_creacion.Text = "Fecha Creación";
			// 
			// lbl_usuario
			// 
			this.lbl_usuario.AutoSize = true;
			this.lbl_usuario.Location = new System.Drawing.Point(410, 31);
			this.lbl_usuario.Name = "lbl_usuario";
			this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
			this.lbl_usuario.TabIndex = 35;
			this.lbl_usuario.Text = "Usuario";
			// 
			// txt_usuario
			// 
			this.txt_usuario.Location = new System.Drawing.Point(459, 28);
			this.txt_usuario.Name = "txt_usuario";
			this.txt_usuario.Size = new System.Drawing.Size(100, 20);
			this.txt_usuario.TabIndex = 34;
			// 
			// frm_registro_qc_entrada_edit
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(931, 424);
			this.Controls.Add(this.lbl_usuario);
			this.Controls.Add(this.txt_usuario);
			this.Controls.Add(this.dtp_fecha_creacion);
			this.Controls.Add(this.lbl_fecha_creacion);
			this.Controls.Add(this.tc_datos);
			this.Controls.Add(this.gb_muestreo);
			this.Controls.Add(this.gb_resultado);
			this.Controls.Add(this.lbl_num_pl);
			this.Controls.Add(this.txt_num_pl);
			this.Controls.Add(this.lbl_num_lote);
			this.Controls.Add(this.txt_num_lote);
			this.Controls.Add(this.lbl_proveedor);
			this.Controls.Add(this.txt_proveedor);
			this.Controls.Add(this.lbl_ref_metalcaucho);
			this.Controls.Add(this.txt_ref_metalcaucho);
			this.Controls.Add(this.dtp_fecha_revision);
			this.Controls.Add(this.lbl_date_revision);
			this.Controls.Add(this.lbl_num_registro);
			this.Controls.Add(this.txt_num_registro);
			this.Name = "frm_registro_qc_entrada_edit";
			this.Text = "xRegistro Q.C. entrada";
			this.Load += new System.EventHandler(this.frm_registro_qc_entrada_Load);
			this.Controls.SetChildIndex(this.pnl_contenedor, 0);
			this.Controls.SetChildIndex(this.txt_num_registro, 0);
			this.Controls.SetChildIndex(this.lbl_num_registro, 0);
			this.Controls.SetChildIndex(this.lbl_date_revision, 0);
			this.Controls.SetChildIndex(this.dtp_fecha_revision, 0);
			this.Controls.SetChildIndex(this.txt_ref_metalcaucho, 0);
			this.Controls.SetChildIndex(this.lbl_ref_metalcaucho, 0);
			this.Controls.SetChildIndex(this.txt_proveedor, 0);
			this.Controls.SetChildIndex(this.lbl_proveedor, 0);
			this.Controls.SetChildIndex(this.txt_num_lote, 0);
			this.Controls.SetChildIndex(this.lbl_num_lote, 0);
			this.Controls.SetChildIndex(this.txt_num_pl, 0);
			this.Controls.SetChildIndex(this.lbl_num_pl, 0);
			this.Controls.SetChildIndex(this.gb_resultado, 0);
			this.Controls.SetChildIndex(this.gb_muestreo, 0);
			this.Controls.SetChildIndex(this.tc_datos, 0);
			this.Controls.SetChildIndex(this.lbl_fecha_creacion, 0);
			this.Controls.SetChildIndex(this.dtp_fecha_creacion, 0);
			this.Controls.SetChildIndex(this.txt_usuario, 0);
			this.Controls.SetChildIndex(this.lbl_usuario, 0);
			((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
			this.gb_resultado.ResumeLayout(false);
			this.gb_resultado.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_verificacion)).EndInit();
			this.gb_muestreo.ResumeLayout(false);
			this.gb_muestreo.PerformLayout();
			this.tc_datos.ResumeLayout(false);
			this.tp_entradas.ResumeLayout(false);
			this.tp_entradas.PerformLayout();
			this.gb_metodo_verificacion.ResumeLayout(false);
			this.tp_images.ResumeLayout(false);
			this.tp_images.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
			this.tp_calidad.ResumeLayout(false);
			this.tp_calidad.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txt_num_registro;
    private System.Windows.Forms.Label lbl_num_registro;
    private System.Windows.Forms.Label lbl_date_revision;
    private System.Windows.Forms.DateTimePicker dtp_fecha_revision;
    private System.Windows.Forms.Label lbl_ref_metalcaucho;
    private System.Windows.Forms.TextBox txt_ref_metalcaucho;
    private System.Windows.Forms.Label lbl_proveedor;
    private System.Windows.Forms.TextBox txt_proveedor;
    private System.Windows.Forms.Label lbl_num_lote;
    private System.Windows.Forms.TextBox txt_num_lote;
    private System.Windows.Forms.Label lbl_num_pl;
    private System.Windows.Forms.TextBox txt_num_pl;
    private System.Windows.Forms.Label lbl_num_recibidas;
    private System.Windows.Forms.TextBox txt_num_recibidas;
    private System.Windows.Forms.GroupBox gb_resultado;
    private System.Windows.Forms.CheckBox ch_ok;
    private System.Windows.Forms.CheckBox ch_rj;
    private System.Windows.Forms.CheckBox ch_hl;
    private System.Windows.Forms.Label lbl_verificador;
    private System.Windows.Forms.TextBox txt_verificador;
    private System.Windows.Forms.Label lbl_almacen;
    private System.Windows.Forms.TextBox txt_almacen;
    private System.Windows.Forms.DataGridView dgv_verificacion;
    private System.Windows.Forms.TextBox txt_observaciones;
    private System.Windows.Forms.Label lbl_observaciones;
    private System.Windows.Forms.CheckBox ch_revisar_qa;
    private System.Windows.Forms.Label lbl_num_verificadas;
    private System.Windows.Forms.TextBox txt_num_verificadas;
    private System.Windows.Forms.CheckBox ch_visualizar_pautas_autocontrol;
    private System.Windows.Forms.CheckBox ch_banco_pruebas;
    private System.Windows.Forms.GroupBox gb_muestreo;
    private System.Windows.Forms.TabControl tc_datos;
    private System.Windows.Forms.TabPage tp_entradas;
    private System.Windows.Forms.TabPage tp_images;
    private System.Windows.Forms.GroupBox gb_metodo_verificacion;
    private System.Windows.Forms.Button btn_eliminar_verificacion;
    private System.Windows.Forms.Button btn_añadir_verificacion;
    private System.Windows.Forms.PictureBox pb5;
    private System.Windows.Forms.PictureBox pb4;
    private System.Windows.Forms.PictureBox pb2;
    private System.Windows.Forms.PictureBox pb3;
    private System.Windows.Forms.PictureBox pb1;
    private System.Windows.Forms.TabPage tp_calidad;
    private System.Windows.Forms.TextBox txt_acciones;
    private System.Windows.Forms.Label lbl_accion_realizada;
    private System.Windows.Forms.DateTimePicker dtp_fecha_calidad;
    private System.Windows.Forms.Label lbl_fecha_calidad;
    private System.Windows.Forms.Label lbl_certificados;
    private System.Windows.Forms.TextBox txt_certificados;
    private System.Windows.Forms.DateTimePicker dtp_fecha_creacion;
    private System.Windows.Forms.Label lbl_fecha_creacion;
    private System.Windows.Forms.Label lbl_usuario;
    private System.Windows.Forms.TextBox txt_usuario;
    private System.Windows.Forms.Button btn_borrar_ruta_doc;
    private System.Windows.Forms.Button btn_añadir_ruta_doc;
    private System.Windows.Forms.TextBox txt_documento;
    private System.Windows.Forms.Label lbl_documento;
    private System.Windows.Forms.Button btn_eliminar_certificado;
    private System.Windows.Forms.Button btn_añadir_certificado;
  }
}