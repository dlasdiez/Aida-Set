namespace lavanderia
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.txt_clock = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.txt_cod_terminal = new System.Windows.Forms.TextBox();
            this.lbl_terminal_code = new System.Windows.Forms.Label();
            this.txt_cod_operario = new System.Windows.Forms.TextBox();
            this.lbl_cod_operario = new System.Windows.Forms.Label();
            this.txt_cod_customer = new System.Windows.Forms.TextBox();
            this.lbl_cod_cliente = new System.Windows.Forms.Label();
            this.txt_terminal_name = new System.Windows.Forms.TextBox();
            this.lbl_terminals_family = new System.Windows.Forms.Label();
            this.txt_cod_operator_name = new System.Windows.Forms.TextBox();
            this.btn_set_operator = new System.Windows.Forms.Button();
            this.btn_customer = new System.Windows.Forms.Button();
            this.txt_customer_name = new System.Windows.Forms.TextBox();
            this.btn_voucher1 = new System.Windows.Forms.Button();
            this.btn_voucher2 = new System.Windows.Forms.Button();
            this.btn_voucher4 = new System.Windows.Forms.Button();
            this.btn_voucher3 = new System.Windows.Forms.Button();
            this.txt_cod_art1 = new System.Windows.Forms.TextBox();
            this.lbl_art1 = new System.Windows.Forms.Label();
            this.btn_sel_art_1 = new System.Windows.Forms.Button();
            this.lbl_uni_art1 = new System.Windows.Forms.Label();
            this.txt_units1 = new System.Windows.Forms.TextBox();
            this.lbl_uni_art2 = new System.Windows.Forms.Label();
            this.txt_units2 = new System.Windows.Forms.TextBox();
            this.btn_sel_art_2 = new System.Windows.Forms.Button();
            this.lbl_art2 = new System.Windows.Forms.Label();
            this.txt_cod_art2 = new System.Windows.Forms.TextBox();
            this.lbl_uni_art4 = new System.Windows.Forms.Label();
            this.txt_units4 = new System.Windows.Forms.TextBox();
            this.lbl_art4 = new System.Windows.Forms.Label();
            this.txt_cod_art4 = new System.Windows.Forms.TextBox();
            this.lbl_uni_art3 = new System.Windows.Forms.Label();
            this.txt_units3 = new System.Windows.Forms.TextBox();
            this.btn_sel_art_3 = new System.Windows.Forms.Button();
            this.lbl_art3 = new System.Windows.Forms.Label();
            this.txt_cod_art3 = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_sel_art_4 = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // reloj
            // 
            this.reloj.Enabled = true;
            this.reloj.Interval = 1000;
            this.reloj.Tick += new System.EventHandler(this.reloj_Tick);
            // 
            // txt_clock
            // 
            this.txt_clock.BackColor = System.Drawing.SystemColors.Control;
            this.txt_clock.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_clock.ForeColor = System.Drawing.Color.Black;
            this.txt_clock.Location = new System.Drawing.Point(1034, 22);
            this.txt_clock.Name = "txt_clock";
            this.txt_clock.ReadOnly = true;
            this.txt_clock.Size = new System.Drawing.Size(198, 26);
            this.txt_clock.TabIndex = 0;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(109, 43);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(63, 18);
            this.lbl_fecha.TabIndex = 1;
            this.lbl_fecha.Text = "xFecha:";
            // 
            // txt_fecha
            // 
            this.txt_fecha.BackColor = System.Drawing.Color.White;
            this.txt_fecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_fecha.Location = new System.Drawing.Point(171, 40);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.ReadOnly = true;
            this.txt_fecha.Size = new System.Drawing.Size(126, 26);
            this.txt_fecha.TabIndex = 2;
            // 
            // txt_cod_terminal
            // 
            this.txt_cod_terminal.BackColor = System.Drawing.Color.White;
            this.txt_cod_terminal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_terminal.Location = new System.Drawing.Point(171, 85);
            this.txt_cod_terminal.Name = "txt_cod_terminal";
            this.txt_cod_terminal.ReadOnly = true;
            this.txt_cod_terminal.Size = new System.Drawing.Size(74, 26);
            this.txt_cod_terminal.TabIndex = 4;
            // 
            // lbl_terminal_code
            // 
            this.lbl_terminal_code.AutoSize = true;
            this.lbl_terminal_code.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_terminal_code.Location = new System.Drawing.Point(39, 88);
            this.lbl_terminal_code.Name = "lbl_terminal_code";
            this.lbl_terminal_code.Size = new System.Drawing.Size(125, 18);
            this.lbl_terminal_code.TabIndex = 3;
            this.lbl_terminal_code.Text = "xCodigoTerminal";
            // 
            // txt_cod_operario
            // 
            this.txt_cod_operario.BackColor = System.Drawing.Color.White;
            this.txt_cod_operario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_operario.Location = new System.Drawing.Point(171, 181);
            this.txt_cod_operario.Name = "txt_cod_operario";
            this.txt_cod_operario.ReadOnly = true;
            this.txt_cod_operario.Size = new System.Drawing.Size(126, 26);
            this.txt_cod_operario.TabIndex = 6;
            // 
            // lbl_cod_operario
            // 
            this.lbl_cod_operario.AutoSize = true;
            this.lbl_cod_operario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_operario.Location = new System.Drawing.Point(35, 184);
            this.lbl_cod_operario.Name = "lbl_cod_operario";
            this.lbl_cod_operario.Size = new System.Drawing.Size(137, 18);
            this.lbl_cod_operario.TabIndex = 5;
            this.lbl_cod_operario.Text = "xCódigo Operario:";
            // 
            // txt_cod_customer
            // 
            this.txt_cod_customer.BackColor = System.Drawing.Color.White;
            this.txt_cod_customer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_customer.Location = new System.Drawing.Point(171, 223);
            this.txt_cod_customer.MaxLength = 8;
            this.txt_cod_customer.Name = "txt_cod_customer";
            this.txt_cod_customer.ReadOnly = true;
            this.txt_cod_customer.Size = new System.Drawing.Size(126, 26);
            this.txt_cod_customer.TabIndex = 8;
            // 
            // lbl_cod_cliente
            // 
            this.lbl_cod_cliente.AutoSize = true;
            this.lbl_cod_cliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cod_cliente.Location = new System.Drawing.Point(48, 226);
            this.lbl_cod_cliente.Name = "lbl_cod_cliente";
            this.lbl_cod_cliente.Size = new System.Drawing.Size(124, 18);
            this.lbl_cod_cliente.TabIndex = 7;
            this.lbl_cod_cliente.Text = "xCódigo Cliente:";
            // 
            // txt_terminal_name
            // 
            this.txt_terminal_name.BackColor = System.Drawing.Color.White;
            this.txt_terminal_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_terminal_name.Location = new System.Drawing.Point(251, 85);
            this.txt_terminal_name.Name = "txt_terminal_name";
            this.txt_terminal_name.ReadOnly = true;
            this.txt_terminal_name.Size = new System.Drawing.Size(263, 26);
            this.txt_terminal_name.TabIndex = 10;
            // 
            // lbl_terminals_family
            // 
            this.lbl_terminals_family.AutoSize = true;
            this.lbl_terminals_family.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_terminals_family.Location = new System.Drawing.Point(168, 136);
            this.lbl_terminals_family.Name = "lbl_terminals_family";
            this.lbl_terminals_family.Size = new System.Drawing.Size(127, 18);
            this.lbl_terminals_family.TabIndex = 11;
            this.lbl_terminals_family.Text = "xTerminalsFamily";
            // 
            // txt_cod_operator_name
            // 
            this.txt_cod_operator_name.BackColor = System.Drawing.Color.White;
            this.txt_cod_operator_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_operator_name.Location = new System.Drawing.Point(303, 181);
            this.txt_cod_operator_name.Name = "txt_cod_operator_name";
            this.txt_cod_operator_name.ReadOnly = true;
            this.txt_cod_operator_name.Size = new System.Drawing.Size(263, 26);
            this.txt_cod_operator_name.TabIndex = 12;
            // 
            // btn_set_operator
            // 
            this.btn_set_operator.Location = new System.Drawing.Point(572, 181);
            this.btn_set_operator.Name = "btn_set_operator";
            this.btn_set_operator.Size = new System.Drawing.Size(89, 26);
            this.btn_set_operator.TabIndex = 13;
            this.btn_set_operator.Text = "button1";
            this.btn_set_operator.UseVisualStyleBackColor = true;
            this.btn_set_operator.Click += new System.EventHandler(this.btn_set_operator_Click);
            // 
            // btn_customer
            // 
            this.btn_customer.Location = new System.Drawing.Point(572, 223);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(89, 26);
            this.btn_customer.TabIndex = 15;
            this.btn_customer.Text = "button1";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // txt_customer_name
            // 
            this.txt_customer_name.BackColor = System.Drawing.Color.White;
            this.txt_customer_name.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer_name.Location = new System.Drawing.Point(303, 223);
            this.txt_customer_name.Name = "txt_customer_name";
            this.txt_customer_name.ReadOnly = true;
            this.txt_customer_name.Size = new System.Drawing.Size(263, 26);
            this.txt_customer_name.TabIndex = 14;
            // 
            // btn_voucher1
            // 
            this.btn_voucher1.Location = new System.Drawing.Point(171, 278);
            this.btn_voucher1.Name = "btn_voucher1";
            this.btn_voucher1.Size = new System.Drawing.Size(135, 135);
            this.btn_voucher1.TabIndex = 16;
            this.btn_voucher1.Text = "button1";
            this.btn_voucher1.UseVisualStyleBackColor = true;
            this.btn_voucher1.Click += new System.EventHandler(this.btn_voucher1_Click);
            // 
            // btn_voucher2
            // 
            this.btn_voucher2.Location = new System.Drawing.Point(171, 454);
            this.btn_voucher2.Name = "btn_voucher2";
            this.btn_voucher2.Size = new System.Drawing.Size(135, 135);
            this.btn_voucher2.TabIndex = 17;
            this.btn_voucher2.Text = "button1";
            this.btn_voucher2.UseVisualStyleBackColor = true;
            this.btn_voucher2.Click += new System.EventHandler(this.btn_voucher2_Click);
            // 
            // btn_voucher4
            // 
            this.btn_voucher4.Location = new System.Drawing.Point(695, 454);
            this.btn_voucher4.Name = "btn_voucher4";
            this.btn_voucher4.Size = new System.Drawing.Size(135, 135);
            this.btn_voucher4.TabIndex = 19;
            this.btn_voucher4.Text = "button1";
            this.btn_voucher4.UseVisualStyleBackColor = true;
            this.btn_voucher4.Click += new System.EventHandler(this.btn_voucher4_Click);
            // 
            // btn_voucher3
            // 
            this.btn_voucher3.Location = new System.Drawing.Point(695, 278);
            this.btn_voucher3.Name = "btn_voucher3";
            this.btn_voucher3.Size = new System.Drawing.Size(135, 135);
            this.btn_voucher3.TabIndex = 18;
            this.btn_voucher3.Text = "button1";
            this.btn_voucher3.UseVisualStyleBackColor = true;
            this.btn_voucher3.Click += new System.EventHandler(this.btn_voucher3_Click);
            // 
            // txt_cod_art1
            // 
            this.txt_cod_art1.BackColor = System.Drawing.Color.White;
            this.txt_cod_art1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_art1.Location = new System.Drawing.Point(388, 299);
            this.txt_cod_art1.MaxLength = 8;
            this.txt_cod_art1.Name = "txt_cod_art1";
            this.txt_cod_art1.ReadOnly = true;
            this.txt_cod_art1.Size = new System.Drawing.Size(126, 26);
            this.txt_cod_art1.TabIndex = 20;
            // 
            // lbl_art1
            // 
            this.lbl_art1.AutoSize = true;
            this.lbl_art1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_art1.Location = new System.Drawing.Point(343, 302);
            this.lbl_art1.Name = "lbl_art1";
            this.lbl_art1.Size = new System.Drawing.Size(39, 18);
            this.lbl_art1.TabIndex = 21;
            this.lbl_art1.Text = "xArt:";
            // 
            // btn_sel_art_1
            // 
            this.btn_sel_art_1.Location = new System.Drawing.Point(520, 299);
            this.btn_sel_art_1.Name = "btn_sel_art_1";
            this.btn_sel_art_1.Size = new System.Drawing.Size(89, 26);
            this.btn_sel_art_1.TabIndex = 22;
            this.btn_sel_art_1.Text = "button1";
            this.btn_sel_art_1.UseVisualStyleBackColor = true;
            this.btn_sel_art_1.Click += new System.EventHandler(this.btn_sel_art_1_Click);
            // 
            // lbl_uni_art1
            // 
            this.lbl_uni_art1.AutoSize = true;
            this.lbl_uni_art1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uni_art1.Location = new System.Drawing.Point(343, 357);
            this.lbl_uni_art1.Name = "lbl_uni_art1";
            this.lbl_uni_art1.Size = new System.Drawing.Size(38, 18);
            this.lbl_uni_art1.TabIndex = 24;
            this.lbl_uni_art1.Text = "xUn:";
            // 
            // txt_units1
            // 
            this.txt_units1.BackColor = System.Drawing.Color.White;
            this.txt_units1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_units1.Location = new System.Drawing.Point(388, 354);
            this.txt_units1.MaxLength = 8;
            this.txt_units1.Name = "txt_units1";
            this.txt_units1.ReadOnly = true;
            this.txt_units1.Size = new System.Drawing.Size(126, 26);
            this.txt_units1.TabIndex = 23;
            this.txt_units1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_units1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_units_MouseClick);
            // 
            // lbl_uni_art2
            // 
            this.lbl_uni_art2.AutoSize = true;
            this.lbl_uni_art2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uni_art2.Location = new System.Drawing.Point(343, 540);
            this.lbl_uni_art2.Name = "lbl_uni_art2";
            this.lbl_uni_art2.Size = new System.Drawing.Size(38, 18);
            this.lbl_uni_art2.TabIndex = 29;
            this.lbl_uni_art2.Text = "xUn:";
            // 
            // txt_units2
            // 
            this.txt_units2.BackColor = System.Drawing.Color.White;
            this.txt_units2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_units2.Location = new System.Drawing.Point(388, 537);
            this.txt_units2.MaxLength = 8;
            this.txt_units2.Name = "txt_units2";
            this.txt_units2.ReadOnly = true;
            this.txt_units2.Size = new System.Drawing.Size(126, 26);
            this.txt_units2.TabIndex = 28;
            this.txt_units2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_units2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_units_MouseClick);
            // 
            // btn_sel_art_2
            // 
            this.btn_sel_art_2.Location = new System.Drawing.Point(520, 482);
            this.btn_sel_art_2.Name = "btn_sel_art_2";
            this.btn_sel_art_2.Size = new System.Drawing.Size(89, 26);
            this.btn_sel_art_2.TabIndex = 27;
            this.btn_sel_art_2.Text = "button1";
            this.btn_sel_art_2.UseVisualStyleBackColor = true;
            this.btn_sel_art_2.Click += new System.EventHandler(this.btn_sel_art_2_Click);
            // 
            // lbl_art2
            // 
            this.lbl_art2.AutoSize = true;
            this.lbl_art2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_art2.Location = new System.Drawing.Point(343, 485);
            this.lbl_art2.Name = "lbl_art2";
            this.lbl_art2.Size = new System.Drawing.Size(39, 18);
            this.lbl_art2.TabIndex = 26;
            this.lbl_art2.Text = "xArt:";
            // 
            // txt_cod_art2
            // 
            this.txt_cod_art2.BackColor = System.Drawing.Color.White;
            this.txt_cod_art2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_art2.Location = new System.Drawing.Point(388, 482);
            this.txt_cod_art2.MaxLength = 8;
            this.txt_cod_art2.Name = "txt_cod_art2";
            this.txt_cod_art2.ReadOnly = true;
            this.txt_cod_art2.Size = new System.Drawing.Size(126, 26);
            this.txt_cod_art2.TabIndex = 25;
            // 
            // lbl_uni_art4
            // 
            this.lbl_uni_art4.AutoSize = true;
            this.lbl_uni_art4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uni_art4.Location = new System.Drawing.Point(869, 540);
            this.lbl_uni_art4.Name = "lbl_uni_art4";
            this.lbl_uni_art4.Size = new System.Drawing.Size(38, 18);
            this.lbl_uni_art4.TabIndex = 39;
            this.lbl_uni_art4.Text = "xUn:";
            // 
            // txt_units4
            // 
            this.txt_units4.BackColor = System.Drawing.Color.White;
            this.txt_units4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_units4.Location = new System.Drawing.Point(914, 537);
            this.txt_units4.MaxLength = 8;
            this.txt_units4.Name = "txt_units4";
            this.txt_units4.ReadOnly = true;
            this.txt_units4.Size = new System.Drawing.Size(126, 26);
            this.txt_units4.TabIndex = 38;
            this.txt_units4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_units4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_units_MouseClick);
            // 
            // lbl_art4
            // 
            this.lbl_art4.AutoSize = true;
            this.lbl_art4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_art4.Location = new System.Drawing.Point(869, 485);
            this.lbl_art4.Name = "lbl_art4";
            this.lbl_art4.Size = new System.Drawing.Size(39, 18);
            this.lbl_art4.TabIndex = 36;
            this.lbl_art4.Text = "xArt:";
            // 
            // txt_cod_art4
            // 
            this.txt_cod_art4.BackColor = System.Drawing.Color.White;
            this.txt_cod_art4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_art4.Location = new System.Drawing.Point(914, 482);
            this.txt_cod_art4.MaxLength = 8;
            this.txt_cod_art4.Name = "txt_cod_art4";
            this.txt_cod_art4.ReadOnly = true;
            this.txt_cod_art4.Size = new System.Drawing.Size(126, 26);
            this.txt_cod_art4.TabIndex = 35;
            // 
            // lbl_uni_art3
            // 
            this.lbl_uni_art3.AutoSize = true;
            this.lbl_uni_art3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_uni_art3.Location = new System.Drawing.Point(869, 357);
            this.lbl_uni_art3.Name = "lbl_uni_art3";
            this.lbl_uni_art3.Size = new System.Drawing.Size(38, 18);
            this.lbl_uni_art3.TabIndex = 34;
            this.lbl_uni_art3.Text = "xUn:";
            // 
            // txt_units3
            // 
            this.txt_units3.BackColor = System.Drawing.Color.White;
            this.txt_units3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_units3.Location = new System.Drawing.Point(914, 354);
            this.txt_units3.MaxLength = 8;
            this.txt_units3.Name = "txt_units3";
            this.txt_units3.ReadOnly = true;
            this.txt_units3.Size = new System.Drawing.Size(126, 26);
            this.txt_units3.TabIndex = 33;
            this.txt_units3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_units3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_units_MouseClick);
            // 
            // btn_sel_art_3
            // 
            this.btn_sel_art_3.Location = new System.Drawing.Point(1046, 299);
            this.btn_sel_art_3.Name = "btn_sel_art_3";
            this.btn_sel_art_3.Size = new System.Drawing.Size(89, 26);
            this.btn_sel_art_3.TabIndex = 32;
            this.btn_sel_art_3.Text = "button1";
            this.btn_sel_art_3.UseVisualStyleBackColor = true;
            this.btn_sel_art_3.Click += new System.EventHandler(this.btn_sel_art_3_Click);
            // 
            // lbl_art3
            // 
            this.lbl_art3.AutoSize = true;
            this.lbl_art3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_art3.Location = new System.Drawing.Point(869, 302);
            this.lbl_art3.Name = "lbl_art3";
            this.lbl_art3.Size = new System.Drawing.Size(39, 18);
            this.lbl_art3.TabIndex = 31;
            this.lbl_art3.Text = "xArt:";
            // 
            // txt_cod_art3
            // 
            this.txt_cod_art3.BackColor = System.Drawing.Color.White;
            this.txt_cod_art3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cod_art3.Location = new System.Drawing.Point(914, 299);
            this.txt_cod_art3.MaxLength = 8;
            this.txt_cod_art3.Name = "txt_cod_art3";
            this.txt_cod_art3.ReadOnly = true;
            this.txt_cod_art3.Size = new System.Drawing.Size(126, 26);
            this.txt_cod_art3.TabIndex = 30;
            this.txt_cod_art3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txt_units_MouseClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btn_sel_art_4
            // 
            this.btn_sel_art_4.Location = new System.Drawing.Point(1046, 482);
            this.btn_sel_art_4.Name = "btn_sel_art_4";
            this.btn_sel_art_4.Size = new System.Drawing.Size(89, 26);
            this.btn_sel_art_4.TabIndex = 37;
            this.btn_sel_art_4.Text = "button1";
            this.btn_sel_art_4.UseVisualStyleBackColor = true;
            this.btn_sel_art_4.Click += new System.EventHandler(this.btn_sel_art_4_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::lavanderia.Properties.Resources.ShutDown_Button1;
            this.btn_salir.Location = new System.Drawing.Point(1154, 517);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(80, 80);
            this.btn_salir.TabIndex = 40;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1077, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1255, 601);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_uni_art4);
            this.Controls.Add(this.txt_units4);
            this.Controls.Add(this.btn_sel_art_4);
            this.Controls.Add(this.lbl_art4);
            this.Controls.Add(this.txt_cod_art4);
            this.Controls.Add(this.lbl_uni_art3);
            this.Controls.Add(this.txt_units3);
            this.Controls.Add(this.btn_sel_art_3);
            this.Controls.Add(this.lbl_art3);
            this.Controls.Add(this.txt_cod_art3);
            this.Controls.Add(this.lbl_uni_art2);
            this.Controls.Add(this.txt_units2);
            this.Controls.Add(this.btn_sel_art_2);
            this.Controls.Add(this.lbl_art2);
            this.Controls.Add(this.txt_cod_art2);
            this.Controls.Add(this.lbl_uni_art1);
            this.Controls.Add(this.txt_units1);
            this.Controls.Add(this.btn_sel_art_1);
            this.Controls.Add(this.lbl_art1);
            this.Controls.Add(this.txt_cod_art1);
            this.Controls.Add(this.btn_voucher4);
            this.Controls.Add(this.btn_voucher3);
            this.Controls.Add(this.btn_voucher2);
            this.Controls.Add(this.btn_voucher1);
            this.Controls.Add(this.btn_customer);
            this.Controls.Add(this.txt_customer_name);
            this.Controls.Add(this.btn_set_operator);
            this.Controls.Add(this.txt_cod_operator_name);
            this.Controls.Add(this.lbl_terminals_family);
            this.Controls.Add(this.txt_terminal_name);
            this.Controls.Add(this.txt_cod_customer);
            this.Controls.Add(this.lbl_cod_cliente);
            this.Controls.Add(this.txt_cod_operario);
            this.Controls.Add(this.lbl_cod_operario);
            this.Controls.Add(this.txt_cod_terminal);
            this.Controls.Add(this.lbl_terminal_code);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.txt_clock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer reloj;
        private System.Windows.Forms.TextBox txt_clock;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.TextBox txt_cod_terminal;
        private System.Windows.Forms.Label lbl_terminal_code;
        private System.Windows.Forms.TextBox txt_cod_operario;
        private System.Windows.Forms.Label lbl_cod_operario;
        private System.Windows.Forms.TextBox txt_cod_customer;
        private System.Windows.Forms.Label lbl_cod_cliente;
        private System.Windows.Forms.TextBox txt_terminal_name;
        private System.Windows.Forms.Label lbl_terminals_family;
        private System.Windows.Forms.TextBox txt_cod_operator_name;
        private System.Windows.Forms.Button btn_set_operator;
        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.TextBox txt_customer_name;
        private System.Windows.Forms.Button btn_voucher1;
        private System.Windows.Forms.Button btn_voucher2;
        private System.Windows.Forms.Button btn_voucher4;
        private System.Windows.Forms.Button btn_voucher3;
        private System.Windows.Forms.TextBox txt_cod_art1;
        private System.Windows.Forms.Label lbl_art1;
        private System.Windows.Forms.Button btn_sel_art_1;
        private System.Windows.Forms.Label lbl_uni_art1;
        private System.Windows.Forms.TextBox txt_units1;
        private System.Windows.Forms.Label lbl_uni_art2;
        private System.Windows.Forms.TextBox txt_units2;
        private System.Windows.Forms.Button btn_sel_art_2;
        private System.Windows.Forms.Label lbl_art2;
        private System.Windows.Forms.TextBox txt_cod_art2;
        private System.Windows.Forms.Label lbl_uni_art4;
        private System.Windows.Forms.TextBox txt_units4;
        private System.Windows.Forms.Label lbl_art4;
        private System.Windows.Forms.TextBox txt_cod_art4;
        private System.Windows.Forms.Label lbl_uni_art3;
        private System.Windows.Forms.TextBox txt_units3;
        private System.Windows.Forms.Button btn_sel_art_3;
        private System.Windows.Forms.Label lbl_art3;
        private System.Windows.Forms.TextBox txt_cod_art3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_sel_art_4;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}

