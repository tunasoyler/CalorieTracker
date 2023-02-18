namespace UI
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnMeal = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnMinimizeApp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
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
            this.panelBottom.TabIndex = 1;
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
            this.panelMenu.TabIndex = 2;
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
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.OliveDrab;
            this.panelTitleBar.Controls.Add(this.btnCloseApp);
            this.panelTitleBar.Controls.Add(this.btnMinimizeApp);
            this.panelTitleBar.Controls.Add(this.label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(2);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(360, 40);
            this.panelTitleBar.TabIndex = 3;
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
            this.label1.Location = new System.Drawing.Point(144, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "USER";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(119, 362);
            this.btnChangePassword.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(123, 33);
            this.btnChangePassword.TabIndex = 22;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(49, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Confirm New Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "New Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(49, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Current Password:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(49, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Username:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(49, 157);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(263, 23);
            this.txtUsername.TabIndex = 9;
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtConfirmNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(49, 314);
            this.txtConfirmNewPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.PasswordChar = '*';
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(263, 23);
            this.txtConfirmNewPassword.TabIndex = 12;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPassword.Location = new System.Drawing.Point(49, 209);
            this.txtCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.PasswordChar = '*';
            this.txtCurrentPassword.Size = new System.Drawing.Size(263, 23);
            this.txtCurrentPassword.TabIndex = 10;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Location = new System.Drawing.Point(49, 262);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '*';
            this.txtNewPassword.Size = new System.Drawing.Size(263, 23);
            this.txtNewPassword.TabIndex = 11;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(360, 520);
            this.ControlBox = false;
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtConfirmNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelBottom;
        private Panel panelMenu;
        private Button btnUser;
        private Button btnMeal;
        private Button btnReports;
        private Button btnHome;
        private Panel panel3;
        private Panel panelTitleBar;
        private Button btnMinimizeApp;
        private Label label1;
        private Button btnCloseApp;
        private TextBox txtUsername;
        private TextBox txtConfirmNewPassword;
        private TextBox txtCurrentPassword;
        private TextBox txtNewPassword;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button btnChangePassword;
    }
}