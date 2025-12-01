namespace Constantorvowel
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
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnletter = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblLetter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtLetter
            // 
            this.txtLetter.Location = new System.Drawing.Point(72, 96);
            this.txtLetter.Name = "txtLetter";
            this.txtLetter.Size = new System.Drawing.Size(100, 20);
            this.txtLetter.TabIndex = 0;
            // 
            // btnletter
            // 
            this.btnletter.Location = new System.Drawing.Point(72, 137);
            this.btnletter.Name = "btnletter";
            this.btnletter.Size = new System.Drawing.Size(113, 62);
            this.btnletter.TabIndex = 1;
            this.btnletter.Text = "Press Button to see what the letter is";
            this.btnletter.UseVisualStyleBackColor = true;
            this.btnletter.Click += new System.EventHandler(this.btnletter_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(72, 219);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(140, 50);
            this.txtMessage.TabIndex = 2;
            // 
            // lblLetter
            // 
            this.lblLetter.AutoSize = true;
            this.lblLetter.Location = new System.Drawing.Point(178, 103);
            this.lblLetter.Name = "lblLetter";
            this.lblLetter.Size = new System.Drawing.Size(101, 13);
            this.lblLetter.TabIndex = 3;
            this.lblLetter.Text = "Please enter a letter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLetter);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnletter);
            this.Controls.Add(this.txtLetter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnletter;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label lblLetter;
    }
}

