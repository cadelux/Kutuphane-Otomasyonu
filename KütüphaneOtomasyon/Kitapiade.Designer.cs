namespace KütüphaneOtomasyon
{
    partial class Kitapiade
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
            this.kayitdatagridview = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kayitdatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // kayitdatagridview
            // 
            this.kayitdatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kayitdatagridview.Location = new System.Drawing.Point(12, 67);
            this.kayitdatagridview.Name = "kayitdatagridview";
            this.kayitdatagridview.RowHeadersWidth = 51;
            this.kayitdatagridview.RowTemplate.Height = 24;
            this.kayitdatagridview.Size = new System.Drawing.Size(1125, 286);
            this.kayitdatagridview.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(371, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 56);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alınan Kitaplar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(450, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "İade Et";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Kitapiade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 622);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kayitdatagridview);
            this.Name = "Kitapiade";
            this.Text = "Kitap İade İşlemleri";
            this.Load += new System.EventHandler(this.Kitapiade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kayitdatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView kayitdatagridview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}