
namespace WindowsForm3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_sayi1 = new System.Windows.Forms.TextBox();
            this.txt_sayi2 = new System.Windows.Forms.TextBox();
            this.btn_toplama = new System.Windows.Forms.Button();
            this.btn_cıkarma = new System.Windows.Forms.Button();
            this.btn_çarpma = new System.Windows.Forms.Button();
            this.btn_bolme = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.Sayıyı Giriniz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(106, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Sayıyı Giriniz : ";
            // 
            // txt_sayi1
            // 
            this.txt_sayi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_sayi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sayi1.Location = new System.Drawing.Point(301, 32);
            this.txt_sayi1.Name = "txt_sayi1";
            this.txt_sayi1.Size = new System.Drawing.Size(175, 36);
            this.txt_sayi1.TabIndex = 2;
            this.txt_sayi1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_sayi2
            // 
            this.txt_sayi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_sayi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_sayi2.Location = new System.Drawing.Point(301, 89);
            this.txt_sayi2.Name = "txt_sayi2";
            this.txt_sayi2.Size = new System.Drawing.Size(175, 36);
            this.txt_sayi2.TabIndex = 3;
            // 
            // btn_toplama
            // 
            this.btn_toplama.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_toplama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_toplama.Location = new System.Drawing.Point(111, 142);
            this.btn_toplama.Name = "btn_toplama";
            this.btn_toplama.Size = new System.Drawing.Size(184, 46);
            this.btn_toplama.TabIndex = 4;
            this.btn_toplama.Text = "+";
            this.btn_toplama.UseVisualStyleBackColor = false;
            this.btn_toplama.Click += new System.EventHandler(this.btn_toplama_Click);
            // 
            // btn_cıkarma
            // 
            this.btn_cıkarma.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_cıkarma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cıkarma.Location = new System.Drawing.Point(301, 142);
            this.btn_cıkarma.Name = "btn_cıkarma";
            this.btn_cıkarma.Size = new System.Drawing.Size(175, 46);
            this.btn_cıkarma.TabIndex = 5;
            this.btn_cıkarma.Text = "-";
            this.btn_cıkarma.UseVisualStyleBackColor = false;
            this.btn_cıkarma.Click += new System.EventHandler(this.btn_cıkarma_Click);
            // 
            // btn_çarpma
            // 
            this.btn_çarpma.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_çarpma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_çarpma.Location = new System.Drawing.Point(111, 194);
            this.btn_çarpma.Name = "btn_çarpma";
            this.btn_çarpma.Size = new System.Drawing.Size(184, 44);
            this.btn_çarpma.TabIndex = 6;
            this.btn_çarpma.Text = "x";
            this.btn_çarpma.UseVisualStyleBackColor = false;
            this.btn_çarpma.Click += new System.EventHandler(this.btn_çarpma_Click);
            // 
            // btn_bolme
            // 
            this.btn_bolme.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_bolme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_bolme.Location = new System.Drawing.Point(301, 194);
            this.btn_bolme.Name = "btn_bolme";
            this.btn_bolme.Size = new System.Drawing.Size(175, 44);
            this.btn_bolme.TabIndex = 7;
            this.btn_bolme.Text = "/";
            this.btn_bolme.UseVisualStyleBackColor = false;
            this.btn_bolme.Click += new System.EventHandler(this.btn_bolme_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(290, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 33);
            this.label3.TabIndex = 8;
            this.label3.Text = "SONUÇ =";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_sonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sonuc.Location = new System.Drawing.Point(441, 261);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(35, 37);
            this.lbl_sonuc.TabIndex = 9;
            this.lbl_sonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_bolme);
            this.Controls.Add(this.btn_çarpma);
            this.Controls.Add(this.btn_cıkarma);
            this.Controls.Add(this.btn_toplama);
            this.Controls.Add(this.txt_sayi2);
            this.Controls.Add(this.txt_sayi1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_sayi1;
        private System.Windows.Forms.TextBox txt_sayi2;
        private System.Windows.Forms.Button btn_toplama;
        private System.Windows.Forms.Button btn_cıkarma;
        private System.Windows.Forms.Button btn_çarpma;
        private System.Windows.Forms.Button btn_bolme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

