namespace ControlCalidad
{
  partial class frm_expediente
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
      this.txt_observaciones = new System.Windows.Forms.TextBox();
      this.lbl_observaciones = new System.Windows.Forms.Label();
      this.dtp_fecha_creacion = new System.Windows.Forms.DateTimePicker();
      this.lbl_fecha_creacion = new System.Windows.Forms.Label();
      this.lbl_usuario = new System.Windows.Forms.Label();
      this.txt_usuario = new System.Windows.Forms.TextBox();
      this.gb_cliente = new System.Windows.Forms.GroupBox();
      this.lbl_cli_solicita = new System.Windows.Forms.Label();
      this.ch_cli_SDC = new System.Windows.Forms.CheckBox();
      this.txt_cli_email = new System.Windows.Forms.TextBox();
      this.ch_cli_DC = new System.Windows.Forms.CheckBox();
      this.lbl_cli_email = new System.Windows.Forms.Label();
      this.lbl_motivo_denegacion = new System.Windows.Forms.Label();
      this.txt_motivo_denegacion = new System.Windows.Forms.TextBox();
      this.gb_registro_lineas = new System.Windows.Forms.GroupBox();
      this.dgv_verificacion = new System.Windows.Forms.DataGridView();
      this.btn_eliminar_verificacion = new System.Windows.Forms.Button();
      this.btn_añadir_verificacion = new System.Windows.Forms.Button();
      this.gb_cliente.SuspendLayout();
      this.gb_registro_lineas.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_verificacion)).BeginInit();
      this.SuspendLayout();
      // 
      // btn_salir
      // 
      this.btn_salir.Location = new System.Drawing.Point(13, 427);
      // 
      // btn_guardar
      // 
      this.btn_guardar.Location = new System.Drawing.Point(13, 376);
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
      this.lbl_cli_nombre.Location = new System.Drawing.Point(18, 29);
      this.lbl_cli_nombre.Name = "lbl_cli_nombre";
      this.lbl_cli_nombre.Size = new System.Drawing.Size(44, 13);
      this.lbl_cli_nombre.TabIndex = 16;
      this.lbl_cli_nombre.Text = "Nombre";
      // 
      // txt_cli_nombre
      // 
      this.txt_cli_nombre.Location = new System.Drawing.Point(68, 26);
      this.txt_cli_nombre.Name = "txt_cli_nombre";
      this.txt_cli_nombre.Size = new System.Drawing.Size(288, 20);
      this.txt_cli_nombre.TabIndex = 15;
      // 
      // lbl_cli_referencia
      // 
      this.lbl_cli_referencia.AutoSize = true;
      this.lbl_cli_referencia.Location = new System.Drawing.Point(3, 55);
      this.lbl_cli_referencia.Name = "lbl_cli_referencia";
      this.lbl_cli_referencia.Size = new System.Drawing.Size(59, 13);
      this.lbl_cli_referencia.TabIndex = 18;
      this.lbl_cli_referencia.Text = "Referencia";
      // 
      // txt_cli_referencia
      // 
      this.txt_cli_referencia.Location = new System.Drawing.Point(68, 52);
      this.txt_cli_referencia.Name = "txt_cli_referencia";
      this.txt_cli_referencia.Size = new System.Drawing.Size(100, 20);
      this.txt_cli_referencia.TabIndex = 17;
      // 
      // txt_observaciones
      // 
      this.txt_observaciones.Location = new System.Drawing.Point(20, 369);
      this.txt_observaciones.Multiline = true;
      this.txt_observaciones.Name = "txt_observaciones";
      this.txt_observaciones.Size = new System.Drawing.Size(362, 103);
      this.txt_observaciones.TabIndex = 22;
      // 
      // lbl_observaciones
      // 
      this.lbl_observaciones.AutoSize = true;
      this.lbl_observaciones.Location = new System.Drawing.Point(159, 348);
      this.lbl_observaciones.Name = "lbl_observaciones";
      this.lbl_observaciones.Size = new System.Drawing.Size(78, 13);
      this.lbl_observaciones.TabIndex = 23;
      this.lbl_observaciones.Text = "Observaciones";
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
      this.txt_usuario.Name = "txt_usuario";
      this.txt_usuario.Size = new System.Drawing.Size(100, 20);
      this.txt_usuario.TabIndex = 34;
      // 
      // gb_cliente
      // 
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
      this.gb_cliente.Size = new System.Drawing.Size(362, 134);
      this.gb_cliente.TabIndex = 37;
      this.gb_cliente.TabStop = false;
      this.gb_cliente.Text = "Cliente";
      // 
      // lbl_cli_solicita
      // 
      this.lbl_cli_solicita.AutoSize = true;
      this.lbl_cli_solicita.Location = new System.Drawing.Point(18, 109);
      this.lbl_cli_solicita.Name = "lbl_cli_solicita";
      this.lbl_cli_solicita.Size = new System.Drawing.Size(44, 13);
      this.lbl_cli_solicita.TabIndex = 40;
      this.lbl_cli_solicita.Text = "Solicita:";
      // 
      // ch_cli_SDC
      // 
      this.ch_cli_SDC.AutoSize = true;
      this.ch_cli_SDC.Location = new System.Drawing.Point(114, 107);
      this.ch_cli_SDC.Name = "ch_cli_SDC";
      this.ch_cli_SDC.Size = new System.Drawing.Size(54, 17);
      this.ch_cli_SDC.TabIndex = 39;
      this.ch_cli_SDC.Text = "S.D.C";
      this.ch_cli_SDC.UseVisualStyleBackColor = true;
      // 
      // txt_cli_email
      // 
      this.txt_cli_email.Location = new System.Drawing.Point(68, 78);
      this.txt_cli_email.Name = "txt_cli_email";
      this.txt_cli_email.Size = new System.Drawing.Size(288, 20);
      this.txt_cli_email.TabIndex = 15;
      // 
      // ch_cli_DC
      // 
      this.ch_cli_DC.AutoSize = true;
      this.ch_cli_DC.Location = new System.Drawing.Point(68, 107);
      this.ch_cli_DC.Name = "ch_cli_DC";
      this.ch_cli_DC.Size = new System.Drawing.Size(44, 17);
      this.ch_cli_DC.TabIndex = 38;
      this.ch_cli_DC.Text = "D.C";
      this.ch_cli_DC.UseVisualStyleBackColor = true;
      // 
      // lbl_cli_email
      // 
      this.lbl_cli_email.AutoSize = true;
      this.lbl_cli_email.Location = new System.Drawing.Point(31, 81);
      this.lbl_cli_email.Name = "lbl_cli_email";
      this.lbl_cli_email.Size = new System.Drawing.Size(31, 13);
      this.lbl_cli_email.TabIndex = 16;
      this.lbl_cli_email.Text = "email";
      // 
      // lbl_motivo_denegacion
      // 
      this.lbl_motivo_denegacion.AutoSize = true;
      this.lbl_motivo_denegacion.Location = new System.Drawing.Point(580, 348);
      this.lbl_motivo_denegacion.Name = "lbl_motivo_denegacion";
      this.lbl_motivo_denegacion.Size = new System.Drawing.Size(98, 13);
      this.lbl_motivo_denegacion.TabIndex = 39;
      this.lbl_motivo_denegacion.Text = "Motivo denegación";
      // 
      // txt_motivo_denegacion
      // 
      this.txt_motivo_denegacion.Location = new System.Drawing.Point(441, 369);
      this.txt_motivo_denegacion.Multiline = true;
      this.txt_motivo_denegacion.Name = "txt_motivo_denegacion";
      this.txt_motivo_denegacion.Size = new System.Drawing.Size(362, 103);
      this.txt_motivo_denegacion.TabIndex = 38;
      // 
      // gb_registro_lineas
      // 
      this.gb_registro_lineas.Controls.Add(this.dgv_verificacion);
      this.gb_registro_lineas.Controls.Add(this.btn_eliminar_verificacion);
      this.gb_registro_lineas.Controls.Add(this.btn_añadir_verificacion);
      this.gb_registro_lineas.Location = new System.Drawing.Point(20, 153);
      this.gb_registro_lineas.Name = "gb_registro_lineas";
      this.gb_registro_lineas.Size = new System.Drawing.Size(783, 180);
      this.gb_registro_lineas.TabIndex = 24;
      this.gb_registro_lineas.TabStop = false;
      this.gb_registro_lineas.Text = "Registro de Líneas";
      // 
      // dgv_verificacion
      // 
      this.dgv_verificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_verificacion.Location = new System.Drawing.Point(16, 19);
      this.dgv_verificacion.Name = "dgv_verificacion";
      this.dgv_verificacion.Size = new System.Drawing.Size(682, 155);
      this.dgv_verificacion.TabIndex = 21;
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
      // 
      // frm_expediente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.RoyalBlue;
      this.ClientSize = new System.Drawing.Size(932, 486);
      this.Controls.Add(this.gb_registro_lineas);
      this.Controls.Add(this.lbl_motivo_denegacion);
      this.Controls.Add(this.txt_motivo_denegacion);
      this.Controls.Add(this.gb_cliente);
      this.Controls.Add(this.lbl_observaciones);
      this.Controls.Add(this.txt_observaciones);
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
      this.Name = "frm_expediente";
      this.Text = "xExpediente";
      this.Load += new System.EventHandler(this.frm_expediente_Load);
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
      this.Controls.SetChildIndex(this.txt_observaciones, 0);
      this.Controls.SetChildIndex(this.lbl_observaciones, 0);
      this.Controls.SetChildIndex(this.gb_cliente, 0);
      this.Controls.SetChildIndex(this.txt_motivo_denegacion, 0);
      this.Controls.SetChildIndex(this.lbl_motivo_denegacion, 0);
      this.Controls.SetChildIndex(this.gb_registro_lineas, 0);
      this.gb_cliente.ResumeLayout(false);
      this.gb_cliente.PerformLayout();
      this.gb_registro_lineas.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_verificacion)).EndInit();
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
    private System.Windows.Forms.TextBox txt_observaciones;
    private System.Windows.Forms.Label lbl_observaciones;
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
    private System.Windows.Forms.Label lbl_motivo_denegacion;
    private System.Windows.Forms.TextBox txt_motivo_denegacion;
    private System.Windows.Forms.GroupBox gb_registro_lineas;
    private System.Windows.Forms.DataGridView dgv_verificacion;
    private System.Windows.Forms.Button btn_eliminar_verificacion;
    private System.Windows.Forms.Button btn_añadir_verificacion;
  }
}