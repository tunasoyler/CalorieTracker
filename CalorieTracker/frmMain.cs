using BLL.Services;
using DAL;
using DotNetOpenAuth.Messaging;
using Entities.Concrete;
using Entities.Dtos.UserDtos;
using Entities.ViewModels;
using Syncfusion.UI.Xaml.Charts;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace UI
{
    public partial class frmMain : Form
    {
        frmReports statisticsForm;
        frmUser userForm;
        frmAddMeal addMealForm;
        frmMain mainForm;
        Meal currentMeal;
        User currentUser;

        Context context = new Context();

        private Button currentButton;
        
        public frmMain(User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.currentUser = user;
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
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.OliveDrab;
                }
            }
        }

        UserViewModel userViewModel;

        private void Form1_Load(object sender, EventArgs e)
        {
            
            SetDates();
            FillCaloriesByMealType();
            CircularProgresBarLoad();
            SetWeeklyChartValues();


            //dgvMealsToday.DataSource = mealDetailsService.GetTotalCalorieByMeal(mealDetails, DateTime.Today, currentUser);









            //MealDetailsViewModel mealDetailsVm = new MealDetailsViewModel();
            //double dailyLimit = 0, currentCalorie = 0;

            //foreach (var item in )
            //{

            //}

            //mealDetailsVm.Calorie
            //currentCalorie = 
            //cpbDailyLimit.Text = 






        }

        private void SetWeeklyChartValues()
        {
            MealService mealService = new MealService(context);
            MealDetailsService mealDetailsService = new MealDetailsService(context);
            List<MealViewModel> mealList = new List<MealViewModel>();
            int[] list = new int[7];
            for (int i = 0; i < 7; i++)
            {
                DateTime date = (DateTime.Now.Date).AddDays(-i);
                mealList = mealService.GetMealsByDate(date);
                double totalDailyCalorie = 0;
                foreach (var meal in mealList)
                {

                    totalDailyCalorie += mealDetailsService.GetMealCalorieByMealId(meal.Id, date);
                }
                
                list[i] = Convert.ToInt32(totalDailyCalorie);
                lblDays.Text += $"{date.Day}.{date.Month}     ";

            }
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
            statisticsForm = new frmReports(currentUser);
            statisticsForm.Show();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Hide();
            addMealForm = new frmAddMeal(currentUser);
            addMealForm.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Hide();
            userForm= new frmUser(currentUser);
            userForm.Show();
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
        private void SetDates() 
        {
            DateTime goalDate;
            lblStartDate.Text = currentUser.CreatedDate.ToString("dd.MM.yyyy"); 
            if (currentUser.Timeline == "6 months") 
            {
                goalDate = currentUser.CreatedDate.AddMonths(6);
                lblGoalDate.Text = (goalDate).ToString("dd.MM.yyyy");

            } 
            else 
            {
                goalDate = currentUser.CreatedDate.AddMonths(12);
                lblGoalDate.Text = (goalDate).ToString("dd.MM.yyyy"); 
            }
            progressBar1.Maximum = (goalDate-currentUser.CreatedDate).Days;
            progressBar1.Value=(DateTime.Now- currentUser.CreatedDate).Days;
        }
        double totalMealCalorie;
        //private void FillMealTypes()
        //{
        //    MealTypeService mealTypeService = new MealTypeService(context);
        //    List<MealTypeViewModel> mealTypeList = new List<MealTypeViewModel>();
        //    mealTypeList = mealTypeService.GetAllMealTypes();
        //    foreach (var mealType in mealTypeList)
        //    {
        //        dgvMyMealsToday.Rows.Add(mealType.Id, mealType.Name);
        //    }

        //}
        private void FillCaloriesByMealType()
        {
            try
            {
                MealDetailsService mealDetailsService= new MealDetailsService(context);
                MealService mealService= new MealService(context);
                MealTypeService mealTypeService = new MealTypeService(context);
                List<MealTypeViewModel> mealTypeList = new List<MealTypeViewModel>();
                mealTypeList = mealTypeService.GetAllMealTypes();
                currentMeal = new Meal();
                DateTime date = DateTime.Now.Date;
                foreach (var mealType in mealTypeList)
                {
                    currentMeal = mealService.GetMealByDateAndMealType(date.Date, currentUser, mealType.Id);
                    double mealCalorie = mealDetailsService.GetMealCalorieByMealId(currentMeal.Id, date);
                    dgvMyMealsToday.Rows.Add(mealType.Id, mealType.Name, mealCalorie);
                }
                
               
                

            }
            catch (Exception)
            {

            }
        }
        private void CircularProgresBarLoad()
        {
            
            cpbDailyLimit.Maximum = Convert.ToInt32(currentUser.DailyCalorieLimit);
            for (int i = 0; i<4; i++)
            {
                cpbDailyLimit.Value += Convert.ToInt32(dgvMyMealsToday.Rows[i].Cells["clmCalorie"].Value);
            }
            cpbDailyLimit.Text = $"{cpbDailyLimit.Value}/{cpbDailyLimit.Maximum}";


        }

    }
}