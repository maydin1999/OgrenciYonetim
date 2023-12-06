namespace WindowsFormsApp1
{
    partial class OgrenciDuzenleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OgrenciDuzenleme));
            this.cmbOgrenciAd = new System.Windows.Forms.ComboBox();
            this.txtOgrenciID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOgrenciSinif = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtOgrenciVeli = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbOgrenciAd
            // 
            this.cmbOgrenciAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbOgrenciAd.FormattingEnabled = true;
            this.cmbOgrenciAd.Location = new System.Drawing.Point(176, 31);
            this.cmbOgrenciAd.Name = "cmbOgrenciAd";
            this.cmbOgrenciAd.Size = new System.Drawing.Size(255, 33);
            this.cmbOgrenciAd.TabIndex = 1;
            this.cmbOgrenciAd.SelectedIndexChanged += new System.EventHandler(this.cmbOgrenciAd_SelectedIndexChanged);
            // 
            // txtOgrenciID
            // 
            this.txtOgrenciID.Enabled = false;
            this.txtOgrenciID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOgrenciID.Location = new System.Drawing.Point(176, -9);
            this.txtOgrenciID.Name = "txtOgrenciID";
            this.txtOgrenciID.Size = new System.Drawing.Size(255, 31);
            this.txtOgrenciID.TabIndex = 26;
            this.txtOgrenciID.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(49, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Öğrenci ID :";
            this.label1.Visible = false;
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
            this.cmbOgrenciSinif.Location = new System.Drawing.Point(176, 70);
            this.cmbOgrenciSinif.Name = "cmbOgrenciSinif";
            this.cmbOgrenciSinif.Size = new System.Drawing.Size(255, 33);
            this.cmbOgrenciSinif.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(242, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOgrenciVeli
            // 
            this.txtOgrenciVeli.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtOgrenciVeli.Location = new System.Drawing.Point(176, 114);
            this.txtOgrenciVeli.Name = "txtOgrenciVeli";
            this.txtOgrenciVeli.Size = new System.Drawing.Size(255, 31);
            this.txtOgrenciVeli.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(14, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "Öğrenci Veli Adı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(35, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Öğrenci Sınıfı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(49, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Öğrenci Adı :";
            // 
            // OgrenciDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 219);
            this.Controls.Add(this.cmbOgrenciAd);
            this.Controls.Add(this.txtOgrenciID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOgrenciSinif);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOgrenciVeli);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OgrenciDuzenleme";
            this.Text = "Öğrenci Düzenle";
            this.Load += new System.EventHandler(this.OgrenciDuzenleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOgrenciAd;
        private System.Windows.Forms.TextBox txtOgrenciID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOgrenciSinif;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtOgrenciVeli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}