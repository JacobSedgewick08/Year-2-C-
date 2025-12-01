namespace RoomArea
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
            this.btnCalulateArea = new System.Windows.Forms.Button();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblRoomArea = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.btnCalculateVolume = new System.Windows.Forms.Button();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblCalculateVolume = new System.Windows.Forms.Label();
            this.lblHeight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalulateArea
            // 
            this.btnCalulateArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalulateArea.Location = new System.Drawing.Point(111, 238);
            this.btnCalulateArea.Name = "btnCalulateArea";
            this.btnCalulateArea.Size = new System.Drawing.Size(100, 47);
            this.btnCalulateArea.TabIndex = 0;
            this.btnCalulateArea.Text = "Calculate Area";
            this.btnCalulateArea.UseVisualStyleBackColor = true;
            this.btnCalulateArea.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.Color.White;
            this.txtLength.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtLength.Location = new System.Drawing.Point(111, 100);
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(100, 20);
            this.txtLength.TabIndex = 1;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(111, 176);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 2;
            this.txtWidth.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(111, 328);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 3;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(108, 84);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(68, 13);
            this.lblLength.TabIndex = 4;
            this.lblLength.Text = "Enter Length";
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(108, 160);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(63, 13);
            this.lblWidth.TabIndex = 5;
            this.lblWidth.Text = "Enter Width";
            this.lblWidth.Click += new System.EventHandler(this.lblWidth_Click);
            // 
            // lblRoomArea
            // 
            this.lblRoomArea.AutoSize = true;
            this.lblRoomArea.Location = new System.Drawing.Point(108, 312);
            this.lblRoomArea.Name = "lblRoomArea";
            this.lblRoomArea.Size = new System.Drawing.Size(60, 13);
            this.lblRoomArea.TabIndex = 7;
            this.lblRoomArea.Text = "Room Area";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(297, 176);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(100, 20);
            this.txtHeight.TabIndex = 8;
            // 
            // btnCalculateVolume
            // 
            this.btnCalculateVolume.Location = new System.Drawing.Point(297, 238);
            this.btnCalculateVolume.Name = "btnCalculateVolume";
            this.btnCalculateVolume.Size = new System.Drawing.Size(100, 47);
            this.btnCalculateVolume.TabIndex = 9;
            this.btnCalculateVolume.Text = "Calculate Volume";
            this.btnCalculateVolume.UseVisualStyleBackColor = true;
            this.btnCalculateVolume.Click += new System.EventHandler(this.btnCalculateVolume_Click);
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(297, 328);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(100, 20);
            this.txtVolume.TabIndex = 10;
            // 
            // lblCalculateVolume
            // 
            this.lblCalculateVolume.AutoSize = true;
            this.lblCalculateVolume.Location = new System.Drawing.Point(294, 312);
            this.lblCalculateVolume.Name = "lblCalculateVolume";
            this.lblCalculateVolume.Size = new System.Drawing.Size(73, 13);
            this.lblCalculateVolume.TabIndex = 11;
            this.lblCalculateVolume.Text = "Room Volume";
            this.lblCalculateVolume.Click += new System.EventHandler(this.lblCalculateVolume_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(301, 160);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(66, 13);
            this.lblHeight.TabIndex = 12;
            this.lblHeight.Text = "Enter Height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHeight);
            this.Controls.Add(this.lblCalculateVolume);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.btnCalculateVolume);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.lblRoomArea);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.btnCalulateArea);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Room Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalulateArea;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblRoomArea;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Button btnCalculateVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblCalculateVolume;
        private System.Windows.Forms.Label lblHeight;
    }
}

