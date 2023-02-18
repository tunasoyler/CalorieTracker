namespace UI
{
    partial class frmQuestions1
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimizeApp = new System.Windows.Forms.Button();
            this.btnCloseApp = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.panelBottom.TabIndex = 24;
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
            this.panelTitleBar.TabIndex = 20;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
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
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.OliveDrab;
            this.btnNext.Location = new System.Drawing.Point(230, 410);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 30);
            this.btnNext.TabIndex = 25;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(28, 217);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 1);
            this.panel1.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(23, 190);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 35;
            this.label2.Text = "Gender:";
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmbGender.DisplayMember = "1";
            this.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbGender.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Location = new System.Drawing.Point(173, 185);
            this.cmbGender.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(168, 30);
            this.cmbGender.TabIndex = 36;
            this.cmbGender.Text = " Select";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(28, 265);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 1);
            this.panel2.TabIndex = 31;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(28, 361);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(310, 1);
            this.panel4.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(28, 313);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(310, 1);
            this.panel3.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 241);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 22);
            this.label3.TabIndex = 35;
            this.label3.Text = "Birth Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(23, 290);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 35;
            this.label4.Text = "Weight:";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight;
            this.dtpBirthDate.Checked = false;
            this.dtpBirthDate.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpBirthDate.Location = new System.Drawing.Point(173, 235);
            this.dtpBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(168, 29);
            this.dtpBirthDate.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(23, 338);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 22);
            this.label8.TabIndex = 35;
            this.label8.Text = "Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(23, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(313, 120);
            this.label5.TabIndex = 35;
            this.label5.Text = "    So, let\'s get started by answering the \r\nfollowing questions about you to cal" +
    "culate \r\nyour BMR:\r\n\r\n\r\n";
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtWeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtWeight.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtWeight.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtWeight.Location = new System.Drawing.Point(174, 290);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(79, 22);
            this.txtWeight.TabIndex = 38;
            this.txtWeight.Text = "Enter";
            this.txtWeight.Enter += new System.EventHandler(this.txtWeight_Enter);
            this.txtWeight.Leave += new System.EventHandler(this.txtWeight_Leave);
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtHeight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHeight.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHeight.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtHeight.Location = new System.Drawing.Point(173, 336);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(80, 22);
            this.txtHeight.TabIndex = 38;
            this.txtHeight.Text = "Enter";
            this.txtHeight.Enter += new System.EventHandler(this.txtHeight_Enter);
            this.txtHeight.Leave += new System.EventHandler(this.txtHeight_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(299, 290);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 22);
            this.label7.TabIndex = 49;
            this.label7.Text = "kg";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(299, 336);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 22);
            this.label6.TabIndex = 49;
            this.label6.Text = "cm";
            // 
            // frmQuestions1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(360, 520);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.dtpBirthDate);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuestions1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmQuestions1_Load);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelBottom;
        private Panel panelTitleBar;
        private Label label1;
        private Button btnNext;
        private Panel panel1;
        private Label label2;
        private ComboBox cmbGender;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private DateTimePicker dtpBirthDate;
        private Label label8;
        private Label label5;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private Button btnMinimizeApp;
        private Button btnCloseApp;
        private Label label7;
        private Label label6;
    }
}