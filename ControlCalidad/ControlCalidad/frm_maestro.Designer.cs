namespace ControlCalidad
{
  partial class frm_maestro
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_maestro));
      this.btn_salir = new System.Windows.Forms.Button();
      this.btn_guardar = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // btn_salir
      // 
      this.btn_salir.Location = new System.Drawing.Point(825, 441);
      this.btn_salir.Name = "btn_salir";
      this.btn_salir.Size = new System.Drawing.Size(75, 23);
      this.btn_salir.TabIndex = 32;
      this.btn_salir.Text = "Salir";
      this.btn_salir.UseVisualStyleBackColor = true;
      this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
      // 
      // btn_guardar
      // 
      this.btn_guardar.Location = new System.Drawing.Point(825, 412);
      this.btn_guardar.Name = "btn_guardar";
      this.btn_guardar.Size = new System.Drawing.Size(75, 23);
      this.btn_guardar.TabIndex = 31;
      this.btn_guardar.Text = "Guardar";
      this.btn_guardar.UseVisualStyleBackColor = true;
      this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(804, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(96, 66);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pictureBox1.TabIndex = 33;
      this.pictureBox1.TabStop = false;
      // 
      // frm_maestro
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(912, 477);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.btn_salir);
      this.Controls.Add(this.btn_guardar);
      this.Name = "frm_maestro";
      this.Text = "frm_maestro";
      this.Load += new System.EventHandler(this.frm_maestro_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_salir;
    private System.Windows.Forms.Button btn_guardar;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}