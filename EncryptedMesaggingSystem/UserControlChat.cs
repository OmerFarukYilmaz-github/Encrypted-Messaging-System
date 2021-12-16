using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptedMesaggingSystem
{
    public partial class UserControlChat : UserControl
    {
        public string encrypted_Text, decrypted_Text;
        public UserControlChat()
        {
            InitializeComponent();
        }


        #region Client işlemleri

        private Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        //InterNetwork = ipv4 ailesi için
        //SocketType.Dgram= UDP için
        //SocketType.Stream= TCP için
        //ProtocolType.IP = TCP ve UDP 
        byte[] receivedBuf = new byte[1024];//veri almak için yer ayırdık
        private string chat_History;

      
        #region Bilgi Al
        private void ReceiveData(IAsyncResult ar)//burası asenkron oldugu için hep çalışır thread gibi veriyi almak için
        {

            int listede_yok = 0;//yok
            try
            {

                Socket socket = (Socket)ar.AsyncState;//asenkron soketi alırız
                int received = socket.EndReceive(ar);//verinin toplam uzunlugu
                byte[] dataBuf = new byte[received];//verıyı byte cevırdık
                Array.Copy(receivedBuf, dataBuf, received);//dataBuf=receivedBuf ve received uzunluk
                string gelen = Encoding.ASCII.GetString(dataBuf).ToString();//serverdan gelen mesaj
                if (gelen.Contains("sil*"))
                {
                    string parcala = gelen.Substring(4, (gelen.Length - 4));
                    Console.WriteLine("degerim  " + parcala);
                    for (int j = 0; j < listBox_Clients.Items.Count; j++)//list boxtanda kaldır
                    {
                        if (listBox_Clients.Items[j].Equals(parcala))
                        {
                            listBox_Clients.Items.RemoveAt(j);

                        }
                    }
                }
                else if (gelen.Contains("@"))//içerisinde @ içeriyorsa clienti listeye eklicez
                {

                    for (int i = 0; i < listBox_Clients.Items.Count; i++)//listedeki itemler kadar dön
                    {
                        if (listBox_Clients.Items[i].ToString().Equals(gelen))//listede varsa o client
                        {
                            listede_yok = 1;//var
                        }
                    }
                    if (listede_yok == 0)//yoksa  ekle clienti
                    {
                        string ben = "@" + txt_UserName.Text;
                        if (ben.Equals(gelen))//kendimi ekleme
                        {

                        }
                        else
                        {
                            listBox_Clients.Items.Add(gelen);
                        }
                    }

                }
                else
                {
                  //  txt_IncomingText_UCChat.Text = (gelen);
                    chat_History += txt_IncomingText_UCChat.Text = ("\n" + gelen);
                }


                //rb_chat.AppendText("\nServer: " + label3.Text);

                _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);
                /*
          buffer=Türünde bir dizi Byte yani alınan veri için depolama konumu.
          offset=Sıfır tabanlı konumu buffer , alınan verileri depolamak parametre.
          size=Almak için bayt sayısı.
          socketFlags=Bit seviyesinde birleşimini SocketFlags değerleri.
          callback=Bir AsyncCallback işlemi tamamlandığında harekete geçirmek için bir yönteme başvuran bir temsilci.
          state=Alma işlemi hakkında bilgi içeren bir kullanıcı tanımlı nesne.Bu nesne için geçirilen EndReceive işlemi tamamlandığında temsilci.
                https://msdn.microsoft.com/tr-tr/library/dxkwh6zw(v=vs.110).aspx adresine bakabilirsin
                  */

            }
            catch (Exception e)
            {
                MessageBox.Show("ReceiveData() metodunda hata " + e.Message);
            }

        }
        #endregion


        #region Loop
        private void SendLoop()
        {
            while (true)
            {
                //Console.WriteLine("Enter a request: ");
                //string req = Console.ReadLine();
                //byte[] buffer = Encoding.ASCII.GetBytes(req);
                //_clientSocket.Send(buffer);

                byte[] receivedBuf = new byte[1024];
                int rev = _clientSocket.Receive(receivedBuf);
                if (rev != 0)
                {
                    byte[] data = new byte[rev];
                    Array.Copy(receivedBuf, data, rev);
                    // label3.Text = ("Received: " + Encoding.ASCII.GetString(data));
                    chat_History = txt_IncomingText_UCChat.Text = ("\nServer: " + Encoding.ASCII.GetString(data) + "\n");
                }
                else _clientSocket.Close();

            }
        }

        private void LoopConnect()
        {
            int attempts = 0;
            while (!_clientSocket.Connected )//server çalışmıyorsa(çalışısaya kadar döngü döner)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect("127.0.0.1", 100);//127.0.0.1=IPAddress.Loopback demek 100 portuna bağlan
                }
                catch (SocketException)
                {
                    //Console.Clear();
                    //   label3.Text = ("bağlantılar: " + attempts.ToString());
                    Console.WriteLine("bağlantılar: " + attempts.ToString());
                    MessageBox.Show("Basarız baglantı deneme " + (attempts + 1));
                }
            }
            // SendLoop();
            _clientSocket.BeginReceive(receivedBuf, 0, receivedBuf.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _clientSocket);//AsyncCallback thread gibi asenkron eş zamansız çalışıyor
            byte[] buffer = Encoding.ASCII.GetBytes("@@" + txt_UserName.Text);//ismimizin başına 2 tane @@ koydum belli olsun
            _clientSocket.Send(buffer);//veriyi gönderdim servera
            MessageBox.Show("servere bağlandı!");//servere bağlandı
        }



        #endregion


        #endregion


        #region Baglantı
        private void btnConnect_Click(object sender, EventArgs e)
        {
            Thread t1 = new Thread(LoopConnect);
            t1.Start();
            btnConnect.Visible = false;
            txt_UserName.Enabled = false;

        }
        #endregion


        #region Mesaj Gonderme
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (_clientSocket.Connected)//client servera bağlı ise
            {
                string tmpStr = "";
                foreach (var item in listBox_Clients.SelectedItems)//listboxtaki seçili itemlere
                {

                    tmpStr = listBox_Clients.GetItemText(item);//isimlerini
                    byte[] buffer = Encoding.ASCII.GetBytes(tmpStr + " :" + txt_TextToSend_UCChat.Text + "*" + txt_UserName.Text);//byte çevir
                    _clientSocket.Send(buffer);//ve gönder ip ve porta
                    Thread.Sleep(20);//yapmasanda olur(fakat 4 cliente bırden mesaj gonderınce dıgerlerine gıtmeyebılir)

                }
                if (tmpStr.Equals(""))
                {
                    MessageBox.Show("lütfen listeden değer seçiniz");
                }
                else
                {
                  //  chat_History += ("\n" + txtName.Text + ": " + txtCipher.Text);
                }


                txt_TextToSend_UCChat.Text = "";
            }



        }
        #endregion




    }
}
