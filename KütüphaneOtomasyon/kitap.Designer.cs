namespace KütüphaneOtomasyon
{
    partial class kitap
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
            this.güncelleBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.ekleBtn = new System.Windows.Forms.Button();
            this.kitapDatagrdv = new System.Windows.Forms.DataGridView();
            this.kitapSerinotxt = new System.Windows.Forms.TextBox();
            this.kitapYazartxt = new System.Windows.Forms.TextBox();
            this.kitapAdtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kitapDatagrdv)).BeginInit();
            this.SuspendLayout();
            // 
            // güncelleBtn
            // 
            this.güncelleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.güncelleBtn.Location = new System.Drawing.Point(275, 390);
            this.güncelleBtn.Name = "güncelleBtn";
            this.güncelleBtn.Size = new System.Drawing.Size(101, 73);
            this.güncelleBtn.TabIndex = 23;
            this.güncelleBtn.Text = "GÜNCELLE";
            this.güncelleBtn.UseVisualStyleBackColor = false;
            this.güncelleBtn.Click += new System.EventHandler(this.güncelleBtn_Click);
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.Color.Red;
            this.silBtn.Location = new System.Drawing.Point(166, 390);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(103, 73);
            this.silBtn.TabIndex = 22;
            this.silBtn.Text = "SİL";
            this.silBtn.UseVisualStyleBackColor = false;
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // ekleBtn
            // 
            this.ekleBtn.BackColor = System.Drawing.Color.Lime;
            this.ekleBtn.Location = new System.Drawing.Point(52, 390);
            this.ekleBtn.Name = "ekleBtn";
            this.ekleBtn.Size = new System.Drawing.Size(108, 73);
            this.ekleBtn.TabIndex = 21;
            this.ekleBtn.Text = "EKLE";
            this.ekleBtn.UseVisualStyleBackColor = false;
            this.ekleBtn.Click += new System.EventHandler(this.ekleBtn_Click);
            // 
            // kitapDatagrdv
            // 
            this.kitapDatagrdv.BackgroundColor = System.Drawing.Color.Teal;
            this.kitapDatagrdv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitapDatagrdv.Location = new System.Drawing.Point(500, 126);
            this.kitapDatagrdv.Name = "kitapDatagrdv";
            this.kitapDatagrdv.RowHeadersWidth = 51;
            this.kitapDatagrdv.RowTemplate.Height = 24;
            this.kitapDatagrdv.Size = new System.Drawing.Size(469, 392);
            this.kitapDatagrdv.TabIndex = 20;
            this.kitapDatagrdv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kitapDatagrdv_CellDoubleClick);
            // 
            // kitapSerinotxt
            // 
            this.kitapSerinotxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.kitapSerinotxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapSerinotxt.Location = new System.Drawing.Point(241, 272);
            this.kitapSerinotxt.Name = "kitapSerinotxt";
            this.kitapSerinotxt.Size = new System.Drawing.Size(135, 33);
            this.kitapSerinotxt.TabIndex = 17;
            // 
            // kitapYazartxt
            // 
            this.kitapYazartxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.kitapYazartxt.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapYazartxt.Location = new System.Drawing.Point(241, 210);
            this.kitapYazartxt.Name = "kitapYazartxt";
            this.kitapYazartxt.Size = new System.Drawing.Size(135, 33);
            this.kitapYazartxt.TabIndex = 16;
            // 
            // kitapAdtxt
            // 
            this.kitapAdtxt.BackColor = System.Drawing.SystemColors.HighlightText;
            this.kitapAdtxt.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kitapAdtxt.Location = new System.Drawing.Point(241, 157);
            this.kitapAdtxt.Name = "kitapAdtxt";
            this.kitapAdtxt.Size = new System.Drawing.Size(135, 34);
            this.kitapAdtxt.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kitap Seri No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Kitap Yazarı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(88, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Kitap Adı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(49, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Güncelleme için kitaba çift tıklayınız!";
            // 
            // kitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 603);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.güncelleBtn);
            this.Controls.Add(this.silBtn);
            this.Controls.Add(this.ekleBtn);
            this.Controls.Add(this.kitapDatagrdv);
            this.Controls.Add(this.kitapSerinotxt);
            this.Controls.Add(this.kitapYazartxt);
            this.Controls.Add(this.kitapAdtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "kitap";
            this.Text = "Kitap İşlemleri";
            this.Load += new System.EventHandler(this.kitap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitapDatagrdv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button güncelleBtn;
        private System.Windows.Forms.Button silBtn;
        private System.Windows.Forms.Button ekleBtn;
        private System.Windows.Forms.DataGridView kitapDatagrdv;
        private System.Windows.Forms.TextBox kitapSerinotxt;
        private System.Windows.Forms.TextBox kitapYazartxt;
        private System.Windows.Forms.TextBox kitapAdtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}