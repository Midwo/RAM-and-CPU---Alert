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
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informacjaOAutorzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grafikaUżytaWProjekcieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracjaKontaEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaEmailOdbiorcówToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(6, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Zacznij";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(112, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(112, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(117, 20);
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
            this.groupBox1.Size = new System.Drawing.Size(235, 73);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 217);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(621, 22);
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
            this.menuStrip1.Size = new System.Drawing.Size(621, 43);
            this.menuStrip1.Stretch = false;
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
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
            this.informacjaOAutorzeToolStripMenuItem.Click += new System.EventHandler(this.informacjaOAutorzeToolStripMenuItem_Click);
            // 
            // grafikaUżytaWProjekcieToolStripMenuItem
            // 
            this.grafikaUżytaWProjekcieToolStripMenuItem.Name = "grafikaUżytaWProjekcieToolStripMenuItem";
            this.grafikaUżytaWProjekcieToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.grafikaUżytaWProjekcieToolStripMenuItem.Text = "Grafika użyta w projekcie";
            this.grafikaUżytaWProjekcieToolStripMenuItem.Click += new System.EventHandler(this.grafikaUżytaWProjekcieToolStripMenuItem_Click);
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
            this.konfiguracjaKontaEmailToolStripMenuItem.Click += new System.EventHandler(this.konfiguracjaKontaEmailToolStripMenuItem_Click);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(621, 239);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
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
    }
}

