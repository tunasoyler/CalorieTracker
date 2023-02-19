using BLL.Services;
using DAL;
using Entities.Concrete;
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
    public partial class frmAdminReport : Form
    {
        frmAdminReport AdminReportForm;
        frmAdminUpdate AdminUpdateForm;

        User currentUser;

        MealService mealService;
        Context context = new Context();

        private Button currentButton;
        public frmAdminReport(User user)
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

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Hide();
            AdminUpdateForm = new frmAdminUpdate(currentUser);
            AdminUpdateForm.Show();
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

        private void frmAdminReport_Load(object sender, EventArgs e)
        {
            FillCmbMeals();            
        }

        public void FillCmbMeals()
        {
            mealService = new MealService(context);
            List<MealViewModel> mealList = mealService.MealList();

            cmbMeals.Items.Clear();

            foreach (var item in mealList)
            {
                cmbMeals.Items.Add(item);
            }
        }
        private void cmbMeals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvTotalByMeal.Items.Clear();
            List<ReportVm> meals = _mealDetailService.GetTopTenProduct(x => x.Meal.MealType.TypeName == ((MealTypeVm)cmbMealType.SelectedItem).MealTypeName);
            FillListView(meals, lvTotalByMeal);
        }

        private void FillListView(List<ReportVm> meals, ListView listView)
        {
            listView.Items.Clear();
            foreach (var product in meals)
            {
                string[] newProduct = { product.Key, product.Toplam.ToString() };
                var row = new ListViewItem(newProduct);
                listView.Items.Add(row);
            }
        }


    }
}
