using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedMesaggingSystem
{

    public partial class Form1 : Form
    {
        public string encrypted_Text;



        public Form1()
        {
            InitializeComponent();
            sidePanel.Height = btn_EncryptMenu.Height;
            userControl_Encryption1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;//dinamik nesne eklemek için listeye
        }

        #region Menu Butonları
        private void btn_EncryptMenu_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_EncryptMenu.Height;
            sidePanel.Top = btn_EncryptMenu.Top;
            userControl_Encryption1.BringToFront();
            userControl_Encryption1.txt_PlainText_UCEnc.Text = userControlDecryption1.decrypted_Text;
            userControl_Encryption1.txt_CipherText_UCEnc.Text = "";

        }

        private void btn_DecryptionMenu_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_DecryptionMenu.Height;
            sidePanel.Top = btn_DecryptionMenu.Top;
            userControlDecryption1.BringToFront();
            userControlDecryption1.txt_EncryptedText_UCDec.Text = userControl_Encryption1.encrypted_Text;
            userControlDecryption1.txt_EncryptedText_UCDec.Text = userControlChat1.txt_IncomingText_UCChat.Text;
        }

        private void btn_Chat_Click(object sender, EventArgs e)
        {
            sidePanel.Height = btn_Chat.Height;
            sidePanel.Top = btn_Chat.Top;
            userControlChat1.BringToFront();
            userControlChat1.txt_TextToSend_UCChat.Text = userControl_Encryption1.txt_CipherText_UCEnc.Text;
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        #endregion


        #region Turkish characters Replace
        public string non_T_Chars(string text)
        {
            text = text.Replace("İ", "I");
            text = text.Replace("ı", "i");
            text = text.Replace("Ğ", "G");
            text = text.Replace("ğ", "g");
            text = text.Replace("Ö", "O");
            text = text.Replace("ö", "o");
            text = text.Replace("Ü", "U");
            text = text.Replace("ü", "u");
            text = text.Replace("Ş", "S");
            text = text.Replace("ş", "s");
            text = text.Replace("Ç", "C");
            text = text.Replace("ç", "c");
            return text;
        }
        #endregion




    }
}
