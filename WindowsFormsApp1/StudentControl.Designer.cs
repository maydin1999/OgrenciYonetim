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
            this.btnOgrenciOlustur = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSeansGor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOgrenciOlustur
            // 
            this.btnOgrenciOlustur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciOlustur.Location = new System.Drawing.Point(12, 23);
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
            this.button1.Location = new System.Drawing.Point(194, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seans Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSeansGor
            // 
            this.btnSeansGor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSeansGor.Location = new System.Drawing.Point(361, 23);
            this.btnSeansGor.Name = "btnSeansGor";
            this.btnSeansGor.Size = new System.Drawing.Size(201, 42);
            this.btnSeansGor.TabIndex = 2;
            this.btnSeansGor.Text = "Seansları Görüntüle";
            this.btnSeansGor.UseVisualStyleBackColor = true;
            this.btnSeansGor.Click += new System.EventHandler(this.btnSeansGor_Click);
            // 
            // StudentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 378);
            this.Controls.Add(this.btnSeansGor);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOgrenciOlustur);
            this.Name = "StudentControl";
            this.Text = "StudentControl";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOgrenciOlustur;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSeansGor;
    }
}