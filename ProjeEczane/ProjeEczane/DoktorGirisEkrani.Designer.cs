namespace ProjeEczane
{
    partial class DoktorGirisEkrani
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
            this.doktorgrsbtn = new System.Windows.Forms.Button();
            this.hstgrntbtn = new System.Windows.Forms.Button();
            this.yenihastabtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxad = new System.Windows.Forms.TextBox();
            this.textBoxpass = new System.Windows.Forms.TextBox();
            this.dktrctgrd = new System.Windows.Forms.DataGridView();
            this.secileniSilBtn = new System.Windows.Forms.Button();
            this.secileniGuncelleBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dktrctgrd)).BeginInit();
            this.SuspendLayout();
            // 
            // doktorgrsbtn
            // 
            this.doktorgrsbtn.Location = new System.Drawing.Point(112, 138);
            this.doktorgrsbtn.Name = "doktorgrsbtn";
            this.doktorgrsbtn.Size = new System.Drawing.Size(115, 53);
            this.doktorgrsbtn.TabIndex = 0;
            this.doktorgrsbtn.Text = "giriş yap";
            this.doktorgrsbtn.UseVisualStyleBackColor = true;
            // 
            // hstgrntbtn
            // 
            this.hstgrntbtn.Location = new System.Drawing.Point(36, 213);
            this.hstgrntbtn.Name = "hstgrntbtn";
            this.hstgrntbtn.Size = new System.Drawing.Size(126, 44);
            this.hstgrntbtn.TabIndex = 1;
            this.hstgrntbtn.Text = "HASTA GÖRÜNTÜLE";
            this.hstgrntbtn.UseVisualStyleBackColor = true;
            this.hstgrntbtn.Click += new System.EventHandler(this.hstgrntbtn_Click);
            // 
            // yenihastabtn
            // 
            this.yenihastabtn.Location = new System.Drawing.Point(188, 213);
            this.yenihastabtn.Name = "yenihastabtn";
            this.yenihastabtn.Size = new System.Drawing.Size(117, 44);
            this.yenihastabtn.TabIndex = 2;
            this.yenihastabtn.Text = "YENİ HASTA EKLE";
            this.yenihastabtn.UseVisualStyleBackColor = true;
            this.yenihastabtn.Click += new System.EventHandler(this.yenihastabtn_Click);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(36, 278);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(126, 44);
            this.guncellebtn.TabIndex = 3;
            this.guncellebtn.Text = "GÜNCELLE";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click);
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(188, 278);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(117, 44);
            this.silbtn.TabIndex = 4;
            this.silbtn.Text = "SİL";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adınız";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifreniz";
            // 
            // textBoxad
            // 
            this.textBoxad.Location = new System.Drawing.Point(112, 43);
            this.textBoxad.Name = "textBoxad";
            this.textBoxad.Size = new System.Drawing.Size(100, 22);
            this.textBoxad.TabIndex = 7;
            // 
            // textBoxpass
            // 
            this.textBoxpass.Location = new System.Drawing.Point(112, 85);
            this.textBoxpass.Name = "textBoxpass";
            this.textBoxpass.Size = new System.Drawing.Size(100, 22);
            this.textBoxpass.TabIndex = 8;
            // 
            // dktrctgrd
            // 
            this.dktrctgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dktrctgrd.Location = new System.Drawing.Point(340, 19);
            this.dktrctgrd.Name = "dktrctgrd";
            this.dktrctgrd.RowHeadersWidth = 51;
            this.dktrctgrd.RowTemplate.Height = 24;
            this.dktrctgrd.Size = new System.Drawing.Size(1151, 411);
            this.dktrctgrd.TabIndex = 9;
            // 
            // secileniSilBtn
            // 
            this.secileniSilBtn.Location = new System.Drawing.Point(36, 341);
            this.secileniSilBtn.Name = "secileniSilBtn";
            this.secileniSilBtn.Size = new System.Drawing.Size(126, 44);
            this.secileniSilBtn.TabIndex = 10;
            this.secileniSilBtn.Text = "SEÇİLENİ SİL";
            this.secileniSilBtn.UseVisualStyleBackColor = true;
            this.secileniSilBtn.Click += new System.EventHandler(this.secileniSilBtn_Click);
            // 
            // secileniGuncelleBtn
            // 
            this.secileniGuncelleBtn.Location = new System.Drawing.Point(188, 341);
            this.secileniGuncelleBtn.Name = "secileniGuncelleBtn";
            this.secileniGuncelleBtn.Size = new System.Drawing.Size(117, 44);
            this.secileniGuncelleBtn.TabIndex = 11;
            this.secileniGuncelleBtn.Text = "SEÇİLENİ GÜNCELLE";
            this.secileniGuncelleBtn.UseVisualStyleBackColor = true;
            this.secileniGuncelleBtn.Click += new System.EventHandler(this.secileniGuncelleBtn_Click);
            // 
            // DoktorGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1609, 764);
            this.Controls.Add(this.secileniGuncelleBtn);
            this.Controls.Add(this.secileniSilBtn);
            this.Controls.Add(this.dktrctgrd);
            this.Controls.Add(this.textBoxpass);
            this.Controls.Add(this.textBoxad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.guncellebtn);
            this.Controls.Add(this.yenihastabtn);
            this.Controls.Add(this.hstgrntbtn);
            this.Controls.Add(this.doktorgrsbtn);
            this.Name = "DoktorGirisEkrani";
            this.Text = "DoktorGirisEkrani";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dktrctgrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doktorgrsbtn;
        private System.Windows.Forms.Button hstgrntbtn;
        private System.Windows.Forms.Button yenihastabtn;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxad;
        private System.Windows.Forms.TextBox textBoxpass;
        private System.Windows.Forms.DataGridView dktrctgrd;
        private System.Windows.Forms.Button secileniSilBtn;
        private System.Windows.Forms.Button secileniGuncelleBtn;
    }
}