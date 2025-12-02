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
            // 
            // btnVacateRoom
            // 
            this.btnVacateRoom.Location = new System.Drawing.Point(153, 193);
            this.btnVacateRoom.Name = "btnVacateRoom";
            this.btnVacateRoom.Size = new System.Drawing.Size(110, 51);
            this.btnVacateRoom.TabIndex = 1;
            this.btnVacateRoom.Text = "Vacate Room";
            this.btnVacateRoom.UseVisualStyleBackColor = true;
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.btnShowIncome);
            this.grpInfo.Controls.Add(this.btnCountCustomers);
            this.grpInfo.Location = new System.Drawing.Point(426, 47);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(328, 281);
            this.grpInfo.TabIndex = 2;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "Hotel Information";
            this.grpInfo.Visible = false;
            // 
            // btnShowIncome
            // 
            this.btnShowIncome.Location = new System.Drawing.Point(16, 151);
            this.btnShowIncome.Name = "btnShowIncome";
            this.btnShowIncome.Size = new System.Drawing.Size(109, 46);
            this.btnShowIncome.TabIndex = 3;
            this.btnShowIncome.Text = "Income";
            this.btnShowIncome.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

