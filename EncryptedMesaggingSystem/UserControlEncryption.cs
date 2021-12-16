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
    public partial class UserControl_Encryption : UserControl
    {
        public string encrypted_Text,decrypted_Text;
        public UserControl_Encryption()
        {
            InitializeComponent();
        }
        private void UserControl_Encryption_Load(object sender, EventArgs e)
        {
            txt_PlainText_UCEnc.Text = decrypted_Text;
        }


        #region Checkboxes
        private void check_Spn_UCEnc_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Spn_UCEnc.Checked == true)
            {
                checkSha_UCEnc.Checked = false;
            }
        }

        private void checkSha_UCEnc_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSha_UCEnc.Checked == true)
            {
                check_Spn_UCEnc.Checked = false;
            }
           
        }
        #endregion


        #region Turkish characters Replace
        private string non_T_Chars(string text)
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

        #region Encrypt
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            txt_PlainText_UCEnc.Text = non_T_Chars(txt_PlainText_UCEnc.Text);
            if (txt_PlainText_UCEnc.Text == "") { MessageBox.Show("Text cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }   // can't be empty
            else if (txt_Key_UCEnc.Text == "") { MessageBox.Show("Key cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txt_Key_UCEnc.Text.Length != 8) { MessageBox.Show("Key must be 8 characters long.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else
            {

                if (check_Spn_UCEnc.Checked == true)
                {
                    if (txt_PlainText_UCEnc.Text.Length % 2 == 1) { txt_PlainText_UCEnc.Text += " "; } // Spn works with 2 character in every steps, so Text must be even characters long.                                                                              // uzunluk çift değilse sona boşluk eklenir.

                    SPN_encryption spn = new SPN_encryption(txt_PlainText_UCEnc.Text, txt_Key_UCEnc.Text);
                    txt_CipherText_UCEnc.Text = spn.encrypt();
                }
                else if (checkSha_UCEnc.Checked == true)
                {
                    SHA_encryption sha = new SHA_encryption(txt_PlainText_UCEnc.Text);
                    txt_CipherText_UCEnc.Text = sha.encrypt();
                }
                else if (check_Spn_UCEnc.Checked == false && checkSha_UCEnc.Checked == false) { MessageBox.Show("Select the encryption method you want ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }


                encrypted_Text = txt_CipherText_UCEnc.Text;
                txt_PlainText_UCEnc.Text = "";
                
            }
        }

        #endregion






    }
}
