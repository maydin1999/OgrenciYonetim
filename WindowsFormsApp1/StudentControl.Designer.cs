namespace WindowsFormsApp1
{
    partial class StudentControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentControl));
            this.btnOgrenciOlustur = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSeansGor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOgrenciDuzenle = new System.Windows.Forms.Button();
            this.btnSeansDuzenle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciOlustur
            // 
            this.btnOgrenciOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciOlustur.Location = new System.Drawing.Point(184, 106);
            this.btnOgrenciOlustur.Name = "btnOgrenciOlustur";
            this.btnOgrenciOlustur.Size = new System.Drawing.Size(161, 42);
            this.btnOgrenciOlustur.TabIndex = 0;
            this.btnOgrenciOlustur.Text = "Öğrenci Oluştur";
            this.btnOgrenciOlustur.UseVisualStyleBackColor = true;
            this.btnOgrenciOlustur.Click += new System.EventHandler(this.btnOgrenciOlustur_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(377, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seans Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeansGor
            // 
            this.btnSeansGor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansGor.Location = new System.Drawing.Point(377, 203);
            this.btnSeansGor.Name = "btnSeansGor";
            this.btnSeansGor.Size = new System.Drawing.Size(201, 42);
            this.btnSeansGor.TabIndex = 2;
            this.btnSeansGor.Text = "Seansları Görüntüle";
            this.btnSeansGor.UseVisualStyleBackColor = true;
            this.btnSeansGor.Click += new System.EventHandler(this.btnSeansGor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(431, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Öğrenci Yönetim Sistemi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOgrenciDuzenle
            // 
            this.btnOgrenciDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciDuzenle.Location = new System.Drawing.Point(184, 154);
            this.btnOgrenciDuzenle.Name = "btnOgrenciDuzenle";
            this.btnOgrenciDuzenle.Size = new System.Drawing.Size(161, 42);
            this.btnOgrenciDuzenle.TabIndex = 4;
            this.btnOgrenciDuzenle.Text = "Öğrenci Düzenle";
            this.btnOgrenciDuzenle.UseVisualStyleBackColor = true;
            this.btnOgrenciDuzenle.Click += new System.EventHandler(this.btnOgrenciDuzenle_Click);
            // 
            // btnSeansDuzenle
            // 
            this.btnSeansDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansDuzenle.Location = new System.Drawing.Point(377, 155);
            this.btnSeansDuzenle.Name = "btnSeansDuzenle";
            this.btnSeansDuzenle.Size = new System.Drawing.Size(201, 42);
            this.btnSeansDuzenle.TabIndex = 5;
            this.btnSeansDuzenle.Text = "Seans Düzenle";
            this.btnSeansDuzenle.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(184, 203);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 42);
            this.button2.TabIndex = 6;
            this.button2.Text = "Öğrenci Sil";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 378);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSeansDuzenle);
            this.Controls.Add(this.btnOgrenciDuzenle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeansGor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOgrenciOlustur);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentControl";
            this.Text = "Öğrenci İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciOlustur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSeansGor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOgrenciDuzenle;
        private System.Windows.Forms.Button btnSeansDuzenle;
        private System.Windows.Forms.Button button2;
    }
}