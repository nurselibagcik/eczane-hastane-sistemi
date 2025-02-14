namespace ProjeEczane
{
    partial class HastaGirisEkrani
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
            this.hastaAdtextBox = new System.Windows.Forms.TextBox();
            this.hastaNotextBox = new System.Windows.Forms.TextBox();
            this.hastaSoyadtextBox = new System.Windows.Forms.TextBox();
            this.kimlik = new System.Windows.Forms.Label();
            this.receteGoruntuBtn = new System.Windows.Forms.Button();
            this.hastaReceteGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hastaReceteGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "telefon";
            // 
            // hastaAdtextBox
            // 
            this.hastaAdtextBox.Location = new System.Drawing.Point(188, 63);
            this.hastaAdtextBox.Name = "hastaAdtextBox";
            this.hastaAdtextBox.Size = new System.Drawing.Size(100, 22);
            this.hastaAdtextBox.TabIndex = 3;
            // 
            // hastaNotextBox
            // 
            this.hastaNotextBox.Location = new System.Drawing.Point(188, 179);
            this.hastaNotextBox.Name = "hastaNotextBox";
            this.hastaNotextBox.Size = new System.Drawing.Size(100, 22);
            this.hastaNotextBox.TabIndex = 4;
            // 
            // hastaSoyadtextBox
            // 
            this.hastaSoyadtextBox.Location = new System.Drawing.Point(188, 118);
            this.hastaSoyadtextBox.Name = "hastaSoyadtextBox";
            this.hastaSoyadtextBox.Size = new System.Drawing.Size(100, 22);
            this.hastaSoyadtextBox.TabIndex = 5;
            // 
            // kimlik
            // 
            this.kimlik.AutoSize = true;
            this.kimlik.Location = new System.Drawing.Point(78, 243);
            this.kimlik.Name = "kimlik";
            this.kimlik.Size = new System.Drawing.Size(39, 16);
            this.kimlik.TabIndex = 6;
            this.kimlik.Text = "Kimik";
            // 
            // receteGoruntuBtn
            // 
            this.receteGoruntuBtn.Location = new System.Drawing.Point(114, 300);
            this.receteGoruntuBtn.Name = "receteGoruntuBtn";
            this.receteGoruntuBtn.Size = new System.Drawing.Size(174, 68);
            this.receteGoruntuBtn.TabIndex = 7;
            this.receteGoruntuBtn.Text = "Reçete Görüntüle";
            this.receteGoruntuBtn.UseVisualStyleBackColor = true;
            this.receteGoruntuBtn.Click += new System.EventHandler(this.receteGoruntuBtn_Click);
            // 
            // hastaReceteGrid
            // 
            this.hastaReceteGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hastaReceteGrid.Location = new System.Drawing.Point(363, 33);
            this.hastaReceteGrid.Name = "hastaReceteGrid";
            this.hastaReceteGrid.RowHeadersWidth = 51;
            this.hastaReceteGrid.RowTemplate.Height = 24;
            this.hastaReceteGrid.Size = new System.Drawing.Size(1189, 364);
            this.hastaReceteGrid.TabIndex = 8;
            // 
            // HastaGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1538, 893);
            this.Controls.Add(this.hastaReceteGrid);
            this.Controls.Add(this.receteGoruntuBtn);
            this.Controls.Add(this.kimlik);
            this.Controls.Add(this.hastaSoyadtextBox);
            this.Controls.Add(this.hastaNotextBox);
            this.Controls.Add(this.hastaAdtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HastaGirisEkrani";
            this.Text = "HastaGirisEkrani";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.hastaReceteGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hastaAdtextBox;
        private System.Windows.Forms.TextBox hastaNotextBox;
        private System.Windows.Forms.TextBox hastaSoyadtextBox;
        private System.Windows.Forms.Label kimlik;
        private System.Windows.Forms.Button receteGoruntuBtn;
        private System.Windows.Forms.DataGridView hastaReceteGrid;
    }
}