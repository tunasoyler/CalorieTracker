namespace UI.ChildForms
{
    partial class frmHome
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
            this.pnlDailyStats = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDailyStats = new System.Windows.Forms.ListView();
            this.clmMealType = new System.Windows.Forms.ColumnHeader();
            this.clmCalorie = new System.Windows.Forms.ColumnHeader();
            this.pnlDailyLimit = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cpbDailyLimit = new CircularProgressBar_NET5.CircularProgressBar();
            this.pnlGoalProgress.SuspendLayout();
            this.pnlDailyStats.SuspendLayout();
            this.pnlDailyLimit.SuspendLayout();
            this.SuspendLayout();
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
            this.pnlGoalProgress.Location = new System.Drawing.Point(22, 18);
            this.pnlGoalProgress.Name = "pnlGoalProgress";
            this.pnlGoalProgress.Size = new System.Drawing.Size(300, 180);
            this.pnlGoalProgress.TabIndex = 7;
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
            // pnlDailyStats
            // 
            this.pnlDailyStats.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDailyStats.Controls.Add(this.label3);
            this.pnlDailyStats.Controls.Add(this.lstDailyStats);
            this.pnlDailyStats.Location = new System.Drawing.Point(182, 204);
            this.pnlDailyStats.Name = "pnlDailyStats";
            this.pnlDailyStats.Size = new System.Drawing.Size(140, 200);
            this.pnlDailyStats.TabIndex = 8;
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
            // lstDailyStats
            // 
            this.lstDailyStats.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lstDailyStats.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstDailyStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmMealType,
            this.clmCalorie});
            this.lstDailyStats.FullRowSelect = true;
            this.lstDailyStats.Location = new System.Drawing.Point(3, 36);
            this.lstDailyStats.Name = "lstDailyStats";
            this.lstDailyStats.Size = new System.Drawing.Size(132, 159);
            this.lstDailyStats.TabIndex = 1;
            this.lstDailyStats.UseCompatibleStateImageBehavior = false;
            this.lstDailyStats.View = System.Windows.Forms.View.Details;
            // 
            // clmMealType
            // 
            this.clmMealType.Text = "MealType";
            this.clmMealType.Width = 80;
            // 
            // clmCalorie
            // 
            this.clmCalorie.Text = "Calorie";
            this.clmCalorie.Width = 53;
            // 
            // pnlDailyLimit
            // 
            this.pnlDailyLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDailyLimit.Controls.Add(this.label2);
            this.pnlDailyLimit.Controls.Add(this.cpbDailyLimit);
            this.pnlDailyLimit.Location = new System.Drawing.Point(22, 204);
            this.pnlDailyLimit.Name = "pnlDailyLimit";
            this.pnlDailyLimit.Size = new System.Drawing.Size(140, 200);
            this.pnlDailyLimit.TabIndex = 9;
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
            this.cpbDailyLimit.Location = new System.Drawing.Point(23, 20);
            this.cpbDailyLimit.MarqueeAnimationSpeed = 2000;
            this.cpbDailyLimit.Name = "cpbDailyLimit";
            this.cpbDailyLimit.OuterColor = System.Drawing.Color.DarkTurquoise;
            this.cpbDailyLimit.OuterMargin = -25;
            this.cpbDailyLimit.OuterWidth = 25;
            this.cpbDailyLimit.ProgressColor = System.Drawing.Color.SteelBlue;
            this.cpbDailyLimit.ProgressWidth = 25;
            this.cpbDailyLimit.SecondaryFont = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpbDailyLimit.Size = new System.Drawing.Size(99, 100);
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
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 385);
            this.Controls.Add(this.pnlGoalProgress);
            this.Controls.Add(this.pnlDailyStats);
            this.Controls.Add(this.pnlDailyLimit);
            this.Name = "frmHome";
            this.Text = "frmMain";
            this.pnlGoalProgress.ResumeLayout(false);
            this.pnlGoalProgress.PerformLayout();
            this.pnlDailyStats.ResumeLayout(false);
            this.pnlDailyStats.PerformLayout();
            this.pnlDailyLimit.ResumeLayout(false);
            this.pnlDailyLimit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlGoalProgress;
        private Label lblDay7;
        private Label lblDay6;
        private Label lblDay5;
        private Label lblDay4;
        private Label lblDay3;
        private Label lblDay2;
        private Label lblDay1;
        private Label label7;
        private Syncfusion.Windows.Forms.Chart.SparkLine sparkLine1;
        private Label lblStartDate;
        private Label lblGoalDate;
        private Label label4;
        private ProgressBar progressBar1;
        private Panel pnlDailyStats;
        private Label label3;
        private ListView lstDailyStats;
        private ColumnHeader clmMealType;
        private ColumnHeader clmCalorie;
        private Panel pnlDailyLimit;
        private Label label2;
        private CircularProgressBar_NET5.CircularProgressBar cpbDailyLimit;
    }
}