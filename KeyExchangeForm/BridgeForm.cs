using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyExchangeForm
{
    public partial class BridgeForm : Form
    {
        private readonly Random randomizer = new Random();

        private readonly List<int> primeNumbers;

        public int P { get; set; }

        public int G { get; set; }

        private int a;

        public int OpenA { get; set; }

        public int OpenB { get; set; }

        public ChatFormAlice Alice { get; set; }
        public ChatFormBob Bob { get; set; }

        public BridgeForm()
        {
            InitializeComponent();
            Alice = new ChatFormAlice(this);
            Bob = new ChatFormBob(this);
            Alice.Show();
            Bob.Show();
        }
    }
}
