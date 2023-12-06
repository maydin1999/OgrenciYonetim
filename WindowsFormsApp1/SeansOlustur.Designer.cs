namespace WindowsFormsApp1
{
    partial class SeansOlustur
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbOgrenciAdi = new System.Windows.Forms.ComboBox();
            this.ogrenciYonetimDataSet = new WindowsFormsApp1.OgrenciYonetimDataSet();
            this.ogrenciYonetimDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbOgrenciSinif = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSeansNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rchSeansNot = new System.Windows.Forms.RichTextBox();
            this.dtSeansTarihi = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rchDersProgrami = new System.Windows.Forms.RichTextBox();
            this.rchDigerSeans = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbOgrenciID = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciYonetimDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciYonetimDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(158, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Öğrenci Adı :";
            // 
            // cmbOgrenciAdi
            // 
            this.cmbOgrenciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbOgrenciAdi.FormattingEnabled = true;
            this.cmbOgrenciAdi.Location = new System.Drawing.Point(299, 47);
            this.cmbOgrenciAdi.Name = "cmbOgrenciAdi";
            this.cmbOgrenciAdi.Size = new System.Drawing.Size(190, 28);
            this.cmbOgrenciAdi.TabIndex = 1;
            this.cmbOgrenciAdi.SelectedIndexChanged += new System.EventHandler(this.cmbOgrenciAdi_SelectedIndexChanged);
            // 
            // ogrenciYonetimDataSet
            // 
            this.ogrenciYonetimDataSet.DataSetName = "OgrenciYonetimDataSet";
            this.ogrenciYonetimDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrenciYonetimDataSetBindingSource
            // 
            this.ogrenciYonetimDataSetBindingSource.DataSource = this.ogrenciYonetimDataSet;
            this.ogrenciYonetimDataSetBindingSource.Position = 0;
            // 
            // cmbOgrenciSinif
            // 
            this.cmbOgrenciSinif.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbOgrenciSinif.FormattingEnabled = true;
            this.cmbOgrenciSinif.Location = new System.Drawing.Point(299, 94);
            this.cmbOgrenciSinif.Name = "cmbOgrenciSinif";
            this.cmbOgrenciSinif.Size = new System.Drawing.Size(190, 28);
            this.cmbOgrenciSinif.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(144, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Öğrenci Sınıfı :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(120, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Seans Numarası :";
            // 
            // txtSeansNo
            // 
            this.txtSeansNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtSeansNo.Location = new System.Drawing.Point(299, 139);
            this.txtSeansNo.Name = "txtSeansNo";
            this.txtSeansNo.Size = new System.Drawing.Size(190, 26);
            this.txtSeansNo.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(143, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Seans Notları :";
            // 
            // rchSeansNot
            // 
            this.rchSeansNot.Location = new System.Drawing.Point(299, 180);
            this.rchSeansNot.Name = "rchSeansNot";
            this.rchSeansNot.Size = new System.Drawing.Size(301, 165);
            this.rchSeansNot.TabIndex = 7;
            this.rchSeansNot.Text = "";
            // 
            // dtSeansTarihi
            // 
            this.dtSeansTarihi.Location = new System.Drawing.Point(299, 744);
            this.dtSeansTarihi.Name = "dtSeansTarihi";
            this.dtSeansTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtSeansTarihi.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(151, 744);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Seans Tarihi :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(76, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Seans Ders Programı : ";
            // 
            // rchDersProgrami
            // 
            this.rchDersProgrami.Location = new System.Drawing.Point(299, 360);
            this.rchDersProgrami.Name = "rchDersProgrami";
            this.rchDersProgrami.Size = new System.Drawing.Size(301, 165);
            this.rchDersProgrami.TabIndex = 11;
            this.rchDersProgrami.Text = "";
            // 
            // rchDigerSeans
            // 
            this.rchDigerSeans.Location = new System.Drawing.Point(299, 558);
            this.rchDigerSeans.Name = "rchDigerSeans";
            this.rchDigerSeans.Size = new System.Drawing.Size(301, 165);
            this.rchDigerSeans.TabIndex = 13;
            this.rchDigerSeans.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(31, 628);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(239, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Sonraki Seans Yapılacaklar :";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button1.Location = new System.Drawing.Point(642, 756);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 71);
            this.button1.TabIndex = 14;
            this.button1.Text = "Oluştur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbOgrenciID
            // 
            this.cmbOgrenciID.AllowDrop = true;
            this.cmbOgrenciID.Enabled = false;
            this.cmbOgrenciID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.cmbOgrenciID.FormattingEnabled = true;
            this.cmbOgrenciID.ImeMode = System.Windows.Forms.ImeMode.On;
            this.cmbOgrenciID.Location = new System.Drawing.Point(299, 13);
            this.cmbOgrenciID.Name = "cmbOgrenciID";
            this.cmbOgrenciID.Size = new System.Drawing.Size(190, 28);
            this.cmbOgrenciID.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(158, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Öğrenci ID :";
            // 
            // SeansOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 839);
            this.Controls.Add(this.cmbOgrenciID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rchDigerSeans);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.rchDersProgrami);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtSeansTarihi);
            this.Controls.Add(this.rchSeansNot);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSeansNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbOgrenciSinif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbOgrenciAdi);
            this.Controls.Add(this.label1);
            this.Name = "SeansOlustur";
            this.Text = "SeansOlustur";
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciYonetimDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrenciYonetimDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbOgrenciAdi;
        private OgrenciYonetimDataSet ogrenciYonetimDataSet;
        private System.Windows.Forms.BindingSource ogrenciYonetimDataSetBindingSource;
        private System.Windows.Forms.ComboBox cmbOgrenciSinif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSeansNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rchSeansNot;
        private System.Windows.Forms.DateTimePicker dtSeansTarihi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rchDersProgrami;
        private System.Windows.Forms.RichTextBox rchDigerSeans;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbOgrenciID;
        private System.Windows.Forms.Label label8;
    }
}