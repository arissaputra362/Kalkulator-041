namespace Calculator1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.backspace = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.tambah = new System.Windows.Forms.Button();
            this.angka7 = new System.Windows.Forms.Button();
            this.angka8 = new System.Windows.Forms.Button();
            this.angka9 = new System.Windows.Forms.Button();
            this.kurang = new System.Windows.Forms.Button();
            this.angka4 = new System.Windows.Forms.Button();
            this.angka5 = new System.Windows.Forms.Button();
            this.angka6 = new System.Windows.Forms.Button();
            this.kali = new System.Windows.Forms.Button();
            this.angka1 = new System.Windows.Forms.Button();
            this.angka2 = new System.Windows.Forms.Button();
            this.angka3 = new System.Windows.Forms.Button();
            this.bagi = new System.Windows.Forms.Button();
            this.angka0 = new System.Windows.Forms.Button();
            this.koma = new System.Windows.Forms.Button();
            this.hasil = new System.Windows.Forms.Button();
            this.plus_minus = new System.Windows.Forms.Button();
            this.lblShowOp = new System.Windows.Forms.Label();
            this.seper = new System.Windows.Forms.Button();
            this.kuadrat = new System.Windows.Forms.Button();
            this.akar = new System.Windows.Forms.Button();
            this.persen = new System.Windows.Forms.Button();
            this.faktorial = new System.Windows.Forms.Button();
            this.mode = new System.Windows.Forms.Button();
            this.button_sin = new System.Windows.Forms.Button();
            this.button_cos = new System.Windows.Forms.Button();
            this.button_tan = new System.Windows.Forms.Button();
            this.trigo_switch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(3, 33);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(281, 100);
            this.txtDisplay.TabIndex = 0;
            this.txtDisplay.Text = "0";
            this.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // backspace
            // 
            this.backspace.BackColor = System.Drawing.SystemColors.Control;
            this.backspace.FlatAppearance.BorderSize = 0;
            this.backspace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backspace.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backspace.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.backspace.Location = new System.Drawing.Point(3, 136);
            this.backspace.Name = "backspace";
            this.backspace.Size = new System.Drawing.Size(70, 50);
            this.backspace.TabIndex = 1;
            this.backspace.Text = "<-";
            this.backspace.UseVisualStyleBackColor = false;
            this.backspace.Click += new System.EventHandler(this.backspace_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.Control;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.clear.Location = new System.Drawing.Point(73, 136);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(70, 50);
            this.clear.TabIndex = 1;
            this.clear.Text = "C";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // tambah
            // 
            this.tambah.BackColor = System.Drawing.SystemColors.Control;
            this.tambah.FlatAppearance.BorderSize = 0;
            this.tambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambah.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tambah.Location = new System.Drawing.Point(214, 237);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(70, 50);
            this.tambah.TabIndex = 1;
            this.tambah.Text = "+";
            this.tambah.UseVisualStyleBackColor = false;
            this.tambah.Click += new System.EventHandler(this.operator_mtkdas);
            // 
            // angka7
            // 
            this.angka7.BackColor = System.Drawing.Color.White;
            this.angka7.FlatAppearance.BorderSize = 0;
            this.angka7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angka7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka7.Location = new System.Drawing.Point(3, 187);
            this.angka7.Name = "angka7";
            this.angka7.Size = new System.Drawing.Size(70, 50);
            this.angka7.TabIndex = 1;
            this.angka7.Text = "7";
            this.angka7.UseVisualStyleBackColor = false;
            this.angka7.Click += new System.EventHandler(this.button_Click);
            // 
            // angka8
            // 
            this.angka8.BackColor = System.Drawing.Color.White;
            this.angka8.FlatAppearance.BorderSize = 0;
            this.angka8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angka8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka8.Location = new System.Drawing.Point(73, 187);
            this.angka8.Name = "angka8";
            this.angka8.Size = new System.Drawing.Size(70, 50);
            this.angka8.TabIndex = 1;
            this.angka8.Text = "8";
            this.angka8.UseVisualStyleBackColor = false;
            this.angka8.Click += new System.EventHandler(this.button_Click);
            // 
            // angka9
            // 
            this.angka9.BackColor = System.Drawing.Color.White;
            this.angka9.FlatAppearance.BorderSize = 0;
            this.angka9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angka9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka9.Location = new System.Drawing.Point(143, 187);
            this.angka9.Name = "angka9";
            this.angka9.Size = new System.Drawing.Size(70, 50);
            this.angka9.TabIndex = 1;
            this.angka9.Text = "9";
            this.angka9.UseVisualStyleBackColor = false;
            this.angka9.Click += new System.EventHandler(this.button_Click);
            // 
            // kurang
            // 
            this.kurang.BackColor = System.Drawing.SystemColors.Control;
            this.kurang.FlatAppearance.BorderSize = 0;
            this.kurang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kurang.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kurang.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.kurang.Location = new System.Drawing.Point(214, 287);
            this.kurang.Name = "kurang";
            this.kurang.Size = new System.Drawing.Size(70, 50);
            this.kurang.TabIndex = 1;
            this.kurang.Text = "-";
            this.kurang.UseVisualStyleBackColor = false;
            this.kurang.Click += new System.EventHandler(this.operator_mtkdas);
            // 
            // angka4
            // 
            this.angka4.BackColor = System.Drawing.Color.White;
            this.angka4.FlatAppearance.BorderSize = 0;
            this.angka4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angka4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka4.Location = new System.Drawing.Point(3, 237);
            this.angka4.Name = "angka4";
            this.angka4.Size = new System.Drawing.Size(70, 50);
            this.angka4.TabIndex = 1;
            this.angka4.Text = "4";
            this.angka4.UseVisualStyleBackColor = false;
            this.angka4.Click += new System.EventHandler(this.button_Click);
            // 
            // angka5
            // 
            this.angka5.BackColor = System.Drawing.Color.White;
            this.angka5.FlatAppearance.BorderSize = 0;
            this.angka5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angka5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka5.Location = new System.Drawing.Point(73, 237);
            this.angka5.Name = "angka5";
            this.angka5.Size = new System.Drawing.Size(70, 50);
            this.angka5.TabIndex = 1;
            this.angka5.Text = "5";
            this.angka5.UseVisualStyleBackColor = false;
            this.angka5.Click += new System.EventHandler(this.button_Click);
            // 
            // angka6
            // 
            this.angka6.BackColor = System.Drawing.Color.White;
            this.angka6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.angka6.FlatAppearance.BorderSize = 0;
            this.angka6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angka6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka6.Location = new System.Drawing.Point(143, 237);
            this.angka6.Name = "angka6";
            this.angka6.Size = new System.Drawing.Size(70, 50);
            this.angka6.TabIndex = 1;
            this.angka6.Text = "6";
            this.angka6.UseVisualStyleBackColor = false;
            this.angka6.Click += new System.EventHandler(this.button_Click);
            // 
            // kali
            // 
            this.kali.BackColor = System.Drawing.SystemColors.Control;
            this.kali.FlatAppearance.BorderSize = 0;
            this.kali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kali.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kali.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.kali.Location = new System.Drawing.Point(214, 136);
            this.kali.Name = "kali";
            this.kali.Size = new System.Drawing.Size(72, 50);
            this.kali.TabIndex = 1;
            this.kali.Text = "x";
            this.kali.UseVisualStyleBackColor = false;
            this.kali.Click += new System.EventHandler(this.operator_mtkdas);
            // 
            // angka1
            // 
            this.angka1.BackColor = System.Drawing.Color.White;
            this.angka1.FlatAppearance.BorderSize = 0;
            this.angka1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angka1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka1.Location = new System.Drawing.Point(3, 287);
            this.angka1.Name = "angka1";
            this.angka1.Size = new System.Drawing.Size(70, 50);
            this.angka1.TabIndex = 1;
            this.angka1.Text = "1";
            this.angka1.UseVisualStyleBackColor = false;
            this.angka1.Click += new System.EventHandler(this.button_Click);
            // 
            // angka2
            // 
            this.angka2.BackColor = System.Drawing.Color.White;
            this.angka2.FlatAppearance.BorderSize = 0;
            this.angka2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angka2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka2.Location = new System.Drawing.Point(73, 287);
            this.angka2.Name = "angka2";
            this.angka2.Size = new System.Drawing.Size(70, 50);
            this.angka2.TabIndex = 1;
            this.angka2.Text = "2";
            this.angka2.UseVisualStyleBackColor = false;
            this.angka2.Click += new System.EventHandler(this.button_Click);
            // 
            // angka3
            // 
            this.angka3.BackColor = System.Drawing.Color.White;
            this.angka3.FlatAppearance.BorderSize = 0;
            this.angka3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angka3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka3.Location = new System.Drawing.Point(143, 287);
            this.angka3.Name = "angka3";
            this.angka3.Size = new System.Drawing.Size(70, 50);
            this.angka3.TabIndex = 1;
            this.angka3.Text = "3";
            this.angka3.UseVisualStyleBackColor = false;
            this.angka3.Click += new System.EventHandler(this.button_Click);
            // 
            // bagi
            // 
            this.bagi.BackColor = System.Drawing.SystemColors.Control;
            this.bagi.FlatAppearance.BorderSize = 0;
            this.bagi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bagi.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bagi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bagi.Location = new System.Drawing.Point(214, 186);
            this.bagi.Name = "bagi";
            this.bagi.Size = new System.Drawing.Size(70, 51);
            this.bagi.TabIndex = 1;
            this.bagi.Text = ":";
            this.bagi.UseVisualStyleBackColor = false;
            this.bagi.Click += new System.EventHandler(this.operator_mtkdas);
            // 
            // angka0
            // 
            this.angka0.BackColor = System.Drawing.Color.White;
            this.angka0.FlatAppearance.BorderSize = 0;
            this.angka0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.angka0.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.angka0.Location = new System.Drawing.Point(73, 337);
            this.angka0.Name = "angka0";
            this.angka0.Size = new System.Drawing.Size(70, 50);
            this.angka0.TabIndex = 1;
            this.angka0.Text = "0";
            this.angka0.UseVisualStyleBackColor = false;
            this.angka0.Click += new System.EventHandler(this.button_Click);
            // 
            // koma
            // 
            this.koma.BackColor = System.Drawing.Color.White;
            this.koma.FlatAppearance.BorderSize = 0;
            this.koma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.koma.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.koma.Location = new System.Drawing.Point(143, 337);
            this.koma.Name = "koma";
            this.koma.Size = new System.Drawing.Size(70, 50);
            this.koma.TabIndex = 1;
            this.koma.Text = ",";
            this.koma.UseVisualStyleBackColor = false;
            this.koma.Click += new System.EventHandler(this.button_Click);
            // 
            // hasil
            // 
            this.hasil.BackColor = System.Drawing.SystemColors.HotTrack;
            this.hasil.FlatAppearance.BorderSize = 0;
            this.hasil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hasil.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasil.ForeColor = System.Drawing.SystemColors.Control;
            this.hasil.Location = new System.Drawing.Point(214, 337);
            this.hasil.Name = "hasil";
            this.hasil.Size = new System.Drawing.Size(71, 50);
            this.hasil.TabIndex = 1;
            this.hasil.Text = "=";
            this.hasil.UseVisualStyleBackColor = false;
            this.hasil.Click += new System.EventHandler(this.hasil_Click);
            // 
            // plus_minus
            // 
            this.plus_minus.BackColor = System.Drawing.SystemColors.Control;
            this.plus_minus.FlatAppearance.BorderSize = 0;
            this.plus_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plus_minus.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_minus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.plus_minus.Location = new System.Drawing.Point(143, 136);
            this.plus_minus.Name = "plus_minus";
            this.plus_minus.Size = new System.Drawing.Size(70, 50);
            this.plus_minus.TabIndex = 1;
            this.plus_minus.Text = "+/-";
            this.plus_minus.UseVisualStyleBackColor = false;
            this.plus_minus.Click += new System.EventHandler(this.plus_minus_Click);
            // 
            // lblShowOp
            // 
            this.lblShowOp.AutoSize = true;
            this.lblShowOp.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOp.Location = new System.Drawing.Point(-1, 7);
            this.lblShowOp.Name = "lblShowOp";
            this.lblShowOp.Size = new System.Drawing.Size(0, 23);
            this.lblShowOp.TabIndex = 2;
            // 
            // seper
            // 
            this.seper.BackColor = System.Drawing.SystemColors.Control;
            this.seper.FlatAppearance.BorderSize = 0;
            this.seper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seper.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seper.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.seper.Location = new System.Drawing.Point(72, 136);
            this.seper.Name = "seper";
            this.seper.Size = new System.Drawing.Size(70, 50);
            this.seper.TabIndex = 3;
            this.seper.Text = "1/X";
            this.seper.UseVisualStyleBackColor = false;
            this.seper.Click += new System.EventHandler(this.operator_addon);
            // 
            // kuadrat
            // 
            this.kuadrat.BackColor = System.Drawing.SystemColors.Control;
            this.kuadrat.FlatAppearance.BorderSize = 0;
            this.kuadrat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kuadrat.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kuadrat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.kuadrat.Location = new System.Drawing.Point(212, 136);
            this.kuadrat.Name = "kuadrat";
            this.kuadrat.Size = new System.Drawing.Size(72, 50);
            this.kuadrat.TabIndex = 3;
            this.kuadrat.Text = "X²";
            this.kuadrat.UseVisualStyleBackColor = false;
            this.kuadrat.Click += new System.EventHandler(this.operator_addon);
            // 
            // akar
            // 
            this.akar.BackColor = System.Drawing.SystemColors.Control;
            this.akar.FlatAppearance.BorderSize = 0;
            this.akar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.akar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.akar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.akar.Location = new System.Drawing.Point(142, 136);
            this.akar.Name = "akar";
            this.akar.Size = new System.Drawing.Size(70, 50);
            this.akar.TabIndex = 3;
            this.akar.Text = "√X";
            this.akar.UseVisualStyleBackColor = false;
            this.akar.Click += new System.EventHandler(this.operator_addon);
            // 
            // persen
            // 
            this.persen.BackColor = System.Drawing.SystemColors.Control;
            this.persen.FlatAppearance.BorderSize = 0;
            this.persen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.persen.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.persen.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.persen.Location = new System.Drawing.Point(2, 136);
            this.persen.Name = "persen";
            this.persen.Size = new System.Drawing.Size(70, 50);
            this.persen.TabIndex = 3;
            this.persen.Text = "%";
            this.persen.UseVisualStyleBackColor = false;
            this.persen.Click += new System.EventHandler(this.operator_addon);
            // 
            // faktorial
            // 
            this.faktorial.BackColor = System.Drawing.SystemColors.Control;
            this.faktorial.FlatAppearance.BorderSize = 0;
            this.faktorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faktorial.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faktorial.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.faktorial.Location = new System.Drawing.Point(284, 136);
            this.faktorial.Name = "faktorial";
            this.faktorial.Size = new System.Drawing.Size(70, 50);
            this.faktorial.TabIndex = 3;
            this.faktorial.Text = "X!";
            this.faktorial.UseVisualStyleBackColor = false;
            this.faktorial.Click += new System.EventHandler(this.operator_addon);
            // 
            // mode
            // 
            this.mode.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.mode.FlatAppearance.BorderSize = 0;
            this.mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mode.Image = ((System.Drawing.Image)(resources.GetObject("mode.Image")));
            this.mode.Location = new System.Drawing.Point(3, 337);
            this.mode.Name = "mode";
            this.mode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mode.Size = new System.Drawing.Size(70, 50);
            this.mode.TabIndex = 4;
            this.mode.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mode.UseVisualStyleBackColor = false;
            this.mode.Click += new System.EventHandler(this.mode_Click);
            // 
            // button_sin
            // 
            this.button_sin.BackColor = System.Drawing.SystemColors.Control;
            this.button_sin.FlatAppearance.BorderSize = 0;
            this.button_sin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_sin.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_sin.Location = new System.Drawing.Point(283, 186);
            this.button_sin.Name = "button_sin";
            this.button_sin.Size = new System.Drawing.Size(70, 51);
            this.button_sin.TabIndex = 5;
            this.button_sin.Text = "Sin";
            this.button_sin.UseVisualStyleBackColor = false;
            this.button_sin.Click += new System.EventHandler(this.operator_addon);
            // 
            // button_cos
            // 
            this.button_cos.BackColor = System.Drawing.SystemColors.Control;
            this.button_cos.FlatAppearance.BorderSize = 0;
            this.button_cos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cos.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_cos.Location = new System.Drawing.Point(283, 237);
            this.button_cos.Name = "button_cos";
            this.button_cos.Size = new System.Drawing.Size(70, 51);
            this.button_cos.TabIndex = 5;
            this.button_cos.Text = "Cos";
            this.button_cos.UseVisualStyleBackColor = false;
            this.button_cos.Click += new System.EventHandler(this.operator_addon);
            // 
            // button_tan
            // 
            this.button_tan.BackColor = System.Drawing.SystemColors.Control;
            this.button_tan.FlatAppearance.BorderSize = 0;
            this.button_tan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_tan.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_tan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_tan.Location = new System.Drawing.Point(283, 287);
            this.button_tan.Name = "button_tan";
            this.button_tan.Size = new System.Drawing.Size(70, 50);
            this.button_tan.TabIndex = 5;
            this.button_tan.Text = "Tan";
            this.button_tan.UseVisualStyleBackColor = false;
            this.button_tan.Click += new System.EventHandler(this.operator_addon);
            // 
            // trigo_switch
            // 
            this.trigo_switch.BackColor = System.Drawing.SystemColors.Control;
            this.trigo_switch.FlatAppearance.BorderSize = 0;
            this.trigo_switch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trigo_switch.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trigo_switch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.trigo_switch.Location = new System.Drawing.Point(283, 337);
            this.trigo_switch.Name = "trigo_switch";
            this.trigo_switch.Size = new System.Drawing.Size(70, 50);
            this.trigo_switch.TabIndex = 5;
            this.trigo_switch.Text = "Trigo⁻¹";
            this.trigo_switch.UseVisualStyleBackColor = false;
            this.trigo_switch.Click += new System.EventHandler(this.trigo_switch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(282, 389);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.trigo_switch);
            this.Controls.Add(this.button_tan);
            this.Controls.Add(this.button_cos);
            this.Controls.Add(this.button_sin);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.faktorial);
            this.Controls.Add(this.lblShowOp);
            this.Controls.Add(this.hasil);
            this.Controls.Add(this.bagi);
            this.Controls.Add(this.angka3);
            this.Controls.Add(this.kali);
            this.Controls.Add(this.angka6);
            this.Controls.Add(this.koma);
            this.Controls.Add(this.kurang);
            this.Controls.Add(this.angka2);
            this.Controls.Add(this.angka9);
            this.Controls.Add(this.angka5);
            this.Controls.Add(this.angka0);
            this.Controls.Add(this.plus_minus);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.angka1);
            this.Controls.Add(this.angka8);
            this.Controls.Add(this.angka4);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.angka7);
            this.Controls.Add(this.backspace);
            this.Controls.Add(this.akar);
            this.Controls.Add(this.persen);
            this.Controls.Add(this.kuadrat);
            this.Controls.Add(this.seper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button backspace;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.Button angka7;
        private System.Windows.Forms.Button angka8;
        private System.Windows.Forms.Button angka9;
        private System.Windows.Forms.Button kurang;
        private System.Windows.Forms.Button angka4;
        private System.Windows.Forms.Button angka5;
        private System.Windows.Forms.Button angka6;
        private System.Windows.Forms.Button kali;
        private System.Windows.Forms.Button angka1;
        private System.Windows.Forms.Button angka2;
        private System.Windows.Forms.Button angka3;
        private System.Windows.Forms.Button bagi;
        private System.Windows.Forms.Button angka0;
        private System.Windows.Forms.Button koma;
        private System.Windows.Forms.Button hasil;
        private System.Windows.Forms.Button plus_minus;
        private System.Windows.Forms.Label lblShowOp;
        private System.Windows.Forms.Button seper;
        private System.Windows.Forms.Button kuadrat;
        private System.Windows.Forms.Button akar;
        private System.Windows.Forms.Button persen;
        private System.Windows.Forms.Button faktorial;
        private System.Windows.Forms.Button mode;
        private System.Windows.Forms.Button button_sin;
        private System.Windows.Forms.Button button_cos;
        private System.Windows.Forms.Button button_tan;
        private System.Windows.Forms.Button trigo_switch;
    }
}

