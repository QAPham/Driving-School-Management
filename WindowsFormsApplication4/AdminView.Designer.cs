namespace WindowsFormsApplication4
{
    partial class AdminView
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
            this.listBoxBill = new System.Windows.Forms.ListBox();
            this.labelBill = new System.Windows.Forms.Label();
            this.buttonConfirmPay = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelError = new System.Windows.Forms.Label();
            this.buttonStat = new System.Windows.Forms.Button();
            this.buttonUnregister = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxBill
            // 
            this.listBoxBill.FormattingEnabled = true;
            this.listBoxBill.Location = new System.Drawing.Point(36, 74);
            this.listBoxBill.Name = "listBoxBill";
            this.listBoxBill.Size = new System.Drawing.Size(278, 186);
            this.listBoxBill.TabIndex = 0;
            // 
            // labelBill
            // 
            this.labelBill.AutoSize = true;
            this.labelBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBill.ForeColor = System.Drawing.Color.Black;
            this.labelBill.Location = new System.Drawing.Point(32, 39);
            this.labelBill.Name = "labelBill";
            this.labelBill.Size = new System.Drawing.Size(119, 20);
            this.labelBill.TabIndex = 1;
            this.labelBill.Text = "Bill To Be Pay";
            // 
            // buttonConfirmPay
            // 
            this.buttonConfirmPay.Location = new System.Drawing.Point(176, 279);
            this.buttonConfirmPay.Name = "buttonConfirmPay";
            this.buttonConfirmPay.Size = new System.Drawing.Size(119, 38);
            this.buttonConfirmPay.TabIndex = 2;
            this.buttonConfirmPay.Text = "Confirm Payment";
            this.buttonConfirmPay.UseVisualStyleBackColor = true;
            this.buttonConfirmPay.Click += new System.EventHandler(this.buttonConfirmPay_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelError);
            this.groupBox1.Controls.Add(this.buttonConfirmPay);
            this.groupBox1.Controls.Add(this.listBoxBill);
            this.groupBox1.Controls.Add(this.labelBill);
            this.groupBox1.Location = new System.Drawing.Point(29, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 383);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(160, 58);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 3;
            // 
            // buttonStat
            // 
            this.buttonStat.Location = new System.Drawing.Point(46, 134);
            this.buttonStat.Name = "buttonStat";
            this.buttonStat.Size = new System.Drawing.Size(98, 50);
            this.buttonStat.TabIndex = 0;
            this.buttonStat.Text = "Get Statistics";
            this.buttonStat.UseVisualStyleBackColor = true;
            this.buttonStat.Click += new System.EventHandler(this.buttonStat_Click);
            // 
            // buttonUnregister
            // 
            this.buttonUnregister.Location = new System.Drawing.Point(46, 214);
            this.buttonUnregister.Name = "buttonUnregister";
            this.buttonUnregister.Size = new System.Drawing.Size(98, 46);
            this.buttonUnregister.TabIndex = 1;
            this.buttonUnregister.Text = "Unregister a Staff";
            this.buttonUnregister.UseVisualStyleBackColor = true;
            this.buttonUnregister.Click += new System.EventHandler(this.buttonUnregister_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(46, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 46);
            this.button3.TabIndex = 2;
            this.button3.Text = "View Availability";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonSignOut);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.buttonUnregister);
            this.groupBox2.Controls.Add(this.buttonStat);
            this.groupBox2.Location = new System.Drawing.Point(419, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 383);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(46, 288);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(98, 46);
            this.buttonSignOut.TabIndex = 3;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 453);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxBill;
        private System.Windows.Forms.Label labelBill;
        private System.Windows.Forms.Button buttonConfirmPay;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStat;
        private System.Windows.Forms.Button buttonUnregister;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Button buttonSignOut;
    }
}