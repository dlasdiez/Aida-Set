namespace ControlCalidad
{
  partial class frm_maestro_list
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_maestro_list));
      this.pnl_lateral = new System.Windows.Forms.Panel();
      this.pb_logo = new System.Windows.Forms.PictureBox();
      this.pnl_botones = new System.Windows.Forms.Panel();
      this.btn_salir = new System.Windows.Forms.Button();
      this.pnl_contenedor = new System.Windows.Forms.Panel();
      this.pnl_filtro = new System.Windows.Forms.Panel();
      this.pnl_datos = new System.Windows.Forms.Panel();
      this.dgv_list = new System.Windows.Forms.DataGridView();
      this.btn_new = new System.Windows.Forms.Button();
      this.pnl_lateral.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
      this.pnl_botones.SuspendLayout();
      this.pnl_contenedor.SuspendLayout();
      this.pnl_datos.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).BeginInit();
      this.SuspendLayout();
      // 
      // pnl_lateral
      // 
      this.pnl_lateral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnl_lateral.Controls.Add(this.pb_logo);
      this.pnl_lateral.Controls.Add(this.pnl_botones);
      this.pnl_lateral.Dock = System.Windows.Forms.DockStyle.Right;
      this.pnl_lateral.Location = new System.Drawing.Point(425, 0);
      this.pnl_lateral.Name = "pnl_lateral";
      this.pnl_lateral.Size = new System.Drawing.Size(120, 481);
      this.pnl_lateral.TabIndex = 36;
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
      this.pnl_botones.Controls.Add(this.btn_new);
      this.pnl_botones.Controls.Add(this.btn_salir);
      this.pnl_botones.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnl_botones.Location = new System.Drawing.Point(0, 195);
      this.pnl_botones.Name = "pnl_botones";
      this.pnl_botones.Size = new System.Drawing.Size(118, 284);
      this.pnl_botones.TabIndex = 35;
      // 
      // btn_salir
      // 
      this.btn_salir.Location = new System.Drawing.Point(13, 228);
      this.btn_salir.Name = "btn_salir";
      this.btn_salir.Size = new System.Drawing.Size(96, 45);
      this.btn_salir.TabIndex = 32;
      this.btn_salir.Text = "Salir";
      this.btn_salir.UseVisualStyleBackColor = true;
      this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
      // 
      // pnl_contenedor
      // 
      this.pnl_contenedor.Controls.Add(this.pnl_filtro);
      this.pnl_contenedor.Controls.Add(this.pnl_datos);
      this.pnl_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_contenedor.Location = new System.Drawing.Point(0, 0);
      this.pnl_contenedor.Name = "pnl_contenedor";
      this.pnl_contenedor.Size = new System.Drawing.Size(425, 481);
      this.pnl_contenedor.TabIndex = 37;
      // 
      // pnl_filtro
      // 
      this.pnl_filtro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pnl_filtro.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnl_filtro.Location = new System.Drawing.Point(0, 0);
      this.pnl_filtro.Name = "pnl_filtro";
      this.pnl_filtro.Size = new System.Drawing.Size(425, 87);
      this.pnl_filtro.TabIndex = 2;
      // 
      // pnl_datos
      // 
      this.pnl_datos.Controls.Add(this.dgv_list);
      this.pnl_datos.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pnl_datos.Location = new System.Drawing.Point(0, 93);
      this.pnl_datos.Name = "pnl_datos";
      this.pnl_datos.Size = new System.Drawing.Size(425, 388);
      this.pnl_datos.TabIndex = 3;
      // 
      // dgv_list
      // 
      this.dgv_list.AllowUserToAddRows = false;
      this.dgv_list.AllowUserToDeleteRows = false;
      this.dgv_list.AllowUserToResizeColumns = false;
      this.dgv_list.AllowUserToResizeRows = false;
      this.dgv_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgv_list.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgv_list.Location = new System.Drawing.Point(0, 0);
      this.dgv_list.Name = "dgv_list";
      this.dgv_list.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
      this.dgv_list.Size = new System.Drawing.Size(425, 388);
      this.dgv_list.TabIndex = 1;
      this.dgv_list.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_list_CellDoubleClick);
      // 
      // btn_new
      // 
      this.btn_new.Location = new System.Drawing.Point(13, 177);
      this.btn_new.Name = "btn_new";
      this.btn_new.Size = new System.Drawing.Size(96, 45);
      this.btn_new.TabIndex = 33;
      this.btn_new.Text = "Nuevo";
      this.btn_new.UseVisualStyleBackColor = true;
      this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
      // 
      // frm_maestro_list
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(545, 481);
      this.Controls.Add(this.pnl_contenedor);
      this.Controls.Add(this.pnl_lateral);
      this.Name = "frm_maestro_list";
      this.Text = "frm_maestro_list";
      this.Load += new System.EventHandler(this.frm_maestro_list_Load);
      this.pnl_lateral.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
      this.pnl_botones.ResumeLayout(false);
      this.pnl_contenedor.ResumeLayout(false);
      this.pnl_datos.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgv_list)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnl_lateral;
    private System.Windows.Forms.PictureBox pb_logo;
    public System.Windows.Forms.Panel pnl_contenedor;
    public System.Windows.Forms.DataGridView dgv_list;
    public System.Windows.Forms.Panel pnl_filtro;
    public System.Windows.Forms.Panel pnl_datos;
    private System.Windows.Forms.Panel pnl_botones;
    private System.Windows.Forms.Button btn_salir;
    private System.Windows.Forms.Button btn_new;
  }
}