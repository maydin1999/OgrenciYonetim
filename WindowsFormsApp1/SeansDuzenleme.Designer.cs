namespace WindowsFormsApp1
{
    partial class SeansDuzenleme
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
            this.components = new System.ComponentModel.Container();
            this.cmbOgrenciID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.rchDigerSeans = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rchDersProgrami = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtSeansTarihi = new System.Windows.Forms.DateTimePicker();
            this.rchSeansNot = new System.Windows.Forms.RichTextBox();
            this.txtSeansNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ogrenciYonetimDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ogrenciYonetimDataSet = new WindowsFormsApp1.OgrenciYonetimDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOgrenciAdi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciYonetimDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciYonetimDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOgrenciID
            // 
            this.cmbOgrenciID.AllowDrop = true;
            this.cmbOgrenciID.Enabled = false;
            this.cmbOgrenciID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbOgrenciID.FormattingEnabled = true;
            this.cmbOgrenciID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbOgrenciID.Location = new System.Drawing.Point(272, 23);
            this.cmbOgrenciID.Name = "cmbOgrenciID";
            this.cmbOgrenciID.Size = new System.Drawing.Size(190, 28);
            this.cmbOgrenciID.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(131, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Öğrenci ID :";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnDuzenle.Location = new System.Drawing.Point(568, 831);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(164, 71);
            this.btnDuzenle.TabIndex = 31;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // rchDigerSeans
            // 
            this.rchDigerSeans.Location = new System.Drawing.Point(272, 645);
            this.rchDigerSeans.Name = "rchDigerSeans";
            this.rchDigerSeans.Size = new System.Drawing.Size(301, 165);
            this.rchDigerSeans.TabIndex = 30;
            this.rchDigerSeans.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(4, 715);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Sonraki Seans Yapılacaklar :";
            // 
            // rchDersProgrami
            // 
            this.rchDersProgrami.Location = new System.Drawing.Point(272, 325);
            this.rchDersProgrami.Name = "rchDersProgrami";
            this.rchDersProgrami.Size = new System.Drawing.Size(301, 165);
            this.rchDersProgrami.TabIndex = 28;
            this.rchDersProgrami.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(49, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Seans Ders Programı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(124, 831);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 26;
            this.label5.Text = "Seans Tarihi :";
            // 
            // dtSeansTarihi
            // 
            this.dtSeansTarihi.Location = new System.Drawing.Point(272, 831);
            this.dtSeansTarihi.Name = "dtSeansTarihi";
            this.dtSeansTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtSeansTarihi.TabIndex = 25;
            // 
            // rchSeansNot
            // 
            this.rchSeansNot.Location = new System.Drawing.Point(272, 145);
            this.rchSeansNot.Name = "rchSeansNot";
            this.rchSeansNot.Size = new System.Drawing.Size(301, 165);
            this.rchSeansNot.TabIndex = 24;
            this.rchSeansNot.Text = "";
            // 
            // txtSeansNo
            // 
            this.txtSeansNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtSeansNo.Location = new System.Drawing.Point(272, 103);
            this.txtSeansNo.Name = "txtSeansNo";
            this.txtSeansNo.Size = new System.Drawing.Size(190, 26);
            this.txtSeansNo.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(93, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Seans Numarası :";
            // 
            // ogrenciYonetimDataSetBindingSource
            // 
            this.ogrenciYonetimDataSetBindingSource.DataSource = this.ogrenciYonetimDataSet;
            this.ogrenciYonetimDataSetBindingSource.Position = 0;
            // 
            // ogrenciYonetimDataSet
            // 
            this.ogrenciYonetimDataSet.DataSetName = "OgrenciYonetimDataSet";
            this.ogrenciYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(116, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Seans Notları :";
            // 
            // cmbOgrenciAdi
            // 
            this.cmbOgrenciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbOgrenciAdi.FormattingEnabled = true;
            this.cmbOgrenciAdi.Location = new System.Drawing.Point(272, 57);
            this.cmbOgrenciAdi.Name = "cmbOgrenciAdi";
            this.cmbOgrenciAdi.Size = new System.Drawing.Size(190, 28);
            this.cmbOgrenciAdi.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(131, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Öğrenci Adı :";
            // 
            // SeansDuzenleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 926);
            this.Controls.Add(this.cmbOgrenciID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.rchDigerSeans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rchDersProgrami);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtSeansTarihi);
            this.Controls.Add(this.rchSeansNot);
            this.Controls.Add(this.txtSeansNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbOgrenciAdi);
            this.Controls.Add(this.label1);
            this.Name = "SeansDuzenleme";
            this.Text = "SeansDuzenleme";
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciYonetimDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciYonetimDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOgrenciID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.RichTextBox rchDigerSeans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rchDersProgrami;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtSeansTarihi;
        private System.Windows.Forms.RichTextBox rchSeansNot;
        private System.Windows.Forms.TextBox txtSeansNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource ogrenciYonetimDataSetBindingSource;
        private OgrenciYonetimDataSet ogrenciYonetimDataSet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbOgrenciAdi;
        private System.Windows.Forms.Label label1;
    }
}