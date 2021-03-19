namespace KütüphaneOtomasyon
{
    partial class Ogrenci
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
            this.ogrAdtxt = new System.Windows.Forms.TextBox();
            this.ogrSoyadtxt = new System.Windows.Forms.TextBox();
            this.ogrTeltxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ogrTctxt = new System.Windows.Forms.TextBox();
            this.oDatagrdv = new System.Windows.Forms.DataGridView();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.güncelleBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.oDatagrdv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "AD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "SOYAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "TELEFON";
            // 
            // ogrAdtxt
            // 
            this.ogrAdtxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrAdtxt.Location = new System.Drawing.Point(201, 128);
            this.ogrAdtxt.Name = "ogrAdtxt";
            this.ogrAdtxt.Size = new System.Drawing.Size(100, 33);
            this.ogrAdtxt.TabIndex = 3;
            // 
            // ogrSoyadtxt
            // 
            this.ogrSoyadtxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrSoyadtxt.Location = new System.Drawing.Point(201, 181);
            this.ogrSoyadtxt.Name = "ogrSoyadtxt";
            this.ogrSoyadtxt.Size = new System.Drawing.Size(100, 33);
            this.ogrSoyadtxt.TabIndex = 4;
            // 
            // ogrTeltxt
            // 
            this.ogrTeltxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrTeltxt.Location = new System.Drawing.Point(201, 243);
            this.ogrTeltxt.Name = "ogrTeltxt";
            this.ogrTeltxt.Size = new System.Drawing.Size(100, 33);
            this.ogrTeltxt.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "TC";
            // 
            // ogrTctxt
            // 
            this.ogrTctxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ogrTctxt.Location = new System.Drawing.Point(201, 299);
            this.ogrTctxt.Name = "ogrTctxt";
            this.ogrTctxt.Size = new System.Drawing.Size(100, 33);
            this.ogrTctxt.TabIndex = 7;
            // 
            // oDatagrdv
            // 
            this.oDatagrdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oDatagrdv.Location = new System.Drawing.Point(450, 64);
            this.oDatagrdv.Name = "oDatagrdv";
            this.oDatagrdv.RowHeadersWidth = 51;
            this.oDatagrdv.RowTemplate.Height = 24;
            this.oDatagrdv.Size = new System.Drawing.Size(608, 344);
            this.oDatagrdv.TabIndex = 8;
            this.oDatagrdv.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.oDatagrdv_MouseDoubleClick);
            // 
            // ekleBtn
            // 
            this.ekleBtn.BackColor = System.Drawing.Color.Lime;
            this.ekleBtn.Location = new System.Drawing.Point(63, 352);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(106, 56);
            this.ekleBtn.TabIndex = 9;
            this.ekleBtn.Text = "EKLE";
            this.ekleBtn.UseVisualStyleBackColor = false;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.Red;
            this.silBtn.Location = new System.Drawing.Point(195, 352);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(106, 56);
            this.silBtn.TabIndex = 10;
            this.silBtn.Text = "SİL";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // güncelleBtn
            // 
            this.güncelleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.güncelleBtn.Location = new System.Drawing.Point(326, 352);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(108, 56);
            this.güncelleBtn.TabIndex = 11;
            this.güncelleBtn.Text = "GÜNCELLE";
            this.güncelleBtn.UseVisualStyleBackColor = false;
            this.güncelleBtn.Click += new System.EventHandler(this.güncelleBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(6, 435);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(428, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Güncelleme için öğrenciye çift tıklayınız!";
            // 
            // Ogrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 567);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.güncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.oDatagrdv);
            this.Controls.Add(this.ogrTctxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ogrTeltxt);
            this.Controls.Add(this.ogrSoyadtxt);
            this.Controls.Add(this.ogrAdtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ogrenci";
            this.Text = "Öğrenci İşlemleri";
            this.Load += new System.EventHandler(this.Ogrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oDatagrdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ogrAdtxt;
        private System.Windows.Forms.TextBox ogrSoyadtxt;
        private System.Windows.Forms.TextBox ogrTeltxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ogrTctxt;
        private System.Windows.Forms.DataGridView oDatagrdv;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button güncelleBtn;
        private System.Windows.Forms.Label label5;
    }
}