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
    public partial class frmLogin : Form
    {
        frmSignUp signUpForm;
        frmMain mainFrm;

        User currentUser;

        Context context = new Context();
        private UserLoginDTO user;

        public frmLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.Text = string.Empty;
            //this.currentUser = user;
            CenterToScreen();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = string.Empty;
            }

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = string.Empty;
                txtPassword.PasswordChar = '*';
            }

        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.PasswordChar = default;
                txtPassword.Text = "Password";
            }
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            signUpForm = new frmSignUp();
            signUpForm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UserService userService = new UserService(context);
                user = new UserLoginDTO();
                


                user.UserName = txtUsername.Text;
                user.Password = txtPassword.Text;

                if (!userService.DoesUserExistLogin(user))
                {
                    MessageBox.Show("Username does not exists!");
                }
                else
                {
                    currentUser = userService.LoginUser(user);
                    if (currentUser.UserTypeId == 1)
                    {
                        frmAdminReport frmAdminReport = new frmAdminReport(currentUser);
                        frmAdminReport.Show();
                    }
                    else if (currentUser.UserTypeId == 2)
                    {
                        frmMain mainFrm = new frmMain(currentUser);
                        mainFrm.Show();
                    }

                    this.Hide();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Your password is not correct!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            





        }

    }
}


