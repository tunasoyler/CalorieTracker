namespace UI
{
    partial class frmQuestions2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuestions2));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnBegin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizeApp = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeightGoal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDailyCalorieLimit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTimeline = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbActivityLevel = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.OliveDrab;
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 465);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(2);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(360, 55);
            this.panelBottom.TabIndex = 40;
            // 
            // btnBegin
            // 
            this.btnBegin.BackColor = System.Drawing.Color.OliveDrab;
            this.btnBegin.Location = new System.Drawing.Point(230, 410);
            this.btnBegin.Margin = new System.Windows.Forms.Padding(2);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(100, 30);
            this.btnBegin.TabIndex = 41;
            this.btnBegin.Text = "Begin";
            this.btnBegin.UseVisualStyleBackColor = false;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(109, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 35);
            this.label1.TabIndex = 10;
            this.label1.Text = "QUESTIONS";
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
            this.btnMinimizeApp.TabIndex = 0;
            this.btnMinimizeApp.Text = "_";
            this.btnMinimizeApp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinimizeApp.UseVisualStyleBackColor = false;
            this.btnMinimizeApp.Click += new System.EventHandler(this.btnMinimizeApp_Click);
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
            this.btnCloseApp.TabIndex = 0;
            this.btnCloseApp.Text = "X";
            this.btnCloseApp.UseVisualStyleBackColor = false;
            this.btnCloseApp.Click += new System.EventHandler(this.btnCloseApp_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.OliveDrab;
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Controls.Add(this.btnMinimizeApp);
            this.panelTitleBar.Controls.Add(this.btnCloseApp);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(360, 41);
            this.panelTitleBar.TabIndex = 39;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 57);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(316, 192);
            this.label5.TabIndex = 50;
            this.label5.Text = resources.GetString("label5.Text");
            // 
            // txtWeightGoal
            // 
            this.txtWeightGoal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtWeightGoal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeightGoal.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWeightGoal.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtWeightGoal.Location = new System.Drawing.Point(215, 231);
            this.txtWeightGoal.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeightGoal.Name = "txtWeightGoal";
            this.txtWeightGoal.Size = new System.Drawing.Size(61, 22);
            this.txtWeightGoal.TabIndex = 54;
            this.txtWeightGoal.Text = "Enter";
            this.txtWeightGoal.Enter += new System.EventHandler(this.txtWeightGoal_Enter);
            this.txtWeightGoal.Leave += new System.EventHandler(this.txtWeightGoal_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(25, 231);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 48;
            this.label3.Text = "Goal Weight:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(25, 255);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 1);
            this.panel3.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(25, 301);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 1);
            this.panel4.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 22);
            this.label2.TabIndex = 48;
            this.label2.Text = "Timeline:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 367);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 22);
            this.label4.TabIndex = 48;
            this.label4.Text = "Daily calorie limit:";
            // 
            // lblDailyCalorieLimit
            // 
            this.lblDailyCalorieLimit.AutoSize = true;
            this.lblDailyCalorieLimit.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDailyCalorieLimit.Location = new System.Drawing.Point(215, 367);
            this.lblDailyCalorieLimit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDailyCalorieLimit.Name = "lblDailyCalorieLimit";
            this.lblDailyCalorieLimit.Size = new System.Drawing.Size(59, 22);
            this.lblDailyCalorieLimit.TabIndex = 48;
            this.lblDailyCalorieLimit.Text = "0 kcal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(25, 391);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 1);
            this.panel1.TabIndex = 42;
            // 
            // cmbTimeline
            // 
            this.cmbTimeline.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbTimeline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTimeline.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbTimeline.FormattingEnabled = true;
            this.cmbTimeline.Items.AddRange(new object[] {
            "6 months",
            "12 months"});
            this.cmbTimeline.Location = new System.Drawing.Point(215, 273);
            this.cmbTimeline.Margin = new System.Windows.Forms.Padding(2);
            this.cmbTimeline.Name = "cmbTimeline";
            this.cmbTimeline.Size = new System.Drawing.Size(121, 26);
            this.cmbTimeline.TabIndex = 55;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(280, 231);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 22);
            this.label7.TabIndex = 48;
            this.label7.Text = "kg";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(25, 346);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 1);
            this.panel2.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(25, 322);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 22);
            this.label8.TabIndex = 48;
            this.label8.Text = "Activity Level:";
            // 
            // cmbActivityLevel
            // 
            this.cmbActivityLevel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbActivityLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbActivityLevel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbActivityLevel.FormattingEnabled = true;
            this.cmbActivityLevel.Location = new System.Drawing.Point(215, 318);
            this.cmbActivityLevel.Margin = new System.Windows.Forms.Padding(2);
            this.cmbActivityLevel.Name = "cmbActivityLevel";
            this.cmbActivityLevel.Size = new System.Drawing.Size(121, 26);
            this.cmbActivityLevel.TabIndex = 55;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCalculate.Location = new System.Drawing.Point(34, 410);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 56;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmQuestions2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(360, 520);
            this.ControlBox = false;
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.cmbActivityLevel);
            this.Controls.Add(this.cmbTimeline);
            this.Controls.Add(this.txtWeightGoal);
            this.Controls.Add(this.lblDailyCalorieLimit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.btnBegin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuestions2";
            this.Load += new System.EventHandler(this.frmQuestions2_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panelBottom;
        private Button btnBegin;
        private Label label1;
        private Button btnMinimizeApp;
        private Button btnCloseApp;
        private Panel panelTitleBar;
        private Label label5;
        private TextBox txtWeightGoal;
        private Label label3;
        private Panel panel3;
        private Panel panel4;
        private Label label2;
        private Label label4;
        private Label lblDailyCalorieLimit;
        private Panel panel1;
        private ComboBox cmbTimeline;
        private Label label7;
        private Panel panel2;
        private Label label8;
        private ComboBox cmbActivityLevel;
        private Button btnCalculate;
    }
}