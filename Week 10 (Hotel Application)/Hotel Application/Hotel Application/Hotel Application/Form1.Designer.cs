namespace Hotel_Application
{
    partial class Form1
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
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.btnVacateRoom = new System.Windows.Forms.Button();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.btnShowIncome = new System.Windows.Forms.Button();
            this.btnCountCustomers = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblAmountOfCustomers = new System.Windows.Forms.Label();
            this.txtAmountofCustomers = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblReport = new System.Windows.Forms.Label();
            this.txtReport = new System.Windows.Forms.TextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.txtRoomNumber = new System.Windows.Forms.TextBox();
            this.grpInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.Location = new System.Drawing.Point(12, 193);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(112, 51);
            this.btnBookRoom.TabIndex = 0;
            this.btnBookRoom.Text = "Book Room";
            this.btnBookRoom.UseVisualStyleBackColor = true;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // btnVacateRoom
            // 
            this.btnVacateRoom.Location = new System.Drawing.Point(153, 193);
            this.btnVacateRoom.Name = "btnVacateRoom";
            this.btnVacateRoom.Size = new System.Drawing.Size(110, 51);
            this.btnVacateRoom.TabIndex = 1;
            this.btnVacateRoom.Text = "Vacate Room";
            this.btnVacateRoom.UseVisualStyleBackColor = true;
            this.btnVacateRoom.Click += new System.EventHandler(this.btnVacateRoom_Click);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnShowIncome);
            this.grpInfo.Controls.Add(this.btnCountCustomers);
            this.grpInfo.Location = new System.Drawing.Point(426, 47);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(328, 114);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Hotel Information";
            this.grpInfo.Visible = false;
            // 
            // btnShowIncome
            // 
            this.btnShowIncome.Location = new System.Drawing.Point(174, 39);
            this.btnShowIncome.Name = "btnShowIncome";
            this.btnShowIncome.Size = new System.Drawing.Size(109, 46);
            this.btnShowIncome.TabIndex = 3;
            this.btnShowIncome.Text = "Income";
            this.btnShowIncome.UseVisualStyleBackColor = true;
            this.btnShowIncome.Click += new System.EventHandler(this.btnShowIncome_Click);
            // 
            // btnCountCustomers
            // 
            this.btnCountCustomers.Location = new System.Drawing.Point(16, 39);
            this.btnCountCustomers.Name = "btnCountCustomers";
            this.btnCountCustomers.Size = new System.Drawing.Size(109, 44);
            this.btnCountCustomers.TabIndex = 0;
            this.btnCountCustomers.Text = "Count Customers";
            this.btnCountCustomers.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(168, 325);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(125, 44);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Log in";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(9, 315);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(132, 13);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Enter Employee Username";
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(9, 379);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(130, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Enter Employee Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 395);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 6;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(12, 340);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 7;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 70);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(88, 13);
            this.lblName.TabIndex = 8;
            this.lblName.Text = "Enter Your Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(15, 86);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 9;
            // 
            // lblAmountOfCustomers
            // 
            this.lblAmountOfCustomers.AutoSize = true;
            this.lblAmountOfCustomers.Location = new System.Drawing.Point(9, 125);
            this.lblAmountOfCustomers.Name = "lblAmountOfCustomers";
            this.lblAmountOfCustomers.Size = new System.Drawing.Size(164, 13);
            this.lblAmountOfCustomers.TabIndex = 10;
            this.lblAmountOfCustomers.Text = "How many Customers are coming";
            // 
            // txtAmountofCustomers
            // 
            this.txtAmountofCustomers.Location = new System.Drawing.Point(15, 141);
            this.txtAmountofCustomers.Name = "txtAmountofCustomers";
            this.txtAmountofCustomers.Size = new System.Drawing.Size(100, 20);
            this.txtAmountofCustomers.TabIndex = 11;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(168, 379);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(125, 45);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Location = new System.Drawing.Point(439, 182);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(39, 13);
            this.lblReport.TabIndex = 13;
            this.lblReport.Text = "Report";
            // 
            // txtReport
            // 
            this.txtReport.Location = new System.Drawing.Point(442, 198);
            this.txtReport.Multiline = true;
            this.txtReport.Name = "txtReport";
            this.txtReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReport.Size = new System.Drawing.Size(312, 240);
            this.txtReport.TabIndex = 14;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(290, 193);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(101, 51);
            this.btnReport.TabIndex = 15;
            this.btnReport.Text = "Show Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Location = new System.Drawing.Point(188, 70);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(75, 13);
            this.lblRoomNumber.TabIndex = 16;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // txtRoomNumber
            // 
            this.txtRoomNumber.Location = new System.Drawing.Point(191, 86);
            this.txtRoomNumber.Name = "txtRoomNumber";
            this.txtRoomNumber.Size = new System.Drawing.Size(100, 20);
            this.txtRoomNumber.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRoomNumber);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.txtReport);
            this.Controls.Add(this.lblReport);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.txtAmountofCustomers);
            this.Controls.Add(this.lblAmountOfCustomers);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.btnVacateRoom);
            this.Controls.Add(this.btnBookRoom);
            this.Name = "Form1";
            this.Text = "Hotel System";
            this.grpInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.Button btnVacateRoom;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Button btnCountCustomers;
        private System.Windows.Forms.Button btnShowIncome;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAmountOfCustomers;
        private System.Windows.Forms.TextBox txtAmountofCustomers;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.TextBox txtReport;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.TextBox txtRoomNumber;
    }
}

