using BLL.Services;
using DAL;
using Entities.Concrete;
using Entities.Dtos.FoodDtos;
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
    public partial class frmAdminUpdate : Form
    {
        frmAdminReport AdminReportForm;
        frmAdminUpdate AdminUpdateForm;

        Context context = new Context();
        User currentUser;

        private Button currentButton;
        public frmAdminUpdate(User user)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.ControlBox = false;
            this.currentUser= user;
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

        private void btnReports_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            this.Hide();
            AdminReportForm = new frmAdminReport(currentUser);
            AdminReportForm.Show();
        }

        private void btnMeal_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);            
        }

        private void btnPictureOpenDialog_Click(object sender, EventArgs e)
        {
            Image image = null;
            OpenFileDialog openFileDialog = new()
            {
                InitialDirectory = "C://Destkop",
                Filter = "Image files (*.jpg, *.png) | *.jpg; *.png",
                Title = "Resim dosyası yükleyin"
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog.FileName);
                pbFoodPicture.Image = image;
                pbFoodPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        
    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text.Trim() == "")
            {
                MessageBox.Show("Yemek eklemek için yemek adı girişi zorunludur");
                return;
            }
            try
            {
                FoodService foodService = new FoodService(context);
                FoodCreateDTO food = new FoodCreateDTO
                {
                    FoodName = txtFoodName.Text,
                    Calorie = (double)nmdUnitCalorie.Value,
                    Image = ImageToByteArray(pbFoodPicture.Image)

                };
                foodService.AddFood(food);
                FillFoods();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        private void FillFoods()
        {
            FoodService foodService = new FoodService(context);
            List<FoodViewModel> foodList = new List<FoodViewModel>();
            dgvFoodList.Rows.Clear();

            foodList = foodService.GetAllFoods();
                           

            foreach (var food in foodList)
            {
                dgvFoodList.Rows.Add(food.Id,food.Name, food.Calorie, food.Image);
            }
        }
        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            if (imageIn != null)
            {
                using (var ms = new MemoryStream())
                {
                    imageIn.Save(ms, imageIn.RawFormat);
                    return ms.ToArray();
                }
            }
            return null;
        }
        FoodUpdateDTO updateFood = new FoodUpdateDTO();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFoodName.Text.Trim() == "")
            {
                MessageBox.Show("Yemek eklemek için yemek adı girişi zorunludur");
                return;
            }
            try
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                FoodService foodService = new FoodService(context);
                updateFood = new FoodUpdateDTO
                {
                    Id= Convert.ToInt32(selectedRow.Cells["clmId"].Value.ToString()),
                    FoodName = txtFoodName.Text,
                    Calorie = (double)nmdUnitCalorie.Value,
                    Image = ImageToByteArray(pbFoodPicture.Image),

                };
                foodService.UpdateFood(updateFood);
                FillFoods();
                btnUpdate.Enabled = false;
                btnAdd.Enabled = btnDelete.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
            FoodService foodService = new FoodService(context);
            FoodDeleteDTO deleteFood = new FoodDeleteDTO
            {
                Id = Convert.ToInt32(selectedRow.Cells["clmId"].Value.ToString()),               
            };
            foodService.DeleteFood(deleteFood);
            FillFoods();
        }

        private void frmAdminUpdate_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnAdd.Enabled = btnDelete.Enabled = true;
            FillFoods();
        }

        private void dgvFoodList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
        }
        private byte[] GetBytes()
        {
            return ImageToByteArray(pbFoodPicture.Image);
        }
        private void dgvFoodList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFoodList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
                btnUpdate.Enabled = true;
                btnAdd.Enabled = btnDelete.Enabled = false;               
                updateFood.FoodName = selectedRow.Cells["clmFoodName"].Value.ToString();
                updateFood.Calorie = Convert.ToDouble(selectedRow.Cells["clmFoodCalorie"].Value);
                updateFood.Image = (byte[])selectedRow.Cells["clmImage"].Value;
                txtFoodName.Text = updateFood.FoodName;
                byte[] bytes = GetBytes();
                bytes = updateFood.Image;
                //pbFoodPicture.Image = updateFood.Image;
                if (updateFood.Calorie == null)
                    nmdUnitCalorie.Value = 0;
                else
                    nmdUnitCalorie.Value = (decimal)updateFood.Calorie;

            }
        }

        private void dgvFoodList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
