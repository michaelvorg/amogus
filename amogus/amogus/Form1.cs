using System.ComponentModel;
using System.Media;
using Timer = System.Windows.Forms.Timer;

namespace amogus 
{
    
    public partial class mainForm : Form
    {
        public Rectangle screen = Screen.PrimaryScreen.WorkingArea;
        private static readonly Random _random = new Random();
        private bool isFirstRun = false;

        public mainForm(bool firstRun)
        {
            InitializeComponent();
            isFirstRun = firstRun;
            TopMost = true;

            SoundPlayer amogusAudio = new SoundPlayer(Properties.Resources.amogusAudio);
            amogusAudio.Play();

            Timer timer = new Timer();
            timer.Interval = 500; // 0.5 sec
            timer.Tick += new EventHandler(moveWindow_Tick);
            timer.Start();

            if (isFirstRun)
            {
                new blockForm();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            new mainForm(false);
            new mainForm(false);
            new mainForm(false);
        }

        private void amogusPic_Click(object sender, EventArgs e)
        {
            Hide();
            new mainForm(false);
            new mainForm(false);
            new mainForm(false);
        }

        private void moveWindow_Tick(object sender, EventArgs e)
        {
            int x = _random.Next(screen.Width - Width);   // range [0 .. screen width - form width].
            int y = _random.Next(screen.Height - Height); // range [0 .. screen height - form height].
            Location = new Point(x, y);
            Show();
        }
    }
}