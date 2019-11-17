using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace KeyExchangeForm
{
    public partial class ChatFormAlice : Form
    {
        private readonly Random randomizer = new Random();

        private readonly List<int> primeNumbers;

        private Stage currentStage = Stage.First;

        public int P { get; set; }

        public int G { get; set; }

        private int a;

        public int OpenA { get; set; }

        public int OpenB { get; set; }

        public BridgeForm Bridge { get; set; }

        public ChatFormAlice(BridgeForm bf)
        {
            InitializeComponent();
            primeNumbers = new List<int>{
            11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
                73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149,
                151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199};
            ActionTimer.Start();
            Bridge = bf;
        }

        private void ActionTimer_Tick(object sender, EventArgs e)
        {
            switch (currentStage)
            {
                case Stage.First:
                    FirstStageAlice();
                    Bridge.OpenA = OpenA;
                    Bridge.P = P;
                    Bridge.G = G;
                    Bridge.LogLbl.Text += $"Alice sent openA and PG_KeyPair to Bob\r\n";
                    Bridge.LogLbl.Text += $"A={OpenA}\r\nP={P}\r\nG={G}\r\n";
                    Bridge.LogLbl.Text += $"{new string('-', 50)}\r\n";

                    break;
                case Stage.Second:
                    break;
                default:
                    break;
            }

        }

        //Generates {P,G} pair and OpenA component 
        private void FirstStageAlice()
        {
            P = primeNumbers[randomizer.Next(0, primeNumbers.Count)];
            GetG();
            a = randomizer.Next(12, 150);
            OpenA = (int)BigInteger.ModPow(G, a, P);
            PLbl.Text += P.ToString();
            GLbl.Text += G.ToString();
            ALbl.Text += a;
            OpenALbl.Text += OpenA;
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
    }

    public enum Stage
    {
        First,
        Second
    }
}
