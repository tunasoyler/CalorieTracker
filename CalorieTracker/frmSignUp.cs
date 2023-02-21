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
using static Syncfusion.Windows.Forms.TabBar;
using System.Xml.Linq;
using BLL.Services;
using Microsoft.EntityFrameworkCore;
using Entities.Concrete;
using DAL;
using Entities.Dtos.UserDtos;

namespace UI
{
    public partial class frmSignUp : Form
    {
        frmQuestions0 frmQuestions0;
        public frmSignUp()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.Text = string.Empty;
            CenterToScreen();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

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

        private void txtRePassword_Enter(object sender, EventArgs e)
        {
            if (txtRePassword.Text == "Repeat Password")
            {
                txtRePassword.Text = string.Empty;
                txtRePassword.PasswordChar = '*';
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

        private void txtRePassword_Leave(object sender, EventArgs e)
        {
            if (txtRePassword.Text == "")
            {
                txtRePassword.PasswordChar = default;
                txtRePassword.Text = "Repeat Password";
            }
        }

        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "")
            {
                txtFirstName.Text = "First Name";
            }
        }

        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (txtLastName.Text == "")
            {
                txtLastName.Text = "Last Name";
            }
        }

        private void txtFirstName_Enter(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "First Name")
            {
                txtFirstName.Text = string.Empty;
            }
        }

        private void txtLastName_Enter(object sender, EventArgs e)
        {
            if (txtLastName.Text == "Last Name")
            {
                txtLastName.Text = string.Empty;
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
        Context context = new Context();
        private void btnRegister_Click(object sender, EventArgs e)
        {
            UserService userService = new UserService(context);

            UserCreateDTO user = new UserCreateDTO
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
            };
            if (userService.DoesUserExist(user))
            {
                MessageBox.Show("Username allready exists.");
            }
            else
            {
                frmQuestions0 = new frmQuestions0(user);
                frmQuestions0.Show();
                this.Hide();
            }
        }


    }
}
