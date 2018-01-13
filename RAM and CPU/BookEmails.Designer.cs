namespace RAM_and_CPU
{
    partial class BookEmails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookEmails));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBIDDelete = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tBAdresDelete = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tBIDEdit = new System.Windows.Forms.TextBox();
            this.tBAdresEdit = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBAddEmail = new System.Windows.Forms.TextBox();
            this.bAddEmail = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bDelete = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Orange;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(635, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.tBIDDelete);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.tBAdresDelete);
            this.groupBox4.Controls.Add(this.bDelete);
            this.groupBox4.Location = new System.Drawing.Point(335, 110);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 79);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Usuwanie adresów:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "ID:";
            // 
            // tBIDDelete
            // 
            this.tBIDDelete.Enabled = false;
            this.tBIDDelete.Location = new System.Drawing.Point(51, 21);
            this.tBIDDelete.Name = "tBIDDelete";
            this.tBIDDelete.Size = new System.Drawing.Size(182, 20);
            this.tBIDDelete.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Adres:";
            // 
            // tBAdresDelete
            // 
            this.tBAdresDelete.Enabled = false;
            this.tBAdresDelete.Location = new System.Drawing.Point(51, 50);
            this.tBAdresDelete.Name = "tBAdresDelete";
            this.tBAdresDelete.Size = new System.Drawing.Size(182, 20);
            this.tBAdresDelete.TabIndex = 32;
            this.tBAdresDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBAdresDelete_KeyDown);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.tBIDEdit);
            this.groupBox3.Controls.Add(this.bEdit);
            this.groupBox3.Controls.Add(this.tBAdresEdit);
            this.groupBox3.Location = new System.Drawing.Point(335, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 78);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Edytowanie adresów:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Adres:";
            // 
            // tBIDEdit
            // 
            this.tBIDEdit.Enabled = false;
            this.tBIDEdit.Location = new System.Drawing.Point(51, 19);
            this.tBIDEdit.Name = "tBIDEdit";
            this.tBIDEdit.Size = new System.Drawing.Size(182, 20);
            this.tBIDEdit.TabIndex = 39;
            // 
            // tBAdresEdit
            // 
            this.tBAdresEdit.Location = new System.Drawing.Point(51, 48);
            this.tBAdresEdit.Name = "tBAdresEdit";
            this.tBAdresEdit.Size = new System.Drawing.Size(182, 20);
            this.tBAdresEdit.TabIndex = 37;
            this.tBAdresEdit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBAdresEdit_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tBAddEmail);
            this.groupBox2.Controls.Add(this.bAddEmail);
            this.groupBox2.Location = new System.Drawing.Point(335, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 73);
            this.groupBox2.TabIndex = 45;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dodaj do listy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Adres:";
            // 
            // tBAddEmail
            // 
            this.tBAddEmail.Location = new System.Drawing.Point(11, 45);
            this.tBAddEmail.Name = "tBAddEmail";
            this.tBAddEmail.Size = new System.Drawing.Size(222, 20);
            this.tBAddEmail.TabIndex = 30;
            this.tBAddEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBAddEmail_KeyDown);
            // 
            // bAddEmail
            // 
            this.bAddEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bAddEmail.Cursor = System.Windows.Forms.Cursors.Default;
            this.bAddEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAddEmail.Image = global::RAM_and_CPU.Properties.Resources.icons8_add_user_male_50;
            this.bAddEmail.Location = new System.Drawing.Point(238, 16);
            this.bAddEmail.Name = "bAddEmail";
            this.bAddEmail.Size = new System.Drawing.Size(50, 49);
            this.bAddEmail.TabIndex = 29;
            this.bAddEmail.UseVisualStyleBackColor = false;
            this.bAddEmail.Click += new System.EventHandler(this.BAddEmail_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(4, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 242);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista E-mail działu IT";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 16);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(319, 223);
            this.dataGridView2.TabIndex = 35;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellContentClick);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bDelete.Cursor = System.Windows.Forms.Cursors.Default;
            this.bDelete.Enabled = false;
            this.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDelete.Image = global::RAM_and_CPU.Properties.Resources.icons8_denied_50;
            this.bDelete.Location = new System.Drawing.Point(238, 21);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(50, 49);
            this.bDelete.TabIndex = 1;
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bEdit.Enabled = false;
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdit.Image = global::RAM_and_CPU.Properties.Resources.icons8_edit_profile_50;
            this.bEdit.Location = new System.Drawing.Point(238, 19);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(50, 49);
            this.bEdit.TabIndex = 36;
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // BookEmails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(635, 271);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BookEmails";
            this.Text = "MD - Lista E-mail odbiorców";
            this.Load += new System.EventHandler(this.BookEmails_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBIDDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBAdresDelete;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBIDEdit;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.TextBox tBAdresEdit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBAddEmail;
        private System.Windows.Forms.Button bAddEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}