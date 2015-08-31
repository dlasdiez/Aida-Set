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
      this.dgv_permisos = new System.Windows.Forms.DataGridView();
      this.btn_new = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_permisos)).BeginInit();
      this.SuspendLayout();
      // 
      // dgv_permisos
      // 
      this.dgv_permisos.AllowUserToAddRows = false;
      this.dgv_permisos.AllowUserToDeleteRows = false;
      this.dgv_permisos.AllowUserToResizeColumns = false;
      this.dgv_permisos.AllowUserToResizeRows = false;
      this.dgv_permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_permisos.Location = new System.Drawing.Point(1, 64);
      this.dgv_permisos.Name = "dgv_permisos";
      this.dgv_permisos.Size = new System.Drawing.Size(598, 412);
      this.dgv_permisos.TabIndex = 0;
      this.dgv_permisos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_permisos_CellDoubleClick);
      // 
      // btn_new
      // 
      this.btn_new.Location = new System.Drawing.Point(639, 373);
      this.btn_new.Name = "btn_new";
      this.btn_new.Size = new System.Drawing.Size(75, 23);
      this.btn_new.TabIndex = 1;
      this.btn_new.Text = "Nuevo";
      this.btn_new.UseVisualStyleBackColor = true;
      this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
      // 
      // frm_permisos_list
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(763, 488);
      this.Controls.Add(this.btn_new);
      this.Controls.Add(this.dgv_permisos);
      this.Name = "frm_permisos_list";
      this.Text = "frm_permisos_list";
      this.Load += new System.EventHandler(this.frm_permisos_list_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_permisos)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dgv_permisos;
    private System.Windows.Forms.Button btn_new;
  }
}