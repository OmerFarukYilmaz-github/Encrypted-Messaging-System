
namespace EncryptedMesaggingSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Chat = new System.Windows.Forms.Button();
            this.btn_DecryptionMenu = new System.Windows.Forms.Button();
            this.btn_EncryptMenu = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.userControlChat1 = new EncryptedMesaggingSystem.UserControlChat();
            this.userControlDecryption1 = new EncryptedMesaggingSystem.UserControlDecryption();
            this.userControl_Encryption1 = new EncryptedMesaggingSystem.UserControl_Encryption();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.btn_Chat);
            this.panel1.Controls.Add(this.btn_DecryptionMenu);
            this.panel1.Controls.Add(this.btn_EncryptMenu);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.sidePanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(219, 610);
            this.panel1.TabIndex = 0;
            // 
            // btn_Chat
            // 
            this.btn_Chat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Chat.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Chat.ForeColor = System.Drawing.Color.White;
            this.btn_Chat.Location = new System.Drawing.Point(13, 296);
            this.btn_Chat.Name = "btn_Chat";
            this.btn_Chat.Size = new System.Drawing.Size(206, 43);
            this.btn_Chat.TabIndex = 4;
            this.btn_Chat.Text = "Chat";
            this.btn_Chat.UseVisualStyleBackColor = true;
            this.btn_Chat.Click += new System.EventHandler(this.btn_Chat_Click);
            // 
            // btn_DecryptionMenu
            // 
            this.btn_DecryptionMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DecryptionMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_DecryptionMenu.ForeColor = System.Drawing.Color.White;
            this.btn_DecryptionMenu.Location = new System.Drawing.Point(13, 217);
            this.btn_DecryptionMenu.Name = "btn_DecryptionMenu";
            this.btn_DecryptionMenu.Size = new System.Drawing.Size(206, 43);
            this.btn_DecryptionMenu.TabIndex = 3;
            this.btn_DecryptionMenu.Text = "Decryption";
            this.btn_DecryptionMenu.UseVisualStyleBackColor = true;
            this.btn_DecryptionMenu.Click += new System.EventHandler(this.btn_DecryptionMenu_Click);
            // 
            // btn_EncryptMenu
            // 
            this.btn_EncryptMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EncryptMenu.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_EncryptMenu.ForeColor = System.Drawing.Color.White;
            this.btn_EncryptMenu.Location = new System.Drawing.Point(13, 142);
            this.btn_EncryptMenu.Name = "btn_EncryptMenu";
            this.btn_EncryptMenu.Size = new System.Drawing.Size(206, 43);
            this.btn_EncryptMenu.TabIndex = 2;
            this.btn_EncryptMenu.Text = "Encryption";
            this.btn_EncryptMenu.UseVisualStyleBackColor = true;
            this.btn_EncryptMenu.Click += new System.EventHandler(this.btn_EncryptMenu_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 110);
            this.button1.TabIndex = 1;
            this.button1.Text = "Encrypted Messaging System";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.White;
            this.sidePanel.Location = new System.Drawing.Point(0, 142);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(13, 43);
            this.sidePanel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Indigo;
            this.panel3.Controls.Add(this.btn_Close);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(219, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(835, 23);
            this.panel3.TabIndex = 1;
            // 
            // btn_Close
            // 
            this.btn_Close.Image = ((System.Drawing.Image)(resources.GetObject("btn_Close.Image")));
            this.btn_Close.Location = new System.Drawing.Point(762, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(61, 20);
            this.btn_Close.TabIndex = 0;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.userControlChat1);
            this.mainPanel.Controls.Add(this.userControlDecryption1);
            this.mainPanel.Controls.Add(this.userControl_Encryption1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mainPanel.Location = new System.Drawing.Point(219, 26);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(835, 584);
            this.mainPanel.TabIndex = 3;
            // 
            // userControlChat1
            // 
            this.userControlChat1.Location = new System.Drawing.Point(0, 23);
            this.userControlChat1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlChat1.Name = "userControlChat1";
            this.userControlChat1.Size = new System.Drawing.Size(835, 564);
            this.userControlChat1.TabIndex = 2;
            // 
            // userControlDecryption1
            // 
            this.userControlDecryption1.Location = new System.Drawing.Point(0, 23);
            this.userControlDecryption1.Margin = new System.Windows.Forms.Padding(4);
            this.userControlDecryption1.Name = "userControlDecryption1";
            this.userControlDecryption1.Size = new System.Drawing.Size(835, 564);
            this.userControlDecryption1.TabIndex = 1;
            // 
            // userControl_Encryption1
            // 
            this.userControl_Encryption1.Location = new System.Drawing.Point(0, 23);
            this.userControl_Encryption1.Margin = new System.Windows.Forms.Padding(4);
            this.userControl_Encryption1.Name = "userControl_Encryption1";
            this.userControl_Encryption1.Size = new System.Drawing.Size(835, 564);
            this.userControl_Encryption1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 610);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Chat;
        private System.Windows.Forms.Button btn_DecryptionMenu;
        private System.Windows.Forms.Button btn_EncryptMenu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btn_Close;
        private UserControlDecryption userControlDecryption1;
        private UserControl_Encryption userControl_Encryption1;
        public UserControlChat userControlChat1;
    }
}

