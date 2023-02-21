namespace UI
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimizeApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.pnlDailyLimit = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cpbDailyLimit = new CircularProgressBar_NET5.CircularProgressBar();
            this.pnlDailyStats = new System.Windows.Forms.Panel();
            this.dgvMyMealsToday = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlGoalProgress = new System.Windows.Forms.Panel();
            this.lblDay7 = new System.Windows.Forms.Label();
            this.lblDay6 = new System.Windows.Forms.Label();
            this.lblDay5 = new System.Windows.Forms.Label();
            this.lblDay4 = new System.Windows.Forms.Label();
            this.lblDay3 = new System.Windows.Forms.Label();
            this.lblDay2 = new System.Windows.Forms.Label();
            this.lblDay1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.sparkLine1 = new Syncfusion.Windows.Forms.Chart.SparkLine();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblGoalDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnMeal = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMeals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCalorie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTitleBar.SuspendLayout();
            this.pnlDailyLimit.SuspendLayout();
            this.pnlDailyStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyMealsToday)).BeginInit();
            this.pnlGoalProgress.SuspendLayout();
            this.panelMenu.SuspendLayout();
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
            this.panelBottom.TabIndex = 0;
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
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
            this.label1.Location = new System.Drawing.Point(139, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "HOME";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
            this.btnCloseApp.TabIndex = 4;
            this.btnCloseApp.Text = "X";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // pnlDailyLimit
            // 
            this.pnlDailyLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDailyLimit.Controls.Add(this.label2);
            this.pnlDailyLimit.Controls.Add(this.cpbDailyLimit);
            this.pnlDailyLimit.Location = new System.Drawing.Point(30, 247);
            this.pnlDailyLimit.Name = "pnlDailyLimit";
            this.pnlDailyLimit.Size = new System.Drawing.Size(140, 200);
            this.pnlDailyLimit.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "My Daily\r\nLimit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpbDailyLimit
            // 
            this.cpbDailyLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cpbDailyLimit.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            this.cpbDailyLimit.AnimationSpeed = 500;
            this.cpbDailyLimit.BackColor = System.Drawing.Color.Transparent;
            this.cpbDailyLimit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpbDailyLimit.ForeColor = System.Drawing.Color.Black;
            this.cpbDailyLimit.InnerColor = System.Drawing.Color.Transparent;
            this.cpbDailyLimit.InnerMargin = 25;
            this.cpbDailyLimit.InnerWidth = 25;
            this.cpbDailyLimit.Location = new System.Drawing.Point(20, 20);
            this.cpbDailyLimit.MarqueeAnimationSpeed = 2000;
            this.cpbDailyLimit.Name = "cpbDailyLimit";
            this.cpbDailyLimit.OuterColor = System.Drawing.Color.DarkTurquoise;
            this.cpbDailyLimit.OuterMargin = -25;
            this.cpbDailyLimit.OuterWidth = 25;
            this.cpbDailyLimit.ProgressColor = System.Drawing.Color.SteelBlue;
            this.cpbDailyLimit.ProgressWidth = 25;
            this.cpbDailyLimit.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpbDailyLimit.Size = new System.Drawing.Size(100, 100);
            this.cpbDailyLimit.StartAngle = 270;
            this.cpbDailyLimit.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbDailyLimit.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbDailyLimit.SubscriptText = "";
            this.cpbDailyLimit.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbDailyLimit.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.cpbDailyLimit.SuperscriptText = "";
            this.cpbDailyLimit.TabIndex = 5;
            this.cpbDailyLimit.Text = "1900/2200";
            this.cpbDailyLimit.TextMargin = new System.Windows.Forms.Padding(1, 2, 0, 0);
            this.cpbDailyLimit.Value = 40;
            // 
            // pnlDailyStats
            // 
            this.pnlDailyStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDailyStats.Controls.Add(this.dgvMyMealsToday);
            this.pnlDailyStats.Controls.Add(this.label3);
            this.pnlDailyStats.Location = new System.Drawing.Point(190, 247);
            this.pnlDailyStats.Name = "pnlDailyStats";
            this.pnlDailyStats.Size = new System.Drawing.Size(140, 200);
            this.pnlDailyStats.TabIndex = 6;
            // 
            // dgvMyMealsToday
            // 
            this.dgvMyMealsToday.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvMyMealsToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyMealsToday.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmMeals,
            this.clmCalorie});
            this.dgvMyMealsToday.Location = new System.Drawing.Point(-1, 31);
            this.dgvMyMealsToday.Name = "dgvMyMealsToday";
            this.dgvMyMealsToday.RowHeadersVisible = false;
            this.dgvMyMealsToday.RowTemplate.Height = 25;
            this.dgvMyMealsToday.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyMealsToday.Size = new System.Drawing.Size(140, 168);
            this.dgvMyMealsToday.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "My Meals Today";
            // 
            // pnlGoalProgress
            // 
            this.pnlGoalProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlGoalProgress.Controls.Add(this.lblDay7);
            this.pnlGoalProgress.Controls.Add(this.lblDay6);
            this.pnlGoalProgress.Controls.Add(this.lblDay5);
            this.pnlGoalProgress.Controls.Add(this.lblDay4);
            this.pnlGoalProgress.Controls.Add(this.lblDay3);
            this.pnlGoalProgress.Controls.Add(this.lblDay2);
            this.pnlGoalProgress.Controls.Add(this.lblDay1);
            this.pnlGoalProgress.Controls.Add(this.label7);
            this.pnlGoalProgress.Controls.Add(this.sparkLine1);
            this.pnlGoalProgress.Controls.Add(this.lblStartDate);
            this.pnlGoalProgress.Controls.Add(this.lblGoalDate);
            this.pnlGoalProgress.Controls.Add(this.label4);
            this.pnlGoalProgress.Controls.Add(this.progressBar1);
            this.pnlGoalProgress.Location = new System.Drawing.Point(30, 61);
            this.pnlGoalProgress.Name = "pnlGoalProgress";
            this.pnlGoalProgress.Size = new System.Drawing.Size(300, 180);
            this.pnlGoalProgress.TabIndex = 6;
            // 
            // lblDay7
            // 
            this.lblDay7.AutoSize = true;
            this.lblDay7.Location = new System.Drawing.Point(245, 161);
            this.lblDay7.Name = "lblDay7";
            this.lblDay7.Size = new System.Drawing.Size(32, 15);
            this.lblDay7.TabIndex = 10;
            this.lblDay7.Text = "day7";
            // 
            // lblDay6
            // 
            this.lblDay6.AutoSize = true;
            this.lblDay6.Location = new System.Drawing.Point(208, 161);
            this.lblDay6.Name = "lblDay6";
            this.lblDay6.Size = new System.Drawing.Size(32, 15);
            this.lblDay6.TabIndex = 10;
            this.lblDay6.Text = "day6";
            // 
            // lblDay5
            // 
            this.lblDay5.AutoSize = true;
            this.lblDay5.Location = new System.Drawing.Point(171, 161);
            this.lblDay5.Name = "lblDay5";
            this.lblDay5.Size = new System.Drawing.Size(32, 15);
            this.lblDay5.TabIndex = 10;
            this.lblDay5.Text = "day5";
            // 
            // lblDay4
            // 
            this.lblDay4.AutoSize = true;
            this.lblDay4.Location = new System.Drawing.Point(134, 161);
            this.lblDay4.Name = "lblDay4";
            this.lblDay4.Size = new System.Drawing.Size(32, 15);
            this.lblDay4.TabIndex = 10;
            this.lblDay4.Text = "day4";
            // 
            // lblDay3
            // 
            this.lblDay3.AutoSize = true;
            this.lblDay3.Location = new System.Drawing.Point(97, 161);
            this.lblDay3.Name = "lblDay3";
            this.lblDay3.Size = new System.Drawing.Size(32, 15);
            this.lblDay3.TabIndex = 10;
            this.lblDay3.Text = "day3";
            // 
            // lblDay2
            // 
            this.lblDay2.AutoSize = true;
            this.lblDay2.Location = new System.Drawing.Point(60, 161);
            this.lblDay2.Name = "lblDay2";
            this.lblDay2.Size = new System.Drawing.Size(32, 15);
            this.lblDay2.TabIndex = 10;
            this.lblDay2.Text = "day2";
            // 
            // lblDay1
            // 
            this.lblDay1.AutoSize = true;
            this.lblDay1.Location = new System.Drawing.Point(23, 161);
            this.lblDay1.Name = "lblDay1";
            this.lblDay1.Size = new System.Drawing.Size(32, 15);
            this.lblDay1.TabIndex = 10;
            this.lblDay1.Text = "day1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "Last 7 days";
            // 
            // sparkLine1
            // 
            this.sparkLine1.EndPoint = 10D;
            this.sparkLine1.HighPoint = 90D;
            this.sparkLine1.Location = new System.Drawing.Point(17, 86);
            this.sparkLine1.LowPoint = 10D;
            this.sparkLine1.Name = "sparkLine1";
            this.sparkLine1.NegativeItem = new double[] {
        0D,
        0D,
        0D,
        0D,
        0D};
            this.sparkLine1.Size = new System.Drawing.Size(263, 74);
            this.sparkLine1.Source = new double[] {
        20D,
        90D,
        30D,
        60D,
        10D};
            this.sparkLine1.StartPoint = 20D;
            this.sparkLine1.TabIndex = 9;
            this.sparkLine1.Text = "sparkLine1";
            this.sparkLine1.Type = Syncfusion.Windows.Forms.Chart.SparkLineType.Column;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStartDate.Location = new System.Drawing.Point(20, 55);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(51, 12);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "06.08.2023";
            // 
            // lblGoalDate
            // 
            this.lblGoalDate.AutoSize = true;
            this.lblGoalDate.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGoalDate.Location = new System.Drawing.Point(225, 55);
            this.lblGoalDate.Name = "lblGoalDate";
            this.lblGoalDate.Size = new System.Drawing.Size(51, 12);
            this.lblGoalDate.TabIndex = 7;
            this.lblGoalDate.Text = "06.08.2023";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(59, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Track Progress to Goal";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(43, 31);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(211, 21);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 30;
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
            this.panelMenu.TabIndex = 7;
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
            // clmId
            // 
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.Visible = false;
            // 
            // clmMeals
            // 
            this.clmMeals.HeaderText = "Meal ";
            this.clmMeals.Name = "clmMeals";
            this.clmMeals.Width = 75;
            // 
            // clmCalorie
            // 
            this.clmCalorie.HeaderText = "Calorie";
            this.clmCalorie.Name = "clmCalorie";
            this.clmCalorie.Width = 60;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(360, 520);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.btnCloseApp);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.pnlGoalProgress);
            this.Controls.Add(this.pnlDailyStats);
            this.Controls.Add(this.pnlDailyLimit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.pnlDailyLimit.ResumeLayout(false);
            this.pnlDailyLimit.PerformLayout();
            this.pnlDailyStats.ResumeLayout(false);
            this.pnlDailyStats.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyMealsToday)).EndInit();
            this.pnlGoalProgress.ResumeLayout(false);
            this.pnlGoalProgress.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelBottom;
        private Panel panelTitleBar;
        private Label label1;
        private Button btnCloseApp;
        private Button btnMinimizeApp;
        private Panel pnlDailyLimit;
        private Label label2;
        private CircularProgressBar_NET5.CircularProgressBar cpbDailyLimit;
        private Panel pnlDailyStats;
        private Label label3;
        private Panel pnlGoalProgress;
        private Label lblDay7;
        private Label lblDay6;
        private Label lblDay5;
        private Label lblDay4;
        private Label lblDay3;
        private Label lblDay2;
        private Label lblDay1;
        private Label lblStartDate;
        private Label lblGoalDate;
        private Label label4;
        private ProgressBar progressBar1;
        private Panel panelMenu;
        private Button btnUser;
        private Button btnMeal;
        private Button btnReports;
        private Button btnHome;
        private Panel panel3;
        private DataGridView dgvMyMealsToday;
        private Label label7;
        private Syncfusion.Windows.Forms.Chart.SparkLine sparkLine1;
        private DataGridViewTextBoxColumn clmId;
        private DataGridViewTextBoxColumn clmMeals;
        private DataGridViewTextBoxColumn clmCalorie;
    }
}