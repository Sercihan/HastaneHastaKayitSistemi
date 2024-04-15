namespace HastaneHastaKayit
{
    partial class HemsireEkle
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_ad = new TextBox();
            txt_soyad = new TextBox();
            txt_tc = new TextBox();
            btn_ekle = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(36, 25);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(33, 25);
            label3.TabIndex = 2;
            label3.Text = "TC";
            // 
            // txt_ad
            // 
            txt_ad.Location = new Point(116, 9);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(191, 23);
            txt_ad.TabIndex = 3;
            // 
            // txt_soyad
            // 
            txt_soyad.Location = new Point(116, 53);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(191, 23);
            txt_soyad.TabIndex = 4;
            // 
            // txt_tc
            // 
            txt_tc.Location = new Point(116, 95);
            txt_tc.Name = "txt_tc";
            txt_tc.Size = new Size(191, 23);
            txt_tc.TabIndex = 5;
            // 
            // btn_ekle
            // 
            btn_ekle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_ekle.Location = new Point(116, 134);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(191, 31);
            btn_ekle.TabIndex = 6;
            btn_ekle.Text = "Hemşire Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // HemsireEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 183);
            Controls.Add(btn_ekle);
            Controls.Add(txt_tc);
            Controls.Add(txt_soyad);
            Controls.Add(txt_ad);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HemsireEkle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HemsireEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_ad;
        private TextBox txt_soyad;
        private TextBox txt_tc;
        private Button btn_ekle;
    }
}