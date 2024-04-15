namespace HastaneHastaKayit
{
    partial class AdminPanel
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
            btn_doktorEkle = new Button();
            btn_hemsireEkle = new Button();
            btn_doktorListele = new Button();
            btn_hemsireListele = new Button();
            SuspendLayout();
            // 
            // btn_doktorEkle
            // 
            btn_doktorEkle.BackColor = SystemColors.MenuHighlight;
            btn_doktorEkle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_doktorEkle.ForeColor = SystemColors.Info;
            btn_doktorEkle.Location = new Point(12, 12);
            btn_doktorEkle.Name = "btn_doktorEkle";
            btn_doktorEkle.Size = new Size(372, 224);
            btn_doktorEkle.TabIndex = 0;
            btn_doktorEkle.Text = "Doktor Ekle";
            btn_doktorEkle.UseVisualStyleBackColor = false;
            btn_doktorEkle.Click += btn_doktorEkle_Click;
            // 
            // btn_hemsireEkle
            // 
            btn_hemsireEkle.BackColor = SystemColors.MenuHighlight;
            btn_hemsireEkle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_hemsireEkle.ForeColor = SystemColors.Info;
            btn_hemsireEkle.Location = new Point(390, 12);
            btn_hemsireEkle.Name = "btn_hemsireEkle";
            btn_hemsireEkle.Size = new Size(382, 224);
            btn_hemsireEkle.TabIndex = 1;
            btn_hemsireEkle.Text = "Hemşire Ekle";
            btn_hemsireEkle.UseVisualStyleBackColor = false;
            btn_hemsireEkle.Click += btn_hemsireEkle_Click;
            // 
            // btn_doktorListele
            // 
            btn_doktorListele.BackColor = SystemColors.MenuHighlight;
            btn_doktorListele.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_doktorListele.ForeColor = SystemColors.Info;
            btn_doktorListele.Location = new Point(12, 242);
            btn_doktorListele.Name = "btn_doktorListele";
            btn_doktorListele.Size = new Size(372, 207);
            btn_doktorListele.TabIndex = 2;
            btn_doktorListele.Text = "Doktor Listele";
            btn_doktorListele.UseVisualStyleBackColor = false;
            btn_doktorListele.Click += btn_doktorListele_Click;
            // 
            // btn_hemsireListele
            // 
            btn_hemsireListele.BackColor = SystemColors.MenuHighlight;
            btn_hemsireListele.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_hemsireListele.ForeColor = SystemColors.Info;
            btn_hemsireListele.Location = new Point(390, 242);
            btn_hemsireListele.Name = "btn_hemsireListele";
            btn_hemsireListele.Size = new Size(382, 207);
            btn_hemsireListele.TabIndex = 3;
            btn_hemsireListele.Text = "Hemşire Listele";
            btn_hemsireListele.UseVisualStyleBackColor = false;
            btn_hemsireListele.Click += btn_hemsireListele_Click;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 461);
            Controls.Add(btn_hemsireListele);
            Controls.Add(btn_doktorListele);
            Controls.Add(btn_hemsireEkle);
            Controls.Add(btn_doktorEkle);
            Name = "AdminPanel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AdminPanel";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_doktorEkle;
        private Button btn_hemsireEkle;
        private Button btn_doktorListele;
        private Button btn_hemsireListele;
    }
}