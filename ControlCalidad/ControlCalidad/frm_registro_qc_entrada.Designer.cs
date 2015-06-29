namespace ControlCalidad
{
    partial class frm_registro_qc_entrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registro_qc_entrada));
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
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.tp_calidad = new System.Windows.Forms.TabPage();
            this.lbl_certificados = new System.Windows.Forms.Label();
            this.dtp_fecha_calidad = new System.Windows.Forms.DateTimePicker();
            this.txt_certificados = new System.Windows.Forms.TextBox();
            this.lbl_fecha_calidad = new System.Windows.Forms.Label();
            this.lbl_accion_realizada = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.lbl_date_revision.Location = new System.Drawing.Point(200, 31);
            this.lbl_date_revision.Name = "lbl_date_revision";
            this.lbl_date_revision.Size = new System.Drawing.Size(81, 13);
            this.lbl_date_revision.TabIndex = 2;
            this.lbl_date_revision.Text = "Fecha Revision";
            // 
            // dtp_fecha_revision
            // 
            this.dtp_fecha_revision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha_revision.Location = new System.Drawing.Point(287, 28);
            this.dtp_fecha_revision.Name = "dtp_fecha_revision";
            this.dtp_fecha_revision.Size = new System.Drawing.Size(100, 20);
            this.dtp_fecha_revision.TabIndex = 3;
            // 
            // lbl_ref_metalcaucho
            // 
            this.lbl_ref_metalcaucho.AutoSize = true;
            this.lbl_ref_metalcaucho.Location = new System.Drawing.Point(417, 31);
            this.lbl_ref_metalcaucho.Name = "lbl_ref_metalcaucho";
            this.lbl_ref_metalcaucho.Size = new System.Drawing.Size(43, 13);
            this.lbl_ref_metalcaucho.TabIndex = 5;
            this.lbl_ref_metalcaucho.Text = "Ref MC";
            // 
            // txt_ref_metalcaucho
            // 
            this.txt_ref_metalcaucho.Location = new System.Drawing.Point(466, 28);
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
            this.lbl_num_lote.Location = new System.Drawing.Point(238, 57);
            this.lbl_num_lote.Name = "lbl_num_lote";
            this.lbl_num_lote.Size = new System.Drawing.Size(43, 13);
            this.lbl_num_lote.TabIndex = 9;
            this.lbl_num_lote.Text = "Nº Lote";
            // 
            // txt_num_lote
            // 
            this.txt_num_lote.Location = new System.Drawing.Point(287, 54);
            this.txt_num_lote.Name = "txt_num_lote";
            this.txt_num_lote.Size = new System.Drawing.Size(100, 20);
            this.txt_num_lote.TabIndex = 8;
            // 
            // lbl_num_pl
            // 
            this.lbl_num_pl.AutoSize = true;
            this.lbl_num_pl.Location = new System.Drawing.Point(422, 57);
            this.lbl_num_pl.Name = "lbl_num_pl";
            this.lbl_num_pl.Size = new System.Drawing.Size(38, 13);
            this.lbl_num_pl.TabIndex = 11;
            this.lbl_num_pl.Text = "Nº P.L";
            // 
            // txt_num_pl
            // 
            this.txt_num_pl.Location = new System.Drawing.Point(466, 54);
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
            this.lbl_verificador.Location = new System.Drawing.Point(14, 18);
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
            this.lbl_almacen.Location = new System.Drawing.Point(223, 18);
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
            this.tp_calidad.Controls.Add(this.lbl_certificados);
            this.tp_calidad.Controls.Add(this.dtp_fecha_calidad);
            this.tp_calidad.Controls.Add(this.txt_certificados);
            this.tp_calidad.Controls.Add(this.lbl_fecha_calidad);
            this.tp_calidad.Controls.Add(this.lbl_accion_realizada);
            this.tp_calidad.Controls.Add(this.textBox1);
            this.tp_calidad.Location = new System.Drawing.Point(4, 22);
            this.tp_calidad.Name = "tp_calidad";
            this.tp_calidad.Padding = new System.Windows.Forms.Padding(3);
            this.tp_calidad.Size = new System.Drawing.Size(775, 254);
            this.tp_calidad.TabIndex = 2;
            this.tp_calidad.Text = "Calidad";
            // 
            // lbl_certificados
            // 
            this.lbl_certificados.AutoSize = true;
            this.lbl_certificados.Location = new System.Drawing.Point(70, 144);
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(137, 6);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(627, 103);
            this.textBox1.TabIndex = 23;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(829, 360);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 24;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(829, 389);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(75, 23);
            this.btn_salir.TabIndex = 30;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(816, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // frm_registro_qc_entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(916, 425);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_guardar);
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
            this.Name = "frm_registro_qc_entrada";
            this.Text = "Registro de entrada";
            this.Load += new System.EventHandler(this.frm_registro_qc_entrada_Load);
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
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.tp_calidad.ResumeLayout(false);
            this.tp_calidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.TabPage tp_calidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lbl_accion_realizada;
        private System.Windows.Forms.DateTimePicker dtp_fecha_calidad;
        private System.Windows.Forms.Label lbl_fecha_calidad;
        private System.Windows.Forms.Label lbl_certificados;
        private System.Windows.Forms.TextBox txt_certificados;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}