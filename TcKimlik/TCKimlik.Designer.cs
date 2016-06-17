namespace TcKimlik
{
    partial class TCKimlik
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.btnUret = new MetroFramework.Controls.MetroButton();
            this.btnListeTemizle = new MetroFramework.Controls.MetroButton();
            this.btnDogrula = new MetroFramework.Controls.MetroButton();
            this.textBox1 = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(23, 131);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(297, 285);
            this.listBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ubuntu Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Üretilecek Adet :";
            // 
            // lblSonuc
            // 
            this.lblSonuc.Font = new System.Drawing.Font("Ubuntu Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.ForeColor = System.Drawing.Color.LightYellow;
            this.lblSonuc.Location = new System.Drawing.Point(326, 216);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(203, 27);
            this.lblSonuc.TabIndex = 5;
            this.lblSonuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUret
            // 
            this.btnUret.Location = new System.Drawing.Point(234, 90);
            this.btnUret.Name = "btnUret";
            this.btnUret.Size = new System.Drawing.Size(90, 31);
            this.btnUret.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnUret.TabIndex = 6;
            this.btnUret.Text = "Üret";
            this.btnUret.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnUret.UseSelectable = true;
            this.btnUret.Click += new System.EventHandler(this.btnUret_Click);
            // 
            // btnListeTemizle
            // 
            this.btnListeTemizle.Location = new System.Drawing.Point(326, 130);
            this.btnListeTemizle.Name = "btnListeTemizle";
            this.btnListeTemizle.Size = new System.Drawing.Size(203, 34);
            this.btnListeTemizle.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnListeTemizle.TabIndex = 7;
            this.btnListeTemizle.Text = "Listeyi Temizle";
            this.btnListeTemizle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnListeTemizle.UseSelectable = true;
            this.btnListeTemizle.Click += new System.EventHandler(this.btnListeTemizle_Click);
            // 
            // btnDogrula
            // 
            this.btnDogrula.Location = new System.Drawing.Point(326, 170);
            this.btnDogrula.Name = "btnDogrula";
            this.btnDogrula.Size = new System.Drawing.Size(203, 34);
            this.btnDogrula.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnDogrula.TabIndex = 8;
            this.btnDogrula.Text = "Seçileni Doğrula";
            this.btnDogrula.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnDogrula.UseSelectable = true;
            this.btnDogrula.Click += new System.EventHandler(this.btnDogrula_Click);
            // 
            // textBox1
            // 
            // 
            // 
            // 
            this.textBox1.CustomButton.Image = null;
            this.textBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.textBox1.CustomButton.Name = "";
            this.textBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.CustomButton.TabIndex = 1;
            this.textBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox1.CustomButton.UseSelectable = true;
            this.textBox1.CustomButton.Visible = false;
            this.textBox1.Lines = new string[0];
            this.textBox1.Location = new System.Drawing.Point(153, 93);
            this.textBox1.MaxLength = 32767;
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '\0';
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox1.SelectedText = "";
            this.textBox1.SelectionLength = 0;
            this.textBox1.SelectionStart = 0;
            this.textBox1.Size = new System.Drawing.Size(75, 23);
            this.textBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox1.TabIndex = 9;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.textBox1.UseSelectable = true;
            this.textBox1.WaterMark = "Adet Girin";
            this.textBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // TCKimlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 441);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDogrula);
            this.Controls.Add(this.btnListeTemizle);
            this.Controls.Add(this.btnUret);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "TCKimlik";
            this.Text = "TC Kimlik No Üret/Doğrula";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.TCKimlik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSonuc;
        private MetroFramework.Controls.MetroButton btnUret;
        private MetroFramework.Controls.MetroButton btnListeTemizle;
        private MetroFramework.Controls.MetroButton btnDogrula;
        private MetroFramework.Controls.MetroTextBox textBox1;
    }
}

