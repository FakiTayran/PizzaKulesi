namespace PizzaKulesi
{
    partial class DuzenleYadaEkle
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
            this.lstPizzalar = new System.Windows.Forms.ListBox();
            this.lstMalzemeler = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPizzaAdi = new System.Windows.Forms.TextBox();
            this.txtMalzemeAdi = new System.Windows.Forms.TextBox();
            this.btnPizzaEkle = new System.Windows.Forms.Button();
            this.btnMalzemeEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnPizzaSil = new System.Windows.Forms.Button();
            this.btnMalzemeSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstPizzalar
            // 
            this.lstPizzalar.BackColor = System.Drawing.SystemColors.Desktop;
            this.lstPizzalar.DisplayMember = "CesitAdi";
            this.lstPizzalar.ForeColor = System.Drawing.SystemColors.Info;
            this.lstPizzalar.FormattingEnabled = true;
            this.lstPizzalar.Location = new System.Drawing.Point(12, 56);
            this.lstPizzalar.Name = "lstPizzalar";
            this.lstPizzalar.Size = new System.Drawing.Size(277, 277);
            this.lstPizzalar.TabIndex = 0;
            this.lstPizzalar.SelectedIndexChanged += new System.EventHandler(this.lstPizzalar_SelectedIndexChanged);
            // 
            // lstMalzemeler
            // 
            this.lstMalzemeler.BackColor = System.Drawing.SystemColors.Desktop;
            this.lstMalzemeler.DisplayMember = "MalzemeAdi";
            this.lstMalzemeler.ForeColor = System.Drawing.SystemColors.Info;
            this.lstMalzemeler.FormattingEnabled = true;
            this.lstMalzemeler.Location = new System.Drawing.Point(295, 56);
            this.lstMalzemeler.Name = "lstMalzemeler";
            this.lstMalzemeler.Size = new System.Drawing.Size(285, 277);
            this.lstMalzemeler.TabIndex = 1;
            this.lstMalzemeler.SelectedIndexChanged += new System.EventHandler(this.lstMalzemeler_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pizzalar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(292, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Malzemeler";
            // 
            // txtPizzaAdi
            // 
            this.txtPizzaAdi.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtPizzaAdi.ForeColor = System.Drawing.SystemColors.Info;
            this.txtPizzaAdi.Location = new System.Drawing.Point(69, 33);
            this.txtPizzaAdi.Name = "txtPizzaAdi";
            this.txtPizzaAdi.Size = new System.Drawing.Size(152, 20);
            this.txtPizzaAdi.TabIndex = 3;
            // 
            // txtMalzemeAdi
            // 
            this.txtMalzemeAdi.BackColor = System.Drawing.SystemColors.Desktop;
            this.txtMalzemeAdi.Location = new System.Drawing.Point(368, 33);
            this.txtMalzemeAdi.Name = "txtMalzemeAdi";
            this.txtMalzemeAdi.Size = new System.Drawing.Size(151, 20);
            this.txtMalzemeAdi.TabIndex = 3;
            // 
            // btnPizzaEkle
            // 
            this.btnPizzaEkle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPizzaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizzaEkle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPizzaEkle.Location = new System.Drawing.Point(227, 12);
            this.btnPizzaEkle.Name = "btnPizzaEkle";
            this.btnPizzaEkle.Size = new System.Drawing.Size(27, 40);
            this.btnPizzaEkle.TabIndex = 4;
            this.btnPizzaEkle.Text = "+";
            this.btnPizzaEkle.UseVisualStyleBackColor = false;
            this.btnPizzaEkle.Click += new System.EventHandler(this.btnPizzaEkle_Click);
            // 
            // btnMalzemeEkle
            // 
            this.btnMalzemeEkle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMalzemeEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMalzemeEkle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnMalzemeEkle.Location = new System.Drawing.Point(525, 12);
            this.btnMalzemeEkle.Name = "btnMalzemeEkle";
            this.btnMalzemeEkle.Size = new System.Drawing.Size(23, 41);
            this.btnMalzemeEkle.TabIndex = 4;
            this.btnMalzemeEkle.Text = "+";
            this.btnMalzemeEkle.UseVisualStyleBackColor = false;
            this.btnMalzemeEkle.Click += new System.EventHandler(this.btnMalzemeEkle_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDuzenle.ForeColor = System.Drawing.SystemColors.Info;
            this.btnDuzenle.Location = new System.Drawing.Point(218, 339);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(134, 23);
            this.btnDuzenle.TabIndex = 5;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIptal.ForeColor = System.Drawing.SystemColors.Info;
            this.btnIptal.Location = new System.Drawing.Point(295, 339);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(134, 23);
            this.btnIptal.TabIndex = 5;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = false;
            this.btnIptal.Visible = false;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnPizzaSil
            // 
            this.btnPizzaSil.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnPizzaSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizzaSil.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPizzaSil.Location = new System.Drawing.Point(260, 12);
            this.btnPizzaSil.Name = "btnPizzaSil";
            this.btnPizzaSil.Size = new System.Drawing.Size(26, 41);
            this.btnPizzaSil.TabIndex = 5;
            this.btnPizzaSil.Text = "X";
            this.btnPizzaSil.UseVisualStyleBackColor = false;
            this.btnPizzaSil.Click += new System.EventHandler(this.btnPizzaSil_Click);
            // 
            // btnMalzemeSil
            // 
            this.btnMalzemeSil.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnMalzemeSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMalzemeSil.ForeColor = System.Drawing.SystemColors.Info;
            this.btnMalzemeSil.Location = new System.Drawing.Point(554, 12);
            this.btnMalzemeSil.Name = "btnMalzemeSil";
            this.btnMalzemeSil.Size = new System.Drawing.Size(26, 40);
            this.btnMalzemeSil.TabIndex = 5;
            this.btnMalzemeSil.Text = "X";
            this.btnMalzemeSil.UseVisualStyleBackColor = false;
            this.btnMalzemeSil.Click += new System.EventHandler(this.btnMalzemeSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.Info;
            this.btnKaydet.Location = new System.Drawing.Point(151, 339);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(135, 23);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Visible = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // DuzenleYadaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(589, 371);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnMalzemeSil);
            this.Controls.Add(this.btnPizzaSil);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnMalzemeEkle);
            this.Controls.Add(this.btnPizzaEkle);
            this.Controls.Add(this.txtMalzemeAdi);
            this.Controls.Add(this.txtPizzaAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMalzemeler);
            this.Controls.Add(this.lstPizzalar);
            this.Name = "DuzenleYadaEkle";
            this.Text = "DuzenleYadaEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstPizzalar;
        private System.Windows.Forms.ListBox lstMalzemeler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPizzaAdi;
        private System.Windows.Forms.TextBox txtMalzemeAdi;
        private System.Windows.Forms.Button btnPizzaEkle;
        private System.Windows.Forms.Button btnMalzemeEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnPizzaSil;
        private System.Windows.Forms.Button btnMalzemeSil;
        private System.Windows.Forms.Button btnKaydet;
    }
}