using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography;

namespace KeyExchangeForm
{
    public partial class ChatFormAlice : Form
    {
        private readonly Random randomizer = new Random();

        private readonly List<int> primeNumbers;

        private AlicesStages currentStage = AlicesStages.First;

        public int P { get; set; }

        public int G { get; set; }

        private int a;

        public int OpenA { get; set; }

        public int OpenB { get; set; }

        public string KeyHash { get; set; }

        private int secretKey;

        public BridgeForm Bridge { get; set; }

        public ChatFormAlice(BridgeForm bf)
        {
            InitializeComponent();
            primeNumbers = new List<int>{
                367, 373, 379, 383, 389, 397, 401, 409, 419, 421, 431, 433,
                439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503,
                509, 521, 523, 541, 547, 557, 563, 569, 571, 577, 587, 593,
                599, 601, 607, 613, 617, 619, 631, 641, 643, 647, 653, 659,
                661, 673, 677, 683, 691, 701, 709, 719, 727, 733, 739, 743,
                751, 757, 761, 769, 773, 787, 797, 809, 811, 821, 823, 827,
                829, 839, 853, 857, 859, 863, 877, 881, 883, 887, 907, 911
            };
            ActionTimer.Start();
            Bridge = bf;
            DecryptBtn.Enabled = false;
            EncryptBtn.Enabled = false;
        }

        private void ActionTimer_Tick(object sender, EventArgs e)
        {
            if (CheckForUpdates() || currentStage == AlicesStages.First)
            {
                switch (currentStage)
                {
                    case AlicesStages.First:
                        FirstStageAlice();
                        Bridge.OpenA = OpenA;
                        Bridge.P = P;
                        Bridge.G = G;
                        Bridge.LogLbl.Text += $"Alice sent openA and PG_KeyPair to Bob\r\n";
                        Bridge.LogLbl.Text += $"A={OpenA}\r\nP={P}\r\nG={G}\r\n";
                        Bridge.LogLbl.Text += $"{new string('-', 50)}\r\n";
                        Bridge.UpdatesForBob = true;
                        currentStage = AlicesStages.Second;
                        break;
                    case AlicesStages.Second:
                        SecondStageAlice();
                        KeyLbl.Text += secretKey;
                        Bridge.UpdatesForAlice = false;
                        if (!KeyHash.Equals(Bridge.BobsHash))
                            Bridge.LogLbl.Text += "Alice sent refuse to Bob's hash\r\n";
                        else
                            Bridge.LogLbl.Text += "Alice sent approve to Bob's hash\r\n";

                        Bridge.LogLbl.Text += $"{new string('-', 50)}\r\n";
                        ActionTimer.Stop();
                        DecryptBtn.Enabled = true;
                        EncryptBtn.Enabled = true;
                        break;
                    default:
                        throw new Exception();
                }
            }


        }

        //Generates {P,G} pair and OpenA component 
        private void FirstStageAlice()
        {
            P = primeNumbers[randomizer.Next(0, primeNumbers.Count)];
            GetG();
            a = randomizer.Next(125, 300);
            OpenA = (int)BigInteger.ModPow(G, a, P);
            PLbl.Text += P.ToString();
            GLbl.Text += G.ToString();
            ALbl.Text += a;
            OpenALbl.Text += OpenA;
        }

        private void SecondStageAlice()
        {
            OpenB = Bridge.OpenB;
            secretKey = (int)BigInteger.ModPow(OpenB, a, P);
            using (MD5 md5Hash = MD5.Create())
            {
                KeyHash = MD5Helpers.GetMd5Hash(md5Hash, secretKey.ToString());
                HashLbl.Text += KeyHash;
            }
            OpenBLbl.Text += OpenB;
        }

        private void GetG()
        {
            var GList = new List<int>();
            for (int g = 2; g < P; g++)
            {
                if (BigInteger.ModPow(g, P - 1, P) == 1)
                {
                    GList.Add(g);
                }
            }
            G = GList[randomizer.Next(0, GList.Count)];
        }

        private bool CheckForUpdates()
        {
            return Bridge.UpdatesForAlice;
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (InputTxtBox.Text.Length >= 1)
            {
                Bridge.LogLbl.Text += "-----BEGIN ENCRYPTED MESSAGE-----\r\n";
                OutputLbl.Text = string.Empty;
                foreach (var item in InputTxtBox.Text)
                {
                    Bridge.LogLbl.Text += $"{item ^ secretKey} ";
                    OutputLbl.Text += $"{ item ^ secretKey} ";
                }
                Bridge.LogLbl.Text += "\r\n";
                Bridge.LogLbl.Text += "-----END ENCRYPTED MESSAGE-----\r\n";
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
    }
}
