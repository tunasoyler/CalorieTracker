namespace UI
{
    partial class frmAddMeal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMeal));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnMeal = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimizeApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nudGram = new System.Windows.Forms.NumericUpDown();
            this.dgvMealTypes = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMeals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pbFoodImage = new System.Windows.Forms.PictureBox();
            this.cmbFoodList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.OliveDrab;
            this.panelMenu.Controls.Add(this.btnUser);
            this.panelMenu.Controls.Add(this.btnMeal);
            this.panelMenu.Controls.Add(this.btnReports);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMenu.Location = new System.Drawing.Point(0, 464);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(360, 40);
            this.panelMenu.TabIndex = 11;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.OliveDrab;
            this.btnUser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUser.BackgroundImage")));
            this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUser.Location = new System.Drawing.Point(255, 0);
            this.btnUser.Margin = new System.Windows.Forms.Padding(2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 40);
            this.btnUser.TabIndex = 3;
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnMeal
            // 
            this.btnMeal.BackColor = System.Drawing.Color.OliveDrab;
            this.btnMeal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMeal.BackgroundImage")));
            this.btnMeal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMeal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMeal.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMeal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMeal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMeal.Location = new System.Drawing.Point(180, 0);
            this.btnMeal.Margin = new System.Windows.Forms.Padding(2);
            this.btnMeal.Name = "btnMeal";
            this.btnMeal.Size = new System.Drawing.Size(75, 40);
            this.btnMeal.TabIndex = 2;
            this.btnMeal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnMeal.UseVisualStyleBackColor = false;
            this.btnMeal.Click += new System.EventHandler(this.frmAddMeal_Load);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.OliveDrab;
            this.btnReports.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReports.BackgroundImage")));
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnReports.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReports.Location = new System.Drawing.Point(105, 0);
            this.btnReports.Margin = new System.Windows.Forms.Padding(2);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(75, 40);
            this.btnReports.TabIndex = 1;
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.OliveDrab;
            this.btnHome.BackgroundImage = global::UI.Properties.Resources.home_button;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHome.Location = new System.Drawing.Point(30, 0);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 40);
            this.btnHome.TabIndex = 0;
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
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
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.OliveDrab;
            this.panelTitleBar.Controls.Add(this.btnMinimizeApp);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(360, 40);
            this.panelTitleBar.TabIndex = 9;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(142, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "MEAL";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.OliveDrab;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 504);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(360, 16);
            this.panelBottom.TabIndex = 8;
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
            this.btnCloseApp.TabIndex = 10;
            this.btnCloseApp.Text = "X";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dgvFoods);
            this.panel1.Location = new System.Drawing.Point(10, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 162);
            this.panel1.TabIndex = 12;
            // 
            // dgvFoods
            // 
            this.dgvFoods.AllowUserToAddRows = false;
            this.dgvFoods.AllowUserToOrderColumns = true;
            this.dgvFoods.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clmGram,
            this.clmCalorie,
            this.clmImage});
            this.dgvFoods.Location = new System.Drawing.Point(-3, -1);
            this.dgvFoods.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.RowHeadersVisible = false;
            this.dgvFoods.RowHeadersWidth = 51;
            this.dgvFoods.RowTemplate.Height = 29;
            this.dgvFoods.Size = new System.Drawing.Size(341, 159);
            this.dgvFoods.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Food Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // clmGram
            // 
            this.clmGram.HeaderText = "Gram";
            this.clmGram.MinimumWidth = 6;
            this.clmGram.Name = "clmGram";
            this.clmGram.Width = 60;
            // 
            // clmCalorie
            // 
            this.clmCalorie.HeaderText = "Calorie";
            this.clmCalorie.MinimumWidth = 6;
            this.clmCalorie.Name = "clmCalorie";
            this.clmCalorie.Width = 60;
            // 
            // clmImage
            // 
            this.clmImage.HeaderText = "Picture";
            this.clmImage.Name = "clmImage";
            this.clmImage.Width = 125;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(248, 228);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteFood.TabIndex = 42;
            this.btnDeleteFood.Text = "Delete Food";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Location = new System.Drawing.Point(159, 161);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(80, 30);
            this.btnAddFood.TabIndex = 41;
            this.btnAddFood.Text = "Add Food";
            this.btnAddFood.UseVisualStyleBackColor = true;
            this.btnAddFood.Click += new System.EventHandler(this.btnAddFood_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(156, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Gram :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudGram
            // 
            this.nudGram.BackColor = System.Drawing.SystemColors.ControlLight;
            this.nudGram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudGram.Location = new System.Drawing.Point(160, 122);
            this.nudGram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudGram.Name = "nudGram";
            this.nudGram.Size = new System.Drawing.Size(70, 25);
            this.nudGram.TabIndex = 37;
            // 
            // dgvMealTypes
            // 
            this.dgvMealTypes.AllowUserToDeleteRows = false;
            this.dgvMealTypes.AllowUserToOrderColumns = true;
            this.dgvMealTypes.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMealTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMealTypes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmMeals});
            this.dgvMealTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMealTypes.Location = new System.Drawing.Point(0, 0);
            this.dgvMealTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMealTypes.Name = "dgvMealTypes";
            this.dgvMealTypes.ReadOnly = true;
            this.dgvMealTypes.RowHeadersVisible = false;
            this.dgvMealTypes.RowHeadersWidth = 51;
            this.dgvMealTypes.RowTemplate.Height = 29;
            this.dgvMealTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMealTypes.Size = new System.Drawing.Size(138, 151);
            this.dgvMealTypes.TabIndex = 36;
            this.dgvMealTypes.SelectionChanged += new System.EventHandler(this.dgvMealTypes_SelectionChanged);
            // 
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.ReadOnly = true;
            this.clmId.Width = 30;
            // 
            // clmMeals
            // 
            this.clmMeals.HeaderText = "Meals";
            this.clmMeals.MinimumWidth = 6;
            this.clmMeals.Name = "clmMeals";
            this.clmMeals.ReadOnly = true;
            this.clmMeals.Width = 104;
            // 
            // pbFoodImage
            // 
            this.pbFoodImage.BackColor = System.Drawing.Color.Transparent;
            this.pbFoodImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoodImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbFoodImage.Location = new System.Drawing.Point(262, 117);
            this.pbFoodImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbFoodImage.Name = "pbFoodImage";
            this.pbFoodImage.Size = new System.Drawing.Size(86, 74);
            this.pbFoodImage.TabIndex = 35;
            this.pbFoodImage.TabStop = false;
            // 
            // cmbFoodList
            // 
            this.cmbFoodList.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbFoodList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFoodList.FormattingEnabled = true;
            this.cmbFoodList.Location = new System.Drawing.Point(159, 71);
            this.cmbFoodList.Name = "cmbFoodList";
            this.cmbFoodList.Size = new System.Drawing.Size(189, 23);
            this.cmbFoodList.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(159, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Food :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dgvMealTypes);
            this.panel2.Location = new System.Drawing.Point(10, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 153);
            this.panel2.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(9, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 45;
            this.label5.Text = "Total Calories in Meal :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAddMeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(360, 520);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnAddFood);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudGram);
            this.Controls.Add(this.pbFoodImage);
            this.Controls.Add(this.cmbFoodList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddMeal";
            this.Load += new System.EventHandler(this.frmAddMeal_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMealTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoodImage)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMenu;
        private Button btnUser;
        private Button btnMeal;
        private Button btnReports;
        private Button btnHome;
        private Panel panel3;
        private Panel panelTitleBar;
        private Button btnMinimizeApp;
        private Label label1;
        private Panel panelBottom;
        private Button btnCloseApp;
        private Panel panel1;
        private DataGridView dgvFoods;
        private Button btnDeleteFood;
        private Button btnAddFood;
        private Label label3;
        private NumericUpDown nudGram;
        private DataGridView dgvMealTypes;
        private PictureBox pbFoodImage;
        private ComboBox cmbFoodList;
        private Label label2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn clmGram;
        private DataGridViewTextBoxColumn clmCalorie;
        private DataGridViewImageColumn clmImage;
        private Panel panel2;
        private Label label5;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmMeals;
    }
}