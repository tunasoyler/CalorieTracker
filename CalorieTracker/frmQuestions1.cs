﻿using BLL.Services;
using DAL;
using Entities.Concrete;
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
    public partial class frmQuestions1 : Form
    {
        private User user;
        Context context = new Context();
        public frmQuestions1(User user)
        {
            //tüm formlarda kopyalanacak
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.Text = string.Empty;
            this.user= user;
            CenterToScreen();
            //tmfk son
        }
        //tüm formlarda kopyalanacak
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //tmfk son

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

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txtWeight_Enter(object sender, EventArgs e)
        {
            if (txtWeight.Text == "Enter")
            {
                txtWeight.Text = string.Empty;
            }
        }

        private void txtWeight_Leave(object sender, EventArgs e)
        {
            if (txtWeight.Text == "")
            {
                txtWeight.Text = "Enter";
            }
        }

        private void txtHeight_Enter(object sender, EventArgs e)
        {
            if (txtHeight.Text == "Enter")
            {
                txtHeight.Text = string.Empty;
            }

        }

        private void txtHeight_Leave(object sender, EventArgs e)
        {
            if (txtHeight.Text == "")
            {
                txtHeight.Text = "Enter";
            }
        }

        private void frmQuestions1_Load(object sender, EventArgs e)
        {
            GenderService genderService = new GenderService(context);
            dtpBirthDate.Value = DateTime.Now;
            cmbGender.Items.Clear();
            
            foreach (var item in genderService.GenderList())
            {
                cmbGender.Items.Add(item);
            }
                
        }

        frmQuestions2 frmQuestions2;
        private void btnNext_Click(object sender, EventArgs e)
        {

            user.Gender = (Genders)cmbGender.SelectedItem;
            user.BirthDate = dtpBirthDate.Value;
            user.Weight=Convert.ToDouble(txtWeight.Text);
            user.Height=Convert.ToDouble(txtHeight.Text);
            this.Hide();
            frmQuestions2= new frmQuestions2(user);
            frmQuestions2.Show();
        }
    }
}
