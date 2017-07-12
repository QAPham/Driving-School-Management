namespace WindowsFormsApplication4
{
    partial class btnRegisterClient
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
            this.buttonToLogin = new System.Windows.Forms.Button();
            this.buttonRegisterClient = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxSurname = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.btnRegisterAdmin = new System.Windows.Forms.Button();
            this.btnRegisterInstructor = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxLevel = new System.Windows.Forms.ComboBox();
            this.lblNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonToLogin
            // 
            this.buttonToLogin.Location = new System.Drawing.Point(157, 490);
            this.buttonToLogin.Name = "buttonToLogin";
            this.buttonToLogin.Size = new System.Drawing.Size(362, 45);
            this.buttonToLogin.TabIndex = 0;
            this.buttonToLogin.Text = "Already have an account? Login.";
            this.buttonToLogin.UseVisualStyleBackColor = true;
            this.buttonToLogin.Click += new System.EventHandler(this.buttonToLogin_Click);
            // 
            // buttonRegisterClient
            // 
            this.buttonRegisterClient.Location = new System.Drawing.Point(157, 430);
            this.buttonRegisterClient.Name = "buttonRegisterClient";
            this.buttonRegisterClient.Size = new System.Drawing.Size(118, 44);
            this.buttonRegisterClient.TabIndex = 1;
            this.buttonRegisterClient.Text = "Register Client";
            this.buttonRegisterClient.UseVisualStyleBackColor = true;
            this.buttonRegisterClient.Click += new System.EventHandler(this.buttonRegisterClient_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(286, 145);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(171, 20);
            this.textBoxPassword.TabIndex = 2;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(286, 324);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(171, 20);
            this.textBoxPhone.TabIndex = 3;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(286, 281);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(171, 20);
            this.textBoxEmail.TabIndex = 4;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.Location = new System.Drawing.Point(286, 233);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.Size = new System.Drawing.Size(171, 20);
            this.textBoxSurname.TabIndex = 5;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(286, 187);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(171, 20);
            this.textBoxFirstName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Surname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Email Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone No.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 29);
            this.label6.TabIndex = 12;
            this.label6.Text = "Register Now";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(286, 104);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(171, 20);
            this.textBoxUsername.TabIndex = 14;
            // 
            // btnRegisterAdmin
            // 
            this.btnRegisterAdmin.Location = new System.Drawing.Point(281, 430);
            this.btnRegisterAdmin.Name = "btnRegisterAdmin";
            this.btnRegisterAdmin.Size = new System.Drawing.Size(116, 44);
            this.btnRegisterAdmin.TabIndex = 15;
            this.btnRegisterAdmin.Text = "Register Admin";
            this.btnRegisterAdmin.UseVisualStyleBackColor = true;
            this.btnRegisterAdmin.Click += new System.EventHandler(this.btnRegisterAdmin_Click);
            // 
            // btnRegisterInstructor
            // 
            this.btnRegisterInstructor.Location = new System.Drawing.Point(403, 430);
            this.btnRegisterInstructor.Name = "btnRegisterInstructor";
            this.btnRegisterInstructor.Size = new System.Drawing.Size(116, 44);
            this.btnRegisterInstructor.TabIndex = 16;
            this.btnRegisterInstructor.Text = "Register Instructor";
            this.btnRegisterInstructor.UseVisualStyleBackColor = true;
            this.btnRegisterInstructor.Click += new System.EventHandler(this.btnRegisterInstructor_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Level (Client Only):";
            // 
            // comboBoxLevel
            // 
            this.comboBoxLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLevel.FormattingEnabled = true;
            this.comboBoxLevel.Location = new System.Drawing.Point(286, 371);
            this.comboBoxLevel.Name = "comboBoxLevel";
            this.comboBoxLevel.Size = new System.Drawing.Size(171, 21);
            this.comboBoxLevel.TabIndex = 18;
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Location = new System.Drawing.Point(283, 88);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(0, 13);
            this.lblNotification.TabIndex = 19;
            // 
            // btnRegisterClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 599);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.comboBoxLevel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnRegisterInstructor);
            this.Controls.Add(this.btnRegisterAdmin);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonRegisterClient);
            this.Controls.Add(this.buttonToLogin);
            this.Name = "btnRegisterClient";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToLogin;
        private System.Windows.Forms.Button buttonRegisterClient;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxSurname;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button btnRegisterAdmin;
        private System.Windows.Forms.Button btnRegisterInstructor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxLevel;
        private System.Windows.Forms.Label lblNotification;
    }
}