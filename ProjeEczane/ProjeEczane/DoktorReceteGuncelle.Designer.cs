namespace ProjeEczane
{
    partial class DoktorReceteGuncelle
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
            this.lblHastaAdi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxDoctor = new System.Windows.Forms.ComboBox();
            this.comboBoxIlac = new System.Windows.Forms.ComboBox();
            this.textBoxDosage = new System.Windows.Forms.TextBox();
            this.textBoxFrequency = new System.Windows.Forms.TextBox();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.receteGuncelleBtn = new System.Windows.Forms.Button();
            this.receteDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.receteDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHastaAdi
            // 
            this.lblHastaAdi.AutoSize = true;
            this.lblHastaAdi.Location = new System.Drawing.Point(47, 55);
            this.lblHastaAdi.Name = "lblHastaAdi";
            this.lblHastaAdi.Size = new System.Drawing.Size(0, 16);
            this.lblHastaAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "DOKTOR ADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "İLAÇ ADI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOZAJ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "KULLANIM SIKLIĞI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "KULLANIM SÜRES";
            // 
            // comboBoxDoctor
            // 
            this.comboBoxDoctor.FormattingEnabled = true;
            this.comboBoxDoctor.Location = new System.Drawing.Point(184, 107);
            this.comboBoxDoctor.Name = "comboBoxDoctor";
            this.comboBoxDoctor.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDoctor.TabIndex = 6;
            // 
            // comboBoxIlac
            // 
            this.comboBoxIlac.FormattingEnabled = true;
            this.comboBoxIlac.Location = new System.Drawing.Point(184, 166);
            this.comboBoxIlac.Name = "comboBoxIlac";
            this.comboBoxIlac.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIlac.TabIndex = 7;
            // 
            // textBoxDosage
            // 
            this.textBoxDosage.Location = new System.Drawing.Point(184, 229);
            this.textBoxDosage.Name = "textBoxDosage";
            this.textBoxDosage.Size = new System.Drawing.Size(100, 22);
            this.textBoxDosage.TabIndex = 8;
            // 
            // textBoxFrequency
            // 
            this.textBoxFrequency.Location = new System.Drawing.Point(184, 290);
            this.textBoxFrequency.Name = "textBoxFrequency";
            this.textBoxFrequency.Size = new System.Drawing.Size(100, 22);
            this.textBoxFrequency.TabIndex = 9;
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(184, 353);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(100, 22);
            this.textBoxDuration.TabIndex = 10;
            // 
            // receteGuncelleBtn
            // 
            this.receteGuncelleBtn.Location = new System.Drawing.Point(107, 418);
            this.receteGuncelleBtn.Name = "receteGuncelleBtn";
            this.receteGuncelleBtn.Size = new System.Drawing.Size(149, 52);
            this.receteGuncelleBtn.TabIndex = 11;
            this.receteGuncelleBtn.Text = "REÇETEYİ GÜNCELLE";
            this.receteGuncelleBtn.UseVisualStyleBackColor = true;
            this.receteGuncelleBtn.Click += new System.EventHandler(this.receteGuncelleBtn_Click);
            // 
            // receteDataGridView
            // 
            this.receteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.receteDataGridView.Location = new System.Drawing.Point(342, 55);
            this.receteDataGridView.Name = "receteDataGridView";
            this.receteDataGridView.RowHeadersWidth = 51;
            this.receteDataGridView.RowTemplate.Height = 24;
            this.receteDataGridView.Size = new System.Drawing.Size(774, 320);
            this.receteDataGridView.TabIndex = 12;
            // 
            // DoktorReceteGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1512, 777);
            this.Controls.Add(this.receteDataGridView);
            this.Controls.Add(this.receteGuncelleBtn);
            this.Controls.Add(this.textBoxDuration);
            this.Controls.Add(this.textBoxFrequency);
            this.Controls.Add(this.textBoxDosage);
            this.Controls.Add(this.comboBoxIlac);
            this.Controls.Add(this.comboBoxDoctor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHastaAdi);
            this.Name = "DoktorReceteGuncelle";
            this.Text = "DoktorReceteGuncelle";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DoktorReceteGuncelle_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.receteDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHastaAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxDoctor;
        private System.Windows.Forms.ComboBox comboBoxIlac;
        private System.Windows.Forms.TextBox textBoxDosage;
        private System.Windows.Forms.TextBox textBoxFrequency;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Button receteGuncelleBtn;
        private System.Windows.Forms.DataGridView receteDataGridView;
    }
}