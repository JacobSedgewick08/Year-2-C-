namespace Ticketsales
{
    partial class form1
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
            this.txtTicketsSold = new System.Windows.Forms.TextBox();
            this.btnCalculateSales = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblTicketsSold = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtTicketsSold
            // 
            this.txtTicketsSold.Location = new System.Drawing.Point(28, 57);
            this.txtTicketsSold.Name = "txtTicketsSold";
            this.txtTicketsSold.Size = new System.Drawing.Size(133, 20);
            this.txtTicketsSold.TabIndex = 0;
            // 
            // btnCalculateSales
            // 
            this.btnCalculateSales.Location = new System.Drawing.Point(28, 124);
            this.btnCalculateSales.Name = "btnCalculateSales";
            this.btnCalculateSales.Size = new System.Drawing.Size(133, 53);
            this.btnCalculateSales.TabIndex = 1;
            this.btnCalculateSales.Text = "Calculate Sales";
            this.btnCalculateSales.UseVisualStyleBackColor = true;
            this.btnCalculateSales.Click += new System.EventHandler(this.btnCalculateSales_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(28, 211);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(133, 85);
            this.txtMessage.TabIndex = 2;
            // 
            // lblTicketsSold
            // 
            this.lblTicketsSold.AutoSize = true;
            this.lblTicketsSold.Location = new System.Drawing.Point(167, 64);
            this.lblTicketsSold.Name = "lblTicketsSold";
            this.lblTicketsSold.Size = new System.Drawing.Size(190, 13);
            this.lblTicketsSold.TabIndex = 3;
            this.lblTicketsSold.Text = "Please enter the amount of tickets sold";
            this.lblTicketsSold.Click += new System.EventHandler(this.label1_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTicketsSold);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnCalculateSales);
            this.Controls.Add(this.txtTicketsSold);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTicketsSold;
        private System.Windows.Forms.Button btnCalculateSales;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblTicketsSold;
    }
}

