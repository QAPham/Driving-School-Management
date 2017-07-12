namespace WindowsFormsApplication4
{
    partial class InstructorMainView
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
            this.listBoxAppointment = new System.Windows.Forms.ListBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelComment = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonAvailability = new System.Windows.Forms.Button();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxAppointment
            // 
            this.listBoxAppointment.FormattingEnabled = true;
            this.listBoxAppointment.Location = new System.Drawing.Point(79, 84);
            this.listBoxAppointment.Name = "listBoxAppointment";
            this.listBoxAppointment.Size = new System.Drawing.Size(333, 160);
            this.listBoxAppointment.TabIndex = 0;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(79, 282);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(333, 82);
            this.textBoxComment.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Your Upcoming Appointments";
            // 
            // labelComment
            // 
            this.labelComment.AutoSize = true;
            this.labelComment.Location = new System.Drawing.Point(76, 266);
            this.labelComment.Name = "labelComment";
            this.labelComment.Size = new System.Drawing.Size(94, 13);
            this.labelComment.TabIndex = 3;
            this.labelComment.Text = "Session Comment:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(318, 393);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(94, 45);
            this.buttonSubmit.TabIndex = 4;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonAvailability
            // 
            this.buttonAvailability.Location = new System.Drawing.Point(204, 393);
            this.buttonAvailability.Name = "buttonAvailability";
            this.buttonAvailability.Size = new System.Drawing.Size(94, 47);
            this.buttonAvailability.TabIndex = 5;
            this.buttonAvailability.Text = "Edit Availability";
            this.buttonAvailability.UseVisualStyleBackColor = true;
            this.buttonAvailability.Click += new System.EventHandler(this.buttonAvailability_Click);
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(76, 68);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 6;
            // 
            // buttonOut
            // 
            this.buttonOut.Location = new System.Drawing.Point(407, 2);
            this.buttonOut.Name = "buttonOut";
            this.buttonOut.Size = new System.Drawing.Size(75, 23);
            this.buttonOut.TabIndex = 7;
            this.buttonOut.Text = "Sign Out";
            this.buttonOut.UseVisualStyleBackColor = true;
            this.buttonOut.Click += new System.EventHandler(this.buttonOut_Click);
            // 
            // InstructorMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 465);
            this.Controls.Add(this.buttonOut);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.buttonAvailability);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelComment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.listBoxAppointment);
            this.Name = "InstructorMainView";
            this.Text = "InstructorMainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAppointment;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelComment;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonAvailability;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonOut;
    }
}