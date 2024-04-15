namespace HastaneHastaKayit
{
    partial class DoktorPanel
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
            btn_hastaEkle = new Button();
            btn_hastaGuncelle = new Button();
            SuspendLayout();
            // 
            // btn_hastaEkle
            // 
            btn_hastaEkle.BackColor = SystemColors.Info;
            btn_hastaEkle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_hastaEkle.ForeColor = SystemColors.MenuHighlight;
            btn_hastaEkle.Location = new Point(12, 12);
            btn_hastaEkle.Name = "btn_hastaEkle";
            btn_hastaEkle.Size = new Size(288, 258);
            btn_hastaEkle.TabIndex = 0;
            btn_hastaEkle.Text = "Hasta Ekle";
            btn_hastaEkle.UseVisualStyleBackColor = false;
            btn_hastaEkle.Click += btn_hastaEkle_Click;
            // 
            // btn_hastaGuncelle
            // 
            btn_hastaGuncelle.BackColor = SystemColors.Info;
            btn_hastaGuncelle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btn_hastaGuncelle.ForeColor = SystemColors.MenuHighlight;
            btn_hastaGuncelle.Location = new Point(306, 12);
            btn_hastaGuncelle.Name = "btn_hastaGuncelle";
            btn_hastaGuncelle.Size = new Size(288, 258);
            btn_hastaGuncelle.TabIndex = 1;
            btn_hastaGuncelle.Text = "Hasta Güncelle";
            btn_hastaGuncelle.UseVisualStyleBackColor = false;
            btn_hastaGuncelle.Click += btn_hastaGuncelle_Click;
            // 
            // DoktorPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 277);
            Controls.Add(btn_hastaGuncelle);
            Controls.Add(btn_hastaEkle);
            Name = "DoktorPanel";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DoktorPanel";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_hastaEkle;
        private Button btn_hastaGuncelle;
    }
}