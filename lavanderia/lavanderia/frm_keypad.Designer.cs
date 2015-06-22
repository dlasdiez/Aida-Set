namespace lavanderia
{
    partial class frm_keypad
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnl_label = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_sup = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_1 = new System.Windows.Forms.Button();
            this.txt_amount = new System.Windows.Forms.TextBox();
            this.gb_buttons = new System.Windows.Forms.GroupBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnl_label.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.gb_buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pnl_label);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnl_buttons);
            this.splitContainer1.Size = new System.Drawing.Size(430, 567);
            this.splitContainer1.SplitterDistance = 41;
            this.splitContainer1.TabIndex = 0;
            // 
            // pnl_label
            // 
            this.pnl_label.Controls.Add(this.lbl_title);
            this.pnl_label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_label.Location = new System.Drawing.Point(0, 0);
            this.pnl_label.Name = "pnl_label";
            this.pnl_label.Size = new System.Drawing.Size(430, 41);
            this.pnl_label.TabIndex = 0;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(42, 18);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "xTitle";
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.gb_buttons);
            this.pnl_buttons.Controls.Add(this.txt_amount);
            this.pnl_buttons.Controls.Add(this.btn_sup);
            this.pnl_buttons.Controls.Add(this.btn_ok);
            this.pnl_buttons.Controls.Add(this.btn_0);
            this.pnl_buttons.Controls.Add(this.btn_9);
            this.pnl_buttons.Controls.Add(this.btn_8);
            this.pnl_buttons.Controls.Add(this.btn_7);
            this.pnl_buttons.Controls.Add(this.btn_6);
            this.pnl_buttons.Controls.Add(this.btn_5);
            this.pnl_buttons.Controls.Add(this.btn_4);
            this.pnl_buttons.Controls.Add(this.btn_3);
            this.pnl_buttons.Controls.Add(this.btn_2);
            this.pnl_buttons.Controls.Add(this.btn_1);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_buttons.Location = new System.Drawing.Point(0, 0);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(430, 522);
            this.pnl_buttons.TabIndex = 1;
            // 
            // btn_sup
            // 
            this.btn_sup.Location = new System.Drawing.Point(258, 76);
            this.btn_sup.Name = "btn_sup";
            this.btn_sup.Size = new System.Drawing.Size(156, 75);
            this.btn_sup.TabIndex = 11;
            this.btn_sup.Text = "<--";
            this.btn_sup.UseVisualStyleBackColor = true;
            this.btn_sup.Click += new System.EventHandler(this.btn_sup_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(258, 238);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(156, 156);
            this.btn_ok.TabIndex = 10;
            this.btn_ok.Text = "xOk";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(15, 319);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(156, 75);
            this.btn_0.TabIndex = 9;
            this.btn_0.Text = "x0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(177, 238);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(75, 75);
            this.btn_9.TabIndex = 8;
            this.btn_9.Text = "x9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(96, 238);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(75, 75);
            this.btn_8.TabIndex = 7;
            this.btn_8.Text = "x8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(15, 238);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(75, 75);
            this.btn_7.TabIndex = 6;
            this.btn_7.Text = "x7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(177, 157);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(75, 75);
            this.btn_6.TabIndex = 5;
            this.btn_6.Text = "x6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(96, 157);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(75, 75);
            this.btn_5.TabIndex = 4;
            this.btn_5.Text = "x5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(15, 157);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(75, 75);
            this.btn_4.TabIndex = 3;
            this.btn_4.Text = "x4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(177, 76);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 75);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "x3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_2
            // 
            this.btn_2.Location = new System.Drawing.Point(96, 76);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 75);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "x2";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(15, 76);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 75);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "x1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_amount
            // 
            this.txt_amount.BackColor = System.Drawing.Color.White;
            this.txt_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_amount.Location = new System.Drawing.Point(15, 20);
            this.txt_amount.Name = "txt_amount";
            this.txt_amount.ReadOnly = true;
            this.txt_amount.Size = new System.Drawing.Size(399, 49);
            this.txt_amount.TabIndex = 12;
            this.txt_amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // gb_buttons
            // 
            this.gb_buttons.Controls.Add(this.btn_cancel);
            this.gb_buttons.Location = new System.Drawing.Point(15, 410);
            this.gb_buttons.Name = "gb_buttons";
            this.gb_buttons.Size = new System.Drawing.Size(399, 100);
            this.gb_buttons.TabIndex = 13;
            this.gb_buttons.TabStop = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(237, 19);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(156, 75);
            this.btn_cancel.TabIndex = 12;
            this.btn_cancel.Text = "xCancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // frm_keypad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(430, 567);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_keypad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_keypad";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frm_keypad_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnl_label.ResumeLayout(false);
            this.pnl_label.PerformLayout();
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_buttons.PerformLayout();
            this.gb_buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel pnl_label;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_sup;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.TextBox txt_amount;
        private System.Windows.Forms.GroupBox gb_buttons;
        private System.Windows.Forms.Button btn_cancel;

    }
}