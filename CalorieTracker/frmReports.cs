using BLL.Services;
using DAL;
using DotNetOpenAuth.OpenId;
using Entities.Concrete;
using Entities.Dtos.FoodDtos;
using Entities.Dtos.MealDetailsDtos;
using Entities.Dtos.MealDtos;
using Entities.Dtos.UserDtos;
using Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmReports : Form
    {
        private Form activeForm;


        frmReports statisticsForm;
        frmUser userForm;
        frmAddMeal addMealForm;
        frmMain mainForm;
        Meal currentMeal;
        User currentUser;

        Context context = new Context();
        MealDetailsService mealDetailsService;
        MealDetails mealDetails;


        private Button currentButton;
        private int tempIndex;
        public frmReports(User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.currentUser = user;
            CenterToScreen();
        }

        private void frmStatistics_Load(object sender, EventArgs e)
        {

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

        private void btnHome_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);


            this.Hide();
            mainForm = new frmMain(currentUser);
            mainForm.Show();

        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);

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
            userForm = new frmUser(currentUser);
            userForm.Show();
        }


        private void btnMinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        double totalDailyCalorie = 0;
        double totalMealCalorie = 0;

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterMeals();
        }

        private void dgvFoods_SelectionChanged(object sender, EventArgs e)
        {
            

        }
        
        private void FillMealDetails() 
        {
            try
            {
                mealDetailsService = new MealDetailsService(context);
                MealService mealService = new MealService(context);
                DataGridViewRow selectedRow = dgvMeals.SelectedRows[0];                
                currentMeal = new Meal();               
                DateTime date = dtpDate.Value.Date;
                currentMeal = mealService.GetMealByDateAndMealType(date.Date, currentUser, Convert.ToInt32(selectedRow.Cells["clmId"].Value.ToString()));               
                dgvFoods.Rows.Clear();
                totalMealCalorie = 0;
                if (currentMeal != null)
                {
                    MealViewModel mealViewModel = new MealViewModel()
                    {
                        Id = currentMeal.Id,
                        Date = date.Date,
                        MealTypeName = selectedRow.Cells["clmMeal"].Value.ToString(),
                    };
                    mealViewModel.MealDetailsViewModel = mealDetailsService.GetFoodsByMealType(date.Date, currentUser, Convert.ToInt32(selectedRow.Cells["clmId"].Value.ToString()));
                    foreach (var mealDetails in mealViewModel.MealDetailsViewModel)
                    {
                        dgvFoods.Rows.Add(mealDetails.Id ,mealDetails.Food, mealDetails.Gram, mealDetails.Calorie, mealDetails.Image);
                    }
                    var mealDetailList= mealDetailsService.GetFoodsByMealType(date.Date, currentUser, Convert.ToInt32(selectedRow.Cells["clmId"].Value.ToString()));

                    foreach (var item in mealDetailList)
                    {

                        totalMealCalorie += item.Calorie;
                    }

                    lblMealCalorie.Text = "Total Calories in Daily : " + Math.Round(totalMealCalorie) + " kcal";
                }
            }
            catch (Exception)
            {
                
            }
        }
        private void FillMealTypes()
        {
            MealTypeService mealTypeService = new MealTypeService(context);
            List<MealTypeViewModel> mealTypeList = new List<MealTypeViewModel>();
            mealTypeList = mealTypeService.GetAllMealTypes();
            foreach (var mealType in mealTypeList)
            {
                dgvMeals.Rows.Add(mealType.Id, mealType.Name);
            }
        }
        private void FilterMeals()
        {
            try
            {
                dgvMeals.Rows.Clear();
                FillMealTypes();
                MealService mealService = new MealService(context);
                mealDetailsService= new MealDetailsService(context);
                List<MealViewModel> mealList = new List<MealViewModel>();
                mealList=mealService.GetMealsByDate(dtpDate.Value.Date);              
                totalDailyCalorie = 0;
                foreach (var meal in mealList)
                {                   

                    totalDailyCalorie += mealDetailsService.GetMealCalorieByMealId(meal.Id);
                }

                lblDailyCalorie.Text = "Total Calories in Daily : " + Math.Round(totalDailyCalorie) + " kcal";
            }
            catch (Exception)
            {
                MessageBox.Show("Could not found any information about selected date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblDailyCalorie.Text = "Total Calories in Daily : ";
            }
        }
        

        private void btnDeleteMeal_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvFoods.SelectedRows[0];
            MealDetailsService mealDetailsService = new MealDetailsService(context);
            MealDetailsDeleteDTO deleteMealDetail = new MealDetailsDeleteDTO
            {
                Id = Convert.ToInt32(selectedRow.Cells["clmId"].Value.ToString()),
            };
            mealDetailsService.DeleteMeal(deleteMealDetail);

            FilterMeals();
        }

        private void dgvMeals_SelectionChanged(object sender, EventArgs e)
        {
            FillMealDetails();
        }
    }
}
