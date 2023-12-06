namespace WindowsFormsApp1
{
    partial class SeansGoruntule
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
            this.cmbOgrenciAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSeansTarih = new System.Windows.Forms.Label();
            this.cmbSeansTarih = new System.Windows.Forms.ComboBox();
            this.rchSeansNotlari = new System.Windows.Forms.RichTextBox();
            this.rchDersProgrami = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rchSonrakiDers = new System.Windows.Forms.RichTextBox();
            this.cmbOgrenciSinif = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOgrenciAdi
            // 
            this.cmbOgrenciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbOgrenciAdi.FormattingEnabled = true;
            this.cmbOgrenciAdi.Location = new System.Drawing.Point(163, 26);
            this.cmbOgrenciAdi.Name = "cmbOgrenciAdi";
            this.cmbOgrenciAdi.Size = new System.Drawing.Size(190, 28);
            this.cmbOgrenciAdi.TabIndex = 3;
            this.cmbOgrenciAdi.SelectedIndexChanged += new System.EventHandler(this.cmbOgrenciAdi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(32, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Adı :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ARA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSeansTarih
            // 
            this.lblSeansTarih.AutoSize = true;
            this.lblSeansTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSeansTarih.Location = new System.Drawing.Point(15, 99);
            this.lblSeansTarih.Name = "lblSeansTarih";
            this.lblSeansTarih.Size = new System.Drawing.Size(119, 20);
            this.lblSeansTarih.TabIndex = 5;
            this.lblSeansTarih.Text = "Seans Tarihi :";
            // 
            // cmbSeansTarih
            // 
            this.cmbSeansTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbSeansTarih.FormattingEnabled = true;
            this.cmbSeansTarih.Location = new System.Drawing.Point(163, 96);
            this.cmbSeansTarih.Name = "cmbSeansTarih";
            this.cmbSeansTarih.Size = new System.Drawing.Size(190, 28);
            this.cmbSeansTarih.TabIndex = 6;
            // 
            // rchSeansNotlari
            // 
            this.rchSeansNotlari.Location = new System.Drawing.Point(466, 32);
            this.rchSeansNotlari.Name = "rchSeansNotlari";
            this.rchSeansNotlari.Size = new System.Drawing.Size(385, 231);
            this.rchSeansNotlari.TabIndex = 7;
            this.rchSeansNotlari.Text = "";
            // 
            // rchDersProgrami
            // 
            this.rchDersProgrami.Location = new System.Drawing.Point(876, 31);
            this.rchDersProgrami.Name = "rchDersProgrami";
            this.rchDersProgrami.Size = new System.Drawing.Size(385, 231);
            this.rchDersProgrami.TabIndex = 8;
            this.rchDersProgrami.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Seans Notları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(873, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Ders Programı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1264, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Sonraki Seans Yapılacaklar";
            // 
            // rchSonrakiDers
            // 
            this.rchSonrakiDers.Location = new System.Drawing.Point(1267, 31);
            this.rchSonrakiDers.Name = "rchSonrakiDers";
            this.rchSonrakiDers.Size = new System.Drawing.Size(385, 231);
            this.rchSonrakiDers.TabIndex = 11;
            this.rchSonrakiDers.Text = "";
            // 
            // cmbOgrenciSinif
            // 
            this.cmbOgrenciSinif.Enabled = false;
            this.cmbOgrenciSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbOgrenciSinif.FormattingEnabled = true;
            this.cmbOgrenciSinif.Location = new System.Drawing.Point(163, 64);
            this.cmbOgrenciSinif.Name = "cmbOgrenciSinif";
            this.cmbOgrenciSinif.Size = new System.Drawing.Size(190, 28);
            this.cmbOgrenciSinif.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(32, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Öğrenci Sınıfı :";
            // 
            // SeansGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 320);
            this.Controls.Add(this.cmbOgrenciSinif);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rchSonrakiDers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rchDersProgrami);
            this.Controls.Add(this.rchSeansNotlari);
            this.Controls.Add(this.cmbSeansTarih);
            this.Controls.Add(this.lblSeansTarih);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbOgrenciAdi);
            this.Controls.Add(this.label1);
            this.Name = "SeansGoruntule";
            this.Text = "SeansGoruntule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOgrenciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblSeansTarih;
        private System.Windows.Forms.ComboBox cmbSeansTarih;
        private System.Windows.Forms.RichTextBox rchSeansNotlari;
        private System.Windows.Forms.RichTextBox rchDersProgrami;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rchSonrakiDers;
        private System.Windows.Forms.ComboBox cmbOgrenciSinif;
        private System.Windows.Forms.Label label5;
    }
}