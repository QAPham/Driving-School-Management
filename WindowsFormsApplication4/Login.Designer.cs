namespace WindowsFormsApplication4
{
    partial class Login
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
            this.buttonToRegister = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonLoginClient = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonLoginAdmin = new System.Windows.Forms.Button();
            this.buttonLoginInstructor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonToRegister
            // 
            this.buttonToRegister.Location = new System.Drawing.Point(180, 286);
            this.buttonToRegister.Name = "buttonToRegister";
            this.buttonToRegister.Size = new System.Drawing.Size(309, 37);
            this.buttonToRegister.TabIndex = 0;
            this.buttonToRegister.Text = "Don\'t have an account? Register.";
            this.buttonToRegister.UseVisualStyleBackColor = true;
            this.buttonToRegister.Click += new System.EventHandler(this.buttonToRegister_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(258, 175);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(198, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(258, 124);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(198, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // buttonLoginClient
            // 
            this.buttonLoginClient.Location = new System.Drawing.Point(180, 231);
            this.buttonLoginClient.Name = "buttonLoginClient";
            this.buttonLoginClient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonLoginClient.Size = new System.Drawing.Size(96, 49);
            this.buttonLoginClient.TabIndex = 3;
            this.buttonLoginClient.Text = "Login as Client";
            this.buttonLoginClient.UseVisualStyleBackColor = true;
            this.buttonLoginClient.Click += new System.EventHandler(this.buttonLoginClient_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Please Log In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username:";
            // 
            // buttonLoginAdmin
            // 
            this.buttonLoginAdmin.Location = new System.Drawing.Point(282, 231);
            this.buttonLoginAdmin.Name = "buttonLoginAdmin";
            this.buttonLoginAdmin.Size = new System.Drawing.Size(97, 49);
            this.buttonLoginAdmin.TabIndex = 8;
            this.buttonLoginAdmin.Text = "Login as Admin";
            this.buttonLoginAdmin.UseVisualStyleBackColor = true;
            this.buttonLoginAdmin.Click += new System.EventHandler(this.buttonLoginAdmin_Click);
            // 
            // buttonLoginInstructor
            // 
            this.buttonLoginInstructor.Location = new System.Drawing.Point(385, 231);
            this.buttonLoginInstructor.Name = "buttonLoginInstructor";
            this.buttonLoginInstructor.Size = new System.Drawing.Size(104, 49);
            this.buttonLoginInstructor.TabIndex = 9;
            this.buttonLoginInstructor.Text = "Login as Instructor";
            this.buttonLoginInstructor.UseVisualStyleBackColor = true;
            this.buttonLoginInstructor.Click += new System.EventHandler(this.buttonLoginInstructor_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 372);
            this.Controls.Add(this.buttonLoginInstructor);
            this.Controls.Add(this.buttonLoginAdmin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonLoginClient);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonToRegister);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonToRegister;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonLoginClient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonLoginAdmin;
        private System.Windows.Forms.Button buttonLoginInstructor;
    }
}

