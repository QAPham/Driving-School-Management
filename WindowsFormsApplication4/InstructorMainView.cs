using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace WindowsFormsApplication4
{
    public partial class InstructorMainView : Form
    {
        private string username;
        private string[] instructor;
        private string id = "";
        
        public InstructorMainView(string _username)
        {
            InitializeComponent();
            username = _username;
            SQL.selectQuery("select count(username) from instructor");
            int numInstructor = 0;
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    numInstructor = int.Parse(SQL.read[0].ToString());
                }
            }
            instructor = new string[numInstructor];
            SQL.selectQuery("select username from instructor");
            //string instructorName = "";
            int count = 0;
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    instructor[count] = SQL.read[0].ToString();
                    count++;
                }
            }

            for (int i = 0; i < instructor.Length; i++)
            {
                if (username == instructor[i])
                {
                    id = (i + 1).ToString();
                }
            }
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            listBoxAppointment.Items.Clear();
            int count = 0;
            SQL.selectQuery("select Convert(varchar(10),set_date, 21), set_time, fname, sname, client_type, username from appointment a, client c where instructor_name = '" + username + "' and client_username is not null and notes is null and c.fname = (select fname from client where username = client_username)and c.username = client_username ");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                   
                    listBoxAppointment.Items.Add(SQL.read[0].ToString() + "        " + SQL.read[1].ToString() + "        " + SQL.read[2].ToString() + "        " + SQL.read[3].ToString() + "        " + SQL.read[4].ToString() + "        " + SQL.read[5].ToString());
                }
            }
            else
            {
                listBoxAppointment.Items.Add("You have no appointment.");
            }
        }

        private void buttonAvailability_Click(object sender, EventArgs e)
        {
            //Hides the login page
            this.Hide();

            InstructorView instructor = new InstructorView(username);
            //show the register page
            instructor.ShowDialog();
            //close the login page
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            labelError.Text = "";
            if (listBoxAppointment.SelectedIndex == -1)
            {
                labelError.Text = "*Please select a given appointment.";
                labelError.Show();
                return;
            }
            if (textBoxComment.Text == "")
            {
                labelError.Text = "*Please enter some comments.";
                labelError.Show();
                return;
            }


            SQL.selectQuery("select max(id) from document");
            int id = 0;
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    //MessageBox.Show(SQL.read[0].ToString());
                    if (SQL.read[0].ToString() != "")
                    {
                        id = ((int)(SQL.read[0])) + 1;
                    }
                }
            }
            string[] selected = Regex.Split(listBoxAppointment.SelectedItem.ToString(), @"\s+");
            // string[] selected = listBoxAppointment.SelectedItem.ToString().Split("\s+");
            //MessageBox.Show("Update appointment set notes = '" + textBoxComment.Text + "' where set_date = '" + selected[0] + "' and set_time = '" + selected[1] + "' and instructor_name = '" + username + "'");
            SQL.executeQuery("Update appointment set notes = '" + textBoxComment.Text + "' where set_date = '" + selected[0] + "' and set_time = '" + selected[1] + "' and instructor_name = '" + username + "'");
            string date = DateTime.Today.ToString("yyyy-MM-dd");
            SQL.executeQuery("insert document values (" + id + ",'" + date + "',null,'Bill','" + selected[5] + "',null)");
            RefreshListBox();
            textBoxComment.Text = "";
            double cost = 0.0;
            //create a bill!!!
            using (StreamWriter write = new StreamWriter(@"D:\\Bill.txt"))
            {
                SQL.selectQuery("select cost from type t where name = '" + selected[4] + "'");
                if (SQL.read.HasRows)
                {
                    while (SQL.read.Read())
                    {
                        cost = (int)(SQL.read[0]);
                    }
                }
                write.WriteLine("Invoice");
                write.WriteLine();
                write.WriteLine("Bill To");
                write.WriteLine(selected[2] + " " + selected[3]);
                write.WriteLine();
                write.WriteLine("Invoice No.: " + id);
                write.WriteLine("Date: " + date);
                write.WriteLine();
                write.WriteLine("Description");
                write.WriteLine(selected[4] + " driving lesson               $" + cost);
                write.WriteLine();
                write.WriteLine();
                write.WriteLine("Driving Instruction Academy (DIA)");
                write.WriteLine("143 Knighton Rd, Hillcrest 3216");
                write.WriteLine("Hamilton, New Zealnd");
                write.Close();
            }
        }

        private void buttonOut_Click(object sender, EventArgs e)
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
