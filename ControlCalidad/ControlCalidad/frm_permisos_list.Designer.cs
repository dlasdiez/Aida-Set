namespace ControlCalidad
{
  partial class frm_permisos_list
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
      this.btn_new = new System.Windows.Forms.Button();
      this.pnl_contenedor.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnl_contenedor
      // 
      this.pnl_contenedor.Size = new System.Drawing.Size(455, 485);
      // 
      // pnl_filtro
      // 
      this.pnl_filtro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.pnl_filtro.Size = new System.Drawing.Size(455, 87);
      // 
      // pnl_datos
      // 
      this.pnl_datos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.pnl_datos.Location = new System.Drawing.Point(0, 90);
      this.pnl_datos.Size = new System.Drawing.Size(455, 395);
      // 
      // btn_new
      // 
      this.btn_new.Location = new System.Drawing.Point(639, 373);
      this.btn_new.Name = "btn_new";
      this.btn_new.Size = new System.Drawing.Size(75, 23);
      this.btn_new.TabIndex = 1;
      this.btn_new.Text = "Nuevo";
      this.btn_new.UseVisualStyleBackColor = true;
      // 
      // frm_permisos_list
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(575, 485);
      this.Controls.Add(this.btn_new);
      this.Name = "frm_permisos_list";
      this.Text = "frm_permisos_list";
      this.Controls.SetChildIndex(this.btn_new, 0);
      this.Controls.SetChildIndex(this.pnl_contenedor, 0);
      this.pnl_contenedor.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_new;
  }
}