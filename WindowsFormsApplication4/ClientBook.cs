using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class ClientBook : Form
    {
        private string _username;
        public ClientBook(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void ClientBook_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewAvailabilty_Click(object sender, EventArgs e)
        {
            RefreshListbox();
        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            if (listBoxAppointMent.SelectedIndex == -1)
            {
                labelNotify.Text = "Please select a time.";
                return;
            }
            string[] s = listBoxAppointMent.SelectedItem.ToString().Split(' ');
            string time = s[1];
            string id = s[0];
            SQL.executeQuery("UPDATE appointment SET client_username = '" + _username + "' where  id = " + id );

            using (StreamWriter write = new StreamWriter(@"D:\\Email.txt"))
            {
                string instructorName = "";
                string email = "";
                string name = "";
                string set_time = "";
                string[] selected = Regex.Split(listBoxAppointMent.SelectedItem.ToString(), @"\s+");
                instructorName = selected[2] + " " + selected[3];
                set_time = selected[1];
                SQL.selectQuery("select fname, email from client where username = '" +_username + "'");
                if (SQL.read.HasRows)
                {
                    while (SQL.read.Read())
                    {
                        name = SQL.read[0].ToString();
                        email = SQL.read[1].ToString();
                    }
                }
                
                write.WriteLine("To: " + email);
                write.WriteLine("From: Driving Instruction Academy (DIA)");
                write.WriteLine();
                write.WriteLine("Dear " + name);
                write.WriteLine();
                
                write.WriteLine("Thank you booking a driving lesson with us. This email is a formal confirmation of your driving lesson that was booked for the " + date + " at " + set_time + " with " + instructorName + ". Good luck with your lesson and thanks again.");
                write.WriteLine();
                write.WriteLine("Kind Regards,");
                write.WriteLine("Admin of Driving Instruction Academy (DIA)");
                write.Close();
            }

            RefreshListbox();
        }

        private void RefreshListbox()
        {
            listBoxAppointMent.Items.Clear();
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");

            SQL.selectQuery("select id, set_time, fname, sname from appointment a, instructor i where set_date = '" + date + "' and a.instructor_name = i.username and client_username is null and car_license is not null order by set_time ");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    listBoxAppointMent.Items.Add(SQL.read[0].ToString() + "        " + SQL.read[1].ToString() + "        " + SQL.read[2].ToString() + "        " + SQL.read[3].ToString());
                }
            }
            else
            {
                listBoxAppointMent.Items.Add("There are no slot to pick from on this day.");
            }
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            //Hides the login page
            this.Hide();
            Login off = new Login();
            //show the register page
            off.ShowDialog();
            //close the login page
            this.Close();
        }
    }
}
