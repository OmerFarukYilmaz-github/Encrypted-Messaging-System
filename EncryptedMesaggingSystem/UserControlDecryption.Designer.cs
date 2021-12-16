
namespace EncryptedMesaggingSystem
{
    partial class UserControlDecryption
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkSha_UCDec = new System.Windows.Forms.CheckBox();
            this.check_Spn_UCDec = new System.Windows.Forms.CheckBox();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.txt_DecryptedText_UCDec = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_EncryptedText_UCDec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_Key_UCDec = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Indigo;
            this.groupBox1.Controls.Add(this.checkSha_UCDec);
            this.groupBox1.Controls.Add(this.check_Spn_UCDec);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(608, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 106);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Decryption Method";
            // 
            // checkSha_UCDec
            // 
            this.checkSha_UCDec.AutoSize = true;
            this.checkSha_UCDec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkSha_UCDec.Location = new System.Drawing.Point(6, 67);
            this.checkSha_UCDec.Name = "checkSha_UCDec";
            this.checkSha_UCDec.Size = new System.Drawing.Size(108, 26);
            this.checkSha_UCDec.TabIndex = 1;
            this.checkSha_UCDec.Text = "SHA-256";
            this.checkSha_UCDec.UseVisualStyleBackColor = true;
            this.checkSha_UCDec.CheckedChanged += new System.EventHandler(this.checkSha_UCDec_CheckedChanged);
            // 
            // check_Spn_UCDec
            // 
            this.check_Spn_UCDec.AutoSize = true;
            this.check_Spn_UCDec.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.check_Spn_UCDec.Location = new System.Drawing.Point(6, 35);
            this.check_Spn_UCDec.Name = "check_Spn_UCDec";
            this.check_Spn_UCDec.Size = new System.Drawing.Size(95, 26);
            this.check_Spn_UCDec.TabIndex = 0;
            this.check_Spn_UCDec.Text = "SPN-16";
            this.check_Spn_UCDec.UseVisualStyleBackColor = true;
            this.check_Spn_UCDec.CheckedChanged += new System.EventHandler(this.check_Spn_UCDec_CheckedChanged);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.BackColor = System.Drawing.Color.Indigo;
            this.btnDecrypt.FlatAppearance.BorderSize = 2;
            this.btnDecrypt.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDecrypt.ForeColor = System.Drawing.Color.White;
            this.btnDecrypt.Location = new System.Drawing.Point(654, 391);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(141, 65);
            this.btnDecrypt.TabIndex = 10;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = false;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // txt_DecryptedText_UCDec
            // 
            this.txt_DecryptedText_UCDec.Location = new System.Drawing.Point(51, 314);
            this.txt_DecryptedText_UCDec.Multiline = true;
            this.txt_DecryptedText_UCDec.Name = "txt_DecryptedText_UCDec";
            this.txt_DecryptedText_UCDec.Size = new System.Drawing.Size(289, 142);
            this.txt_DecryptedText_UCDec.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Decrypted Text :";
            // 
            // txt_EncryptedText_UCDec
            // 
            this.txt_EncryptedText_UCDec.Location = new System.Drawing.Point(51, 60);
            this.txt_EncryptedText_UCDec.Multiline = true;
            this.txt_EncryptedText_UCDec.Name = "txt_EncryptedText_UCDec";
            this.txt_EncryptedText_UCDec.Size = new System.Drawing.Size(289, 142);
            this.txt_EncryptedText_UCDec.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Encrypted Text :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Indigo;
            this.groupBox2.Controls.Add(this.txt_Key_UCDec);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(608, 174);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 65);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key";
            // 
            // txt_Key_UCDec
            // 
            this.txt_Key_UCDec.Location = new System.Drawing.Point(6, 25);
            this.txt_Key_UCDec.Name = "txt_Key_UCDec";
            this.txt_Key_UCDec.Size = new System.Drawing.Size(107, 30);
            this.txt_Key_UCDec.TabIndex = 0;
            this.txt_Key_UCDec.Text = "security";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // UserControlDecryption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txt_DecryptedText_UCDec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_EncryptedText_UCDec);
            this.Controls.Add(this.label1);
            this.Name = "UserControlDecryption";
            this.Size = new System.Drawing.Size(835, 498);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkSha_UCDec;
        private System.Windows.Forms.CheckBox check_Spn_UCDec;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_Key_UCDec;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TextBox txt_EncryptedText_UCDec;
        public System.Windows.Forms.TextBox txt_DecryptedText_UCDec;
    }
}
