﻿namespace UI
{
    partial class frmReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReports));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnMinimizeApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnMeal = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnFilter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.btnDeleteFood = new System.Windows.Forms.Button();
            this.btnDeleteMeal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmGram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalCalorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clmMeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.OliveDrab;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 504);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(360, 16);
            this.panelBottom.TabIndex = 7;
            // 
            // btnCloseApp
            // 
            this.btnCloseApp.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCloseApp.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCloseApp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCloseApp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnCloseApp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnCloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseApp.Location = new System.Drawing.Point(318, 10);
            this.btnCloseApp.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseApp.Name = "btnCloseApp";
            this.btnCloseApp.Size = new System.Drawing.Size(28, 24);
            this.btnCloseApp.TabIndex = 10;
            this.btnCloseApp.Text = "X";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
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
            this.label1.Location = new System.Drawing.Point(123, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "REPORTS";
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
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
            this.btnMeal.Click += new System.EventHandler(this.btnMeal_Click);
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
            this.panelMenu.TabIndex = 8;
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarForeColor = System.Drawing.SystemColors.Window;
            this.dtpDate.CalendarTitleBackColor = System.Drawing.SystemColors.Window;
            this.dtpDate.CalendarTitleForeColor = System.Drawing.SystemColors.Window;
            this.dtpDate.CalendarTrailingForeColor = System.Drawing.SystemColors.Window;
            this.dtpDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpDate.Location = new System.Drawing.Point(12, 62);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(220, 26);
            this.dtpDate.TabIndex = 11;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(246, 62);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(100, 30);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(10, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Total Calories in Meal :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(10, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total Calories in Daily :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // btnDeleteFood
            // 
            this.btnDeleteFood.Location = new System.Drawing.Point(246, 418);
            this.btnDeleteFood.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDeleteFood.Name = "btnDeleteFood";
            this.btnDeleteFood.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteFood.TabIndex = 20;
            this.btnDeleteFood.Text = "Delete Food";
            this.btnDeleteFood.UseVisualStyleBackColor = true;
            // 
            // btnDeleteMeal
            // 
            this.btnDeleteMeal.Location = new System.Drawing.Point(246, 196);
            this.btnDeleteMeal.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnDeleteMeal.Name = "btnDeleteMeal";
            this.btnDeleteMeal.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteMeal.TabIndex = 21;
            this.btnDeleteMeal.Text = "Delete Meal";
            this.btnDeleteMeal.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.clmGram,
            this.clmTotalCalorie});
            this.dataGridView1.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(334, 156);
            this.dataGridView1.TabIndex = 22;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Food Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Unit Calorie";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // clmGram
            // 
            this.clmGram.HeaderText = "Gram";
            this.clmGram.Name = "clmGram";
            this.clmGram.Width = 50;
            // 
            // clmTotalCalorie
            // 
            this.clmTotalCalorie.HeaderText = "Total Calorie";
            this.clmTotalCalorie.Name = "clmTotalCalorie";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(12, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(334, 156);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 131);
            this.panel1.TabIndex = 24;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMeal,
            this.clmTime});
            this.dataGridView2.Location = new System.Drawing.Point(-1, -1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(230, 131);
            this.dataGridView2.TabIndex = 23;
            // 
            // clmMeal
            // 
            this.clmMeal.HeaderText = "Meal";
            this.clmMeal.Name = "clmMeal";
            this.clmMeal.Width = 140;
            // 
            // clmTime
            // 
            this.clmTime.HeaderText = "Time";
            this.clmTime.Name = "clmTime";
            this.clmTime.Width = 80;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(360, 520);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnDeleteFood);
            this.Controls.Add(this.btnDeleteMeal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmReports";
            this.Load += new System.EventHandler(this.frmStatistics_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelBottom;
        private Button btnCloseApp;
        private Button btnMinimizeApp;
        private Label label1;
        private Panel panelTitleBar;
        private Button btnUser;
        private Button btnMeal;
        private Button btnReports;
        private Button btnHome;
        private Panel panel3;
        private Panel panelMenu;
        private DateTimePicker dtpDate;
        private Button btnFilter;
        private Label label5;
        private Label label2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Button btnDeleteFood;
        private Button btnDeleteMeal;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn clmGram;
        private DataGridViewTextBoxColumn clmTotalCalorie;
        private DataGridViewTextBoxColumn clmMeal;
        private DataGridViewTextBoxColumn clmTime;
    }
}