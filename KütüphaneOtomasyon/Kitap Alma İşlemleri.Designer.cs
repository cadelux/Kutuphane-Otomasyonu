namespace KütüphaneOtomasyon
{
    partial class Kitap_Alma_İşlemleri
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
            this.odataGridView = new System.Windows.Forms.DataGridView();
            this.kdataGridView = new System.Windows.Forms.DataGridView();
            this.ogrAdtxt = new System.Windows.Forms.TextBox();
            this.ogrSoyadtxt = new System.Windows.Forms.TextBox();
            this.ogrTeltxt = new System.Windows.Forms.TextBox();
            this.ogrTctxt = new System.Windows.Forms.TextBox();
            this.kitapAdtxt = new System.Windows.Forms.TextBox();
            this.kitapYazartxt = new System.Windows.Forms.TextBox();
            this.kitapSerinotxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tarihpicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.odataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(152, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kayıtlı Öğrenciler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(664, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kayıtlı Kitaplar";
            // 
            // odataGridView
            // 
            this.odataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.odataGridView.Location = new System.Drawing.Point(12, 115);
            this.odataGridView.Name = "odataGridView";
            this.odataGridView.RowHeadersWidth = 51;
            this.odataGridView.RowTemplate.Height = 24;
            this.odataGridView.Size = new System.Drawing.Size(533, 388);
            this.odataGridView.TabIndex = 2;
            this.odataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.odataGridView_CellClick);
            // 
            // kdataGridView
            // 
            this.kdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdataGridView.Location = new System.Drawing.Point(569, 115);
            this.kdataGridView.Name = "kdataGridView";
            this.kdataGridView.RowHeadersWidth = 51;
            this.kdataGridView.RowTemplate.Height = 24;
            this.kdataGridView.Size = new System.Drawing.Size(463, 388);
            this.kdataGridView.TabIndex = 3;
            this.kdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kdataGridView_CellClick);
            // 
            // ogrAdtxt
            // 
            this.ogrAdtxt.Location = new System.Drawing.Point(1203, 112);
            this.ogrAdtxt.Name = "ogrAdtxt";
            this.ogrAdtxt.Size = new System.Drawing.Size(100, 22);
            this.ogrAdtxt.TabIndex = 4;
            // 
            // ogrSoyadtxt
            // 
            this.ogrSoyadtxt.Location = new System.Drawing.Point(1203, 159);
            this.ogrSoyadtxt.Name = "ogrSoyadtxt";
            this.ogrSoyadtxt.Size = new System.Drawing.Size(100, 22);
            this.ogrSoyadtxt.TabIndex = 5;
            // 
            // ogrTeltxt
            // 
            this.ogrTeltxt.Location = new System.Drawing.Point(1203, 206);
            this.ogrTeltxt.Name = "ogrTeltxt";
            this.ogrTeltxt.Size = new System.Drawing.Size(100, 22);
            this.ogrTeltxt.TabIndex = 6;
            // 
            // ogrTctxt
            // 
            this.ogrTctxt.Location = new System.Drawing.Point(1203, 253);
            this.ogrTctxt.Name = "ogrTctxt";
            this.ogrTctxt.Size = new System.Drawing.Size(100, 22);
            this.ogrTctxt.TabIndex = 7;
            // 
            // kitapAdtxt
            // 
            this.kitapAdtxt.Location = new System.Drawing.Point(1203, 295);
            this.kitapAdtxt.Name = "kitapAdtxt";
            this.kitapAdtxt.Size = new System.Drawing.Size(100, 22);
            this.kitapAdtxt.TabIndex = 8;
            // 
            // kitapYazartxt
            // 
            this.kitapYazartxt.Location = new System.Drawing.Point(1203, 333);
            this.kitapYazartxt.Name = "kitapYazartxt";
            this.kitapYazartxt.Size = new System.Drawing.Size(100, 22);
            this.kitapYazartxt.TabIndex = 9;
            // 
            // kitapSerinotxt
            // 
            this.kitapSerinotxt.Location = new System.Drawing.Point(1203, 381);
            this.kitapSerinotxt.Name = "kitapSerinotxt";
            this.kitapSerinotxt.Size = new System.Drawing.Size(100, 22);
            this.kitapSerinotxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1074, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ögrenci Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1074, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Öğrenci Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1074, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Öğrenci Telefon:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1074, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Öğrenci TC:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1074, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kitap Adı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1074, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Kitap Yazarı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1074, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Kitap Seri No:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1074, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Alış Tarihi:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(1147, 472);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 46);
            this.button1.TabIndex = 20;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tarihpicker
            // 
            this.tarihpicker.Location = new System.Drawing.Point(1166, 421);
            this.tarihpicker.Name = "tarihpicker";
            this.tarihpicker.Size = new System.Drawing.Size(168, 22);
            this.tarihpicker.TabIndex = 23;
            // 
            // Kitap_Alma_İşlemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 735);
            this.Controls.Add(this.tarihpicker);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kitapSerinotxt);
            this.Controls.Add(this.kitapYazartxt);
            this.Controls.Add(this.kitapAdtxt);
            this.Controls.Add(this.ogrTctxt);
            this.Controls.Add(this.ogrTeltxt);
            this.Controls.Add(this.ogrSoyadtxt);
            this.Controls.Add(this.ogrAdtxt);
            this.Controls.Add(this.kdataGridView);
            this.Controls.Add(this.odataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kitap_Alma_İşlemleri";
            this.Text = "Kitap Alma İşlemleri";
            this.Load += new System.EventHandler(this.Kitap_Alma_İşlemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.odataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView odataGridView;
        private System.Windows.Forms.DataGridView kdataGridView;
        private System.Windows.Forms.TextBox ogrAdtxt;
        private System.Windows.Forms.TextBox ogrSoyadtxt;
        private System.Windows.Forms.TextBox ogrTeltxt;
        private System.Windows.Forms.TextBox ogrTctxt;
        private System.Windows.Forms.TextBox kitapAdtxt;
        private System.Windows.Forms.TextBox kitapYazartxt;
        private System.Windows.Forms.TextBox kitapSerinotxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker tarihpicker;
    }
}