namespace OnlineBanking
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInitialBalance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnDisplayBalance = new System.Windows.Forms.Button();
            this.btnMakeWithdrawal = new System.Windows.Forms.Button();
            this.btnMakeDeposit = new System.Windows.Forms.Button();
            this.txtMakeDeposit = new System.Windows.Forms.TextBox();
            this.txtMakeWithdrawal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtName.Location = new System.Drawing.Point(64, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            // 
            // txtInitialBalance
            // 
            this.txtInitialBalance.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtInitialBalance.Location = new System.Drawing.Point(64, 148);
            this.txtInitialBalance.Name = "txtInitialBalance";
            this.txtInitialBalance.Size = new System.Drawing.Size(100, 20);
            this.txtInitialBalance.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Initial Balance";
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOpen.Location = new System.Drawing.Point(34, 200);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(162, 92);
            this.btnOpen.TabIndex = 4;
            this.btnOpen.Text = "Open Account";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnDisplayBalance
            // 
            this.btnDisplayBalance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDisplayBalance.Location = new System.Drawing.Point(226, 200);
            this.btnDisplayBalance.Name = "btnDisplayBalance";
            this.btnDisplayBalance.Size = new System.Drawing.Size(165, 92);
            this.btnDisplayBalance.TabIndex = 5;
            this.btnDisplayBalance.Text = "Display Balance";
            this.btnDisplayBalance.UseVisualStyleBackColor = false;
            this.btnDisplayBalance.Click += new System.EventHandler(this.btnDisplayBalance_Click);
            // 
            // btnMakeWithdrawal
            // 
            this.btnMakeWithdrawal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMakeWithdrawal.Location = new System.Drawing.Point(602, 200);
            this.btnMakeWithdrawal.Name = "btnMakeWithdrawal";
            this.btnMakeWithdrawal.Size = new System.Drawing.Size(160, 92);
            this.btnMakeWithdrawal.TabIndex = 6;
            this.btnMakeWithdrawal.Text = "Withdraw money";
            this.btnMakeWithdrawal.UseVisualStyleBackColor = false;
            // 
            // btnMakeDeposit
            // 
            this.btnMakeDeposit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMakeDeposit.Location = new System.Drawing.Point(417, 200);
            this.btnMakeDeposit.Name = "btnMakeDeposit";
            this.btnMakeDeposit.Size = new System.Drawing.Size(159, 92);
            this.btnMakeDeposit.TabIndex = 7;
            this.btnMakeDeposit.Text = "Deposit Money";
            this.btnMakeDeposit.UseVisualStyleBackColor = false;
            // 
            // txtMakeDeposit
            // 
            this.txtMakeDeposit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMakeDeposit.Location = new System.Drawing.Point(417, 162);
            this.txtMakeDeposit.Name = "txtMakeDeposit";
            this.txtMakeDeposit.Size = new System.Drawing.Size(100, 20);
            this.txtMakeDeposit.TabIndex = 8;
            // 
            // txtMakeWithdrawal
            // 
            this.txtMakeWithdrawal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMakeWithdrawal.Location = new System.Drawing.Point(602, 162);
            this.txtMakeWithdrawal.Name = "txtMakeWithdrawal";
            this.txtMakeWithdrawal.Size = new System.Drawing.Size(100, 20);
            this.txtMakeWithdrawal.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount to deposit";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(599, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amount to withdraw";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMakeWithdrawal);
            this.Controls.Add(this.txtMakeDeposit);
            this.Controls.Add(this.btnMakeDeposit);
            this.Controls.Add(this.btnMakeWithdrawal);
            this.Controls.Add(this.btnDisplayBalance);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInitialBalance);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInitialBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnDisplayBalance;
        private System.Windows.Forms.Button btnMakeWithdrawal;
        private System.Windows.Forms.Button btnMakeDeposit;
        private System.Windows.Forms.TextBox txtMakeDeposit;
        private System.Windows.Forms.TextBox txtMakeWithdrawal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

