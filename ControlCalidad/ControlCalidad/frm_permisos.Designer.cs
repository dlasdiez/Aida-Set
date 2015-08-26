namespace ControlCalidad
{
  partial class frm_permisos
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
      this.lbl_usuario = new System.Windows.Forms.Label();
      this.txt_usuario = new System.Windows.Forms.TextBox();
      this.dgv_permisos = new System.Windows.Forms.DataGridView();
      this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.id_modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.modulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.lectura = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.baja = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.modificar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
      this.pnl_contenedor.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Error)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_permisos)).BeginInit();
      this.SuspendLayout();
      // 
      // btn_salir
      // 
      this.btn_salir.Location = new System.Drawing.Point(13, 184);
      // 
      // btn_guardar
      // 
      this.btn_guardar.Location = new System.Drawing.Point(13, 133);
      // 
      // pnl_contenedor
      // 
      this.pnl_contenedor.Controls.Add(this.dgv_permisos);
      this.pnl_contenedor.Controls.Add(this.lbl_usuario);
      this.pnl_contenedor.Controls.Add(this.txt_usuario);
      this.pnl_contenedor.Size = new System.Drawing.Size(719, 247);
      // 
      // lbl_usuario
      // 
      this.lbl_usuario.AutoSize = true;
      this.lbl_usuario.Location = new System.Drawing.Point(38, 33);
      this.lbl_usuario.Name = "lbl_usuario";
      this.lbl_usuario.Size = new System.Drawing.Size(43, 13);
      this.lbl_usuario.TabIndex = 37;
      this.lbl_usuario.Text = "Usuario";
      // 
      // txt_usuario
      // 
      this.txt_usuario.Location = new System.Drawing.Point(87, 30);
      this.txt_usuario.Name = "txt_usuario";
      this.txt_usuario.Size = new System.Drawing.Size(100, 20);
      this.txt_usuario.TabIndex = 36;
      // 
      // dgv_permisos
      // 
      this.dgv_permisos.AllowUserToAddRows = false;
      this.dgv_permisos.AllowUserToDeleteRows = false;
      this.dgv_permisos.AllowUserToResizeColumns = false;
      this.dgv_permisos.AllowUserToResizeRows = false;
      this.dgv_permisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_permisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.id_modulo,
            this.modulo,
            this.lectura,
            this.baja,
            this.modificar});
      this.dgv_permisos.Location = new System.Drawing.Point(41, 70);
      this.dgv_permisos.Name = "dgv_permisos";
      this.dgv_permisos.Size = new System.Drawing.Size(660, 161);
      this.dgv_permisos.TabIndex = 38;
      // 
      // id
      // 
      this.id.HeaderText = "ID";
      this.id.Name = "id";
      this.id.Visible = false;
      // 
      // id_modulo
      // 
      this.id_modulo.HeaderText = "ID_Modulo";
      this.id_modulo.Name = "id_modulo";
      this.id_modulo.Visible = false;
      // 
      // modulo
      // 
      this.modulo.HeaderText = "Módulo";
      this.modulo.Name = "modulo";
      this.modulo.ReadOnly = true;
      this.modulo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.modulo.Width = 300;
      // 
      // lectura
      // 
      this.lectura.FalseValue = "0";
      this.lectura.HeaderText = "Lectura";
      this.lectura.IndeterminateValue = "0";
      this.lectura.Name = "lectura";
      this.lectura.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.lectura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.lectura.TrueValue = "1";
      // 
      // baja
      // 
      this.baja.FalseValue = "0";
      this.baja.HeaderText = "Baja";
      this.baja.IndeterminateValue = "0";
      this.baja.Name = "baja";
      this.baja.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.baja.TrueValue = "1";
      // 
      // modificar
      // 
      this.modificar.FalseValue = "0";
      this.modificar.HeaderText = "Modificación";
      this.modificar.IndeterminateValue = "0";
      this.modificar.Name = "modificar";
      this.modificar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
      this.modificar.TrueValue = "1";
      // 
      // frm_permisos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(840, 247);
      this.Name = "frm_permisos";
      this.Text = "frm_permisos";
      this.Load += new System.EventHandler(this.frm_permisos_Load);
      this.pnl_contenedor.ResumeLayout(false);
      this.pnl_contenedor.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.Error)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_permisos)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label lbl_usuario;
    private System.Windows.Forms.TextBox txt_usuario;
    private System.Windows.Forms.DataGridView dgv_permisos;
    private System.Windows.Forms.DataGridViewTextBoxColumn id;
    private System.Windows.Forms.DataGridViewTextBoxColumn id_modulo;
    private System.Windows.Forms.DataGridViewTextBoxColumn modulo;
    private System.Windows.Forms.DataGridViewCheckBoxColumn lectura;
    private System.Windows.Forms.DataGridViewCheckBoxColumn baja;
    private System.Windows.Forms.DataGridViewCheckBoxColumn modificar;
  }
}