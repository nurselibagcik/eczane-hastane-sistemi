namespace ProjeEczane
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hastaGirisBtn = new System.Windows.Forms.Button();
            this.doktorGirisBtn = new System.Windows.Forms.Button();
            this.eczaciGirisBtn = new System.Windows.Forms.Button();
            this.ureticiGirisBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // hastaGirisBtn
            // 
            this.hastaGirisBtn.Location = new System.Drawing.Point(254, 403);
            this.hastaGirisBtn.Name = "hastaGirisBtn";
            this.hastaGirisBtn.Size = new System.Drawing.Size(134, 60);
            this.hastaGirisBtn.TabIndex = 0;
            this.hastaGirisBtn.Text = "HASTA GİRİŞİ";
            this.hastaGirisBtn.UseVisualStyleBackColor = true;
            this.hastaGirisBtn.Click += new System.EventHandler(this.hastaGirisBtn_Click);
            // 
            // doktorGirisBtn
            // 
            this.doktorGirisBtn.Location = new System.Drawing.Point(250, 548);
            this.doktorGirisBtn.Name = "doktorGirisBtn";
            this.doktorGirisBtn.Size = new System.Drawing.Size(138, 60);
            this.doktorGirisBtn.TabIndex = 1;
            this.doktorGirisBtn.Text = "DOKTOR GİRİŞİ";
            this.doktorGirisBtn.UseVisualStyleBackColor = true;
            this.doktorGirisBtn.Click += new System.EventHandler(this.doktorGirisBtn_Click);
            // 
            // eczaciGirisBtn
            // 
            this.eczaciGirisBtn.Location = new System.Drawing.Point(1127, 569);
            this.eczaciGirisBtn.Name = "eczaciGirisBtn";
            this.eczaciGirisBtn.Size = new System.Drawing.Size(135, 60);
            this.eczaciGirisBtn.TabIndex = 2;
            this.eczaciGirisBtn.Text = "ECZANE GİRİŞİ";
            this.eczaciGirisBtn.UseVisualStyleBackColor = true;
            this.eczaciGirisBtn.Click += new System.EventHandler(this.eczaciGirisBtn_Click);
            // 
            // ureticiGirisBtn
            // 
            this.ureticiGirisBtn.Location = new System.Drawing.Point(1127, 411);
            this.ureticiGirisBtn.Name = "ureticiGirisBtn";
            this.ureticiGirisBtn.Size = new System.Drawing.Size(135, 60);
            this.ureticiGirisBtn.TabIndex = 3;
            this.ureticiGirisBtn.Text = "ÜRETİCİ GİRİŞİ";
            this.ureticiGirisBtn.UseVisualStyleBackColor = true;
            this.ureticiGirisBtn.Click += new System.EventHandler(this.ureticiGirisBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1108, 152);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(242, 253);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(302, 135);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(258, 219);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(528, 548);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(63, 64);
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(526, 403);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(65, 64);
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1365, 403);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(65, 64);
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(1365, 565);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(66, 64);
            this.pictureBox7.TabIndex = 10;
            this.pictureBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1540, 800);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ureticiGirisBtn);
            this.Controls.Add(this.eczaciGirisBtn);
            this.Controls.Add(this.doktorGirisBtn);
            this.Controls.Add(this.hastaGirisBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hastaGirisBtn;
        private System.Windows.Forms.Button doktorGirisBtn;
        private System.Windows.Forms.Button eczaciGirisBtn;
        private System.Windows.Forms.Button ureticiGirisBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
    }
}

