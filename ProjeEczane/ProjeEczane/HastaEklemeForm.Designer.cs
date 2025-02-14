namespace ProjeEczane
{
    partial class HastaEklemeForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.hastaKaydetBtn = new System.Windows.Forms.Button();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.textBoxHastalikGecmis = new System.Windows.Forms.TextBox();
            this.dateTimePickerDogumTarih = new System.Windows.Forms.DateTimePicker();
            this.radioBtnKadin = new System.Windows.Forms.RadioButton();
            this.radioBtnErkek = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextTelNo = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.identityNumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "HASTA SOYADI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "CİNSİYET";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(413, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "DOĞUM TARİHİ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(413, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "İLETİŞİM BİLGİSİ";
            // 
            // hastaKaydetBtn
            // 
            this.hastaKaydetBtn.Location = new System.Drawing.Point(277, 315);
            this.hastaKaydetBtn.Name = "hastaKaydetBtn";
            this.hastaKaydetBtn.Size = new System.Drawing.Size(195, 45);
            this.hastaKaydetBtn.TabIndex = 5;
            this.hastaKaydetBtn.Text = "HASTAYI KAYDET";
            this.hastaKaydetBtn.UseVisualStyleBackColor = true;
            this.hastaKaydetBtn.Click += new System.EventHandler(this.hastaKaydetBtn_Click);
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(207, 79);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(100, 22);
            this.adTextBox.TabIndex = 6;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(207, 134);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(100, 22);
            this.soyadTextBox.TabIndex = 7;
            // 
            // textBoxHastalikGecmis
            // 
            this.textBoxHastalikGecmis.Location = new System.Drawing.Point(556, 246);
            this.textBoxHastalikGecmis.Name = "textBoxHastalikGecmis";
            this.textBoxHastalikGecmis.Size = new System.Drawing.Size(100, 22);
            this.textBoxHastalikGecmis.TabIndex = 8;
            // 
            // dateTimePickerDogumTarih
            // 
            this.dateTimePickerDogumTarih.Location = new System.Drawing.Point(556, 79);
            this.dateTimePickerDogumTarih.Name = "dateTimePickerDogumTarih";
            this.dateTimePickerDogumTarih.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDogumTarih.TabIndex = 9;
            // 
            // radioBtnKadin
            // 
            this.radioBtnKadin.AutoSize = true;
            this.radioBtnKadin.Location = new System.Drawing.Point(180, 252);
            this.radioBtnKadin.Name = "radioBtnKadin";
            this.radioBtnKadin.Size = new System.Drawing.Size(68, 20);
            this.radioBtnKadin.TabIndex = 10;
            this.radioBtnKadin.TabStop = true;
            this.radioBtnKadin.Text = "KADIN";
            this.radioBtnKadin.UseVisualStyleBackColor = true;
            // 
            // radioBtnErkek
            // 
            this.radioBtnErkek.AutoSize = true;
            this.radioBtnErkek.Location = new System.Drawing.Point(286, 252);
            this.radioBtnErkek.Name = "radioBtnErkek";
            this.radioBtnErkek.Size = new System.Drawing.Size(72, 20);
            this.radioBtnErkek.TabIndex = 11;
            this.radioBtnErkek.TabStop = true;
            this.radioBtnErkek.Text = "ERKEK";
            this.radioBtnErkek.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "HASTALIK GEÇMİŞİ";
            // 
            // maskedTextTelNo
            // 
            this.maskedTextTelNo.Location = new System.Drawing.Point(556, 161);
            this.maskedTextTelNo.Mask = "(999) 000-0000";
            this.maskedTextTelNo.Name = "maskedTextTelNo";
            this.maskedTextTelNo.Size = new System.Drawing.Size(100, 22);
            this.maskedTextTelNo.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 187);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "KİMLİK NUMARASI";
            // 
            // identityNumberTextBox
            // 
            this.identityNumberTextBox.Location = new System.Drawing.Point(207, 180);
            this.identityNumberTextBox.Name = "identityNumberTextBox";
            this.identityNumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.identityNumberTextBox.TabIndex = 16;
            // 
            // HastaEklemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1511, 840);
            this.Controls.Add(this.identityNumberTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.maskedTextTelNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioBtnErkek);
            this.Controls.Add(this.radioBtnKadin);
            this.Controls.Add(this.dateTimePickerDogumTarih);
            this.Controls.Add(this.textBoxHastalikGecmis);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(this.hastaKaydetBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HastaEklemeForm";
            this.Text = "HastaEklemeForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button hastaKaydetBtn;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox textBoxHastalikGecmis;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogumTarih;
        private System.Windows.Forms.RadioButton radioBtnKadin;
        private System.Windows.Forms.RadioButton radioBtnErkek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextTelNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox identityNumberTextBox;
    }
}