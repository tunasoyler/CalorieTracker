using System.Runtime.InteropServices;

namespace UI
{
    public partial class frmMain : Form
    {
        frmStatistics statisticsForm;
        frmUser userForm;
        frmSettings settingsForm;
        frmAddMeal addMealForm;
        frmMain mainForm;

        private Button currentButton;
        //private int tempIndex;
        public frmMain()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ControlBox = false;
            CenterToScreen();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.YellowGreen;
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                }
            }
        }

        private void DisableButton()
        {
            //List<Button> menuButtons = new List<Button>() { btnHome, btnMeal, btnSettings, btnUser, btnReports};
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.OliveDrab;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetWeeklyChartValues(1900, 1500, 2500, 1800, 1000, 1000, 2000);   
        }

        private void SetWeeklyChartValues(int day1, int day2, int day3, int day4, int day5, int day6, int day7)
        {
            int[] list = { day1, day2, day3, day4, day5, day6, day7 };
            sparkLine1.Source = list;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Hide();
            statisticsForm = new frmStatistics();
            statisticsForm.Show();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Hide();
            addMealForm = new frmAddMeal();
            addMealForm.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Hide();
            userForm= new frmUser();
            userForm.Show();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Hide();
            settingsForm = new frmSettings();
            settingsForm.Show();
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


    }
}