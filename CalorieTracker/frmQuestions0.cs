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
using static Syncfusion.Windows.Forms.TabBar;

namespace UI
{
    public partial class frmQuestions0 : Form
    {
        frmQuestions1 frmQuestions1;
        private UserCreateDTO user;        
        public frmQuestions0(UserCreateDTO user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.Text = string.Empty;
            this.user= user;
            CenterToScreen();            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnNext_Click(object sender, EventArgs e)
        {                      
            frmQuestions1 = new frmQuestions1(user);
            frmQuestions1.Show();
            this.Hide();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmQuestions0_Load(object sender, EventArgs e)
        {
            
        }
    }
}
