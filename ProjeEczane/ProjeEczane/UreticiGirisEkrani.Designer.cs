namespace ProjeEczane
{
    partial class UreticiGirisEkrani
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
            this.epsttextBox = new System.Windows.Forms.TextBox();
            this.urtcsfrtextBox = new System.Windows.Forms.TextBox();
            this.urtgrsbtn = new System.Windows.Forms.Button();
            this.urtcrctgrntgrd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.urtcrctgrntgrd)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÜRETİCİ ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "E POSTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "ŞİFRE";
            // 
            // epsttextBox
            // 
            this.epsttextBox.Location = new System.Drawing.Point(170, 84);
            this.epsttextBox.Name = "epsttextBox";
            this.epsttextBox.Size = new System.Drawing.Size(100, 22);
            this.epsttextBox.TabIndex = 3;
            // 
            // urtcsfrtextBox
            // 
            this.urtcsfrtextBox.Location = new System.Drawing.Point(170, 140);
            this.urtcsfrtextBox.Name = "urtcsfrtextBox";
            this.urtcsfrtextBox.Size = new System.Drawing.Size(100, 22);
            this.urtcsfrtextBox.TabIndex = 4;
            // 
            // urtgrsbtn
            // 
            this.urtgrsbtn.Location = new System.Drawing.Point(76, 201);
            this.urtgrsbtn.Name = "urtgrsbtn";
            this.urtgrsbtn.Size = new System.Drawing.Size(145, 60);
            this.urtgrsbtn.TabIndex = 5;
            this.urtgrsbtn.Text = "GİRİŞ YAP";
            this.urtgrsbtn.UseVisualStyleBackColor = true;
            this.urtgrsbtn.Click += new System.EventHandler(this.urtgrsbtn_Click);
            // 
            // urtcrctgrntgrd
            // 
            this.urtcrctgrntgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urtcrctgrntgrd.Location = new System.Drawing.Point(303, 21);
            this.urtcrctgrntgrd.Name = "urtcrctgrntgrd";
            this.urtcrctgrntgrd.RowHeadersWidth = 51;
            this.urtcrctgrntgrd.RowTemplate.Height = 24;
            this.urtcrctgrntgrd.Size = new System.Drawing.Size(1251, 350);
            this.urtcrctgrntgrd.TabIndex = 6;
            // 
            // UreticiGirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(1541, 794);
            this.Controls.Add(this.urtcrctgrntgrd);
            this.Controls.Add(this.urtgrsbtn);
            this.Controls.Add(this.urtcsfrtextBox);
            this.Controls.Add(this.epsttextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UreticiGirisEkrani";
            this.Text = "UreticiGirisEkrani";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.urtcrctgrntgrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox epsttextBox;
        private System.Windows.Forms.TextBox urtcsfrtextBox;
        private System.Windows.Forms.Button urtgrsbtn;
        private System.Windows.Forms.DataGridView urtcrctgrntgrd;
    }
}