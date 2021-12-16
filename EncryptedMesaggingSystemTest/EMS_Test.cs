using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;

namespace EncryptedMesaggingSystemTest
{
    [TestClass]
    public class EMS_Test
    {
        [TestMethod]
        public void CanInstaniateSPN_encryption()
        {
            EncryptedMesaggingSystem.SPN_encryption spn = new EncryptedMesaggingSystem.SPN_encryption();
        }


        [TestMethod]
        public void CanInstaniateSHA_encryption()
        {
            EncryptedMesaggingSystem.SHA_encryption sha = new EncryptedMesaggingSystem.SHA_encryption();
        }


        [TestMethod]
        public void StringToBinary()
        {
            EncryptedMesaggingSystem.SPN_encryption spn = new EncryptedMesaggingSystem.SPN_encryption();
            string sonuc = spn.stringToBinary("omer");
            Assert.AreEqual("01101111011011010110010101110010", sonuc);
        }


        [TestMethod]
        public void BinaryToString()
        {
            EncryptedMesaggingSystem.SPN_encryption spn = new EncryptedMesaggingSystem.SPN_encryption();
            string sonuc = spn.binaryToString("01101111011011010110010101110010");
            Assert.AreEqual("omer", sonuc);
        }


        [TestMethod]
        public void Xor()
        {
            EncryptedMesaggingSystem.SPN_encryption spn = new EncryptedMesaggingSystem.SPN_encryption();
            string sonuc = spn.xor("0110", "0011");
            Assert.AreEqual("0101", sonuc);
        }


        [TestMethod]
        public void subsitute()
        {
            EncryptedMesaggingSystem.SPN_encryption spn = new EncryptedMesaggingSystem.SPN_encryption();
            string sonuc = spn.substitution("0123456789abcdef");
            Assert.AreEqual("28c590e4b1f63a7d", sonuc);
        }


        [TestMethod]
        public void ReverseSubsitute()
        {
            EncryptedMesaggingSystem.SPN_encryption spn = new EncryptedMesaggingSystem.SPN_encryption();
            string sonuc = spn.r_Substitution("28c590e4b1f63a7d");
            Assert.AreEqual("0123456789abcdef", sonuc);
        }


        
        [TestMethod]
        public void SpnEncrypt()
        {
            EncryptedMesaggingSystem.SPN_encryption spn = new EncryptedMesaggingSystem.SPN_encryption("omer","security");//Kurucu methoda metni ve keyi ilk başta gönderiyoruz
            string sonuc = spn.encrypt();
            Assert.AreEqual("00101110111011011110111001011011", sonuc);
   
        }
        
 
        [TestMethod]
        public void SpnDecrypt()
        {
            EncryptedMesaggingSystem.SPN_encryption spn = new EncryptedMesaggingSystem.SPN_encryption("security");//Kurucu methoda keyi ilk başta gönderiyoruz
            string sonuc = spn.decrypt("00101110111011011110111001011011");
            Assert.AreEqual("omer", sonuc);
        }


        [TestMethod]
        public void ShaEncrypt()
        {
            EncryptedMesaggingSystem.SHA_encryption sha = new EncryptedMesaggingSystem.SHA_encryption("omer");//Kurucu methoda metni ilk başta gönderiyoruz
            string sonuc = sha.encrypt();
            Assert.AreEqual("790272c06db5d329c92e4fb1be244b2d6340c15286628852093b0a7f4e6292aa", sonuc);

        }



    }
}
