using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Threading;

namespace KeyExchangeForm
{
    public partial class ChatFormAlice : Form
    {
        private readonly Random randomizer = new Random();
        private readonly List<int> primeNumbers;
        public int P { get; set; }
        public int G { get; set; }
        private int a;
        public int OpenA { get; set; }
        public int OpenB { get; set; }
        private ChatFormBob bob = new ChatFormBob();


        public ChatFormAlice()
        {
            InitializeComponent();
            primeNumbers = new List<int>{
            11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71,
                73, 79, 83, 89, 97, 101, 103, 107, 109, 113, 127, 131, 137, 139, 149,
                151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199};

            bob.Show();
        }

        private async void ChatFormAlice_DoubleClick(object sender, EventArgs e)
        {
            P = primeNumbers[randomizer.Next(0, primeNumbers.Count)];
            GetG();
            a = randomizer.Next(12, 150);
            OpenA = (int)BigInteger.ModPow(G, a, P);
            PLbl.Text += P.ToString();
            GLbl.Text += G.ToString();
            await Task.Delay(1500);

            Console.WriteLine($"Alice sent to Bob pair: P:{P} G:{G}");
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
}
