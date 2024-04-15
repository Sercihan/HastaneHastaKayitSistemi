namespace HastaneHastaKayit
{
    partial class DoktorListele
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
            dg_doktorListe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg_doktorListe).BeginInit();
            SuspendLayout();
            // 
            // dg_doktorListe
            // 
            dg_doktorListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_doktorListe.Location = new Point(12, 12);
            dg_doktorListe.Name = "dg_doktorListe";
            dg_doktorListe.Size = new Size(920, 477);
            dg_doktorListe.TabIndex = 0;
            // 
            // DoktorListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 501);
            Controls.Add(dg_doktorListe);
            Name = "DoktorListele";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DoktorListele";
            ((System.ComponentModel.ISupportInitialize)dg_doktorListe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg_doktorListe;
    }
}