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
    public partial class UserControlDecryption : UserControl
    {
        public string encrypted_Text, decrypted_Text;
        public UserControlDecryption()
        {
            InitializeComponent();
        }
     

        #region Checkboxes
        private void check_Spn_UCDec_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Spn_UCDec.Checked == true)
            {
                checkSha_UCDec.Checked = false;
            }

        }

        private void checkSha_UCDec_CheckedChanged(object sender, EventArgs e)
        {
            if (check_Spn_UCDec.Checked == true)
            {
                checkSha_UCDec.Checked = false;
            }
        }

        #endregion



        #region Decrypt

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (txt_EncryptedText_UCDec.Text == "") { MessageBox.Show("Cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txt_Key_UCDec.Text == "") { MessageBox.Show("Key cannot be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txt_Key_UCDec.Text.Length != 8) { MessageBox.Show("Key must be 8 character.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            else if (txt_EncryptedText_UCDec.Text.Length % 2 == 1) { MessageBox.Show("Be sure there is only '0'and '1' in descrypted text "); }
            else
            {

                txt_EncryptedText_UCDec.Text.Replace(" ", "");

                if (check_Spn_UCDec.Checked == true)
                {
                    SPN_encryption spn = new SPN_encryption(txt_Key_UCDec.Text);
                    txt_DecryptedText_UCDec.Text = spn.decrypt(txt_EncryptedText_UCDec.Text);
                    decrypted_Text = txt_DecryptedText_UCDec.Text;
                    txt_EncryptedText_UCDec.Text = "";
                }
                else if (checkSha_UCDec.Checked == true) { MessageBox.Show("SHA cannot be decrypted. "); }
                else if (check_Spn_UCDec.Checked == false && checkSha_UCDec.Checked == false) { MessageBox.Show("Select the decryption method you want ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
        }

        #endregion

     
    }
}
