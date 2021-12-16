
namespace EncryptedMesaggingSystem
{
    partial class UserControl_Encryption
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_PlainText_UCEnc = new System.Windows.Forms.TextBox();
            this.txt_CipherText_UCEnc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkSha_UCEnc = new System.Windows.Forms.CheckBox();
            this.check_Spn_UCEnc = new System.Windows.Forms.CheckBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Key_UCEnc = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Plain Text :";
            // 
            // txt_PlainText_UCEnc
            // 
            this.txt_PlainText_UCEnc.Location = new System.Drawing.Point(51, 60);
            this.txt_PlainText_UCEnc.Multiline = true;
            this.txt_PlainText_UCEnc.Name = "txt_PlainText_UCEnc";
            this.txt_PlainText_UCEnc.Size = new System.Drawing.Size(289, 142);
            this.txt_PlainText_UCEnc.TabIndex = 1;
            // 
            // txt_CipherText_UCEnc
            // 
            this.txt_CipherText_UCEnc.Location = new System.Drawing.Point(51, 308);
            this.txt_CipherText_UCEnc.Multiline = true;
            this.txt_CipherText_UCEnc.Name = "txt_CipherText_UCEnc";
            this.txt_CipherText_UCEnc.Size = new System.Drawing.Size(289, 142);
            this.txt_CipherText_UCEnc.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cipher Text :";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.BackColor = System.Drawing.Color.Indigo;
            this.btnEncrypt.FlatAppearance.BorderSize = 2;
            this.btnEncrypt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEncrypt.ForeColor = System.Drawing.Color.White;
            this.btnEncrypt.Location = new System.Drawing.Point(654, 385);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(141, 65);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = false;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Indigo;
            this.groupBox1.Controls.Add(this.checkSha_UCEnc);
            this.groupBox1.Controls.Add(this.check_Spn_UCEnc);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(608, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encryption Method";
            // 
            // checkSha_UCEnc
            // 
            this.checkSha_UCEnc.AutoSize = true;
            this.checkSha_UCEnc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkSha_UCEnc.Location = new System.Drawing.Point(6, 67);
            this.checkSha_UCEnc.Name = "checkSha_UCEnc";
            this.checkSha_UCEnc.Size = new System.Drawing.Size(108, 26);
            this.checkSha_UCEnc.TabIndex = 1;
            this.checkSha_UCEnc.Text = "SHA-256";
            this.checkSha_UCEnc.UseVisualStyleBackColor = true;
            this.checkSha_UCEnc.CheckedChanged += new System.EventHandler(this.checkSha_UCEnc_CheckedChanged);
            // 
            // check_Spn_UCEnc
            // 
            this.check_Spn_UCEnc.AutoSize = true;
            this.check_Spn_UCEnc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_Spn_UCEnc.Location = new System.Drawing.Point(6, 35);
            this.check_Spn_UCEnc.Name = "check_Spn_UCEnc";
            this.check_Spn_UCEnc.Size = new System.Drawing.Size(95, 26);
            this.check_Spn_UCEnc.TabIndex = 0;
            this.check_Spn_UCEnc.Text = "SPN-16";
            this.check_Spn_UCEnc.UseVisualStyleBackColor = true;
            this.check_Spn_UCEnc.CheckedChanged += new System.EventHandler(this.check_Spn_UCEnc_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Indigo;
            this.groupBox2.Controls.Add(this.txt_Key_UCEnc);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(608, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 65);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key";
            // 
            // txt_Key_UCEnc
            // 
            this.txt_Key_UCEnc.Location = new System.Drawing.Point(6, 25);
            this.txt_Key_UCEnc.Name = "txt_Key_UCEnc";
            this.txt_Key_UCEnc.Size = new System.Drawing.Size(107, 30);
            this.txt_Key_UCEnc.TabIndex = 0;
            this.txt_Key_UCEnc.Text = "security";
            // 
            // UserControl_Encryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txt_CipherText_UCEnc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PlainText_UCEnc);
            this.Controls.Add(this.label1);
            this.Name = "UserControl_Encryption";
            this.Size = new System.Drawing.Size(835, 498);
            this.Load += new System.EventHandler(this.UserControl_Encryption_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkSha_UCEnc;
        private System.Windows.Forms.CheckBox check_Spn_UCEnc;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Key_UCEnc;
        public System.Windows.Forms.TextBox txt_PlainText_UCEnc;
        public System.Windows.Forms.TextBox txt_CipherText_UCEnc;
    }
}
