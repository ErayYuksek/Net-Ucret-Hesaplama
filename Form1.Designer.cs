namespace Maaş_bordro_Hesapllama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnhesapla = new System.Windows.Forms.Button();
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcgs = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkıdeem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcocuksayısı = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listbilgiler = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btntemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnhesapla
            // 
            this.btnhesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnhesapla.Location = new System.Drawing.Point(91, 358);
            this.btnhesapla.Name = "btnhesapla";
            this.btnhesapla.Size = new System.Drawing.Size(128, 54);
            this.btnhesapla.TabIndex = 0;
            this.btnhesapla.Text = "Hesapla";
            this.btnhesapla.UseVisualStyleBackColor = true;
            this.btnhesapla.Click += new System.EventHandler(this.btnhesapla_Click);
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsoyad.Location = new System.Drawing.Point(368, 134);
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(167, 22);
            this.txtadsoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(154, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ad Soyadı : ";
            // 
            // txtcgs
            // 
            this.txtcgs.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcgs.Location = new System.Drawing.Point(368, 197);
            this.txtcgs.Name = "txtcgs";
            this.txtcgs.Size = new System.Drawing.Size(167, 22);
            this.txtcgs.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(97, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Çalıştıgı Gün Sayısı :";
            // 
            // txtkıdeem
            // 
            this.txtkıdeem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkıdeem.Location = new System.Drawing.Point(368, 250);
            this.txtkıdeem.Name = "txtkıdeem";
            this.txtkıdeem.Size = new System.Drawing.Size(167, 22);
            this.txtkıdeem.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(111, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "kıdemYılı :";
            // 
            // txtcocuksayısı
            // 
            this.txtcocuksayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcocuksayısı.Location = new System.Drawing.Point(368, 306);
            this.txtcocuksayısı.Name = "txtcocuksayısı";
            this.txtcocuksayısı.Size = new System.Drawing.Size(167, 22);
            this.txtcocuksayısı.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(111, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Çocuk Sayısı :";
            // 
            // listbilgiler
            // 
            this.listbilgiler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.listbilgiler.Dock = System.Windows.Forms.DockStyle.Right;
            this.listbilgiler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listbilgiler.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listbilgiler.FormattingEnabled = true;
            this.listbilgiler.ItemHeight = 29;
            this.listbilgiler.Location = new System.Drawing.Point(642, 0);
            this.listbilgiler.Name = "listbilgiler";
            this.listbilgiler.Size = new System.Drawing.Size(332, 490);
            this.listbilgiler.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(75, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(404, 42);
            this.label5.TabIndex = 2;
            this.label5.Text = "Net Ücret Hesaplama ";
            // 
            // btntemizle
            // 
            this.btntemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btntemizle.Location = new System.Drawing.Point(289, 358);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(117, 54);
            this.btntemizle.TabIndex = 5;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(974, 490);
            this.Controls.Add(this.listbilgiler);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcocuksayısı);
            this.Controls.Add(this.txtkıdeem);
            this.Controls.Add(this.txtcgs);
            this.Controls.Add(this.txtadsoyad);
            this.Controls.Add(this.btnhesapla);
            this.Controls.Add(this.btntemizle);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnhesapla;
        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcgs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkıdeem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcocuksayısı;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listbilgiler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btntemizle;
    }
}

