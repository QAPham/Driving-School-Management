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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //This line of code allows us to obscure the password visually and limit the max chars in textbox
            textBoxPassword.PasswordChar = '*';     //password character to hide password characters
            textBoxPassword.MaxLength = 20;         //max textbox character count
        }

        private void buttonLoginClient_Click(object sender, EventArgs e)
        {
            //Variables to be used: 1x bool, 4x string
            // bool loggedIn = false;
            bool found = false;
            string username = "", password = "";

            //check if boxes are empty, the Trim removes white space in text from either side
            if ("".Equals(textBoxUsername.Text.Trim()) || "".Equals(textBoxPassword.Text.Trim()))
            {
                MessageBox.Show("Please make sure you enter a Username and Password");
                return;
            }

            //(1) GET the username and password from the text boxes, is good to put them in a try catch
            try
            {
                username = textBoxUsername.Text.Trim();
                password = textBoxPassword.Text.Trim();
            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Username or Password given is in an incorrect format.");
                return;
            }
            string userType = "client";

            int usernamePos = 0;
            int passwordPos = 5;

            found = SearchUser(userType, usernamePos, passwordPos, username, password);

            if (!found)
            {
                //message stating we couldn't log in
                MessageBox.Show("Login attempt unsuccessful! Please check details");
                initialiseTextBoxes();
                textBoxUsername.Focus();
                
            }
            else
            {
                //Hides the login page
                this.Hide();
                ClientView client = new ClientView(username);
                //show the register page
                client.ShowDialog();
                //close the login page
                this.Close();
            }
            
        }

        private void buttonToRegister_Click(object sender, EventArgs e)
        {
            //Hides the login page
            this.Hide();
            btnRegisterClient register = new btnRegisterClient();
            //show the register page
            register.ShowDialog();
            //close the login page
            this.Close();
        }
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
            //makes next place user types the text box
            textBoxUsername.Focus();
        }

        private bool SearchUser(string userType, int usernamePos, int passwordPos, string username, string password)
        {
            bool loggedIn = false;

            string firstname = "", lastname = "";
            
            SQL.selectQuery("SELECT * FROM " + userType);
            
            
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    if (username.Equals(SQL.read[usernamePos].ToString()) && password.Equals(SQL.read[passwordPos].ToString()))
                    {
                        loggedIn = true;
                        firstname = SQL.read[1].ToString();
                        lastname = SQL.read[2].ToString();
                        break;
                    }
                }
            }
            else
            {
                initialiseTextBoxes();
                textBoxUsername.Focus();
                MessageBox.Show("There is no data matches this username. Please register.");
               // return;
            }
            //if logged in display a success message
            if (loggedIn)
            {
                //message stating we logged in good
                //MessageBox.Show("Successfully logged in as: " + firstname + " " + lastname);
                initialiseTextBoxes();
                
            }
            
            return loggedIn;
        }

        private void buttonLoginAdmin_Click(object sender, EventArgs e)
        {
            //Variables to be used: 1x bool, 4x string
            // bool loggedIn = false;
            bool found = false;
            string username = "", password = "";

            //check if boxes are empty, the Trim removes white space in text from either side
            if ("".Equals(textBoxUsername.Text.Trim()) || "".Equals(textBoxPassword.Text.Trim()))
            {
                MessageBox.Show("Please make sure you enter a Username and Password");
                return;
            }

            //(1) GET the username and password from the text boxes, is good to put them in a try catch
            try
            {
                username = textBoxUsername.Text.Trim();
                password = textBoxPassword.Text.Trim();
            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Username or Password given is in an incorrect format.");
                return;
            }
            string userType = "admin" ;
            
            int usernamePos = 0;
            int passwordPos = 4;
            
           found = SearchUser(userType, usernamePos, passwordPos, username, password);
                
            if (!found)
            {
                //message stating we couldn't log in
                MessageBox.Show("Login attempt unsuccessful! Please check details");
                initialiseTextBoxes();
                textBoxUsername.Focus();
                
            }
            else
            {
                //Hides the login page
                this.Hide();
                AdminView admin = new AdminView();
                //show the register page
                admin.ShowDialog();
                //close the login page
                this.Close();
            }
        }

        private void buttonLoginInstructor_Click(object sender, EventArgs e)
        {
            //Variables to be used: 1x bool, 4x string
            // bool loggedIn = false;
            bool found = false;
            string username = "", password = "";

            //check if boxes are empty, the Trim removes white space in text from either side
            if ("".Equals(textBoxUsername.Text.Trim()) || "".Equals(textBoxPassword.Text.Trim()))
            {
                MessageBox.Show("Please make sure you enter a Username and Password");
                return;
            }

            //(1) GET the username and password from the text boxes, is good to put them in a try catch
            try
            {
                username = textBoxUsername.Text.Trim();
                password = textBoxPassword.Text.Trim();
            }
            catch
            {
                //Error message, more useful when you are storing numbers etc. into the database.
                MessageBox.Show("Username or Password given is in an incorrect format.");
                return;
            }
            string userType = "instructor";

            int usernamePos = 0;
            int passwordPos = 5;

            found = SearchUser(userType, usernamePos, passwordPos, username, password);

            if (!found)
            {
                //message stating we couldn't log in
                MessageBox.Show("Login attempt unsuccessful! Please check details");
                initialiseTextBoxes();
                textBoxUsername.Focus();
                
            }
            else
            {
                //Hides the login page
                this.Hide();

                InstructorMainView instructor = new InstructorMainView(username);
                //show the register page
                instructor.ShowDialog();
                //close the login page
                this.Close();
            }
        }
    }
}
