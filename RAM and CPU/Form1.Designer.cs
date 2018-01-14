namespace RAM_and_CPU
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.konfiguracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracjaKontaEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaEmailOdbiorcówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjaOAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafikaUżytaWProjekcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lczas = new System.Windows.Forms.Label();
            this.lMinuty = new System.Windows.Forms.Label();
            this.lWykonujCo = new System.Windows.Forms.Label();
            this.nUDCoIleSecond = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.bEditExt = new System.Windows.Forms.Button();
            this.numericUpDownCPU = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRAM = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCoIleSecond)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(6, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(518, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zacznij";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(112, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(112, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(159, 20);
            this.textBox2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktualne zużycie:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dostępna pamięć:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Procesor:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Orange;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 280);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(529, 22);
            this.statusStrip1.TabIndex = 46;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(138, 17);
            this.toolStripStatusLabel1.Text = "Status: Nie uruchomiony";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfiguracjaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(529, 43);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // konfiguracjaToolStripMenuItem
            // 
            this.konfiguracjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.konfiguracjaKontaEmailToolStripMenuItem,
            this.ListaEmailOdbiorcówToolStripMenuItem});
            this.konfiguracjaToolStripMenuItem.Image = global::RAM_and_CPU.Properties.Resources.icons8_administrative_tools_35;
            this.konfiguracjaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.konfiguracjaToolStripMenuItem.Name = "konfiguracjaToolStripMenuItem";
            this.konfiguracjaToolStripMenuItem.Size = new System.Drawing.Size(85, 39);
            this.konfiguracjaToolStripMenuItem.Text = "Menu";
            // 
            // konfiguracjaKontaEmailToolStripMenuItem
            // 
            this.konfiguracjaKontaEmailToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.konfiguracjaKontaEmailToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.konfiguracjaKontaEmailToolStripMenuItem.Name = "konfiguracjaKontaEmailToolStripMenuItem";
            this.konfiguracjaKontaEmailToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.konfiguracjaKontaEmailToolStripMenuItem.Text = "Konfiguracja konta E-mail - nadawca";
            this.konfiguracjaKontaEmailToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.konfiguracjaKontaEmailToolStripMenuItem.Click += new System.EventHandler(this.KonfiguracjaKontaEmailToolStripMenuItem_Click);
            // 
            // ListaEmailOdbiorcówToolStripMenuItem
            // 
            this.ListaEmailOdbiorcówToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ListaEmailOdbiorcówToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ListaEmailOdbiorcówToolStripMenuItem.Name = "ListaEmailOdbiorcówToolStripMenuItem";
            this.ListaEmailOdbiorcówToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.ListaEmailOdbiorcówToolStripMenuItem.Text = "Lista E-mail - odbiorcy";
            this.ListaEmailOdbiorcówToolStripMenuItem.Click += new System.EventHandler(this.ListaEmailOdbiorcówToolStripMenuItem_Click);
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informacjaOAutorzeToolStripMenuItem,
            this.grafikaUżytaWProjekcieToolStripMenuItem});
            this.pomocToolStripMenuItem.Image = global::RAM_and_CPU.Properties.Resources.icons8_information_35;
            this.pomocToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(111, 39);
            this.pomocToolStripMenuItem.Text = "Informacje";
            // 
            // informacjaOAutorzeToolStripMenuItem
            // 
            this.informacjaOAutorzeToolStripMenuItem.Name = "informacjaOAutorzeToolStripMenuItem";
            this.informacjaOAutorzeToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.informacjaOAutorzeToolStripMenuItem.Text = "Informacja o autorze";
            this.informacjaOAutorzeToolStripMenuItem.Click += new System.EventHandler(this.InformacjaOAutorzeToolStripMenuItem_Click);
            // 
            // grafikaUżytaWProjekcieToolStripMenuItem
            // 
            this.grafikaUżytaWProjekcieToolStripMenuItem.Name = "grafikaUżytaWProjekcieToolStripMenuItem";
            this.grafikaUżytaWProjekcieToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.grafikaUżytaWProjekcieToolStripMenuItem.Text = "Grafika użyta w projekcie";
            this.grafikaUżytaWProjekcieToolStripMenuItem.Click += new System.EventHandler(this.GrafikaUżytaWProjekcieToolStripMenuItem_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.lMinuty);
            this.groupBox3.Controls.Add(this.lWykonujCo);
            this.groupBox3.Controls.Add(this.nUDCoIleSecond);
            this.groupBox3.Location = new System.Drawing.Point(289, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 188);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opcje - czas sprawdzania:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lczas);
            this.groupBox4.Location = new System.Drawing.Point(51, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(120, 77);
            this.groupBox4.TabIndex = 23;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Aktualny czas:";
            // 
            // lczas
            // 
            this.lczas.AutoSize = true;
            this.lczas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lczas.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lczas.Location = new System.Drawing.Point(8, 28);
            this.lczas.Name = "lczas";
            this.lczas.Size = new System.Drawing.Size(103, 29);
            this.lczas.TabIndex = 8;
            this.lczas.Text = "00:00:00";
            // 
            // lMinuty
            // 
            this.lMinuty.AutoSize = true;
            this.lMinuty.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lMinuty.Location = new System.Drawing.Point(127, 148);
            this.lMinuty.Name = "lMinuty";
            this.lMinuty.Size = new System.Drawing.Size(44, 13);
            this.lMinuty.TabIndex = 21;
            this.lMinuty.Text = "Sekund";
            // 
            // lWykonujCo
            // 
            this.lWykonujCo.AutoSize = true;
            this.lWykonujCo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lWykonujCo.Location = new System.Drawing.Point(34, 113);
            this.lWykonujCo.Name = "lWykonujCo";
            this.lWykonujCo.Size = new System.Drawing.Size(155, 13);
            this.lWykonujCo.TabIndex = 20;
            this.lWykonujCo.Text = "Minimalny czas między alertami:";
            // 
            // nUDCoIleSecond
            // 
            this.nUDCoIleSecond.Location = new System.Drawing.Point(59, 145);
            this.nUDCoIleSecond.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nUDCoIleSecond.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDCoIleSecond.Name = "nUDCoIleSecond";
            this.nUDCoIleSecond.Size = new System.Drawing.Size(62, 20);
            this.nUDCoIleSecond.TabIndex = 12;
            this.nUDCoIleSecond.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.numericUpDownRAM);
            this.groupBox5.Controls.Add(this.numericUpDownCPU);
            this.groupBox5.Location = new System.Drawing.Point(6, 122);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(277, 72);
            this.groupBox5.TabIndex = 50;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Menu alertów RAM i CPU";
            // 
            // bEditExt
            // 
            this.bEditExt.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEditExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditExt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bEditExt.Location = new System.Drawing.Point(6, 199);
            this.bEditExt.Name = "bEditExt";
            this.bEditExt.Size = new System.Drawing.Size(277, 32);
            this.bEditExt.TabIndex = 37;
            this.bEditExt.Text = "Zapisz ustawienia";
            this.bEditExt.UseVisualStyleBackColor = false;
            this.bEditExt.Click += new System.EventHandler(this.BEditExt_Click);
            // 
            // numericUpDownCPU
            // 
            this.numericUpDownCPU.Location = new System.Drawing.Point(157, 19);
            this.numericUpDownCPU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCPU.Name = "numericUpDownCPU";
            this.numericUpDownCPU.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownCPU.TabIndex = 24;
            this.numericUpDownCPU.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownRAM
            // 
            this.numericUpDownRAM.Location = new System.Drawing.Point(157, 43);
            this.numericUpDownRAM.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownRAM.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRAM.Name = "numericUpDownRAM";
            this.numericUpDownRAM.Size = new System.Drawing.Size(85, 20);
            this.numericUpDownRAM.TabIndex = 38;
            this.numericUpDownRAM.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Reaguj powyżej użycia CPU:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "MB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Reaguj poniżej wolnego RAM:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(529, 302);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bEditExt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MD RAM i CPU alert";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCoIleSecond)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfiguracjaKontaEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListaEmailOdbiorcówToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacjaOAutorzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grafikaUżytaWProjekcieToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lczas;
        private System.Windows.Forms.Label lMinuty;
        private System.Windows.Forms.Label lWykonujCo;
        private System.Windows.Forms.NumericUpDown nUDCoIleSecond;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button bEditExt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownRAM;
        private System.Windows.Forms.NumericUpDown numericUpDownCPU;
    }
}

