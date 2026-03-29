namespace Şifre_Oluşturucu
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
            this.chkBuyukHarf = new System.Windows.Forms.CheckBox();
            this.chkKucukHarf = new System.Windows.Forms.CheckBox();
            this.chkRakam = new System.Windows.Forms.CheckBox();
            this.chkOzelKarakter = new System.Windows.Forms.CheckBox();
            this.numUzunluk = new System.Windows.Forms.NumericUpDown();
            this.btnOlustur = new System.Windows.Forms.Button();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnKopyala = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUzunluk)).BeginInit();
            this.SuspendLayout();
            // 
            // chkBuyukHarf
            // 
            this.chkBuyukHarf.AutoSize = true;
            this.chkBuyukHarf.Location = new System.Drawing.Point(53, 61);
            this.chkBuyukHarf.Name = "chkBuyukHarf";
            this.chkBuyukHarf.Size = new System.Drawing.Size(156, 22);
            this.chkBuyukHarf.TabIndex = 0;
            this.chkBuyukHarf.Text = "Büyük Harf (A-Z)";
            this.chkBuyukHarf.UseVisualStyleBackColor = true;
            // 
            // chkKucukHarf
            // 
            this.chkKucukHarf.AutoSize = true;
            this.chkKucukHarf.Location = new System.Drawing.Point(53, 106);
            this.chkKucukHarf.Name = "chkKucukHarf";
            this.chkKucukHarf.Size = new System.Drawing.Size(155, 22);
            this.chkKucukHarf.TabIndex = 1;
            this.chkKucukHarf.Text = "Küçük Harf (a-z)";
            this.chkKucukHarf.UseVisualStyleBackColor = true;
            // 
            // chkRakam
            // 
            this.chkRakam.AutoSize = true;
            this.chkRakam.Location = new System.Drawing.Point(53, 150);
            this.chkRakam.Name = "chkRakam";
            this.chkRakam.Size = new System.Drawing.Size(124, 22);
            this.chkRakam.TabIndex = 2;
            this.chkRakam.Text = "Rakam (0-9)";
            this.chkRakam.UseVisualStyleBackColor = true;
            // 
            // chkOzelKarakter
            // 
            this.chkOzelKarakter.AutoSize = true;
            this.chkOzelKarakter.Location = new System.Drawing.Point(53, 197);
            this.chkOzelKarakter.Name = "chkOzelKarakter";
            this.chkOzelKarakter.Size = new System.Drawing.Size(200, 22);
            this.chkOzelKarakter.TabIndex = 3;
            this.chkOzelKarakter.Text = "Özel Karakter (@#$...)";
            this.chkOzelKarakter.UseVisualStyleBackColor = true;
            // 
            // numUzunluk
            // 
            this.numUzunluk.Location = new System.Drawing.Point(298, 71);
            this.numUzunluk.Name = "numUzunluk";
            this.numUzunluk.Size = new System.Drawing.Size(184, 24);
            this.numUzunluk.TabIndex = 4;
            this.numUzunluk.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // btnOlustur
            // 
            this.btnOlustur.ForeColor = System.Drawing.Color.Black;
            this.btnOlustur.Location = new System.Drawing.Point(53, 245);
            this.btnOlustur.Name = "btnOlustur";
            this.btnOlustur.Size = new System.Drawing.Size(182, 42);
            this.btnOlustur.TabIndex = 5;
            this.btnOlustur.Text = "Şifre Üret";
            this.btnOlustur.UseVisualStyleBackColor = true;
            this.btnOlustur.Click += new System.EventHandler(this.btnOlustur_Click);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(301, 183);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(148, 24);
            this.txtSifre.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(298, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Üretilen Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(298, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Şifrenin Uzunluğu";
            // 
            // btnKopyala
            // 
            this.btnKopyala.ForeColor = System.Drawing.Color.Black;
            this.btnKopyala.Location = new System.Drawing.Point(53, 294);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(182, 50);
            this.btnKopyala.TabIndex = 9;
            this.btnKopyala.Text = "Şifreyi Kopyala";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(574, 356);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.btnOlustur);
            this.Controls.Add(this.numUzunluk);
            this.Controls.Add(this.chkOzelKarakter);
            this.Controls.Add(this.chkRakam);
            this.Controls.Add(this.chkKucukHarf);
            this.Controls.Add(this.chkBuyukHarf);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Şifre Oluşturucu";
            ((System.ComponentModel.ISupportInitialize)(this.numUzunluk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkBuyukHarf;
        private System.Windows.Forms.CheckBox chkKucukHarf;
        private System.Windows.Forms.CheckBox chkRakam;
        private System.Windows.Forms.CheckBox chkOzelKarakter;
        private System.Windows.Forms.NumericUpDown numUzunluk;
        private System.Windows.Forms.Button btnOlustur;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKopyala;
    }
}

