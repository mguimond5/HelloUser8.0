namespace HelloUser8._0
{
    partial class frmHelloUser
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
            this.btnHelloUser = new System.Windows.Forms.Button();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserNumber = new System.Windows.Forms.Label();
            this.txtUserNumber = new System.Windows.Forms.TextBox();
            this.lblDisplay2 = new System.Windows.Forms.Label();
            this.lblDisplay3 = new System.Windows.Forms.Label();
            this.btnClickMeSecond = new System.Windows.Forms.Button();
            this.lblDisplay4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHelloUser
            // 
            this.btnHelloUser.Location = new System.Drawing.Point(89, 12);
            this.btnHelloUser.Name = "btnHelloUser";
            this.btnHelloUser.Size = new System.Drawing.Size(95, 32);
            this.btnHelloUser.TabIndex = 0;
            this.btnHelloUser.Text = "Click me!";
            this.btnHelloUser.UseVisualStyleBackColor = true;
            this.btnHelloUser.Click += new System.EventHandler(this.btnHelloUser_Click);
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(89, 47);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblDisplay.TabIndex = 1;
            this.lblDisplay.Click += new System.EventHandler(this.lblDisplay_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(86, 70);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(38, 13);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Name:";
            this.lblUserName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(145, 67);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(98, 20);
            this.txtUserName.TabIndex = 3;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblUserNumber
            // 
            this.lblUserNumber.Location = new System.Drawing.Point(41, 105);
            this.lblUserNumber.Name = "lblUserNumber";
            this.lblUserNumber.Size = new System.Drawing.Size(98, 14);
            this.lblUserNumber.TabIndex = 4;
            this.lblUserNumber.Text = "Favourite Number:";
            this.lblUserNumber.Click += new System.EventHandler(this.lblUserNumber_Click);
            // 
            // txtUserNumber
            // 
            this.txtUserNumber.Location = new System.Drawing.Point(145, 99);
            this.txtUserNumber.Name = "txtUserNumber";
            this.txtUserNumber.Size = new System.Drawing.Size(98, 20);
            this.txtUserNumber.TabIndex = 5;
            this.txtUserNumber.TextChanged += new System.EventHandler(this.txtUserNumber_TextChanged);
            // 
            // lblDisplay2
            // 
            this.lblDisplay2.Location = new System.Drawing.Point(65, 135);
            this.lblDisplay2.Name = "lblDisplay2";
            this.lblDisplay2.Size = new System.Drawing.Size(74, 28);
            this.lblDisplay2.TabIndex = 6;
            this.lblDisplay2.Click += new System.EventHandler(this.lblDisplay2_Click);
            // 
            // lblDisplay3
            // 
            this.lblDisplay3.Location = new System.Drawing.Point(145, 135);
            this.lblDisplay3.Name = "lblDisplay3";
            this.lblDisplay3.Size = new System.Drawing.Size(82, 28);
            this.lblDisplay3.TabIndex = 7;
            this.lblDisplay3.Click += new System.EventHandler(this.lblDisplay3_Click);
            // 
            // btnClickMeSecond
            // 
            this.btnClickMeSecond.Location = new System.Drawing.Point(89, 166);
            this.btnClickMeSecond.Name = "btnClickMeSecond";
            this.btnClickMeSecond.Size = new System.Drawing.Size(109, 23);
            this.btnClickMeSecond.TabIndex = 8;
            this.btnClickMeSecond.Text = "Click me second!";
            this.btnClickMeSecond.UseVisualStyleBackColor = true;
            this.btnClickMeSecond.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblDisplay4
            // 
            this.lblDisplay4.AutoSize = true;
            this.lblDisplay4.Location = new System.Drawing.Point(65, 150);
            this.lblDisplay4.Name = "lblDisplay4";
            this.lblDisplay4.Size = new System.Drawing.Size(0, 13);
            this.lblDisplay4.TabIndex = 9;
            // 
            // frmHelloUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblDisplay4);
            this.Controls.Add(this.btnClickMeSecond);
            this.Controls.Add(this.lblDisplay3);
            this.Controls.Add(this.lblDisplay2);
            this.Controls.Add(this.txtUserNumber);
            this.Controls.Add(this.lblUserNumber);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.btnHelloUser);
            this.Name = "frmHelloUser";
            this.Text = "Hello User";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelloUser;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserNumber;
        private System.Windows.Forms.TextBox txtUserNumber;
        private System.Windows.Forms.Label lblDisplay2;
        private System.Windows.Forms.Label lblDisplay3;
        private System.Windows.Forms.Button btnClickMeSecond;
        private System.Windows.Forms.Label lblDisplay4;
    }
}

