namespace HastaneHastaKayit
{
    partial class DoktorEkle
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
            txt_ad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txt_soyad = new TextBox();
            txt_doktorKimlik = new TextBox();
            txt_tc = new TextBox();
            txt_email = new TextBox();
            txt_sifre = new TextBox();
            btn_ekle = new Button();
            SuspendLayout();
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(206, 9);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(217, 23);
            txt_ad.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 1;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 2;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 99);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 3;
            label3.Text = "Doktor Kimliği";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(12, 148);
            label4.Name = "label4";
            label4.Size = new Size(28, 21);
            label4.TabIndex = 4;
            label4.Text = "TC";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(12, 191);
            label5.Name = "label5";
            label5.Size = new Size(48, 21);
            label5.TabIndex = 5;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(12, 233);
            label6.Name = "label6";
            label6.Size = new Size(44, 21);
            label6.TabIndex = 6;
            label6.Text = "Şifre";
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(206, 54);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(217, 23);
            txt_soyad.TabIndex = 7;
            // 
            // txt_doktorKimlik
            // 
            txt_doktorKimlik.Location = new Point(206, 99);
            txt_doktorKimlik.Name = "txt_doktorKimlik";
            txt_doktorKimlik.Size = new Size(217, 23);
            txt_doktorKimlik.TabIndex = 8;
            // 
            // txt_tc
            // 
            txt_tc.Location = new Point(206, 148);
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(217, 23);
            txt_tc.TabIndex = 9;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(206, 191);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(217, 23);
            txt_email.TabIndex = 10;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(206, 233);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.Size = new Size(217, 23);
            txt_sifre.TabIndex = 11;
            // 
            // btn_ekle
            // 
            btn_ekle.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_ekle.Location = new Point(12, 291);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(411, 46);
            btn_ekle.TabIndex = 12;
            btn_ekle.Text = "Doktor Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // DoktorEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 357);
            Controls.Add(btn_ekle);
            Controls.Add(txt_sifre);
            Controls.Add(txt_email);
            Controls.Add(txt_tc);
            Controls.Add(txt_doktorKimlik);
            Controls.Add(txt_soyad);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_ad);
            Name = "DoktorEkle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DoktorEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_ad;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txt_soyad;
        private TextBox txt_doktorKimlik;
        private TextBox txt_tc;
        private TextBox txt_email;
        private TextBox txt_sifre;
        private Button btn_ekle;
    }
}