namespace Conversions
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
            this.txtFeet = new System.Windows.Forms.TextBox();
            this.txtMetres = new System.Windows.Forms.TextBox();
            this.txtPounds = new System.Windows.Forms.TextBox();
            this.txtKilograms = new System.Windows.Forms.TextBox();
            this.txtGallons = new System.Windows.Forms.TextBox();
            this.txtLitres = new System.Windows.Forms.TextBox();
            this.btnMetrestofeet = new System.Windows.Forms.Button();
            this.btnKilogramstopounds = new System.Windows.Forms.Button();
            this.btnLitrestogallons = new System.Windows.Forms.Button();
            this.lblFeet = new System.Windows.Forms.Label();
            this.lblMetres = new System.Windows.Forms.Label();
            this.lblPounds = new System.Windows.Forms.Label();
            this.lblKilograms = new System.Windows.Forms.Label();
            this.lblLitres = new System.Windows.Forms.Label();
            this.lblGallons = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtFeet
            // 
            this.txtFeet.Location = new System.Drawing.Point(380, 70);
            this.txtFeet.Name = "txtFeet";
            this.txtFeet.Size = new System.Drawing.Size(100, 20);
            this.txtFeet.TabIndex = 0;
            // 
            // txtMetres
            // 
            this.txtMetres.Location = new System.Drawing.Point(137, 70);
            this.txtMetres.Name = "txtMetres";
            this.txtMetres.Size = new System.Drawing.Size(100, 20);
            this.txtMetres.TabIndex = 1;
            // 
            // txtPounds
            // 
            this.txtPounds.Location = new System.Drawing.Point(380, 167);
            this.txtPounds.Name = "txtPounds";
            this.txtPounds.Size = new System.Drawing.Size(100, 20);
            this.txtPounds.TabIndex = 2;
            this.txtPounds.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtKilograms
            // 
            this.txtKilograms.Location = new System.Drawing.Point(137, 167);
            this.txtKilograms.Name = "txtKilograms";
            this.txtKilograms.Size = new System.Drawing.Size(100, 20);
            this.txtKilograms.TabIndex = 3;
            // 
            // txtGallons
            // 
            this.txtGallons.Location = new System.Drawing.Point(380, 254);
            this.txtGallons.Name = "txtGallons";
            this.txtGallons.Size = new System.Drawing.Size(100, 20);
            this.txtGallons.TabIndex = 4;
            this.txtGallons.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtLitres
            // 
            this.txtLitres.Location = new System.Drawing.Point(137, 254);
            this.txtLitres.Name = "txtLitres";
            this.txtLitres.Size = new System.Drawing.Size(100, 20);
            this.txtLitres.TabIndex = 5;
            // 
            // btnMetrestofeet
            // 
            this.btnMetrestofeet.Location = new System.Drawing.Point(258, 60);
            this.btnMetrestofeet.Name = "btnMetrestofeet";
            this.btnMetrestofeet.Size = new System.Drawing.Size(101, 60);
            this.btnMetrestofeet.TabIndex = 6;
            this.btnMetrestofeet.Text = "Convert Metres to feet";
            this.btnMetrestofeet.UseVisualStyleBackColor = true;
            this.btnMetrestofeet.Click += new System.EventHandler(this.btnMetrestofeet_Click);
            // 
            // btnKilogramstopounds
            // 
            this.btnKilogramstopounds.Location = new System.Drawing.Point(258, 167);
            this.btnKilogramstopounds.Name = "btnKilogramstopounds";
            this.btnKilogramstopounds.Size = new System.Drawing.Size(101, 51);
            this.btnKilogramstopounds.TabIndex = 7;
            this.btnKilogramstopounds.Text = "Convert Kilograms to Pounds";
            this.btnKilogramstopounds.UseVisualStyleBackColor = true;
            this.btnKilogramstopounds.Click += new System.EventHandler(this.btnKilogramstopounds_Click);
            // 
            // btnLitrestogallons
            // 
            this.btnLitrestogallons.Location = new System.Drawing.Point(258, 245);
            this.btnLitrestogallons.Name = "btnLitrestogallons";
            this.btnLitrestogallons.Size = new System.Drawing.Size(101, 59);
            this.btnLitrestogallons.TabIndex = 8;
            this.btnLitrestogallons.Text = "Convert Litres to Gallons";
            this.btnLitrestogallons.UseVisualStyleBackColor = true;
            this.btnLitrestogallons.Click += new System.EventHandler(this.btnLitrestogallons_Click);
            // 
            // lblFeet
            // 
            this.lblFeet.AutoSize = true;
            this.lblFeet.Location = new System.Drawing.Point(409, 107);
            this.lblFeet.Name = "lblFeet";
            this.lblFeet.Size = new System.Drawing.Size(28, 13);
            this.lblFeet.TabIndex = 9;
            this.lblFeet.Text = "Feet";
            // 
            // lblMetres
            // 
            this.lblMetres.AutoSize = true;
            this.lblMetres.Location = new System.Drawing.Point(169, 107);
            this.lblMetres.Name = "lblMetres";
            this.lblMetres.Size = new System.Drawing.Size(39, 13);
            this.lblMetres.TabIndex = 10;
            this.lblMetres.Text = "Metres";
            // 
            // lblPounds
            // 
            this.lblPounds.AutoSize = true;
            this.lblPounds.Location = new System.Drawing.Point(409, 205);
            this.lblPounds.Name = "lblPounds";
            this.lblPounds.Size = new System.Drawing.Size(43, 13);
            this.lblPounds.TabIndex = 11;
            this.lblPounds.Text = "Pounds";
            // 
            // lblKilograms
            // 
            this.lblKilograms.AutoSize = true;
            this.lblKilograms.Location = new System.Drawing.Point(169, 205);
            this.lblKilograms.Name = "lblKilograms";
            this.lblKilograms.Size = new System.Drawing.Size(52, 13);
            this.lblKilograms.TabIndex = 12;
            this.lblKilograms.Text = "Kilograms";
            // 
            // lblLitres
            // 
            this.lblLitres.AutoSize = true;
            this.lblLitres.Location = new System.Drawing.Point(169, 291);
            this.lblLitres.Name = "lblLitres";
            this.lblLitres.Size = new System.Drawing.Size(32, 13);
            this.lblLitres.TabIndex = 13;
            this.lblLitres.Text = "Litres";
            // 
            // lblGallons
            // 
            this.lblGallons.AutoSize = true;
            this.lblGallons.Location = new System.Drawing.Point(409, 291);
            this.lblGallons.Name = "lblGallons";
            this.lblGallons.Size = new System.Drawing.Size(42, 13);
            this.lblGallons.TabIndex = 14;
            this.lblGallons.Text = "Gallons";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGallons);
            this.Controls.Add(this.lblLitres);
            this.Controls.Add(this.lblKilograms);
            this.Controls.Add(this.lblPounds);
            this.Controls.Add(this.lblMetres);
            this.Controls.Add(this.lblFeet);
            this.Controls.Add(this.btnLitrestogallons);
            this.Controls.Add(this.btnKilogramstopounds);
            this.Controls.Add(this.btnMetrestofeet);
            this.Controls.Add(this.txtLitres);
            this.Controls.Add(this.txtGallons);
            this.Controls.Add(this.txtKilograms);
            this.Controls.Add(this.txtPounds);
            this.Controls.Add(this.txtMetres);
            this.Controls.Add(this.txtFeet);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFeet;
        private System.Windows.Forms.TextBox txtMetres;
        private System.Windows.Forms.TextBox txtPounds;
        private System.Windows.Forms.TextBox txtKilograms;
        private System.Windows.Forms.TextBox txtGallons;
        private System.Windows.Forms.TextBox txtLitres;
        private System.Windows.Forms.Button btnMetrestofeet;
        private System.Windows.Forms.Button btnKilogramstopounds;
        private System.Windows.Forms.Button btnLitrestogallons;
        private System.Windows.Forms.Label lblFeet;
        private System.Windows.Forms.Label lblMetres;
        private System.Windows.Forms.Label lblPounds;
        private System.Windows.Forms.Label lblKilograms;
        private System.Windows.Forms.Label lblLitres;
        private System.Windows.Forms.Label lblGallons;
    }
}

