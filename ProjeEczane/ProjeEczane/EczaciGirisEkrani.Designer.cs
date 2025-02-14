namespace ProjeEczane
{
    partial class EczaciGirisEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eczaneAdtextBox = new System.Windows.Forms.TextBox();
            this.sifretextBox = new System.Windows.Forms.TextBox();
            this.girisBtn = new System.Windows.Forms.Button();
            this.eczaneGrnDataGridView = new System.Windows.Forms.DataGridView();
            this.receteGoruntuBtn = new System.Windows.Forms.Button();
            this.identityNumbertextBox = new System.Windows.Forms.TextBox();
            this.kimlikSorgulaBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eczaneGrnDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Eczane Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre";
            // 
            // eczaneAdtextBox
            // 
            this.eczaneAdtextBox.Location = new System.Drawing.Point(139, 42);
            this.eczaneAdtextBox.Name = "eczaneAdtextBox";
            this.eczaneAdtextBox.Size = new System.Drawing.Size(100, 22);
            this.eczaneAdtextBox.TabIndex = 3;
            // 
            // sifretextBox
            // 
            this.sifretextBox.Location = new System.Drawing.Point(139, 90);
            this.sifretextBox.Name = "sifretextBox";
            this.sifretextBox.Size = new System.Drawing.Size(100, 22);
            this.sifretextBox.TabIndex = 4;
            // 
            // girisBtn
            // 
            this.girisBtn.Location = new System.Drawing.Point(51, 135);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(134, 49);
            this.girisBtn.TabIndex = 5;
            this.girisBtn.Text = "Giriş Yap";
            this.girisBtn.UseVisualStyleBackColor = true;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // eczaneGrnDataGridView
            // 
            this.eczaneGrnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.eczaneGrnDataGridView.Location = new System.Drawing.Point(275, 42);
            this.eczaneGrnDataGridView.Name = "eczaneGrnDataGridView";
            this.eczaneGrnDataGridView.RowHeadersWidth = 51;
            this.eczaneGrnDataGridView.RowTemplate.Height = 24;
            this.eczaneGrnDataGridView.Size = new System.Drawing.Size(977, 341);
            this.eczaneGrnDataGridView.TabIndex = 6;
            // 
            // receteGoruntuBtn
            // 
            this.receteGoruntuBtn.Location = new System.Drawing.Point(51, 201);
            this.receteGoruntuBtn.Name = "receteGoruntuBtn";
            this.receteGoruntuBtn.Size = new System.Drawing.Size(134, 54);
            this.receteGoruntuBtn.TabIndex = 7;
            this.receteGoruntuBtn.Text = "Reçete görüntüle";
            this.receteGoruntuBtn.UseVisualStyleBackColor = true;
            this.receteGoruntuBtn.Click += new System.EventHandler(this.receteGoruntuBtn_Click);
            // 
            // identityNumbertextBox
            // 
            this.identityNumbertextBox.Location = new System.Drawing.Point(139, 308);
            this.identityNumbertextBox.Name = "identityNumbertextBox";
            this.identityNumbertextBox.Size = new System.Drawing.Size(100, 22);
            this.identityNumbertextBox.TabIndex = 8;
            // 
            // kimlikSorgulaBtn
            // 
            this.kimlikSorgulaBtn.Location = new System.Drawing.Point(63, 368);
            this.kimlikSorgulaBtn.Name = "kimlikSorgulaBtn";
            this.kimlikSorgulaBtn.Size = new System.Drawing.Size(148, 45);
            this.kimlikSorgulaBtn.TabIndex = 9;
            this.kimlikSorgulaBtn.Text = "HASTA GÖSTER";
            this.kimlikSorgulaBtn.UseVisualStyleBackColor = true;
            this.kimlikSorgulaBtn.Click += new System.EventHandler(this.kimlikSorgulaBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "TC Kimlik";
            // 
            // EczaciGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1493, 822);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kimlikSorgulaBtn);
            this.Controls.Add(this.identityNumbertextBox);
            this.Controls.Add(this.receteGoruntuBtn);
            this.Controls.Add(this.eczaneGrnDataGridView);
            this.Controls.Add(this.girisBtn);
            this.Controls.Add(this.sifretextBox);
            this.Controls.Add(this.eczaneAdtextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EczaciGirisEkrani";
            this.Text = "EczaciGirisEkrani";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.eczaneGrnDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eczaneAdtextBox;
        private System.Windows.Forms.TextBox sifretextBox;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.DataGridView eczaneGrnDataGridView;
        private System.Windows.Forms.Button receteGoruntuBtn;
        private System.Windows.Forms.TextBox identityNumbertextBox;
        private System.Windows.Forms.Button kimlikSorgulaBtn;
        private System.Windows.Forms.Label label3;
    }
}