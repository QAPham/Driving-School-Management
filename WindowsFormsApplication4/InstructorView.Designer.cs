namespace WindowsFormsApplication4
{
    partial class InstructorView
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
            this.buttonViewAvailabilty = new System.Windows.Forms.Button();
            this.listBoxInstructor = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonAvailable = new System.Windows.Forms.Button();
            this.buttonRemoveAvail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNotify = new System.Windows.Forms.Label();
            this.listBoxEmpty = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonViewAvailabilty
            // 
            this.buttonViewAvailabilty.Location = new System.Drawing.Point(392, 107);
            this.buttonViewAvailabilty.Name = "buttonViewAvailabilty";
            this.buttonViewAvailabilty.Size = new System.Drawing.Size(81, 23);
            this.buttonViewAvailabilty.TabIndex = 9;
            this.buttonViewAvailabilty.Text = "View";
            this.buttonViewAvailabilty.UseVisualStyleBackColor = true;
            this.buttonViewAvailabilty.Click += new System.EventHandler(this.buttonViewAvailabilty_Click);
            // 
            // listBoxInstructor
            // 
            this.listBoxInstructor.FormattingEnabled = true;
            this.listBoxInstructor.Location = new System.Drawing.Point(106, 169);
            this.listBoxInstructor.Name = "listBoxInstructor";
            this.listBoxInstructor.Size = new System.Drawing.Size(345, 95);
            this.listBoxInstructor.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select a Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(178, 107);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker.TabIndex = 6;
            // 
            // buttonAvailable
            // 
            this.buttonAvailable.Location = new System.Drawing.Point(251, 413);
            this.buttonAvailable.Name = "buttonAvailable";
            this.buttonAvailable.Size = new System.Drawing.Size(97, 44);
            this.buttonAvailable.TabIndex = 10;
            this.buttonAvailable.Text = "Set as Available";
            this.buttonAvailable.UseVisualStyleBackColor = true;
            this.buttonAvailable.Click += new System.EventHandler(this.buttonAvailable_Click);
            // 
            // buttonRemoveAvail
            // 
            this.buttonRemoveAvail.Location = new System.Drawing.Point(354, 413);
            this.buttonRemoveAvail.Name = "buttonRemoveAvail";
            this.buttonRemoveAvail.Size = new System.Drawing.Size(97, 44);
            this.buttonRemoveAvail.TabIndex = 11;
            this.buttonRemoveAvail.Text = "Remove Availability";
            this.buttonRemoveAvail.UseVisualStyleBackColor = true;
            this.buttonRemoveAvail.Click += new System.EventHandler(this.buttonRemoveAvail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(130, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = " Set your Availability";
            // 
            // labelNotify
            // 
            this.labelNotify.AutoSize = true;
            this.labelNotify.ForeColor = System.Drawing.Color.Red;
            this.labelNotify.Location = new System.Drawing.Point(175, 153);
            this.labelNotify.Name = "labelNotify";
            this.labelNotify.Size = new System.Drawing.Size(0, 13);
            this.labelNotify.TabIndex = 13;
            // 
            // listBoxEmpty
            // 
            this.listBoxEmpty.FormattingEnabled = true;
            this.listBoxEmpty.Location = new System.Drawing.Point(106, 300);
            this.listBoxEmpty.Name = "listBoxEmpty";
            this.listBoxEmpty.Size = new System.Drawing.Size(345, 95);
            this.listBoxEmpty.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Set as available:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Empty slots:";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(460, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // InstructorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 513);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxEmpty);
            this.Controls.Add(this.labelNotify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoveAvail);
            this.Controls.Add(this.buttonAvailable);
            this.Controls.Add(this.buttonViewAvailabilty);
            this.Controls.Add(this.listBoxInstructor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "InstructorView";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.InstructorView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonViewAvailabilty;
        private System.Windows.Forms.ListBox listBoxInstructor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonAvailable;
        private System.Windows.Forms.Button buttonRemoveAvail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNotify;
        private System.Windows.Forms.ListBox listBoxEmpty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBack;
    }
}