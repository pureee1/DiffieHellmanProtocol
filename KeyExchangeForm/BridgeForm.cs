using System.Windows.Forms;

namespace KeyExchangeForm
{
    public partial class BridgeForm : Form
    {
        public int P { get; set; }
        public int G { get; set; }
        public int OpenA { get; set; }
        public int OpenB { get; set; }
        public bool UpdatesForBob { get; set; } = false;
        public bool UpdatesForAlice { get; set; } = false;
        public string BobsHash { get; set; }

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
