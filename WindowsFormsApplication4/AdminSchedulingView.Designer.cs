namespace WindowsFormsApplication4
{
    partial class AdminSchedulingView
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
            this.comboBoxInstructor = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxInstructor = new System.Windows.Forms.ListBox();
            this.buttonViewAvailabilty = new System.Windows.Forms.Button();
            this.listBoxCar = new System.Windows.Forms.ListBox();
            this.buttonViewCar = new System.Windows.Forms.Button();
            this.buttonAssign = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNotify = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxEmpty = new System.Windows.Forms.ListBox();
            this.buttonRemoveAvailable = new System.Windows.Forms.Button();
            this.buttonSetAvailable = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelNotifyCar = new System.Windows.Forms.Label();
            this.buttonOut = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxInstructor
            // 
            this.comboBoxInstructor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInstructor.FormattingEnabled = true;
            this.comboBoxInstructor.Location = new System.Drawing.Point(143, 50);
            this.comboBoxInstructor.Name = "comboBoxInstructor";
            this.comboBoxInstructor.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInstructor.TabIndex = 0;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(143, 93);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Instructor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select a Date:";
            // 
            // listBoxInstructor
            // 
            this.listBoxInstructor.FormattingEnabled = true;
            this.listBoxInstructor.Location = new System.Drawing.Point(36, 225);
            this.listBoxInstructor.Name = "listBoxInstructor";
            this.listBoxInstructor.Size = new System.Drawing.Size(303, 108);
            this.listBoxInstructor.TabIndex = 4;
            // 
            // buttonViewAvailabilty
            // 
            this.buttonViewAvailabilty.Location = new System.Drawing.Point(36, 142);
            this.buttonViewAvailabilty.Name = "buttonViewAvailabilty";
            this.buttonViewAvailabilty.Size = new System.Drawing.Size(97, 40);
            this.buttonViewAvailabilty.TabIndex = 5;
            this.buttonViewAvailabilty.Text = "View";
            this.buttonViewAvailabilty.UseVisualStyleBackColor = true;
            this.buttonViewAvailabilty.Click += new System.EventHandler(this.buttonViewAvailabilty_Click);
            // 
            // listBoxCar
            // 
            this.listBoxCar.FormattingEnabled = true;
            this.listBoxCar.Location = new System.Drawing.Point(52, 99);
            this.listBoxCar.Name = "listBoxCar";
            this.listBoxCar.Size = new System.Drawing.Size(221, 225);
            this.listBoxCar.TabIndex = 8;
            // 
            // buttonViewCar
            // 
            this.buttonViewCar.Location = new System.Drawing.Point(62, 339);
            this.buttonViewCar.Name = "buttonViewCar";
            this.buttonViewCar.Size = new System.Drawing.Size(97, 40);
            this.buttonViewCar.TabIndex = 9;
            this.buttonViewCar.Text = "View Car";
            this.buttonViewCar.UseVisualStyleBackColor = true;
            this.buttonViewCar.Click += new System.EventHandler(this.buttonViewCar_Click);
            // 
            // buttonAssign
            // 
            this.buttonAssign.Location = new System.Drawing.Point(165, 339);
            this.buttonAssign.Name = "buttonAssign";
            this.buttonAssign.Size = new System.Drawing.Size(97, 40);
            this.buttonAssign.TabIndex = 10;
            this.buttonAssign.Text = "Assign";
            this.buttonAssign.UseVisualStyleBackColor = true;
            this.buttonAssign.Click += new System.EventHandler(this.buttonAssign_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelNotify);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.listBoxEmpty);
            this.groupBox1.Controls.Add(this.buttonRemoveAvailable);
            this.groupBox1.Controls.Add(this.buttonViewAvailabilty);
            this.groupBox1.Controls.Add(this.buttonSetAvailable);
            this.groupBox1.Controls.Add(this.listBoxInstructor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.comboBoxInstructor);
            this.groupBox1.Location = new System.Drawing.Point(24, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 489);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Instructor Availabilty";
            // 
            // labelNotify
            // 
            this.labelNotify.AutoSize = true;
            this.labelNotify.ForeColor = System.Drawing.Color.Red;
            this.labelNotify.Location = new System.Drawing.Point(115, 209);
            this.labelNotify.Name = "labelNotify";
            this.labelNotify.Size = new System.Drawing.Size(0, 13);
            this.labelNotify.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Empty slots:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Set as available:";
            // 
            // listBoxEmpty
            // 
            this.listBoxEmpty.FormattingEnabled = true;
            this.listBoxEmpty.Location = new System.Drawing.Point(40, 355);
            this.listBoxEmpty.Name = "listBoxEmpty";
            this.listBoxEmpty.Size = new System.Drawing.Size(303, 108);
            this.listBoxEmpty.TabIndex = 17;
            // 
            // buttonRemoveAvailable
            // 
            this.buttonRemoveAvailable.Location = new System.Drawing.Point(246, 140);
            this.buttonRemoveAvailable.Name = "buttonRemoveAvailable";
            this.buttonRemoveAvailable.Size = new System.Drawing.Size(97, 44);
            this.buttonRemoveAvailable.TabIndex = 14;
            this.buttonRemoveAvailable.Text = "Remove Availability";
            this.buttonRemoveAvailable.UseVisualStyleBackColor = true;
            this.buttonRemoveAvailable.Click += new System.EventHandler(this.buttonRemoveAvailable_Click);
            // 
            // buttonSetAvailable
            // 
            this.buttonSetAvailable.Location = new System.Drawing.Point(143, 140);
            this.buttonSetAvailable.Name = "buttonSetAvailable";
            this.buttonSetAvailable.Size = new System.Drawing.Size(97, 44);
            this.buttonSetAvailable.TabIndex = 13;
            this.buttonSetAvailable.Text = "Set as Available";
            this.buttonSetAvailable.UseVisualStyleBackColor = true;
            this.buttonSetAvailable.Click += new System.EventHandler(this.buttonSetAvailable_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonBack);
            this.groupBox2.Controls.Add(this.labelNotifyCar);
            this.groupBox2.Controls.Add(this.buttonAssign);
            this.groupBox2.Controls.Add(this.buttonViewCar);
            this.groupBox2.Controls.Add(this.listBoxCar);
            this.groupBox2.Location = new System.Drawing.Point(436, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 490);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View and Assign Car";
            // 
            // labelNotifyCar
            // 
            this.labelNotifyCar.AutoSize = true;
            this.labelNotifyCar.ForeColor = System.Drawing.Color.Red;
            this.labelNotifyCar.Location = new System.Drawing.Point(49, 209);
            this.labelNotifyCar.Name = "labelNotifyCar";
            this.labelNotifyCar.Size = new System.Drawing.Size(0, 13);
            this.labelNotifyCar.TabIndex = 21;
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(700, 2);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(75, 23);
            this.buttonOut.TabIndex = 13;
            this.buttonOut.Text = "Back";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(117, 423);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(97, 40);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AdminSchedulingView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 565);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminSchedulingView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminSchedulingView_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxInstructor;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxInstructor;
        private System.Windows.Forms.Button buttonViewAvailabilty;
        private System.Windows.Forms.ListBox listBoxCar;
        private System.Windows.Forms.Button buttonViewCar;
        private System.Windows.Forms.Button buttonAssign;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonRemoveAvailable;
        private System.Windows.Forms.Button buttonSetAvailable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxEmpty;
        private System.Windows.Forms.Label labelNotify;
        private System.Windows.Forms.Label labelNotifyCar;
        private System.Windows.Forms.Button buttonOut;
        private System.Windows.Forms.Button buttonBack;
    }
}