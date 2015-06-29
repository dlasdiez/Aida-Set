namespace ControlCalidad
{
    partial class frm_main
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
          this.btn_registro_qc_entrada = new System.Windows.Forms.Button();
          this.SuspendLayout();
          // 
          // btn_registro_qc_entrada
          // 
          this.btn_registro_qc_entrada.Location = new System.Drawing.Point(36, 38);
          this.btn_registro_qc_entrada.Name = "btn_registro_qc_entrada";
          this.btn_registro_qc_entrada.Size = new System.Drawing.Size(75, 49);
          this.btn_registro_qc_entrada.TabIndex = 0;
          this.btn_registro_qc_entrada.Text = "Registro QC entrada";
          this.btn_registro_qc_entrada.UseVisualStyleBackColor = true;
          this.btn_registro_qc_entrada.Click += new System.EventHandler(this.btn_registro_qc_entrada_Click);
          // 
          // frm_main
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
          this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
          this.ClientSize = new System.Drawing.Size(447, 363);
          this.Controls.Add(this.btn_registro_qc_entrada);
          this.DoubleBuffered = true;
          this.Name = "frm_main";
          this.Text = "Seleccione una opción";
          this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_registro_qc_entrada;
    }
}

