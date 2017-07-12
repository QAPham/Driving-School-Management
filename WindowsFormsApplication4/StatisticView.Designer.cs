namespace WindowsFormsApplication4
{
    partial class StatisticView
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
            this.textBoxInfo = new System.Windows.Forms.TextBox();
            this.radioButtonToday = new System.Windows.Forms.RadioButton();
            this.radioButtonWeek = new System.Windows.Forms.RadioButton();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonClient = new System.Windows.Forms.RadioButton();
            this.radioButtonWork = new System.Windows.Forms.RadioButton();
            this.radioButtonApp = new System.Windows.Forms.RadioButton();
            this.buttonView = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInfo
            // 
            this.textBoxInfo.Location = new System.Drawing.Point(88, 198);
            this.textBoxInfo.Multiline = true;
            this.textBoxInfo.Name = "textBoxInfo";
            this.textBoxInfo.ReadOnly = true;
            this.textBoxInfo.Size = new System.Drawing.Size(416, 192);
            this.textBoxInfo.TabIndex = 0;
            // 
            // radioButtonToday
            // 
            this.radioButtonToday.AutoSize = true;
            this.radioButtonToday.Location = new System.Drawing.Point(112, 11);
            this.radioButtonToday.Name = "radioButtonToday";
            this.radioButtonToday.Size = new System.Drawing.Size(55, 17);
            this.radioButtonToday.TabIndex = 1;
            this.radioButtonToday.TabStop = true;
            this.radioButtonToday.Text = "Today";
            this.radioButtonToday.UseVisualStyleBackColor = true;
            // 
            // radioButtonWeek
            // 
            this.radioButtonWeek.AutoSize = true;
            this.radioButtonWeek.Location = new System.Drawing.Point(189, 11);
            this.radioButtonWeek.Name = "radioButtonWeek";
            this.radioButtonWeek.Size = new System.Drawing.Size(77, 17);
            this.radioButtonWeek.TabIndex = 2;
            this.radioButtonWeek.TabStop = true;
            this.radioButtonWeek.Text = "This Week";
            this.radioButtonWeek.UseVisualStyleBackColor = true;
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.Location = new System.Drawing.Point(287, 11);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(78, 17);
            this.radioButtonMonth.TabIndex = 3;
            this.radioButtonMonth.TabStop = true;
            this.radioButtonMonth.Text = "This Month";
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Statistics";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonToday);
            this.groupBox1.Controls.Add(this.radioButtonMonth);
            this.groupBox1.Controls.Add(this.radioButtonWeek);
            this.groupBox1.Location = new System.Drawing.Point(103, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 37);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a Period:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonClient);
            this.groupBox2.Controls.Add(this.radioButtonWork);
            this.groupBox2.Controls.Add(this.radioButtonApp);
            this.groupBox2.Location = new System.Drawing.Point(103, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(388, 37);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose a Type:";
            // 
            // radioButtonClient
            // 
            this.radioButtonClient.AutoSize = true;
            this.radioButtonClient.Location = new System.Drawing.Point(112, 11);
            this.radioButtonClient.Name = "radioButtonClient";
            this.radioButtonClient.Size = new System.Drawing.Size(71, 17);
            this.radioButtonClient.TabIndex = 1;
            this.radioButtonClient.TabStop = true;
            this.radioButtonClient.Text = "No. Client";
            this.radioButtonClient.UseVisualStyleBackColor = true;
            // 
            // radioButtonWork
            // 
            this.radioButtonWork.AutoSize = true;
            this.radioButtonWork.Location = new System.Drawing.Point(287, 11);
            this.radioButtonWork.Name = "radioButtonWork";
            this.radioButtonWork.Size = new System.Drawing.Size(89, 17);
            this.radioButtonWork.TabIndex = 3;
            this.radioButtonWork.TabStop = true;
            this.radioButtonWork.Text = "Hour Worked";
            this.radioButtonWork.UseVisualStyleBackColor = true;
            // 
            // radioButtonApp
            // 
            this.radioButtonApp.AutoSize = true;
            this.radioButtonApp.Location = new System.Drawing.Point(189, 11);
            this.radioButtonApp.Name = "radioButtonApp";
            this.radioButtonApp.Size = new System.Drawing.Size(84, 17);
            this.radioButtonApp.TabIndex = 2;
            this.radioButtonApp.TabStop = true;
            this.radioButtonApp.Text = "Appointment";
            this.radioButtonApp.UseVisualStyleBackColor = true;
            // 
            // buttonView
            // 
            this.buttonView.Location = new System.Drawing.Point(409, 396);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(85, 36);
            this.buttonView.TabIndex = 11;
            this.buttonView.Text = "View";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(505, 2);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 12;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // StatisticView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 479);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "StatisticView";
            this.Text = "StatisticView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInfo;
        private System.Windows.Forms.RadioButton radioButtonToday;
        private System.Windows.Forms.RadioButton radioButtonWeek;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonClient;
        private System.Windows.Forms.RadioButton radioButtonWork;
        private System.Windows.Forms.RadioButton radioButtonApp;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.Button buttonBack;
    }
}