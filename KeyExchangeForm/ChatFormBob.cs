using System;
using System.Numerics;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace KeyExchangeForm
{
    public partial class ChatFormBob : Form
    {
        private readonly Random randomizer = new Random();

        public int P { get; set; }

        public int G { get; set; }

        private int b;

        public int OpenA { get; set; }

        public int OpenB { get; set; }
        private int secretKey;
        private string keyHash;

        private readonly BridgeForm Bridge;

        public ChatFormBob(BridgeForm bf)
        {
            InitializeComponent();
            Bridge = bf;
            ActionTimer.Start();
            DecryptBtn.Enabled = false;
            EncryptBtn.Enabled = false;
        }

        private void ActionTime_Tick(object sender, EventArgs e)
        {
            if (CheckForUpdates())
            {
                OpenA = Bridge.OpenA;
                P = Bridge.P;
                G = Bridge.G;
                Bridge.UpdatesForBob = false;
                PLbl.Text += P;
                GLbl.Text += G;
                OpenALbl.Text += OpenA;


                FirstStageBob();
                secretKey = (int)BigInteger.ModPow(OpenA, b, P);
                KeyLbl.Text += secretKey;
                GetKeyHash();
                HashLbl.Text += keyHash;

                Bridge.OpenB = OpenB;
                Bridge.LogLbl.Text += "Пользователь 2 отправляет остаток от деления - 'B' в открытом виде,\r\n а также хеш секрета Пользователю 1\r\n";
                Bridge.LogLbl.Text += $"B={OpenB}\r\n";
                Bridge.LogLbl.Text += $"ХЕШ={keyHash}\r\n";
                Bridge.LogLbl.Text += $"{new string('-', 50)}\r\n";
                Bridge.BobsHash = keyHash;
                Bridge.UpdatesForAlice = true;
                ActionTimer.Stop();
                DecryptBtn.Enabled = true;
                EncryptBtn.Enabled = true;
            }


        }

        private void FirstStageBob()//rename
        {
            b = 2147483152;
            //b = randomizer.Next(25, 300);
            OpenB = (int)BigInteger.ModPow(G, b, P);
            BLbl.Text += b;
            OpenBLbl.Text += OpenB;
        }

        private bool CheckForUpdates()
        {
            return Bridge.UpdatesForBob;
        }

        private void GetKeyHash()
        {
            using (MD5 md5Hash = MD5.Create())
            {
                keyHash = MD5Helpers.GetMd5Hash(md5Hash, secretKey.ToString());
            }
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            if (InputTxtBox.Text.Length >= 1)
            {
                OutputLbl.Text = string.Empty;
                foreach (var item in InputTxtBox.Text.Split(' '))
                {
                    OutputLbl.Text += $"{(char)(Convert.ToInt32(item) ^ secretKey)}";
                }
            }
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (InputTxtBox.Text.Length >= 1)
            {
                OutputLbl.Text = string.Empty;
                Bridge.LogLbl.Text += "-----НАЧАЛО СООБЩЕНИЯ-----\r\n";
                foreach (var item in InputTxtBox.Text)
                {
                    Bridge.LogLbl.Text += $"{item ^ secretKey} ";
                    OutputLbl.Text += $"{ item ^ secretKey} ";
                }
                Bridge.LogLbl.Text += "\r\n";
                Bridge.LogLbl.Text += "-----КОНЕЦ СООБЩЕНИЯ-----\r\n";
            }
        }
    }
}
