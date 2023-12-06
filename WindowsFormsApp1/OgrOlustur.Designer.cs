namespace WindowsFormsApp1
{
    partial class OgrOlustur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrOlustur));
            this.cmbOgrenciSinif = new System.Windows.Forms.ComboBox();
            this.btnOgrenciOlustur = new System.Windows.Forms.Button();
            this.txtOgrenciVeli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOgrenciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbOgrenciSinif
            // 
            this.cmbOgrenciSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbOgrenciSinif.FormattingEnabled = true;
            this.cmbOgrenciSinif.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbOgrenciSinif.Location = new System.Drawing.Point(192, 87);
            this.cmbOgrenciSinif.Name = "cmbOgrenciSinif";
            this.cmbOgrenciSinif.Size = new System.Drawing.Size(174, 33);
            this.cmbOgrenciSinif.TabIndex = 2;
            // 
            // btnOgrenciOlustur
            // 
            this.btnOgrenciOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnOgrenciOlustur.Location = new System.Drawing.Point(211, 168);
            this.btnOgrenciOlustur.Name = "btnOgrenciOlustur";
            this.btnOgrenciOlustur.Size = new System.Drawing.Size(122, 31);
            this.btnOgrenciOlustur.TabIndex = 4;
            this.btnOgrenciOlustur.Text = "Oluştur";
            this.btnOgrenciOlustur.UseVisualStyleBackColor = true;
            this.btnOgrenciOlustur.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOgrenciVeli
            // 
            this.txtOgrenciVeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtOgrenciVeli.Location = new System.Drawing.Point(192, 131);
            this.txtOgrenciVeli.Name = "txtOgrenciVeli";
            this.txtOgrenciVeli.Size = new System.Drawing.Size(174, 31);
            this.txtOgrenciVeli.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(30, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Öğrenci Veli Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(51, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Öğrenci Sınıfı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(65, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Öğrenci Adı :";
            // 
            // txtOgrenciAdi
            // 
            this.txtOgrenciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtOgrenciAdi.Location = new System.Drawing.Point(192, 48);
            this.txtOgrenciAdi.Name = "txtOgrenciAdi";
            this.txtOgrenciAdi.Size = new System.Drawing.Size(174, 31);
            this.txtOgrenciAdi.TabIndex = 1;
            // 
            // OgrOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 226);
            this.Controls.Add(this.txtOgrenciAdi);
            this.Controls.Add(this.cmbOgrenciSinif);
            this.Controls.Add(this.btnOgrenciOlustur);
            this.Controls.Add(this.txtOgrenciVeli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrOlustur";
            this.Text = "Öğrenci Oluştur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbOgrenciSinif;
        private System.Windows.Forms.Button btnOgrenciOlustur;
        private System.Windows.Forms.TextBox txtOgrenciVeli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOgrenciAdi;
    }
}