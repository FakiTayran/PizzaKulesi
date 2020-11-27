namespace PizzaKulesi
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

            if (disposing)
            {
                db.Dispose();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.cboPizzaCesidi = new System.Windows.Forms.ComboBox();
            this.clbEkstraMalzemeler = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.cbTeslimEdildi = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSiparisSil = new System.Windows.Forms.Button();
            this.btnSiparisDuzenle = new System.Windows.Forms.Button();
            this.btnEkstraMalzemeDuzenle = new System.Windows.Forms.Button();
            this.btnPizzaCesidiDuzenle = new System.Windows.Forms.Button();
            this.cbTeslimEdileniGizle = new System.Windows.Forms.CheckBox();
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(27, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Müşteri Ad Soyad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(27, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pizza Çeşidi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label4.Location = new System.Drawing.Point(26, 332);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Teslimat Adres";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAdSoyad.Location = new System.Drawing.Point(29, 75);
            this.txtAdSoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(215, 26);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // cboPizzaCesidi
            // 
            this.cboPizzaCesidi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.cboPizzaCesidi.DisplayMember = "CesitAdi";
            this.cboPizzaCesidi.FormattingEnabled = true;
            this.cboPizzaCesidi.Location = new System.Drawing.Point(30, 140);
            this.cboPizzaCesidi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboPizzaCesidi.Name = "cboPizzaCesidi";
            this.cboPizzaCesidi.Size = new System.Drawing.Size(215, 28);
            this.cboPizzaCesidi.TabIndex = 2;
            this.cboPizzaCesidi.ValueMember = "Id";
            // 
            // clbEkstraMalzemeler
            // 
            this.clbEkstraMalzemeler.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.clbEkstraMalzemeler.ForeColor = System.Drawing.SystemColors.Desktop;
            this.clbEkstraMalzemeler.FormattingEnabled = true;
            this.clbEkstraMalzemeler.Location = new System.Drawing.Point(30, 208);
            this.clbEkstraMalzemeler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbEkstraMalzemeler.Name = "clbEkstraMalzemeler";
            this.clbEkstraMalzemeler.Size = new System.Drawing.Size(215, 109);
            this.clbEkstraMalzemeler.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(40, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ekstra Malzemeler";
            // 
            // txtAdres
            // 
            this.txtAdres.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtAdres.Location = new System.Drawing.Point(30, 356);
            this.txtAdres.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(215, 90);
            this.txtAdres.TabIndex = 4;
            // 
            // cbTeslimEdildi
            // 
            this.cbTeslimEdildi.AutoSize = true;
            this.cbTeslimEdildi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbTeslimEdildi.Location = new System.Drawing.Point(30, 452);
            this.cbTeslimEdildi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTeslimEdildi.Name = "cbTeslimEdildi";
            this.cbTeslimEdildi.Size = new System.Drawing.Size(128, 24);
            this.cbTeslimEdildi.TabIndex = 5;
            this.cbTeslimEdildi.Text = "Teslim Edildi";
            this.cbTeslimEdildi.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEkle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnEkle.Location = new System.Drawing.Point(31, 502);
            this.btnEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(214, 30);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSiparisSil
            // 
            this.btnSiparisSil.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSiparisSil.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSiparisSil.Location = new System.Drawing.Point(353, 502);
            this.btnSiparisSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiparisSil.Name = "btnSiparisSil";
            this.btnSiparisSil.Size = new System.Drawing.Size(162, 30);
            this.btnSiparisSil.TabIndex = 6;
            this.btnSiparisSil.Text = "Sil";
            this.btnSiparisSil.UseVisualStyleBackColor = false;
            this.btnSiparisSil.Click += new System.EventHandler(this.btnSiparisSil_Click);
            // 
            // btnSiparisDuzenle
            // 
            this.btnSiparisDuzenle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSiparisDuzenle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnSiparisDuzenle.Location = new System.Drawing.Point(521, 502);
            this.btnSiparisDuzenle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSiparisDuzenle.Name = "btnSiparisDuzenle";
            this.btnSiparisDuzenle.Size = new System.Drawing.Size(170, 30);
            this.btnSiparisDuzenle.TabIndex = 6;
            this.btnSiparisDuzenle.Text = "Düzenle";
            this.btnSiparisDuzenle.UseVisualStyleBackColor = false;
            this.btnSiparisDuzenle.Click += new System.EventHandler(this.btnSiparisDuzenle_Click);
            // 
            // btnEkstraMalzemeDuzenle
            // 
            this.btnEkstraMalzemeDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkstraMalzemeDuzenle.Location = new System.Drawing.Point(207, 176);
            this.btnEkstraMalzemeDuzenle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEkstraMalzemeDuzenle.Name = "btnEkstraMalzemeDuzenle";
            this.btnEkstraMalzemeDuzenle.Size = new System.Drawing.Size(38, 31);
            this.btnEkstraMalzemeDuzenle.TabIndex = 6;
            this.btnEkstraMalzemeDuzenle.Text = "+";
            this.btnEkstraMalzemeDuzenle.UseVisualStyleBackColor = true;
            this.btnEkstraMalzemeDuzenle.Click += new System.EventHandler(this.btnEkstraMalzemeDuzenle_Click);
            // 
            // btnPizzaCesidiDuzenle
            // 
            this.btnPizzaCesidiDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPizzaCesidiDuzenle.Location = new System.Drawing.Point(206, 105);
            this.btnPizzaCesidiDuzenle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPizzaCesidiDuzenle.Name = "btnPizzaCesidiDuzenle";
            this.btnPizzaCesidiDuzenle.Size = new System.Drawing.Size(38, 31);
            this.btnPizzaCesidiDuzenle.TabIndex = 6;
            this.btnPizzaCesidiDuzenle.Text = "+";
            this.btnPizzaCesidiDuzenle.UseVisualStyleBackColor = true;
            this.btnPizzaCesidiDuzenle.Click += new System.EventHandler(this.btnPizzaCesidiDuzenle_Click);
            // 
            // cbTeslimEdileniGizle
            // 
            this.cbTeslimEdileniGizle.AutoSize = true;
            this.cbTeslimEdileniGizle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.cbTeslimEdileniGizle.Location = new System.Drawing.Point(487, 26);
            this.cbTeslimEdileniGizle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTeslimEdileniGizle.Name = "cbTeslimEdileniGizle";
            this.cbTeslimEdileniGizle.Size = new System.Drawing.Size(204, 24);
            this.cbTeslimEdileniGizle.TabIndex = 7;
            this.cbTeslimEdileniGizle.Text = "Teslim Edilenleri Gizle";
            this.cbTeslimEdileniGizle.UseVisualStyleBackColor = true;
            this.cbTeslimEdileniGizle.CheckedChanged += new System.EventHandler(this.cbTeslimEdileniGizle_CheckedChanged);
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AllowUserToAddRows = false;
            this.dgvSiparisler.AllowUserToDeleteRows = false;
            this.dgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparisler.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvSiparisler.Location = new System.Drawing.Point(267, 56);
            this.dgvSiparisler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.ReadOnly = true;
            this.dgvSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisler.Size = new System.Drawing.Size(504, 429);
            this.dgvSiparisler.TabIndex = 8;
            this.dgvSiparisler.SelectionChanged += new System.EventHandler(this.dgvSiparisler_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MusteriTamAd";
            this.Column1.FillWeight = 61.54822F;
            this.Column1.HeaderText = "Müşteri Ad";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TeslimString";
            this.Column5.FillWeight = 140F;
            this.Column5.HeaderText = "Teslim Durumu";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Pizza";
            this.Column2.FillWeight = 61.54822F;
            this.Column2.HeaderText = "Pizza Çeşidi";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MalzemeIsimleri";
            this.Column3.HeaderText = "Malzemeler";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Adres";
            this.Column4.FillWeight = 61.54822F;
            this.Column4.HeaderText = "Adres";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(31, 502);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(213, 30);
            this.btnKaydet.TabIndex = 9;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Visible = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(353, 490);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(338, 52);
            this.btnDuzenle.TabIndex = 10;
            this.btnDuzenle.Text = "Düzenlemeyi Sonlandır";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Visible = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnİptal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(783, 566);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.dgvSiparisler);
            this.Controls.Add(this.cbTeslimEdileniGizle);
            this.Controls.Add(this.btnSiparisDuzenle);
            this.Controls.Add(this.btnPizzaCesidiDuzenle);
            this.Controls.Add(this.btnEkstraMalzemeDuzenle);
            this.Controls.Add(this.btnSiparisSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cbTeslimEdildi);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.clbEkstraMalzemeler);
            this.Controls.Add(this.cboPizzaCesidi);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "PizzaKulesi(Pizza Sipariş Takip))";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.ComboBox cboPizzaCesidi;
        private System.Windows.Forms.CheckedListBox clbEkstraMalzemeler;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.CheckBox cbTeslimEdildi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSiparisSil;
        private System.Windows.Forms.Button btnSiparisDuzenle;
        private System.Windows.Forms.Button btnEkstraMalzemeDuzenle;
        private System.Windows.Forms.Button btnPizzaCesidiDuzenle;
        private System.Windows.Forms.CheckBox cbTeslimEdileniGizle;
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnDuzenle;
    }
}

