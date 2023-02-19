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
            try
            {
                mealDetailsService = new MealDetailsService(context);

                List<MealDetails> mealDetailsList = mealDetailsService.GetAll();

                dgvFoods.Rows.Clear();
                totalMealCalorie = 0;

                foreach (var meal in mealDetailsList)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvFoods);
                    row.Cells[0].Value = meal.Food.Name;
                    row.Cells[1].Value = meal.Food.Calorie;
                    row.Cells[2].Value = meal.Gram;
                    row.Cells[3].Value = Math.Round(meal.Food.Calorie * meal.Gram);

                    dgvFoods.Rows.Add(row);

                    totalMealCalorie += meal.Food.Calorie * meal.Gram;
                }
            }
            catch (Exception)
            {
                lblMealCalorie.Text = "Total Calories in Meal : ";
            }

        }
        private void FilterMeals()
        {
            try
            {
                MealService mealService = new MealService(context);
                MealDetailsService mealDetailsService= new MealDetailsService(context);

                List<Meal> mealList = mealService.GetMealsByDate(dtpDate.Value.Date);

                dgvMeals.Rows.Clear();
                totalDailyCalorie = 0;

                foreach (var meal in mealList)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvMeals);
                    row.Cells[0].Value = meal.Id;
                    row.Cells[1].Value = meal.MealType;
                    row.Cells[2].Value = meal.CreatedDate.ToString("tt:ss");
                    dgvMeals.Rows.Add(row);

                    totalDailyCalorie += mealDetailsService.GetMealCalorieByMeal(meal);
                }

                lblDailyCalorie.Text = "Total Calories in Daily : " + totalDailyCalorie + " kcal";
            }
            catch (Exception)
            {
                MessageBox.Show("Could not found any information about selected date.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblDailyCalorie.Text = "Total Calories in Daily : ";
            }
        }
       

        private void btnDeleteMeal_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvMeals.SelectedRows[0];
            MealService mealService = new MealService(context);
            MealDeleteDTO deleteMeal = new MealDeleteDTO
            {
                Id = Convert.ToInt32(selectedRow.Cells["clmId"].Value.ToString()),
            };
            mealService.DeleteMeal(deleteMeal);

            FilterMeals();
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
    }
}
