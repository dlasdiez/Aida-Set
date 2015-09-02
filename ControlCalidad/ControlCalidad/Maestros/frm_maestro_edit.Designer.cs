namespace ControlCalidad
{
  partial class frm_maestro_edit
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_maestro_edit));
      this.btn_salir = new System.Windows.Forms.Button();
      this.btn_guardar = new System.Windows.Forms.Button();
      this.pb_logo = new System.Windows.Forms.PictureBox();
      this.pnl_botones = new System.Windows.Forms.Panel();
      this.pnl_contenedor = new System.Windows.Forms.Panel();
      this.Error = new System.Windows.Forms.ErrorProvider(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
      this.pnl_botones.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
      this.SuspendLayout();
      // 
      // btn_salir
      // 
      this.btn_salir.Location = new System.Drawing.Point(13, 323);
      this.btn_salir.Name = "btn_salir";
      this.btn_salir.Size = new System.Drawing.Size(96, 45);
      this.btn_salir.TabIndex = 32;
      this.btn_salir.Text = "Salir";
      this.btn_salir.UseVisualStyleBackColor = true;
      this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
      // 
      // btn_guardar
      // 
      this.btn_guardar.Location = new System.Drawing.Point(13, 272);
      this.btn_guardar.Name = "btn_guardar";
      this.btn_guardar.Size = new System.Drawing.Size(96, 45);
      this.btn_guardar.TabIndex = 31;
      this.btn_guardar.Text = "Guardar";
      this.btn_guardar.UseVisualStyleBackColor = true;
      this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
      // 
      // pb_logo
      // 
      this.pb_logo.Image = ((System.Drawing.Image)(resources.GetObject("pb_logo.Image")));
      this.pb_logo.Location = new System.Drawing.Point(13, 12);
      this.pb_logo.Name = "pb_logo";
      this.pb_logo.Size = new System.Drawing.Size(96, 66);
      this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pb_logo.TabIndex = 34;
      this.pb_logo.TabStop = false;
      // 
      // pnl_botones
      // 
      this.pnl_botones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnl_botones.Controls.Add(this.btn_guardar);
      this.pnl_botones.Controls.Add(this.pb_logo);
      this.pnl_botones.Controls.Add(this.btn_salir);
      this.pnl_botones.Dock = System.Windows.Forms.DockStyle.Right;
      this.pnl_botones.Location = new System.Drawing.Point(439, 0);
      this.pnl_botones.Name = "pnl_botones";
      this.pnl_botones.Size = new System.Drawing.Size(121, 377);
      this.pnl_botones.TabIndex = 35;
      // 
      // pnl_contenedor
      // 
      this.pnl_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_contenedor.Location = new System.Drawing.Point(0, 0);
      this.pnl_contenedor.Name = "pnl_contenedor";
      this.pnl_contenedor.Size = new System.Drawing.Size(439, 377);
      this.pnl_contenedor.TabIndex = 33;
      // 
      // Error
      // 
      this.Error.ContainerControl = this;
      // 
      // frm_maestro
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(560, 377);
      this.Controls.Add(this.pnl_contenedor);
      this.Controls.Add(this.pnl_botones);
      this.Name = "frm_maestro";
      this.Text = "frm_maestro";
      this.Load += new System.EventHandler(this.frm_maestro_edit_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
      this.pnl_botones.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.PictureBox pb_logo;
    private System.Windows.Forms.Panel pnl_botones;
    public System.Windows.Forms.Button btn_salir;
    public System.Windows.Forms.Button btn_guardar;
    public System.Windows.Forms.Panel pnl_contenedor;
    public System.Windows.Forms.ErrorProvider Error;
  }
}