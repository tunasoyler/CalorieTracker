namespace CalorieTracker
{
    public partial class Form1 : Form
    {
        private Button currentButton;
        private Random rnd;
        private int tempIndex;
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            //this.MinimizeBox = false;
            rnd = new Random();
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = Color.PeachPuff;
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
                    previousBtn.BackColor = Color.Peru;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}