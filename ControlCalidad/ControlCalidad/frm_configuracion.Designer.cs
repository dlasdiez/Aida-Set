namespace ControlCalidad
{
  partial class frm_configuracion
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
      this.lbl_color = new System.Windows.Forms.Label();
      this.txt_color = new System.Windows.Forms.TextBox();
      this.btn_seleccionar_color = new System.Windows.Forms.Button();
      this.btn_guardar = new System.Windows.Forms.Button();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.tb_conexiones = new System.Windows.Forms.TabControl();
      this.tp_conexion_cobol = new System.Windows.Forms.TabPage();
      this.tp_conexion_bd = new System.Windows.Forms.TabPage();
      this.lbl_puerto = new System.Windows.Forms.Label();
      this.txt_puerto_BD = new System.Windows.Forms.TextBox();
      this.btn_test = new System.Windows.Forms.Button();
      this.lbl_password_bd = new System.Windows.Forms.Label();
      this.txt_password_bd = new System.Windows.Forms.TextBox();
      this.lbl_usuario_bd = new System.Windows.Forms.Label();
      this.txt_usuario_bd = new System.Windows.Forms.TextBox();
      this.lbl_database = new System.Windows.Forms.Label();
      this.txt_database = new System.Windows.Forms.TextBox();
      this.lbl_servidor_bd = new System.Windows.Forms.Label();
      this.txt_servidor_bd = new System.Windows.Forms.TextBox();
      this.txt_path_webservices = new System.Windows.Forms.TextBox();
      this.lbl_path_webservices = new System.Windows.Forms.Label();
      this.txt_path_datos = new System.Windows.Forms.TextBox();
      this.lbl_path_datos = new System.Windows.Forms.Label();
      this.txt_runtime = new System.Windows.Forms.TextBox();
      this.lbl_runtime = new System.Windows.Forms.Label();
      this.tp_crear_bd = new System.Windows.Forms.TabPage();
      this.btn_crear_bd = new System.Windows.Forms.Button();
      this.lbl_password_admin = new System.Windows.Forms.Label();
      this.txt_password_admin = new System.Windows.Forms.TextBox();
      this.lbl_user_admin = new System.Windows.Forms.Label();
      this.txt_user_admin = new System.Windows.Forms.TextBox();
      this.tb_conexiones.SuspendLayout();
      this.tp_conexion_cobol.SuspendLayout();
      this.tp_conexion_bd.SuspendLayout();
      this.tp_crear_bd.SuspendLayout();
      this.SuspendLayout();
      // 
      // lbl_color
      // 
      this.lbl_color.AutoSize = true;
      this.lbl_color.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_color.Location = new System.Drawing.Point(108, 210);
      this.lbl_color.Name = "lbl_color";
      this.lbl_color.Size = new System.Drawing.Size(53, 18);
      this.lbl_color.TabIndex = 18;
      this.lbl_color.Text = "xColor";
      // 
      // txt_color
      // 
      this.txt_color.BackColor = System.Drawing.Color.White;
      this.txt_color.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_color.Location = new System.Drawing.Point(167, 207);
      this.txt_color.Name = "txt_color";
      this.txt_color.Size = new System.Drawing.Size(228, 26);
      this.txt_color.TabIndex = 17;
      // 
      // btn_seleccionar_color
      // 
      this.btn_seleccionar_color.Location = new System.Drawing.Point(401, 210);
      this.btn_seleccionar_color.Name = "btn_seleccionar_color";
      this.btn_seleccionar_color.Size = new System.Drawing.Size(75, 23);
      this.btn_seleccionar_color.TabIndex = 16;
      this.btn_seleccionar_color.Text = "button1";
      this.btn_seleccionar_color.UseVisualStyleBackColor = true;
      this.btn_seleccionar_color.Click += new System.EventHandler(this.btn_seleccionar_color_Click);
      // 
      // btn_guardar
      // 
      this.btn_guardar.Location = new System.Drawing.Point(497, 244);
      this.btn_guardar.Name = "btn_guardar";
      this.btn_guardar.Size = new System.Drawing.Size(92, 38);
      this.btn_guardar.TabIndex = 15;
      this.btn_guardar.Text = "xGuardar";
      this.btn_guardar.UseVisualStyleBackColor = true;
      this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
      // 
      // tb_conexiones
      // 
      this.tb_conexiones.Controls.Add(this.tp_conexion_bd);
      this.tb_conexiones.Controls.Add(this.tp_conexion_cobol);
      this.tb_conexiones.Controls.Add(this.tp_crear_bd);
      this.tb_conexiones.Location = new System.Drawing.Point(1, 12);
      this.tb_conexiones.Name = "tb_conexiones";
      this.tb_conexiones.SelectedIndex = 0;
      this.tb_conexiones.Size = new System.Drawing.Size(592, 189);
      this.tb_conexiones.TabIndex = 30;
      // 
      // tp_conexion_cobol
      // 
      this.tp_conexion_cobol.BackColor = System.Drawing.SystemColors.Control;
      this.tp_conexion_cobol.Controls.Add(this.txt_path_webservices);
      this.tp_conexion_cobol.Controls.Add(this.lbl_path_webservices);
      this.tp_conexion_cobol.Controls.Add(this.txt_path_datos);
      this.tp_conexion_cobol.Controls.Add(this.lbl_path_datos);
      this.tp_conexion_cobol.Controls.Add(this.txt_runtime);
      this.tp_conexion_cobol.Controls.Add(this.lbl_runtime);
      this.tp_conexion_cobol.Location = new System.Drawing.Point(4, 22);
      this.tp_conexion_cobol.Name = "tp_conexion_cobol";
      this.tp_conexion_cobol.Padding = new System.Windows.Forms.Padding(3);
      this.tp_conexion_cobol.Size = new System.Drawing.Size(584, 163);
      this.tp_conexion_cobol.TabIndex = 0;
      this.tp_conexion_cobol.Text = "Conexión Cobol";
      // 
      // tp_conexion_bd
      // 
      this.tp_conexion_bd.BackColor = System.Drawing.SystemColors.Control;
      this.tp_conexion_bd.Controls.Add(this.lbl_puerto);
      this.tp_conexion_bd.Controls.Add(this.txt_puerto_BD);
      this.tp_conexion_bd.Controls.Add(this.btn_test);
      this.tp_conexion_bd.Controls.Add(this.lbl_password_bd);
      this.tp_conexion_bd.Controls.Add(this.txt_password_bd);
      this.tp_conexion_bd.Controls.Add(this.lbl_usuario_bd);
      this.tp_conexion_bd.Controls.Add(this.txt_usuario_bd);
      this.tp_conexion_bd.Controls.Add(this.lbl_database);
      this.tp_conexion_bd.Controls.Add(this.txt_database);
      this.tp_conexion_bd.Controls.Add(this.lbl_servidor_bd);
      this.tp_conexion_bd.Controls.Add(this.txt_servidor_bd);
      this.tp_conexion_bd.Location = new System.Drawing.Point(4, 22);
      this.tp_conexion_bd.Name = "tp_conexion_bd";
      this.tp_conexion_bd.Padding = new System.Windows.Forms.Padding(3);
      this.tp_conexion_bd.Size = new System.Drawing.Size(584, 163);
      this.tp_conexion_bd.TabIndex = 1;
      this.tp_conexion_bd.Text = "Conexión BD";
      // 
      // lbl_puerto
      // 
      this.lbl_puerto.AutoSize = true;
      this.lbl_puerto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_puerto.Location = new System.Drawing.Point(67, 97);
      this.lbl_puerto.Name = "lbl_puerto";
      this.lbl_puerto.Size = new System.Drawing.Size(61, 18);
      this.lbl_puerto.TabIndex = 40;
      this.lbl_puerto.Text = "xPuerto";
      // 
      // txt_puerto_BD
      // 
      this.txt_puerto_BD.BackColor = System.Drawing.Color.White;
      this.txt_puerto_BD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_puerto_BD.Location = new System.Drawing.Point(134, 94);
      this.txt_puerto_BD.Name = "txt_puerto_BD";
      this.txt_puerto_BD.Size = new System.Drawing.Size(150, 26);
      this.txt_puerto_BD.TabIndex = 39;
      // 
      // btn_test
      // 
      this.btn_test.Location = new System.Drawing.Point(466, 94);
      this.btn_test.Name = "btn_test";
      this.btn_test.Size = new System.Drawing.Size(92, 38);
      this.btn_test.TabIndex = 38;
      this.btn_test.Text = "xTest";
      this.btn_test.UseVisualStyleBackColor = true;
      this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
      // 
      // lbl_password_bd
      // 
      this.lbl_password_bd.AutoSize = true;
      this.lbl_password_bd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_password_bd.Location = new System.Drawing.Point(317, 65);
      this.lbl_password_bd.Name = "lbl_password_bd";
      this.lbl_password_bd.Size = new System.Drawing.Size(85, 18);
      this.lbl_password_bd.TabIndex = 37;
      this.lbl_password_bd.Text = "xPassword";
      // 
      // txt_password_bd
      // 
      this.txt_password_bd.BackColor = System.Drawing.Color.White;
      this.txt_password_bd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_password_bd.Location = new System.Drawing.Point(408, 62);
      this.txt_password_bd.Name = "txt_password_bd";
      this.txt_password_bd.PasswordChar = '*';
      this.txt_password_bd.Size = new System.Drawing.Size(150, 26);
      this.txt_password_bd.TabIndex = 36;
      // 
      // lbl_usuario_bd
      // 
      this.lbl_usuario_bd.AutoSize = true;
      this.lbl_usuario_bd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_usuario_bd.Location = new System.Drawing.Point(333, 33);
      this.lbl_usuario_bd.Name = "lbl_usuario_bd";
      this.lbl_usuario_bd.Size = new System.Drawing.Size(69, 18);
      this.lbl_usuario_bd.TabIndex = 35;
      this.lbl_usuario_bd.Text = "xUsuario";
      // 
      // txt_usuario_bd
      // 
      this.txt_usuario_bd.BackColor = System.Drawing.Color.White;
      this.txt_usuario_bd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_usuario_bd.Location = new System.Drawing.Point(408, 30);
      this.txt_usuario_bd.Name = "txt_usuario_bd";
      this.txt_usuario_bd.Size = new System.Drawing.Size(150, 26);
      this.txt_usuario_bd.TabIndex = 34;
      // 
      // lbl_database
      // 
      this.lbl_database.AutoSize = true;
      this.lbl_database.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_database.Location = new System.Drawing.Point(27, 65);
      this.lbl_database.Name = "lbl_database";
      this.lbl_database.Size = new System.Drawing.Size(98, 18);
      this.lbl_database.TabIndex = 33;
      this.lbl_database.Text = "xBase Datos";
      // 
      // txt_database
      // 
      this.txt_database.BackColor = System.Drawing.Color.White;
      this.txt_database.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_database.Location = new System.Drawing.Point(134, 62);
      this.txt_database.Name = "txt_database";
      this.txt_database.Size = new System.Drawing.Size(150, 26);
      this.txt_database.TabIndex = 32;
      // 
      // lbl_servidor_bd
      // 
      this.lbl_servidor_bd.AutoSize = true;
      this.lbl_servidor_bd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_servidor_bd.Location = new System.Drawing.Point(27, 33);
      this.lbl_servidor_bd.Name = "lbl_servidor_bd";
      this.lbl_servidor_bd.Size = new System.Drawing.Size(101, 18);
      this.lbl_servidor_bd.TabIndex = 31;
      this.lbl_servidor_bd.Text = "xServidor BD";
      // 
      // txt_servidor_bd
      // 
      this.txt_servidor_bd.BackColor = System.Drawing.Color.White;
      this.txt_servidor_bd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_servidor_bd.Location = new System.Drawing.Point(134, 30);
      this.txt_servidor_bd.Name = "txt_servidor_bd";
      this.txt_servidor_bd.Size = new System.Drawing.Size(150, 26);
      this.txt_servidor_bd.TabIndex = 30;
      // 
      // txt_path_webservices
      // 
      this.txt_path_webservices.BackColor = System.Drawing.Color.White;
      this.txt_path_webservices.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_path_webservices.Location = new System.Drawing.Point(130, 86);
      this.txt_path_webservices.Name = "txt_path_webservices";
      this.txt_path_webservices.Size = new System.Drawing.Size(429, 26);
      this.txt_path_webservices.TabIndex = 22;
      // 
      // lbl_path_webservices
      // 
      this.lbl_path_webservices.AutoSize = true;
      this.lbl_path_webservices.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_path_webservices.Location = new System.Drawing.Point(15, 89);
      this.lbl_path_webservices.Name = "lbl_path_webservices";
      this.lbl_path_webservices.Size = new System.Drawing.Size(109, 18);
      this.lbl_path_webservices.TabIndex = 21;
      this.lbl_path_webservices.Text = "xWebServices";
      // 
      // txt_path_datos
      // 
      this.txt_path_datos.BackColor = System.Drawing.Color.White;
      this.txt_path_datos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_path_datos.Location = new System.Drawing.Point(130, 54);
      this.txt_path_datos.Name = "txt_path_datos";
      this.txt_path_datos.Size = new System.Drawing.Size(429, 26);
      this.txt_path_datos.TabIndex = 20;
      // 
      // lbl_path_datos
      // 
      this.lbl_path_datos.AutoSize = true;
      this.lbl_path_datos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_path_datos.Location = new System.Drawing.Point(31, 57);
      this.lbl_path_datos.Name = "lbl_path_datos";
      this.lbl_path_datos.Size = new System.Drawing.Size(93, 18);
      this.lbl_path_datos.TabIndex = 19;
      this.lbl_path_datos.Text = "xRuta Datos";
      // 
      // txt_runtime
      // 
      this.txt_runtime.BackColor = System.Drawing.Color.White;
      this.txt_runtime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_runtime.Location = new System.Drawing.Point(130, 22);
      this.txt_runtime.Name = "txt_runtime";
      this.txt_runtime.Size = new System.Drawing.Size(429, 26);
      this.txt_runtime.TabIndex = 18;
      // 
      // lbl_runtime
      // 
      this.lbl_runtime.AutoSize = true;
      this.lbl_runtime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_runtime.Location = new System.Drawing.Point(12, 25);
      this.lbl_runtime.Name = "lbl_runtime";
      this.lbl_runtime.Size = new System.Drawing.Size(112, 18);
      this.lbl_runtime.TabIndex = 17;
      this.lbl_runtime.Text = "xRuta RunTime";
      // 
      // tp_crear_bd
      // 
      this.tp_crear_bd.BackColor = System.Drawing.SystemColors.Control;
      this.tp_crear_bd.Controls.Add(this.btn_crear_bd);
      this.tp_crear_bd.Controls.Add(this.lbl_password_admin);
      this.tp_crear_bd.Controls.Add(this.txt_password_admin);
      this.tp_crear_bd.Controls.Add(this.lbl_user_admin);
      this.tp_crear_bd.Controls.Add(this.txt_user_admin);
      this.tp_crear_bd.Location = new System.Drawing.Point(4, 22);
      this.tp_crear_bd.Name = "tp_crear_bd";
      this.tp_crear_bd.Padding = new System.Windows.Forms.Padding(3);
      this.tp_crear_bd.Size = new System.Drawing.Size(584, 163);
      this.tp_crear_bd.TabIndex = 2;
      this.tp_crear_bd.Text = "Crear BD";
      // 
      // btn_crear_bd
      // 
      this.btn_crear_bd.Location = new System.Drawing.Point(399, 9);
      this.btn_crear_bd.Name = "btn_crear_bd";
      this.btn_crear_bd.Size = new System.Drawing.Size(92, 38);
      this.btn_crear_bd.TabIndex = 43;
      this.btn_crear_bd.Text = "xCrear";
      this.btn_crear_bd.UseVisualStyleBackColor = true;
      this.btn_crear_bd.Click += new System.EventHandler(this.btn_crear_bd_Click);
      // 
      // lbl_password_admin
      // 
      this.lbl_password_admin.AutoSize = true;
      this.lbl_password_admin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_password_admin.Location = new System.Drawing.Point(23, 41);
      this.lbl_password_admin.Name = "lbl_password_admin";
      this.lbl_password_admin.Size = new System.Drawing.Size(133, 18);
      this.lbl_password_admin.TabIndex = 42;
      this.lbl_password_admin.Text = "xPassword Admin";
      // 
      // txt_password_admin
      // 
      this.txt_password_admin.BackColor = System.Drawing.Color.White;
      this.txt_password_admin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_password_admin.Location = new System.Drawing.Point(162, 38);
      this.txt_password_admin.Name = "txt_password_admin";
      this.txt_password_admin.PasswordChar = '*';
      this.txt_password_admin.Size = new System.Drawing.Size(150, 26);
      this.txt_password_admin.TabIndex = 41;
      // 
      // lbl_user_admin
      // 
      this.lbl_user_admin.AutoSize = true;
      this.lbl_user_admin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_user_admin.Location = new System.Drawing.Point(39, 9);
      this.lbl_user_admin.Name = "lbl_user_admin";
      this.lbl_user_admin.Size = new System.Drawing.Size(117, 18);
      this.lbl_user_admin.TabIndex = 40;
      this.lbl_user_admin.Text = "xUsuario Admin";
      // 
      // txt_user_admin
      // 
      this.txt_user_admin.BackColor = System.Drawing.Color.White;
      this.txt_user_admin.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_user_admin.Location = new System.Drawing.Point(162, 6);
      this.txt_user_admin.Name = "txt_user_admin";
      this.txt_user_admin.Size = new System.Drawing.Size(150, 26);
      this.txt_user_admin.TabIndex = 39;
      // 
      // frm_configuracion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(605, 287);
      this.Controls.Add(this.tb_conexiones);
      this.Controls.Add(this.lbl_color);
      this.Controls.Add(this.txt_color);
      this.Controls.Add(this.btn_seleccionar_color);
      this.Controls.Add(this.btn_guardar);
      this.Name = "frm_configuracion";
      this.Text = "Configuración";
      this.Load += new System.EventHandler(this.frm_configuracion_Load);
      this.tb_conexiones.ResumeLayout(false);
      this.tp_conexion_cobol.ResumeLayout(false);
      this.tp_conexion_cobol.PerformLayout();
      this.tp_conexion_bd.ResumeLayout(false);
      this.tp_conexion_bd.PerformLayout();
      this.tp_crear_bd.ResumeLayout(false);
      this.tp_crear_bd.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_color;
    private System.Windows.Forms.TextBox txt_color;
    private System.Windows.Forms.Button btn_seleccionar_color;
    private System.Windows.Forms.Button btn_guardar;
    private System.Windows.Forms.ColorDialog colorDialog1;
    private System.Windows.Forms.TabControl tb_conexiones;
    private System.Windows.Forms.TabPage tp_conexion_cobol;
    private System.Windows.Forms.TabPage tp_conexion_bd;
    private System.Windows.Forms.Label lbl_puerto;
    private System.Windows.Forms.TextBox txt_puerto_BD;
    private System.Windows.Forms.Button btn_test;
    private System.Windows.Forms.Label lbl_password_bd;
    private System.Windows.Forms.TextBox txt_password_bd;
    private System.Windows.Forms.Label lbl_usuario_bd;
    private System.Windows.Forms.TextBox txt_usuario_bd;
    private System.Windows.Forms.Label lbl_database;
    private System.Windows.Forms.TextBox txt_database;
    private System.Windows.Forms.Label lbl_servidor_bd;
    private System.Windows.Forms.TextBox txt_servidor_bd;
    private System.Windows.Forms.TextBox txt_path_webservices;
    private System.Windows.Forms.Label lbl_path_webservices;
    private System.Windows.Forms.TextBox txt_path_datos;
    private System.Windows.Forms.Label lbl_path_datos;
    private System.Windows.Forms.TextBox txt_runtime;
    private System.Windows.Forms.Label lbl_runtime;
    private System.Windows.Forms.TabPage tp_crear_bd;
    private System.Windows.Forms.Button btn_crear_bd;
    private System.Windows.Forms.Label lbl_password_admin;
    private System.Windows.Forms.TextBox txt_password_admin;
    private System.Windows.Forms.Label lbl_user_admin;
    private System.Windows.Forms.TextBox txt_user_admin;
  }
}