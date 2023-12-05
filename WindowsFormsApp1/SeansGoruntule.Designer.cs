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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Öğrenci Adı :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 29);
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
            this.lblSeansTarih.Location = new System.Drawing.Point(22, 82);
            this.lblSeansTarih.Name = "lblSeansTarih";
            this.lblSeansTarih.Size = new System.Drawing.Size(119, 20);
            this.lblSeansTarih.TabIndex = 5;
            this.lblSeansTarih.Text = "Seans Tarihi :";
            this.lblSeansTarih.Visible = false;
            // 
            // cmbSeansTarih
            // 
            this.cmbSeansTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbSeansTarih.FormattingEnabled = true;
            this.cmbSeansTarih.Location = new System.Drawing.Point(163, 79);
            this.cmbSeansTarih.Name = "cmbSeansTarih";
            this.cmbSeansTarih.Size = new System.Drawing.Size(190, 28);
            this.cmbSeansTarih.TabIndex = 6;
            this.cmbSeansTarih.Visible = false;
            // 
            // SeansGoruntule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 508);
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
    }
}