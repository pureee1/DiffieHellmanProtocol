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
    public partial class ChatFormBob : Form
    {
        private readonly Random randomizer = new Random();

        public int P { get; set; }

        public int G { get; set; }

        private int b;

        public int OpenA { get; set; }

        public int OpenB { get; set; }

        public ChatFormBob(BridgeForm bf)
        {
            InitializeComponent();
        }
    }
}
