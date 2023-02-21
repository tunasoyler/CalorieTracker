namespace UI
{
    partial class frmAdminUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdminUpdate));
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizeApp = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnAdminMeal = new System.Windows.Forms.Button();
            this.btnAdminReports = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.nmdUnitCalorie = new System.Windows.Forms.NumericUpDown();
            this.btnPictureOpenDialog = new System.Windows.Forms.Button();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFoodName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmFoodCalorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.pbFoodPicture = new System.Windows.Forms.PictureBox();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmdUnitCalorie)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.OliveDrab;
            this.panelTitleBar.Controls.Add(this.btnCloseApp);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.btnMinimizeApp);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(360, 40);
            this.panelTitleBar.TabIndex = 5;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCloseApp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCloseApp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnCloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Location = new System.Drawing.Point(320, 10);
            this.btnCloseApp.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(28, 24);
            this.btnCloseApp.TabIndex = 5;
            this.btnCloseApp.Text = "X";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(129, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "UPDATE";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimizeApp
            // 
            this.btnMinimizeApp.BackColor = System.Drawing.Color.OliveDrab;
            this.btnMinimizeApp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnMinimizeApp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnMinimizeApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnMinimizeApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnMinimizeApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeApp.Location = new System.Drawing.Point(280, 10);
            this.btnMinimizeApp.Margin = new System.Windows.Forms.Padding(2);
            this.btnMinimizeApp.Name = "btnMinimizeApp";
            this.btnMinimizeApp.Size = new System.Drawing.Size(28, 24);
            this.btnMinimizeApp.TabIndex = 4;
            this.btnMinimizeApp.Text = "_";
            this.btnMinimizeApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizeApp.UseVisualStyleBackColor = false;
            this.btnMinimizeApp.Click += new System.EventHandler(this.btnMinimizeApp_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.OliveDrab;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 504);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(360, 16);
            this.panelBottom.TabIndex = 6;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.OliveDrab;
            this.panelMenu.Controls.Add(this.btnAdminMeal);
            this.panelMenu.Controls.Add(this.btnAdminReports);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 464);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(360, 40);
            this.panelMenu.TabIndex = 7;
            // 
            // btnAdminMeal
            // 
            this.btnAdminMeal.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAdminMeal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminMeal.BackgroundImage")));
            this.btnAdminMeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdminMeal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdminMeal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdminMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminMeal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdminMeal.Location = new System.Drawing.Point(180, 0);
            this.btnAdminMeal.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminMeal.Name = "btnAdminMeal";
            this.btnAdminMeal.Size = new System.Drawing.Size(150, 40);
            this.btnAdminMeal.TabIndex = 2;
            this.btnAdminMeal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminMeal.UseVisualStyleBackColor = false;
            this.btnAdminMeal.Click += new System.EventHandler(this.btnMeal_Click);
            // 
            // btnAdminReports
            // 
            this.btnAdminReports.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAdminReports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdminReports.BackgroundImage")));
            this.btnAdminReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdminReports.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAdminReports.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAdminReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminReports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdminReports.Location = new System.Drawing.Point(30, 0);
            this.btnAdminReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdminReports.Name = "btnAdminReports";
            this.btnAdminReports.Size = new System.Drawing.Size(150, 40);
            this.btnAdminReports.TabIndex = 1;
            this.btnAdminReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdminReports.UseVisualStyleBackColor = false;
            this.btnAdminReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OliveDrab;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 40);
            this.panel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nmdUnitCalorie);
            this.panel1.Controls.Add(this.btnPictureOpenDialog);
            this.panel1.Controls.Add(this.txtFoodName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 170);
            this.panel1.TabIndex = 9;
            // 
            // nmdUnitCalorie
            // 
            this.nmdUnitCalorie.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nmdUnitCalorie.DecimalPlaces = 2;
            this.nmdUnitCalorie.Location = new System.Drawing.Point(114, 88);
            this.nmdUnitCalorie.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.nmdUnitCalorie.Name = "nmdUnitCalorie";
            this.nmdUnitCalorie.Size = new System.Drawing.Size(216, 23);
            this.nmdUnitCalorie.TabIndex = 12;
            // 
            // btnPictureOpenDialog
            // 
            this.btnPictureOpenDialog.Location = new System.Drawing.Point(42, 127);
            this.btnPictureOpenDialog.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnPictureOpenDialog.Name = "btnPictureOpenDialog";
            this.btnPictureOpenDialog.Size = new System.Drawing.Size(259, 23);
            this.btnPictureOpenDialog.TabIndex = 11;
            this.btnPictureOpenDialog.Text = "Add Picture";
            this.btnPictureOpenDialog.UseVisualStyleBackColor = true;
            this.btnPictureOpenDialog.Click += new System.EventHandler(this.btnPictureOpenDialog_Click);
            // 
            // txtFoodName
            // 
            this.txtFoodName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFoodName.Location = new System.Drawing.Point(115, 48);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(216, 23);
            this.txtFoodName.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(3, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Unit Calorie:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(3, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Food Name:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(81, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "FOOD INFORMATIONS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvFoodList);
            this.panel2.Location = new System.Drawing.Point(11, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 220);
            this.panel2.TabIndex = 10;
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.AllowUserToAddRows = false;
            this.dgvFoodList.AllowUserToOrderColumns = true;
            this.dgvFoodList.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmFoodName,
            this.clmFoodCalorie,
            this.clmImage});
            this.dgvFoodList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFoodList.Location = new System.Drawing.Point(0, 0);
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.RowHeadersVisible = false;
            this.dgvFoodList.RowTemplate.Height = 25;
            this.dgvFoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFoodList.Size = new System.Drawing.Size(231, 218);
            this.dgvFoodList.TabIndex = 0;
            this.dgvFoodList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodList_CellClick);
            this.dgvFoodList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodList_CellContentClick);
            this.dgvFoodList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoodList_CellDoubleClick);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            // 
            // clmFoodName
            // 
            this.clmFoodName.HeaderText = "FoodName";
            this.clmFoodName.Name = "clmFoodName";
            this.clmFoodName.Width = 80;
            // 
            // clmFoodCalorie
            // 
            this.clmFoodCalorie.HeaderText = "UnitCalorie";
            this.clmFoodCalorie.Name = "clmFoodCalorie";
            this.clmFoodCalorie.Width = 50;
            // 
            // clmImage
            // 
            this.clmImage.HeaderText = "Image";
            this.clmImage.Name = "clmImage";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(250, 338);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(250, 378);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 30);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(250, 419);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // pbFoodPicture
            // 
            this.pbFoodPicture.Location = new System.Drawing.Point(250, 229);
            this.pbFoodPicture.Name = "pbFoodPicture";
            this.pbFoodPicture.Size = new System.Drawing.Size(100, 86);
            this.pbFoodPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoodPicture.TabIndex = 12;
            this.pbFoodPicture.TabStop = false;
            // 
            // frmAdminUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(360, 520);
            this.ControlBox = false;
            this.Controls.Add(this.pbFoodPicture);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdminUpdate";
            this.Load += new System.EventHandler(this.frmAdminUpdate_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmdUnitCalorie)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelTitleBar;
        private Button btnCloseApp;
        private Label label1;
        private Button btnMinimizeApp;
        private Panel panelBottom;
        private Panel panelMenu;
        private Button btnAdminMeal;
        private Button btnAdminReports;
        private Panel panel3;
        private Panel panel1;
        private TextBox txtFoodName;
        private Label label4;
        private Label label2;
        private Panel panel2;
        private Label label5;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnPictureOpenDialog;
        private PictureBox pbFoodPicture;
        private NumericUpDown nmdUnitCalorie;
        private DataGridView dgvFoodList;
        private DataGridViewTextBoxColumn clmFoodName;
        private DataGridViewTextBoxColumn clmFoodCalorie;
        private DataGridViewImageColumn clmImage;
        private DataGridViewTextBoxColumn clmId;
    }
}