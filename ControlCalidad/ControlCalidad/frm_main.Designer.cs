﻿namespace ControlCalidad
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
      this.btn_registro_garantia_tramite = new System.Windows.Forms.Button();
      this.btn_expediente = new System.Windows.Forms.Button();
      this.btn_evaluacion_piezas = new System.Windows.Forms.Button();
      this.btn_evaluacion_muestras_report = new System.Windows.Forms.Button();
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
      // btn_registro_garantia_tramite
      // 
      this.btn_registro_garantia_tramite.Location = new System.Drawing.Point(36, 114);
      this.btn_registro_garantia_tramite.Name = "btn_registro_garantia_tramite";
      this.btn_registro_garantia_tramite.Size = new System.Drawing.Size(75, 49);
      this.btn_registro_garantia_tramite.TabIndex = 1;
      this.btn_registro_garantia_tramite.Text = "Registro de garantias en tramite";
      this.btn_registro_garantia_tramite.UseVisualStyleBackColor = true;
      this.btn_registro_garantia_tramite.Click += new System.EventHandler(this.btn_registro_garantia_tramite_Click);
      // 
      // btn_expediente
      // 
      this.btn_expediente.Location = new System.Drawing.Point(281, 38);
      this.btn_expediente.Name = "btn_expediente";
      this.btn_expediente.Size = new System.Drawing.Size(75, 49);
      this.btn_expediente.TabIndex = 2;
      this.btn_expediente.Text = "Expediente";
      this.btn_expediente.UseVisualStyleBackColor = true;
      this.btn_expediente.Click += new System.EventHandler(this.btn_expediente_Click);
      // 
      // btn_evaluacion_piezas
      // 
      this.btn_evaluacion_piezas.Location = new System.Drawing.Point(281, 114);
      this.btn_evaluacion_piezas.Name = "btn_evaluacion_piezas";
      this.btn_evaluacion_piezas.Size = new System.Drawing.Size(75, 49);
      this.btn_evaluacion_piezas.TabIndex = 3;
      this.btn_evaluacion_piezas.Text = "Evaluación Piezas";
      this.btn_evaluacion_piezas.UseVisualStyleBackColor = true;
      this.btn_evaluacion_piezas.Click += new System.EventHandler(this.btn_evaluacion_piezas_Click);
      // 
      // btn_evaluacion_muestras_report
      // 
      this.btn_evaluacion_muestras_report.Location = new System.Drawing.Point(36, 197);
      this.btn_evaluacion_muestras_report.Name = "btn_evaluacion_muestras_report";
      this.btn_evaluacion_muestras_report.Size = new System.Drawing.Size(75, 49);
      this.btn_evaluacion_muestras_report.TabIndex = 4;
      this.btn_evaluacion_muestras_report.Text = "Evaluación Muestras Report";
      this.btn_evaluacion_muestras_report.UseVisualStyleBackColor = true;
      this.btn_evaluacion_muestras_report.Click += new System.EventHandler(this.btn_evaluacion_muestras_report_Click);
      // 
      // frm_main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.ClientSize = new System.Drawing.Size(447, 363);
      this.Controls.Add(this.btn_evaluacion_muestras_report);
      this.Controls.Add(this.btn_evaluacion_piezas);
      this.Controls.Add(this.btn_expediente);
      this.Controls.Add(this.btn_registro_garantia_tramite);
      this.Controls.Add(this.btn_registro_qc_entrada);
      this.DoubleBuffered = true;
      this.Name = "frm_main";
      this.Text = "Seleccione una opción";
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_registro_qc_entrada;
        private System.Windows.Forms.Button btn_registro_garantia_tramite;
        private System.Windows.Forms.Button btn_expediente;
        private System.Windows.Forms.Button btn_evaluacion_piezas;
        private System.Windows.Forms.Button btn_evaluacion_muestras_report;
    }
}

