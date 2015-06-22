namespace Configuración
{
    partial class frm_config
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
            this.txt_runtime = new System.Windows.Forms.TextBox();
            this.lbl_runtime = new System.Windows.Forms.Label();
            this.txt_path_datos = new System.Windows.Forms.TextBox();
            this.lbl_path_datos = new System.Windows.Forms.Label();
            this.txt_path_webservices = new System.Windows.Forms.TextBox();
            this.lbl_path_webservices = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_seleccionar_color = new System.Windows.Forms.Button();
            this.txt_color = new System.Windows.Forms.TextBox();
            this.lbl_color = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.txt_terminal = new System.Windows.Forms.TextBox();
            this.lbl_terminal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_runtime
            // 
            this.txt_runtime.BackColor = System.Drawing.Color.White;
            this.txt_runtime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_runtime.Location = new System.Drawing.Point(155, 43);
            this.txt_runtime.Name = "txt_runtime";
            this.txt_runtime.Size = new System.Drawing.Size(228, 26);
            this.txt_runtime.TabIndex = 6;
            // 
            // lbl_runtime
            // 
            this.lbl_runtime.AutoSize = true;
            this.lbl_runtime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_runtime.Location = new System.Drawing.Point(15, 46);
            this.lbl_runtime.Name = "lbl_runtime";
            this.lbl_runtime.Size = new System.Drawing.Size(76, 18);
            this.lbl_runtime.TabIndex = 5;
            this.lbl_runtime.Text = "xRunTime";
            // 
            // txt_path_datos
            // 
            this.txt_path_datos.BackColor = System.Drawing.Color.White;
            this.txt_path_datos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path_datos.Location = new System.Drawing.Point(155, 75);
            this.txt_path_datos.Name = "txt_path_datos";
            this.txt_path_datos.Size = new System.Drawing.Size(228, 26);
            this.txt_path_datos.TabIndex = 8;
            // 
            // lbl_path_datos
            // 
            this.lbl_path_datos.AutoSize = true;
            this.lbl_path_datos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_path_datos.Location = new System.Drawing.Point(15, 78);
            this.lbl_path_datos.Name = "lbl_path_datos";
            this.lbl_path_datos.Size = new System.Drawing.Size(57, 18);
            this.lbl_path_datos.TabIndex = 7;
            this.lbl_path_datos.Text = "xDatos";
            // 
            // txt_path_webservices
            // 
            this.txt_path_webservices.BackColor = System.Drawing.Color.White;
            this.txt_path_webservices.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_path_webservices.Location = new System.Drawing.Point(155, 107);
            this.txt_path_webservices.Name = "txt_path_webservices";
            this.txt_path_webservices.Size = new System.Drawing.Size(228, 26);
            this.txt_path_webservices.TabIndex = 10;
            // 
            // lbl_path_webservices
            // 
            this.lbl_path_webservices.AutoSize = true;
            this.lbl_path_webservices.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_path_webservices.Location = new System.Drawing.Point(15, 110);
            this.lbl_path_webservices.Name = "lbl_path_webservices";
            this.lbl_path_webservices.Size = new System.Drawing.Size(109, 18);
            this.lbl_path_webservices.TabIndex = 9;
            this.lbl_path_webservices.Text = "xWebServices";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(411, 205);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(92, 38);
            this.btn_guardar.TabIndex = 11;
            this.btn_guardar.Text = "xGuardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_seleccionar_color
            // 
            this.btn_seleccionar_color.Location = new System.Drawing.Point(389, 142);
            this.btn_seleccionar_color.Name = "btn_seleccionar_color";
            this.btn_seleccionar_color.Size = new System.Drawing.Size(75, 23);
            this.btn_seleccionar_color.TabIndex = 12;
            this.btn_seleccionar_color.Text = "button1";
            this.btn_seleccionar_color.UseVisualStyleBackColor = true;
            this.btn_seleccionar_color.Click += new System.EventHandler(this.btn_seleccionar_color_Click);
            // 
            // txt_color
            // 
            this.txt_color.BackColor = System.Drawing.Color.White;
            this.txt_color.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_color.Location = new System.Drawing.Point(155, 139);
            this.txt_color.Name = "txt_color";
            this.txt_color.Size = new System.Drawing.Size(228, 26);
            this.txt_color.TabIndex = 13;
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.Location = new System.Drawing.Point(15, 142);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(53, 18);
            this.lbl_color.TabIndex = 14;
            this.lbl_color.Text = "xColor";
            // 
            // txt_terminal
            // 
            this.txt_terminal.BackColor = System.Drawing.Color.White;
            this.txt_terminal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_terminal.Location = new System.Drawing.Point(155, 171);
            this.txt_terminal.Name = "txt_terminal";
            this.txt_terminal.Size = new System.Drawing.Size(228, 26);
            this.txt_terminal.TabIndex = 15;
            // 
            // lbl_terminal
            // 
            this.lbl_terminal.AutoSize = true;
            this.lbl_terminal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_terminal.Location = new System.Drawing.Point(19, 174);
            this.lbl_terminal.Name = "lbl_terminal";
            this.lbl_terminal.Size = new System.Drawing.Size(73, 18);
            this.lbl_terminal.TabIndex = 16;
            this.lbl_terminal.Text = "xTerminal";
            // 
            // frm_config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 255);
            this.Controls.Add(this.lbl_terminal);
            this.Controls.Add(this.txt_terminal);
            this.Controls.Add(this.lbl_color);
            this.Controls.Add(this.txt_color);
            this.Controls.Add(this.btn_seleccionar_color);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_path_webservices);
            this.Controls.Add(this.lbl_path_webservices);
            this.Controls.Add(this.txt_path_datos);
            this.Controls.Add(this.lbl_path_datos);
            this.Controls.Add(this.txt_runtime);
            this.Controls.Add(this.lbl_runtime);
            this.Name = "frm_config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuración";
            this.Load += new System.EventHandler(this.frm_config_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_runtime;
        private System.Windows.Forms.Label lbl_runtime;
        private System.Windows.Forms.TextBox txt_path_datos;
        private System.Windows.Forms.Label lbl_path_datos;
        private System.Windows.Forms.TextBox txt_path_webservices;
        private System.Windows.Forms.Label lbl_path_webservices;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_seleccionar_color;
        private System.Windows.Forms.TextBox txt_color;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox txt_terminal;
        private System.Windows.Forms.Label lbl_terminal;
    }
}

