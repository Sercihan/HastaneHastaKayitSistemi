namespace HastaneHastaKayit
{
    partial class HastaGüncelle
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
            dg_hastaListe = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_ad = new TextBox();
            txt_soyad = new TextBox();
            txt_email = new TextBox();
            msk_telefon = new MaskedTextBox();
            txt_tc = new TextBox();
            rtxt_teshis = new RichTextBox();
            nmr_tedavi = new NumericUpDown();
            btn_guncelle = new Button();
            ((System.ComponentModel.ISupportInitialize)dg_hastaListe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_tedavi).BeginInit();
            SuspendLayout();
            // 
            // dg_hastaListe
            // 
            dg_hastaListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_hastaListe.Location = new Point(12, 12);
            dg_hastaListe.Name = "dg_hastaListe";
            dg_hastaListe.Size = new Size(334, 460);
            dg_hastaListe.TabIndex = 0;
            dg_hastaListe.CellClick += dg_hastaListe_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(373, 20);
            label1.Name = "label1";
            label1.Size = new Size(31, 21);
            label1.TabIndex = 1;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(373, 55);
            label2.Name = "label2";
            label2.Size = new Size(55, 21);
            label2.TabIndex = 2;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(373, 93);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(373, 133);
            label4.Name = "label4";
            label4.Size = new Size(64, 21);
            label4.TabIndex = 4;
            label4.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label5.Location = new Point(373, 173);
            label5.Name = "label5";
            label5.Size = new Size(28, 21);
            label5.TabIndex = 5;
            label5.Text = "TC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label6.Location = new Point(373, 236);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 6;
            label6.Text = "Teşhis";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(373, 387);
            label7.Name = "label7";
            label7.Size = new Size(104, 21);
            label7.TabIndex = 7;
            label7.Text = "Tedavi Süresi";
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(474, 20);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(227, 23);
            txt_ad.TabIndex = 8;
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(474, 55);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(227, 23);
            txt_soyad.TabIndex = 9;
            // 
            // txt_email
            // 
            txt_email.Location = new Point(474, 93);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(227, 23);
            txt_email.TabIndex = 10;
            // 
            // msk_telefon
            // 
            msk_telefon.Location = new Point(474, 133);
            msk_telefon.Mask = "0000000000";
            msk_telefon.Name = "msk_telefon";
            msk_telefon.Size = new Size(227, 23);
            msk_telefon.TabIndex = 11;
            // 
            // txt_tc
            // 
            txt_tc.Location = new Point(474, 173);
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(227, 23);
            txt_tc.TabIndex = 12;
            // 
            // rtxt_teshis
            // 
            rtxt_teshis.Location = new Point(474, 236);
            rtxt_teshis.Name = "rtxt_teshis";
            rtxt_teshis.Size = new Size(227, 132);
            rtxt_teshis.TabIndex = 13;
            rtxt_teshis.Text = "";
            // 
            // nmr_tedavi
            // 
            nmr_tedavi.Location = new Point(510, 387);
            nmr_tedavi.Name = "nmr_tedavi";
            nmr_tedavi.Size = new Size(148, 23);
            nmr_tedavi.TabIndex = 14;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_guncelle.Location = new Point(474, 436);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(227, 36);
            btn_guncelle.TabIndex = 15;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // HastaGüncelle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 484);
            Controls.Add(btn_guncelle);
            Controls.Add(nmr_tedavi);
            Controls.Add(rtxt_teshis);
            Controls.Add(txt_tc);
            Controls.Add(msk_telefon);
            Controls.Add(txt_email);
            Controls.Add(txt_soyad);
            Controls.Add(txt_ad);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dg_hastaListe);
            Name = "HastaGüncelle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HastaGüncelle";
            ((System.ComponentModel.ISupportInitialize)dg_hastaListe).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_tedavi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dg_hastaListe;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_ad;
        private TextBox txt_soyad;
        private TextBox txt_email;
        private MaskedTextBox msk_telefon;
        private TextBox txt_tc;
        private RichTextBox rtxt_teshis;
        private NumericUpDown nmr_tedavi;
        private Button btn_guncelle;
    }
}