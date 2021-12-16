
namespace EncryptedMesaggingSystem
{
    partial class UserControlChat
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
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txt_IncomingText_UCChat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TextToSend_UCChat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 19;
            this.listBox_Clients.Location = new System.Drawing.Point(6, 21);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(165, 403);
            this.listBox_Clients.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox_Clients);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(645, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(177, 433);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clients List:";
            // 
            // txt_IncomingText_UCChat
            // 
            this.txt_IncomingText_UCChat.Location = new System.Drawing.Point(51, 308);
            this.txt_IncomingText_UCChat.Multiline = true;
            this.txt_IncomingText_UCChat.Name = "txt_IncomingText_UCChat";
            this.txt_IncomingText_UCChat.Size = new System.Drawing.Size(289, 142);
            this.txt_IncomingText_UCChat.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Incoming Message :";
            // 
            // txt_TextToSend_UCChat
            // 
            this.txt_TextToSend_UCChat.Location = new System.Drawing.Point(51, 120);
            this.txt_TextToSend_UCChat.Multiline = true;
            this.txt_TextToSend_UCChat.Name = "txt_TextToSend_UCChat";
            this.txt_TextToSend_UCChat.Size = new System.Drawing.Size(289, 142);
            this.txt_TextToSend_UCChat.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(47, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "The encrypted Text To Send:";
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Indigo;
            this.btnSend.FlatAppearance.BorderSize = 2;
            this.btnSend.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(384, 197);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(141, 65);
            this.btnSend.TabIndex = 8;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(47, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "User Name:";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(189, 27);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(151, 22);
            this.txt_UserName.TabIndex = 10;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Indigo;
            this.btnConnect.FlatAppearance.BorderSize = 2;
            this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(367, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(141, 34);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // UserControlChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txt_IncomingText_UCChat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_TextToSend_UCChat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserControlChat";
            this.Size = new System.Drawing.Size(881, 458);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Button btnConnect;
        public System.Windows.Forms.TextBox txt_TextToSend_UCChat;
        public System.Windows.Forms.TextBox txt_IncomingText_UCChat;
    }
}
