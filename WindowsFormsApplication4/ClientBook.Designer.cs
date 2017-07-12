namespace WindowsFormsApplication4
{
    partial class ClientBook
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
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonViewAvailabilty = new System.Windows.Forms.Button();
            this.listBoxAppointMent = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNotify = new System.Windows.Forms.Label();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(327, 441);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(113, 51);
            this.buttonBook.TabIndex = 17;
            this.buttonBook.Text = "Book Appointment";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonViewAvailabilty
            // 
            this.buttonViewAvailabilty.Location = new System.Drawing.Point(389, 122);
            this.buttonViewAvailabilty.Name = "buttonViewAvailabilty";
            this.buttonViewAvailabilty.Size = new System.Drawing.Size(110, 46);
            this.buttonViewAvailabilty.TabIndex = 15;
            this.buttonViewAvailabilty.Text = "View Available Appointments";
            this.buttonViewAvailabilty.UseVisualStyleBackColor = true;
            this.buttonViewAvailabilty.Click += new System.EventHandler(this.buttonViewAvailabilty_Click);
            // 
            // listBoxAppointMent
            // 
            this.listBoxAppointMent.FormattingEnabled = true;
            this.listBoxAppointMent.Location = new System.Drawing.Point(95, 197);
            this.listBoxAppointMent.Name = "listBoxAppointMent";
            this.listBoxAppointMent.Size = new System.Drawing.Size(345, 238);
            this.listBoxAppointMent.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Select a Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(167, 135);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 18;
            this.label1.Text = "Book an Appointment";
            // 
            // labelNotify
            // 
            this.labelNotify.AutoSize = true;
            this.labelNotify.ForeColor = System.Drawing.Color.Red;
            this.labelNotify.Location = new System.Drawing.Point(92, 181);
            this.labelNotify.Name = "labelNotify";
            this.labelNotify.Size = new System.Drawing.Size(0, 13);
            this.labelNotify.TabIndex = 19;
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(483, 12);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(75, 23);
            this.buttonSignOut.TabIndex = 20;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // ClientBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 554);
            this.Controls.Add(this.buttonSignOut);
            this.Controls.Add(this.labelNotify);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.buttonViewAvailabilty);
            this.Controls.Add(this.listBoxAppointMent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "ClientBook";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ClientBook_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonViewAvailabilty;
        private System.Windows.Forms.ListBox listBoxAppointMent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNotify;
        private System.Windows.Forms.Button buttonSignOut;
    }
}