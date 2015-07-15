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
      this.SuspendLayout();
      // 
      // lbl_color
      // 
      this.lbl_color.AutoSize = true;
      this.lbl_color.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbl_color.Location = new System.Drawing.Point(19, 112);
      this.lbl_color.Name = "lbl_color";
      this.lbl_color.Size = new System.Drawing.Size(53, 18);
      this.lbl_color.TabIndex = 18;
      this.lbl_color.Text = "xColor";
      // 
      // txt_color
      // 
      this.txt_color.BackColor = System.Drawing.Color.White;
      this.txt_color.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txt_color.Location = new System.Drawing.Point(159, 109);
      this.txt_color.Name = "txt_color";
      this.txt_color.Size = new System.Drawing.Size(228, 26);
      this.txt_color.TabIndex = 17;
      // 
      // btn_seleccionar_color
      // 
      this.btn_seleccionar_color.Location = new System.Drawing.Point(393, 112);
      this.btn_seleccionar_color.Name = "btn_seleccionar_color";
      this.btn_seleccionar_color.Size = new System.Drawing.Size(75, 23);
      this.btn_seleccionar_color.TabIndex = 16;
      this.btn_seleccionar_color.Text = "button1";
      this.btn_seleccionar_color.UseVisualStyleBackColor = true;
      this.btn_seleccionar_color.Click += new System.EventHandler(this.btn_seleccionar_color_Click);
      // 
      // btn_guardar
      // 
      this.btn_guardar.Location = new System.Drawing.Point(415, 175);
      this.btn_guardar.Name = "btn_guardar";
      this.btn_guardar.Size = new System.Drawing.Size(92, 38);
      this.btn_guardar.TabIndex = 15;
      this.btn_guardar.Text = "xGuardar";
      this.btn_guardar.UseVisualStyleBackColor = true;
      this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
      // 
      // frm_configuracion
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(515, 255);
      this.Controls.Add(this.lbl_color);
      this.Controls.Add(this.txt_color);
      this.Controls.Add(this.btn_seleccionar_color);
      this.Controls.Add(this.btn_guardar);
      this.Name = "frm_configuracion";
      this.Text = "Configuración";
      this.Load += new System.EventHandler(this.frm_configuracion_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lbl_color;
    private System.Windows.Forms.TextBox txt_color;
    private System.Windows.Forms.Button btn_seleccionar_color;
    private System.Windows.Forms.Button btn_guardar;
    private System.Windows.Forms.ColorDialog colorDialog1;
  }
}