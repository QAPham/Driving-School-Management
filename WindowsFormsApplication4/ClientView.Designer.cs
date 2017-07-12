namespace WindowsFormsApplication4
{
    partial class ClientView
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
            this.SuspendLayout();
            // 
            // buttonBook
            // 
            this.buttonBook.Location = new System.Drawing.Point(449, 105);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(138, 60);
            this.buttonBook.TabIndex = 0;
            this.buttonBook.Text = "Book an Appointment";
            this.buttonBook.UseVisualStyleBackColor = true;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // ClientView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 294);
            this.Controls.Add(this.buttonBook);
            this.Name = "ClientView";
            this.Text = "ClientView";
            this.Load += new System.EventHandler(this.ClientView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBook;
    }
}