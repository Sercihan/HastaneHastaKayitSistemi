namespace HastaneHastaKayit
{
    partial class HemsireListele
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
            dg_hemsireListe = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg_hemsireListe).BeginInit();
            SuspendLayout();
            // 
            // dg_hemsireListe
            // 
            dg_hemsireListe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_hemsireListe.Location = new Point(12, 12);
            dg_hemsireListe.Name = "dg_hemsireListe";
            dg_hemsireListe.Size = new Size(680, 417);
            dg_hemsireListe.TabIndex = 0;
            // 
            // HemsireListele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 441);
            Controls.Add(dg_hemsireListe);
            Name = "HemsireListele";
            StartPosition = FormStartPosition.CenterParent;
            Text = "HemsireListele";
            ((System.ComponentModel.ISupportInitialize)dg_hemsireListe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg_hemsireListe;
    }
}