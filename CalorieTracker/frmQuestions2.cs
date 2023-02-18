using BLL.Services;
using DAL;
using Entities.Concrete;
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
    public partial class frmQuestions2 : Form
    {
        private UserCreateDTO user;
        Context context = new Context();
        public frmQuestions2(UserCreateDTO user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.Text = string.Empty;
            this.user = user;
            CenterToScreen();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmQuestions2_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(640, 796);
            FillActivityTypes();
            
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnMinimizeApp_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtWeightGoal_Enter(object sender, EventArgs e)
        {
            if (txtWeightGoal.Text == "Enter")
            {
                txtWeightGoal.Text = string.Empty;
            }
        }

        private void txtWeightGoal_Leave(object sender, EventArgs e)
        {
            if (txtWeightGoal.Text == "")
            {
                txtWeightGoal.Text = "Enter";
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService(context);
            
            userService.AddUser(user);

            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService(context);
            ActivityTypeService activityTypeService = new ActivityTypeService(context);
            user.GoalWeight = Convert.ToDouble(txtWeightGoal.Text);
            user.Timeline = cmbTimeline.Text;
            user.ActivityType = activityTypeService.GetActivityTypeById((cmbActivityLevel.SelectedIndex+1));
            userService.BMRCalculate(user);
            userService.DailyCalorieLimitCalculate(user);
            lblDailyCalorieLimit.Text = user.DailyCalorieLimit.ToString()+" kcal";
        }

        private void FillActivityTypes()
        {
            ActivityTypeService activityTypeService = new ActivityTypeService(context);
            List<ActivityTypeViewModel> activityTypes = activityTypeService.ActivityTypeList();
            cmbActivityLevel.DataSource = activityTypes;
        }
    }
}
