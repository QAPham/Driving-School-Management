using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class btnRegisterClient : Form
    {
        public btnRegisterClient()
        {
            InitializeComponent();
            //give constraints to length of input for each textbox so database would accept them
            textBoxFirstName.MaxLength = 20;
            textBoxUsername.MaxLength = 20;
            textBoxSurname.MaxLength = 20;
            textBoxEmail.MaxLength = 50;
            textBoxPhone.MaxLength = 15;
            textBoxPassword.MaxLength = 30;
            textBoxPassword.PasswordChar = '*';
            SetupComboBox();
        }

        private void SetupComboBox()
        {
            SQL.selectQuery("Select name From type");

            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                    comboBoxLevel.Items.Add(SQL.read[0].ToString());
            }
        }


        /// <summary>
        /// take in the user inputs in the textbox and enter it into the database as a new client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegisterClient_Click(object sender, EventArgs e)
        {
            bool hasClient = false;
            string username, firstName, lastName, email, phoneNo, password, levelType;

            //check if user enter all required info if not display an error message
            bool hasText = checkTextBoxesClient();
            if (!hasText)
            {
                MessageBox.Show("Please make sure all fields have been filled");
                textBoxUsername.Focus();
                return;
            }
            try
            {
                // get the user inputs from textboxes
                username = textBoxUsername.Text.Trim();
                firstName = textBoxFirstName.Text.Trim();
                lastName = textBoxSurname.Text.Trim();
                email = textBoxEmail.Text.Trim();
                //check if email is in the correct format as stated in database
                char[] emailChar = email.ToCharArray();
                if(!email.Contains("@") || emailChar[0].ToString() == "@" || emailChar[emailChar.Length -1].ToString() == "@")
                {
                    MessageBox.Show("Email is not in the correct format.");
                    return;
                }

                phoneNo = textBoxPhone.Text.Trim();
                password = textBoxPassword.Text.Trim();
                levelType = comboBoxLevel.Text;

            }
            catch
            {
                MessageBox.Show("Please make sure your text is in correct format.");
                return;
            }
            //(2) Execute the INSERT statement, making sure all quotes and commas are in the correct places.
            //      Practice first on SQL Server Management Studio to make sure it is entering the correct data and in the correct format,
            //      then copy across the statement and where there are string replace the actual text for the variables stored above.
            //Example query: " INSERT INTO Users VALUES ('jkc1', 'John', 'Middle', 'Carter', 'pass1') "
            try
            {
                //check if there a client in the database with the same username, if there is one then display error message
                SQL.selectQuery("SELECT * FROM client");
                if (SQL.read.HasRows)
                {
                    while (SQL.read.Read())
                    {
                        if (username.Equals(SQL.read[0].ToString()))
                        {
                            hasClient = true;
                            MessageBox.Show("There already a client with that username. Please chose another username.");
                            initialiseTextBoxes();
                            return;
                        }
                    }
                    
                }

                //if no client in database with the same username then enter new client into the database
                if (hasClient == false)
                {
                    SQL.executeQuery("INSERT client values ('" + username + "','" + firstName + "','" + lastName + "','" + email + "','" + phoneNo + "','" + password + "','" + levelType + "')");
                    Console.WriteLine("INSERT client values ('" + username + "','" + firstName + "','" + lastName + "','" + email + "','" + phoneNo + "','" + password + "','" + levelType + "')");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Register attempt unsuccessful. Check insert statement.");
                return;
            }

            if (hasClient == false)
            {
                //success message for the user to know it worked
                MessageBox.Show("Successfully Registered: " + firstName + " " + lastName + ". Your username is: " + username);

                //Go back to the login page since we registered successfully to let the user log in
                Hide();                                 //hides the register form
                Login login = new Login();      //creates the login page as an object
                login.ShowDialog();                     //shows the new login page form
                this.Close();                           //closes the register form that was hidden
            }
            
        }
        /// <summary>
        /// Checks if they textboxes have data in them
        /// </summary>
        /// <returns>TRUE if all hold text, but FALSE if at least one does not hold data</returns>
        private bool checkTextBoxes()
        {
            bool holdsData = true;
            //go through all of the controls
            foreach (Control c in this.Controls)
            {
                //if its a textbox, but doesnt matter if its middle textbox
                if (c is TextBox )
                {
                    //If it is not the case that it is empty
                    if ("".Equals((c as TextBox).Text.Trim()))
                    {
                        //set boolean to false because on textbox is empty
                        holdsData = false;
                    }
                }
            }
            //returns true or false based on if data is in all text boxs or not
            return holdsData;
        }
        /// <summary>
        /// Checks if they textboxes have data in them
        /// </summary>
        /// <returns>TRUE if all hold text, but FALSE if at least one does not hold data</returns>
        private bool checkTextBoxesAdmin()
        {
            bool holdsData = true;
            //go through all of the controls
            foreach (Control c in this.Controls)
            {
                //if its a textbox, but doesnt matter if its middle textbox
                if (c is TextBox)
                {
                    //If it is not the case that it is empty
                    if ("".Equals((c as TextBox).Text.Trim()) && c.Name != "textBoxPhone")
                    {
                        //set boolean to false because on textbox is empty
                        holdsData = false;
                    }
                }
            }
            //returns true or false based on if data is in all text boxs or not
            return holdsData;
        }
        /// <summary>
        /// Checks if they textboxes have data in them
        /// </summary>
        /// <returns>TRUE if all hold text, but FALSE if at least one does not hold data</returns>
        private bool checkTextBoxesClient()
        {
            bool holdsData = true;
            //go through all of the controls
            foreach (Control c in this.Controls)
            {
                //if its a textbox, but doesnt matter if its middle textbox
                if (c is TextBox )
                {
                    //If it is not the case that it is empty
                    if ("".Equals((c as TextBox).Text.Trim()))
                    {
                        //set boolean to false because on textbox is empty
                        holdsData = false;
                    }
                }
                else if(c is ComboBox)
                {
                    if ("".Equals((c as ComboBox).Text))
                    {
                        //set boolean to false because on textbox is empty
                        holdsData = false;
                    }
                }
            }
            //returns true or false based on if data is in all text boxs or not
            return holdsData;
        }
        /// <summary>
        /// Hide Register window and open Login window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.ShowDialog();
            this.Close();
        }

        /// <summary>
        /// clear all textboxes and set focus on Username textbox
        /// </summary>
        public void initialiseTextBoxes()
        {
            //goes through and clears all of the textboxes
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).Clear();
                }
            }
            textBoxUsername.Focus();
        }

        private void btnRegisterAdmin_Click(object sender, EventArgs e)
        {
            bool hasClient = false;
            string username, firstName, lastName, email, password;

            //check if user enter all required info if not display an error message
            bool hasText = checkTextBoxesAdmin();
            if (!hasText)
            {
                MessageBox.Show("Please make sure all textboxes have text.");
                textBoxUsername.Focus();
                return;
            }
            try
            {
                // get the user inputs from textboxes
                username = textBoxUsername.Text.Trim();
                firstName = textBoxFirstName.Text.Trim();
                lastName = textBoxSurname.Text.Trim();
                email = textBoxEmail.Text.Trim();
                //check if email is in the correct format as stated in database
                char[] emailChar = email.ToCharArray();
                if (!email.Contains("@") || emailChar[0].ToString() == "@" || emailChar[emailChar.Length - 1].ToString() == "@")
                {
                    MessageBox.Show("Email is not in the correct format.");
                    return;
                }

               
                password = textBoxPassword.Text.Trim();

            }
            catch
            {
                MessageBox.Show("Please make sure your text is in correct format.");
                return;
            }
            
            try
            {
                //check if there a client in the database with the same username, if there is one then display error message
                SQL.selectQuery("SELECT * FROM admin");
                if (SQL.read.HasRows)
                {
                    while (SQL.read.Read())
                    {
                        if (username.Equals(SQL.read[0].ToString()))
                        {
                            hasClient = true;
                            MessageBox.Show("There already an admin with that username. Please chose another username.");
                            initialiseTextBoxes();
                            return;
                        }
                    }

                }

                //if no client in database with the same username then enter new client into the database
                if (hasClient == false)
                {
                    SQL.executeQuery("INSERT admin values ('" + username + "','" + firstName + "','" + lastName + "','" + email + "','" + password + "')");
                    Console.WriteLine("INSERT admin values ('" + username + "','" + firstName + "','" + lastName + "','" + email + "','" + password + "')");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Register attempt unsuccessful. Check insert statement.");
                return;
            }

            if (hasClient == false)
            {
                //success message for the user to know it worked
                MessageBox.Show("Successfully Registered: " + firstName + " " + lastName + ". Your username is: " + username);

                //Go back to the login page since we registered successfully to let the user log in
                Hide();                                 //hides the register form
                Login login = new Login();      //creates the login page as an object
                login.ShowDialog();                     //shows the new login page form
                this.Close();                           //closes the register form that was hidden
            }
        }

        private void btnRegisterInstructor_Click(object sender, EventArgs e)
        {
            bool hasClient = false;
            string username, firstName, lastName, email, phoneNo, password;

            //check if user enter all required info if not display an error message
            bool hasText = checkTextBoxes();
            if (!hasText)
            {
                MessageBox.Show("Please make sure all textboxes have text.");
                textBoxUsername.Focus();
                return;
            }
            try
            {
                // get the user inputs from textboxes
                username = textBoxUsername.Text.Trim();
                firstName = textBoxFirstName.Text.Trim();
                lastName = textBoxSurname.Text.Trim();
                email = textBoxEmail.Text.Trim();
                //check if email is in the correct format as stated in database
                char[] emailChar = email.ToCharArray();
                if (!email.Contains("@") || emailChar[0].ToString() == "@" || emailChar[emailChar.Length - 1].ToString() == "@")
                {
                    MessageBox.Show("Email is not in the correct format.");
                    return;
                }

                phoneNo = textBoxPhone.Text.Trim();
                password = textBoxPassword.Text.Trim();

            }
            catch
            {
                MessageBox.Show("Please make sure your text is in correct format.");
                return;
            }
            
            try
            {
                //check if there a client in the database with the same username, if there is one then display error message
                SQL.selectQuery("SELECT * FROM instructor");
                if (SQL.read.HasRows)
                {
                    while (SQL.read.Read())
                    {
                        if (username.Equals(SQL.read[0].ToString()))
                        {
                            hasClient = true;
                            MessageBox.Show("There already an instructor with that username. Please chose another username.");
                            initialiseTextBoxes();
                            return;
                        }
                    }

                }

                //if no client in database with the same username then enter new client into the database
                if (hasClient == false)
                {
                    SQL.executeQuery("INSERT instructor values ('" + username + "','" + firstName + "','" + lastName + "','" + email + "','" + phoneNo+ "','" + password + "')");
                    Console.WriteLine("INSERT instructor values ('" + username + "','" + firstName + "','" + lastName + "','" + email + "','" + phoneNo + "','" + password + "')");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Register attempt unsuccessful. Check insert statement.");
                return;
            }

            if (hasClient == false)
            {
                //success message for the user to know it worked
                MessageBox.Show("Successfully Registered: " + firstName + " " + lastName + ". Your username is: " + username);

                //Go back to the login page since we registered successfully to let the user log in
                Hide();                                 //hides the register form
                Login login = new Login();      //creates the login page as an object
                login.ShowDialog();                     //shows the new login page form
                this.Close();                           //closes the register form that was hidden
            }
        }
    }
}
