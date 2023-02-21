using BLL.Services;
using DAL;
using Entities.Concrete;
using Entities.Dtos.UserDtos;
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
    public partial class frmUser : Form
    {

        frmReports statisticsForm;
        frmUser userForm;
        frmAddMeal addMealForm;
        frmMain mainForm;

        Context context = new Context();
        User currentUser;
        UserChangePasswordDTO changePasswordDTO;

        private Button currentButton;
        public frmUser(User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.currentUser = user;
            txtUsername.Text = user.Name;
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
            userForm = new frmUser(currentUser);
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                UserService userService = new UserService(context);
                changePasswordDTO = new UserChangePasswordDTO();

                changePasswordDTO.NewPassword = txtCurrentPassword.Text;
                changePasswordDTO.Id = currentUser.Id;

                if (txtNewPassword.Text == txtConfirmNewPassword.Text)
                {
                    changePasswordDTO.OldPassword = txtCurrentPassword.Text;
                    changePasswordDTO.NewPassword = txtNewPassword.Text;
                    userService.ChangePassword(changePasswordDTO);

                    MessageBox.Show("Your password succesfully changed!");
                }
                else
                {
                    MessageBox.Show("Your passwords are not matching!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Your old password is incorrect!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
