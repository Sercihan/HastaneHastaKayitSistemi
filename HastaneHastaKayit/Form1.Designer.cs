namespace HastaneHastaKayit
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_email = new TextBox();
            txt_sifre = new TextBox();
            btn_giris = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "Şifre";
            // 
            // txt_email
            // 
            txt_email.Location = new Point(101, 9);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(165, 23);
            txt_email.TabIndex = 2;
            // 
            // txt_sifre
            // 
            txt_sifre.Location = new Point(101, 38);
            txt_sifre.Name = "txt_sifre";
            txt_sifre.PasswordChar = '*';
            txt_sifre.Size = new Size(165, 23);
            txt_sifre.TabIndex = 3;
            // 
            // btn_giris
            // 
            btn_giris.Location = new Point(101, 67);
            btn_giris.Name = "btn_giris";
            btn_giris.Size = new Size(165, 23);
            btn_giris.TabIndex = 4;
            btn_giris.Text = "Giriş Yap";
            btn_giris.UseVisualStyleBackColor = true;
            btn_giris.Click += btn_giris_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 105);
            Controls.Add(btn_giris);
            Controls.Add(txt_sifre);
            Controls.Add(txt_email);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_email;
        private TextBox txt_sifre;
        private Button btn_giris;
    }
}
