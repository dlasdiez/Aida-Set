namespace ControlCalidad
{
  partial class frm_expediente_edit
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
      this.lbl_date_expedicion = new System.Windows.Forms.Label();
      this.dtp_fecha_expedicion = new System.Windows.Forms.DateTimePicker();
      this.lbl_ref_metalcaucho = new System.Windows.Forms.Label();
      this.txt_ref_metalcaucho = new System.Windows.Forms.TextBox();
      this.lbl_cli_nombre = new System.Windows.Forms.Label();
      this.txt_cli_nombre = new System.Windows.Forms.TextBox();
      this.lbl_cli_referencia = new System.Windows.Forms.Label();
      this.txt_cli_referencia = new System.Windows.Forms.TextBox();
      this.dtp_fecha_creacion = new System.Windows.Forms.DateTimePicker();
      this.lbl_fecha_creacion = new System.Windows.Forms.Label();
      this.lbl_usuario = new System.Windows.Forms.Label();
      this.txt_usuario = new System.Windows.Forms.TextBox();
      this.gb_cliente = new System.Windows.Forms.GroupBox();
      this.btn_seleccionar_cuenta = new System.Windows.Forms.Button();
      this.lbl_cod_cliente = new System.Windows.Forms.Label();
      this.txt_cliente_id = new System.Windows.Forms.TextBox();
      this.lbl_cli_solicita = new System.Windows.Forms.Label();
      this.ch_cli_SDC = new System.Windows.Forms.CheckBox();
      this.txt_cli_email = new System.Windows.Forms.TextBox();
      this.ch_cli_DC = new System.Windows.Forms.CheckBox();
      this.lbl_cli_email = new System.Windows.Forms.Label();
      this.gb_registro_lineas = new System.Windows.Forms.GroupBox();
      this.btn_seleccionar_proveedor = new System.Windows.Forms.Button();
      this.txt_nombre_proveedor = new System.Windows.Forms.TextBox();
      this.lbl_unidades = new System.Windows.Forms.Label();
      this.txt_unidades = new System.Windows.Forms.TextBox();
      this.lbl_num_lote = new System.Windows.Forms.Label();
      this.txt_num_lote = new System.Windows.Forms.TextBox();
      this.lbl_proveedor = new System.Windows.Forms.Label();
      this.txt_proveedor_id = new System.Windows.Forms.TextBox();
      this.dgv_verificacion = new System.Windows.Forms.DataGridView();
      this.btn_eliminar_verificacion = new System.Windows.Forms.Button();
      this.btn_añadir_verificacion = new System.Windows.Forms.Button();
      this.txt_usuario_id = new System.Windows.Forms.TextBox();
      this.dtp_fecha_modificacion = new System.Windows.Forms.DateTimePicker();
      this.lbl_fecha_modificacion = new System.Windows.Forms.Label();
      this.lbl_cod_articulo = new System.Windows.Forms.Label();
      this.txt_cod_articulo = new System.Windows.Forms.TextBox();
      this.txt_nombre_articulo = new System.Windows.Forms.TextBox();
      this.tc_comentarios = new System.Windows.Forms.TabControl();
      this.tp_observaciones = new System.Windows.Forms.TabPage();
      this.txt_observaciones = new System.Windows.Forms.TextBox();
      this.tp_motivo_denegacion = new System.Windows.Forms.TabPage();
      this.txt_motivo_denegacion = new System.Windows.Forms.TextBox();
      this.tp_notas = new System.Windows.Forms.TabPage();
      this.txt_notas = new System.Windows.Forms.TextBox();
      this.btn_seleccionar_articulo = new System.Windows.Forms.Button();
      this.pnl_contenedor.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
      this.gb_cliente.SuspendLayout();
      this.gb_registro_lineas.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_verificacion)).BeginInit();
      this.tc_comentarios.SuspendLayout();
      this.tp_observaciones.SuspendLayout();
      this.tp_motivo_denegacion.SuspendLayout();
      this.tp_notas.SuspendLayout();
      this.SuspendLayout();
      // 
      // btn_salir
      // 
      this.btn_salir.Location = new System.Drawing.Point(13, 531);
      // 
      // btn_guardar
      // 
      this.btn_guardar.Location = new System.Drawing.Point(13, 480);
      // 
      // pnl_contenedor
      // 
      this.pnl_contenedor.Controls.Add(this.btn_seleccionar_articulo);
      this.pnl_contenedor.Controls.Add(this.txt_nombre_articulo);
      this.pnl_contenedor.Controls.Add(this.lbl_cod_articulo);
      this.pnl_contenedor.Controls.Add(this.gb_registro_lineas);
      this.pnl_contenedor.Controls.Add(this.txt_cod_articulo);
      this.pnl_contenedor.Controls.Add(this.dtp_fecha_modificacion);
      this.pnl_contenedor.Controls.Add(this.lbl_fecha_modificacion);
      this.pnl_contenedor.Controls.Add(this.txt_usuario_id);
      this.pnl_contenedor.Controls.Add(this.tc_comentarios);
      this.pnl_contenedor.Size = new System.Drawing.Size(826, 587);
      // 
      // txt_num_registro
      // 
      this.txt_num_registro.Location = new System.Drawing.Point(84, 28);
      this.txt_num_registro.MaxLength = 10;
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
      // lbl_date_expedicion
      // 
      this.lbl_date_expedicion.AutoSize = true;
      this.lbl_date_expedicion.Location = new System.Drawing.Point(192, 54);
      this.lbl_date_expedicion.Name = "lbl_date_expedicion";
      this.lbl_date_expedicion.Size = new System.Drawing.Size(92, 13);
      this.lbl_date_expedicion.TabIndex = 2;
      this.lbl_date_expedicion.Text = "Fecha Expedición";
      // 
      // dtp_fecha_expedicion
      // 
      this.dtp_fecha_expedicion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtp_fecha_expedicion.Location = new System.Drawing.Point(287, 51);
      this.dtp_fecha_expedicion.Name = "dtp_fecha_expedicion";
      this.dtp_fecha_expedicion.Size = new System.Drawing.Size(100, 20);
      this.dtp_fecha_expedicion.TabIndex = 3;
      // 
      // lbl_ref_metalcaucho
      // 
      this.lbl_ref_metalcaucho.AutoSize = true;
      this.lbl_ref_metalcaucho.Location = new System.Drawing.Point(35, 113);
      this.lbl_ref_metalcaucho.Name = "lbl_ref_metalcaucho";
      this.lbl_ref_metalcaucho.Size = new System.Drawing.Size(43, 13);
      this.lbl_ref_metalcaucho.TabIndex = 5;
      this.lbl_ref_metalcaucho.Text = "Ref MC";
      // 
      // txt_ref_metalcaucho
      // 
      this.txt_ref_metalcaucho.Location = new System.Drawing.Point(84, 110);
      this.txt_ref_metalcaucho.Name = "txt_ref_metalcaucho";
      this.txt_ref_metalcaucho.Size = new System.Drawing.Size(303, 20);
      this.txt_ref_metalcaucho.TabIndex = 4;
      // 
      // lbl_cli_nombre
      // 
      this.lbl_cli_nombre.AutoSize = true;
      this.lbl_cli_nombre.Location = new System.Drawing.Point(18, 58);
      this.lbl_cli_nombre.Name = "lbl_cli_nombre";
      this.lbl_cli_nombre.Size = new System.Drawing.Size(44, 13);
      this.lbl_cli_nombre.TabIndex = 16;
      this.lbl_cli_nombre.Text = "Nombre";
      // 
      // txt_cli_nombre
      // 
      this.txt_cli_nombre.Location = new System.Drawing.Point(68, 55);
      this.txt_cli_nombre.MaxLength = 30;
      this.txt_cli_nombre.Name = "txt_cli_nombre";
      this.txt_cli_nombre.Size = new System.Drawing.Size(277, 20);
      this.txt_cli_nombre.TabIndex = 15;
      // 
      // lbl_cli_referencia
      // 
      this.lbl_cli_referencia.AutoSize = true;
      this.lbl_cli_referencia.Location = new System.Drawing.Point(3, 84);
      this.lbl_cli_referencia.Name = "lbl_cli_referencia";
      this.lbl_cli_referencia.Size = new System.Drawing.Size(59, 13);
      this.lbl_cli_referencia.TabIndex = 18;
      this.lbl_cli_referencia.Text = "Referencia";
      // 
      // txt_cli_referencia
      // 
      this.txt_cli_referencia.Location = new System.Drawing.Point(68, 81);
      this.txt_cli_referencia.MaxLength = 22;
      this.txt_cli_referencia.Name = "txt_cli_referencia";
      this.txt_cli_referencia.Size = new System.Drawing.Size(100, 20);
      this.txt_cli_referencia.TabIndex = 17;
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
      this.lbl_fecha_creacion.Location = new System.Drawing.Point(202, 28);
      this.lbl_fecha_creacion.Name = "lbl_fecha_creacion";
      this.lbl_fecha_creacion.Size = new System.Drawing.Size(82, 13);
      this.lbl_fecha_creacion.TabIndex = 32;
      this.lbl_fecha_creacion.Text = "Fecha Creación";
      // 
      // lbl_usuario
      // 
      this.lbl_usuario.AutoSize = true;
      this.lbl_usuario.Location = new System.Drawing.Point(35, 54);
      this.lbl_usuario.Name = "lbl_usuario";
      this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
      this.lbl_usuario.TabIndex = 35;
      this.lbl_usuario.Text = "Usuario";
      // 
      // txt_usuario
      // 
      this.txt_usuario.Location = new System.Drawing.Point(84, 51);
      this.txt_usuario.MaxLength = 4;
      this.txt_usuario.Name = "txt_usuario";
      this.txt_usuario.Size = new System.Drawing.Size(100, 20);
      this.txt_usuario.TabIndex = 34;
      // 
      // gb_cliente
      // 
      this.gb_cliente.Controls.Add(this.btn_seleccionar_cuenta);
      this.gb_cliente.Controls.Add(this.lbl_cod_cliente);
      this.gb_cliente.Controls.Add(this.txt_cliente_id);
      this.gb_cliente.Controls.Add(this.lbl_cli_solicita);
      this.gb_cliente.Controls.Add(this.ch_cli_SDC);
      this.gb_cliente.Controls.Add(this.txt_cli_email);
      this.gb_cliente.Controls.Add(this.ch_cli_DC);
      this.gb_cliente.Controls.Add(this.txt_cli_nombre);
      this.gb_cliente.Controls.Add(this.lbl_cli_email);
      this.gb_cliente.Controls.Add(this.txt_cli_referencia);
      this.gb_cliente.Controls.Add(this.lbl_cli_nombre);
      this.gb_cliente.Controls.Add(this.lbl_cli_referencia);
      this.gb_cliente.Location = new System.Drawing.Point(437, 6);
      this.gb_cliente.Name = "gb_cliente";
      this.gb_cliente.Size = new System.Drawing.Size(362, 180);
      this.gb_cliente.TabIndex = 37;
      this.gb_cliente.TabStop = false;
      this.gb_cliente.Text = "Cliente";
      // 
      // btn_seleccionar_cuenta
      // 
      this.btn_seleccionar_cuenta.Location = new System.Drawing.Point(270, 132);
      this.btn_seleccionar_cuenta.Name = "btn_seleccionar_cuenta";
      this.btn_seleccionar_cuenta.Size = new System.Drawing.Size(75, 23);
      this.btn_seleccionar_cuenta.TabIndex = 51;
      this.btn_seleccionar_cuenta.Text = "Seleccionar";
      this.btn_seleccionar_cuenta.UseVisualStyleBackColor = true;
      this.btn_seleccionar_cuenta.Click += new System.EventHandler(this.btn_seleccionar_cuenta_Click);
      // 
      // lbl_cod_cliente
      // 
      this.lbl_cod_cliente.AutoSize = true;
      this.lbl_cod_cliente.Location = new System.Drawing.Point(22, 32);
      this.lbl_cod_cliente.Name = "lbl_cod_cliente";
      this.lbl_cod_cliente.Size = new System.Drawing.Size(40, 13);
      this.lbl_cod_cliente.TabIndex = 41;
      this.lbl_cod_cliente.Text = "Código";
      // 
      // txt_cliente_id
      // 
      this.txt_cliente_id.Location = new System.Drawing.Point(68, 29);
      this.txt_cliente_id.MaxLength = 9;
      this.txt_cliente_id.Name = "txt_cliente_id";
      this.txt_cliente_id.Size = new System.Drawing.Size(100, 20);
      this.txt_cliente_id.TabIndex = 40;
      // 
      // lbl_cli_solicita
      // 
      this.lbl_cli_solicita.AutoSize = true;
      this.lbl_cli_solicita.Location = new System.Drawing.Point(18, 138);
      this.lbl_cli_solicita.Name = "lbl_cli_solicita";
      this.lbl_cli_solicita.Size = new System.Drawing.Size(44, 13);
      this.lbl_cli_solicita.TabIndex = 40;
      this.lbl_cli_solicita.Text = "Solicita:";
      // 
      // ch_cli_SDC
      // 
      this.ch_cli_SDC.AutoSize = true;
      this.ch_cli_SDC.Location = new System.Drawing.Point(114, 136);
      this.ch_cli_SDC.Name = "ch_cli_SDC";
      this.ch_cli_SDC.Size = new System.Drawing.Size(54, 17);
      this.ch_cli_SDC.TabIndex = 39;
      this.ch_cli_SDC.Text = "S.D.C";
      this.ch_cli_SDC.UseVisualStyleBackColor = true;
      // 
      // txt_cli_email
      // 
      this.txt_cli_email.Location = new System.Drawing.Point(68, 107);
      this.txt_cli_email.MaxLength = 40;
      this.txt_cli_email.Name = "txt_cli_email";
      this.txt_cli_email.Size = new System.Drawing.Size(277, 20);
      this.txt_cli_email.TabIndex = 15;
      // 
      // ch_cli_DC
      // 
      this.ch_cli_DC.AutoSize = true;
      this.ch_cli_DC.Location = new System.Drawing.Point(68, 136);
      this.ch_cli_DC.Name = "ch_cli_DC";
      this.ch_cli_DC.Size = new System.Drawing.Size(44, 17);
      this.ch_cli_DC.TabIndex = 38;
      this.ch_cli_DC.Text = "D.C";
      this.ch_cli_DC.UseVisualStyleBackColor = true;
      // 
      // lbl_cli_email
      // 
      this.lbl_cli_email.AutoSize = true;
      this.lbl_cli_email.Location = new System.Drawing.Point(31, 110);
      this.lbl_cli_email.Name = "lbl_cli_email";
      this.lbl_cli_email.Size = new System.Drawing.Size(32, 13);
      this.lbl_cli_email.TabIndex = 16;
      this.lbl_cli_email.Text = "Email";
      // 
      // gb_registro_lineas
      // 
      this.gb_registro_lineas.Controls.Add(this.btn_seleccionar_proveedor);
      this.gb_registro_lineas.Controls.Add(this.txt_nombre_proveedor);
      this.gb_registro_lineas.Controls.Add(this.lbl_unidades);
      this.gb_registro_lineas.Controls.Add(this.txt_unidades);
      this.gb_registro_lineas.Controls.Add(this.lbl_num_lote);
      this.gb_registro_lineas.Controls.Add(this.txt_num_lote);
      this.gb_registro_lineas.Controls.Add(this.lbl_proveedor);
      this.gb_registro_lineas.Controls.Add(this.txt_proveedor_id);
      this.gb_registro_lineas.Controls.Add(this.dgv_verificacion);
      this.gb_registro_lineas.Controls.Add(this.btn_eliminar_verificacion);
      this.gb_registro_lineas.Controls.Add(this.btn_añadir_verificacion);
      this.gb_registro_lineas.Location = new System.Drawing.Point(20, 192);
      this.gb_registro_lineas.Name = "gb_registro_lineas";
      this.gb_registro_lineas.Size = new System.Drawing.Size(783, 230);
      this.gb_registro_lineas.TabIndex = 24;
      this.gb_registro_lineas.TabStop = false;
      this.gb_registro_lineas.Text = "Registro de Líneas";
      // 
      // btn_seleccionar_proveedor
      // 
      this.btn_seleccionar_proveedor.Location = new System.Drawing.Point(175, 17);
      this.btn_seleccionar_proveedor.Name = "btn_seleccionar_proveedor";
      this.btn_seleccionar_proveedor.Size = new System.Drawing.Size(75, 23);
      this.btn_seleccionar_proveedor.TabIndex = 49;
      this.btn_seleccionar_proveedor.Text = "Seleccionar";
      this.btn_seleccionar_proveedor.UseVisualStyleBackColor = true;
      this.btn_seleccionar_proveedor.Click += new System.EventHandler(this.btn_seleccionar_proveedor_Click);
      // 
      // txt_nombre_proveedor
      // 
      this.txt_nombre_proveedor.Location = new System.Drawing.Point(77, 45);
      this.txt_nombre_proveedor.MaxLength = 30;
      this.txt_nombre_proveedor.Name = "txt_nombre_proveedor";
      this.txt_nombre_proveedor.Size = new System.Drawing.Size(249, 20);
      this.txt_nombre_proveedor.TabIndex = 47;
      // 
      // lbl_unidades
      // 
      this.lbl_unidades.AutoSize = true;
      this.lbl_unidades.Location = new System.Drawing.Point(533, 22);
      this.lbl_unidades.Name = "lbl_unidades";
      this.lbl_unidades.Size = new System.Drawing.Size(52, 13);
      this.lbl_unidades.TabIndex = 46;
      this.lbl_unidades.Text = "Unidades";
      // 
      // txt_unidades
      // 
      this.txt_unidades.Location = new System.Drawing.Point(590, 19);
      this.txt_unidades.MaxLength = 20;
      this.txt_unidades.Name = "txt_unidades";
      this.txt_unidades.Size = new System.Drawing.Size(75, 20);
      this.txt_unidades.TabIndex = 45;
      // 
      // lbl_num_lote
      // 
      this.lbl_num_lote.AutoSize = true;
      this.lbl_num_lote.Location = new System.Drawing.Point(360, 22);
      this.lbl_num_lote.Name = "lbl_num_lote";
      this.lbl_num_lote.Size = new System.Drawing.Size(56, 13);
      this.lbl_num_lote.TabIndex = 44;
      this.lbl_num_lote.Text = "Num. Lote";
      // 
      // txt_num_lote
      // 
      this.txt_num_lote.Location = new System.Drawing.Point(422, 19);
      this.txt_num_lote.MaxLength = 22;
      this.txt_num_lote.Name = "txt_num_lote";
      this.txt_num_lote.Size = new System.Drawing.Size(75, 20);
      this.txt_num_lote.TabIndex = 43;
      // 
      // lbl_proveedor
      // 
      this.lbl_proveedor.AutoSize = true;
      this.lbl_proveedor.Location = new System.Drawing.Point(15, 22);
      this.lbl_proveedor.Name = "lbl_proveedor";
      this.lbl_proveedor.Size = new System.Drawing.Size(56, 13);
      this.lbl_proveedor.TabIndex = 42;
      this.lbl_proveedor.Text = "Proveedor";
      // 
      // txt_proveedor_id
      // 
      this.txt_proveedor_id.Location = new System.Drawing.Point(77, 19);
      this.txt_proveedor_id.MaxLength = 9;
      this.txt_proveedor_id.Name = "txt_proveedor_id";
      this.txt_proveedor_id.Size = new System.Drawing.Size(87, 20);
      this.txt_proveedor_id.TabIndex = 42;
      // 
      // dgv_verificacion
      // 
      this.dgv_verificacion.AllowUserToAddRows = false;
      this.dgv_verificacion.AllowUserToDeleteRows = false;
      this.dgv_verificacion.AllowUserToOrderColumns = true;
      this.dgv_verificacion.AllowUserToResizeColumns = false;
      this.dgv_verificacion.AllowUserToResizeRows = false;
      this.dgv_verificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_verificacion.Location = new System.Drawing.Point(16, 71);
      this.dgv_verificacion.MultiSelect = false;
      this.dgv_verificacion.Name = "dgv_verificacion";
      this.dgv_verificacion.ReadOnly = true;
      this.dgv_verificacion.Size = new System.Drawing.Size(682, 149);
      this.dgv_verificacion.TabIndex = 21;
      this.dgv_verificacion.SelectionChanged += new System.EventHandler(this.dgv_verificacion_SelectionChanged);
      // 
      // btn_eliminar_verificacion
      // 
      this.btn_eliminar_verificacion.Location = new System.Drawing.Point(704, 151);
      this.btn_eliminar_verificacion.Name = "btn_eliminar_verificacion";
      this.btn_eliminar_verificacion.Size = new System.Drawing.Size(75, 23);
      this.btn_eliminar_verificacion.TabIndex = 23;
      this.btn_eliminar_verificacion.Text = "Eliminar";
      this.btn_eliminar_verificacion.UseVisualStyleBackColor = true;
      // 
      // btn_añadir_verificacion
      // 
      this.btn_añadir_verificacion.Location = new System.Drawing.Point(704, 122);
      this.btn_añadir_verificacion.Name = "btn_añadir_verificacion";
      this.btn_añadir_verificacion.Size = new System.Drawing.Size(75, 23);
      this.btn_añadir_verificacion.TabIndex = 22;
      this.btn_añadir_verificacion.Text = "Añadir";
      this.btn_añadir_verificacion.UseVisualStyleBackColor = true;
      this.btn_añadir_verificacion.Click += new System.EventHandler(this.btn_añadir_verificacion_Click);
      // 
      // txt_usuario_id
      // 
      this.txt_usuario_id.Location = new System.Drawing.Point(57, 77);
      this.txt_usuario_id.Name = "txt_usuario_id";
      this.txt_usuario_id.Size = new System.Drawing.Size(100, 20);
      this.txt_usuario_id.TabIndex = 41;
      this.txt_usuario_id.Visible = false;
      // 
      // dtp_fecha_modificacion
      // 
      this.dtp_fecha_modificacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
      this.dtp_fecha_modificacion.Location = new System.Drawing.Point(287, 77);
      this.dtp_fecha_modificacion.Name = "dtp_fecha_modificacion";
      this.dtp_fecha_modificacion.Size = new System.Drawing.Size(100, 20);
      this.dtp_fecha_modificacion.TabIndex = 41;
      // 
      // lbl_fecha_modificacion
      // 
      this.lbl_fecha_modificacion.AutoSize = true;
      this.lbl_fecha_modificacion.Location = new System.Drawing.Point(181, 80);
      this.lbl_fecha_modificacion.Name = "lbl_fecha_modificacion";
      this.lbl_fecha_modificacion.Size = new System.Drawing.Size(100, 13);
      this.lbl_fecha_modificacion.TabIndex = 40;
      this.lbl_fecha_modificacion.Text = "Fecha Modificación";
      // 
      // lbl_cod_articulo
      // 
      this.lbl_cod_articulo.AutoSize = true;
      this.lbl_cod_articulo.Location = new System.Drawing.Point(12, 139);
      this.lbl_cod_articulo.Name = "lbl_cod_articulo";
      this.lbl_cod_articulo.Size = new System.Drawing.Size(67, 13);
      this.lbl_cod_articulo.TabIndex = 48;
      this.lbl_cod_articulo.Text = "Cod. Articulo";
      // 
      // txt_cod_articulo
      // 
      this.txt_cod_articulo.Location = new System.Drawing.Point(84, 136);
      this.txt_cod_articulo.MaxLength = 22;
      this.txt_cod_articulo.Name = "txt_cod_articulo";
      this.txt_cod_articulo.Size = new System.Drawing.Size(75, 20);
      this.txt_cod_articulo.TabIndex = 47;
      // 
      // txt_nombre_articulo
      // 
      this.txt_nombre_articulo.Location = new System.Drawing.Point(165, 136);
      this.txt_nombre_articulo.MaxLength = 50;
      this.txt_nombre_articulo.Name = "txt_nombre_articulo";
      this.txt_nombre_articulo.Size = new System.Drawing.Size(141, 20);
      this.txt_nombre_articulo.TabIndex = 49;
      // 
      // tc_comentarios
      // 
      this.tc_comentarios.Controls.Add(this.tp_observaciones);
      this.tc_comentarios.Controls.Add(this.tp_motivo_denegacion);
      this.tc_comentarios.Controls.Add(this.tp_notas);
      this.tc_comentarios.Location = new System.Drawing.Point(20, 432);
      this.tc_comentarios.Name = "tc_comentarios";
      this.tc_comentarios.SelectedIndex = 0;
      this.tc_comentarios.Size = new System.Drawing.Size(789, 147);
      this.tc_comentarios.TabIndex = 50;
      // 
      // tp_observaciones
      // 
      this.tp_observaciones.BackColor = System.Drawing.Color.RoyalBlue;
      this.tp_observaciones.Controls.Add(this.txt_observaciones);
      this.tp_observaciones.Location = new System.Drawing.Point(4, 22);
      this.tp_observaciones.Name = "tp_observaciones";
      this.tp_observaciones.Padding = new System.Windows.Forms.Padding(3);
      this.tp_observaciones.Size = new System.Drawing.Size(781, 121);
      this.tp_observaciones.TabIndex = 0;
      this.tp_observaciones.Text = "Observaciones";
      // 
      // txt_observaciones
      // 
      this.txt_observaciones.Location = new System.Drawing.Point(6, 12);
      this.txt_observaciones.MaxLength = 350;
      this.txt_observaciones.Multiline = true;
      this.txt_observaciones.Name = "txt_observaciones";
      this.txt_observaciones.Size = new System.Drawing.Size(763, 103);
      this.txt_observaciones.TabIndex = 24;
      // 
      // tp_motivo_denegacion
      // 
      this.tp_motivo_denegacion.BackColor = System.Drawing.Color.RoyalBlue;
      this.tp_motivo_denegacion.Controls.Add(this.txt_motivo_denegacion);
      this.tp_motivo_denegacion.Location = new System.Drawing.Point(4, 22);
      this.tp_motivo_denegacion.Name = "tp_motivo_denegacion";
      this.tp_motivo_denegacion.Padding = new System.Windows.Forms.Padding(3);
      this.tp_motivo_denegacion.Size = new System.Drawing.Size(781, 121);
      this.tp_motivo_denegacion.TabIndex = 1;
      this.tp_motivo_denegacion.Text = "Motivo denegación";
      // 
      // txt_motivo_denegacion
      // 
      this.txt_motivo_denegacion.Location = new System.Drawing.Point(6, 12);
      this.txt_motivo_denegacion.MaxLength = 350;
      this.txt_motivo_denegacion.Multiline = true;
      this.txt_motivo_denegacion.Name = "txt_motivo_denegacion";
      this.txt_motivo_denegacion.Size = new System.Drawing.Size(763, 103);
      this.txt_motivo_denegacion.TabIndex = 39;
      // 
      // tp_notas
      // 
      this.tp_notas.BackColor = System.Drawing.Color.RoyalBlue;
      this.tp_notas.Controls.Add(this.txt_notas);
      this.tp_notas.Location = new System.Drawing.Point(4, 22);
      this.tp_notas.Name = "tp_notas";
      this.tp_notas.Padding = new System.Windows.Forms.Padding(3);
      this.tp_notas.Size = new System.Drawing.Size(781, 121);
      this.tp_notas.TabIndex = 2;
      this.tp_notas.Text = "Notas";
      // 
      // txt_notas
      // 
      this.txt_notas.Location = new System.Drawing.Point(6, 12);
      this.txt_notas.MaxLength = 350;
      this.txt_notas.Multiline = true;
      this.txt_notas.Name = "txt_notas";
      this.txt_notas.Size = new System.Drawing.Size(763, 103);
      this.txt_notas.TabIndex = 40;
      // 
      // btn_seleccionar_articulo
      // 
      this.btn_seleccionar_articulo.Location = new System.Drawing.Point(312, 134);
      this.btn_seleccionar_articulo.Name = "btn_seleccionar_articulo";
      this.btn_seleccionar_articulo.Size = new System.Drawing.Size(75, 23);
      this.btn_seleccionar_articulo.TabIndex = 48;
      this.btn_seleccionar_articulo.Text = "Seleccionar";
      this.btn_seleccionar_articulo.UseVisualStyleBackColor = true;
      this.btn_seleccionar_articulo.Click += new System.EventHandler(this.btn_seleccionar_articulo_Click);
      // 
      // frm_expediente_edit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.RoyalBlue;
      this.ClientSize = new System.Drawing.Size(947, 587);
      this.Controls.Add(this.gb_cliente);
      this.Controls.Add(this.lbl_usuario);
      this.Controls.Add(this.txt_usuario);
      this.Controls.Add(this.dtp_fecha_creacion);
      this.Controls.Add(this.lbl_fecha_creacion);
      this.Controls.Add(this.lbl_ref_metalcaucho);
      this.Controls.Add(this.txt_ref_metalcaucho);
      this.Controls.Add(this.dtp_fecha_expedicion);
      this.Controls.Add(this.lbl_date_expedicion);
      this.Controls.Add(this.lbl_num_registro);
      this.Controls.Add(this.txt_num_registro);
      this.Name = "frm_expediente_edit";
      this.Text = "xExpediente";
      this.Controls.SetChildIndex(this.pnl_contenedor, 0);
      this.Controls.SetChildIndex(this.txt_num_registro, 0);
      this.Controls.SetChildIndex(this.lbl_num_registro, 0);
      this.Controls.SetChildIndex(this.lbl_date_expedicion, 0);
      this.Controls.SetChildIndex(this.dtp_fecha_expedicion, 0);
      this.Controls.SetChildIndex(this.txt_ref_metalcaucho, 0);
      this.Controls.SetChildIndex(this.lbl_ref_metalcaucho, 0);
      this.Controls.SetChildIndex(this.lbl_fecha_creacion, 0);
      this.Controls.SetChildIndex(this.dtp_fecha_creacion, 0);
      this.Controls.SetChildIndex(this.txt_usuario, 0);
      this.Controls.SetChildIndex(this.lbl_usuario, 0);
      this.Controls.SetChildIndex(this.gb_cliente, 0);
      this.pnl_contenedor.ResumeLayout(false);
      this.pnl_contenedor.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
      this.gb_cliente.ResumeLayout(false);
      this.gb_cliente.PerformLayout();
      this.gb_registro_lineas.ResumeLayout(false);
      this.gb_registro_lineas.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_verificacion)).EndInit();
      this.tc_comentarios.ResumeLayout(false);
      this.tp_observaciones.ResumeLayout(false);
      this.tp_observaciones.PerformLayout();
      this.tp_motivo_denegacion.ResumeLayout(false);
      this.tp_motivo_denegacion.PerformLayout();
      this.tp_notas.ResumeLayout(false);
      this.tp_notas.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txt_num_registro;
    private System.Windows.Forms.Label lbl_num_registro;
    private System.Windows.Forms.Label lbl_date_expedicion;
    private System.Windows.Forms.DateTimePicker dtp_fecha_expedicion;
    private System.Windows.Forms.Label lbl_ref_metalcaucho;
    private System.Windows.Forms.TextBox txt_ref_metalcaucho;
    private System.Windows.Forms.Label lbl_cli_nombre;
    private System.Windows.Forms.TextBox txt_cli_nombre;
    private System.Windows.Forms.Label lbl_cli_referencia;
    private System.Windows.Forms.TextBox txt_cli_referencia;
    private System.Windows.Forms.DateTimePicker dtp_fecha_creacion;
    private System.Windows.Forms.Label lbl_fecha_creacion;
    private System.Windows.Forms.Label lbl_usuario;
    private System.Windows.Forms.TextBox txt_usuario;
    private System.Windows.Forms.GroupBox gb_cliente;
    private System.Windows.Forms.TextBox txt_cli_email;
    private System.Windows.Forms.Label lbl_cli_email;
    private System.Windows.Forms.Label lbl_cli_solicita;
    private System.Windows.Forms.CheckBox ch_cli_SDC;
    private System.Windows.Forms.CheckBox ch_cli_DC;
    private System.Windows.Forms.GroupBox gb_registro_lineas;
    private System.Windows.Forms.DataGridView dgv_verificacion;
    private System.Windows.Forms.Button btn_eliminar_verificacion;
    private System.Windows.Forms.Button btn_añadir_verificacion;
    private System.Windows.Forms.TextBox txt_cliente_id;
    private System.Windows.Forms.TextBox txt_usuario_id;
    private System.Windows.Forms.DateTimePicker dtp_fecha_modificacion;
    private System.Windows.Forms.Label lbl_fecha_modificacion;
    private System.Windows.Forms.Label lbl_cod_cliente;
    private System.Windows.Forms.Label lbl_proveedor;
    private System.Windows.Forms.TextBox txt_proveedor_id;
    private System.Windows.Forms.Label lbl_num_lote;
    private System.Windows.Forms.TextBox txt_num_lote;
    private System.Windows.Forms.Label lbl_unidades;
    private System.Windows.Forms.TextBox txt_unidades;
    private System.Windows.Forms.Label lbl_cod_articulo;
    private System.Windows.Forms.TextBox txt_cod_articulo;
    private System.Windows.Forms.TextBox txt_nombre_articulo;
    private System.Windows.Forms.TextBox txt_nombre_proveedor;
    private System.Windows.Forms.TabControl tc_comentarios;
    private System.Windows.Forms.TabPage tp_observaciones;
    private System.Windows.Forms.TextBox txt_observaciones;
    private System.Windows.Forms.TabPage tp_motivo_denegacion;
    private System.Windows.Forms.TextBox txt_motivo_denegacion;
    private System.Windows.Forms.TabPage tp_notas;
    private System.Windows.Forms.TextBox txt_notas;
    private System.Windows.Forms.Button btn_seleccionar_articulo;
    private System.Windows.Forms.Button btn_seleccionar_cuenta;
    private System.Windows.Forms.Button btn_seleccionar_proveedor;
  }
}