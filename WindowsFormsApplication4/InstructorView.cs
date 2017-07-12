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
    public partial class InstructorView : Form
    {
        private string username;
        private string[] instructor;
        private string id = "";
           
public InstructorView(string _username)
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
        }

        private void InstructorView_Load(object sender, EventArgs e)
        {

        }

        private void buttonViewAvailabilty_Click(object sender, EventArgs e)
        {
            RefreshListBox();
        }

        private void RefreshListBox()
        {
            listBoxInstructor.Items.Clear();
            listBoxEmpty.Items.Clear();
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            DateTime testDay = DateTime.Parse(date);
            if (testDay.DayOfWeek.ToString() == "Saturday")
            {
                id = "1";
            }
            SQL.selectQuery("select set_time from timeslot where id = " + id + " and set_date = '" + date + "' and set_time Not in (select set_time from appointment where set_date = '" + date + "' and timeslot_id = " + id + ") order by set_time");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    listBoxInstructor.Items.Add(SQL.read[0].ToString());
                }
            }
            else
            {
                listBoxInstructor.Items.Add("There are no slot to pick from on this day.");
            }
            SQL.selectQuery("select set_time from timeslot where id = " + id + " and set_date = '" + date + "' and set_time in (select set_time from appointment where set_date = '" + date + "' and timeslot_id = " + id + " and instructor_name ='" + username+ "') order by set_time");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    listBoxEmpty.Items.Add(SQL.read[0].ToString());
                }
            }
            else
            {
                listBoxEmpty.Items.Add("You have not pick any slot on this day");
            }
        }
        private void buttonAvailable_Click(object sender, EventArgs e)
        {
            labelNotify.Text = "";
            if(listBoxInstructor.SelectedIndex == -1)
            {
                labelNotify.Text = "*Please select a timeslot.";
                labelNotify.Show();
                return;
            }
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            
            string s = listBoxInstructor.SelectedItem.ToString();
            SQL.selectQuery("select timeslot_id, set_date, set_time from appointment");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    if(id == SQL.read[0].ToString() && date == SQL.read[1].ToString() && s == SQL.read[2].ToString())
                    {
                        return;
                    }
                }
            }

            //SQL.selectQuery("select max(id) from appointment");
            //int count = 1;
            //if (SQL.read.HasRows)
            //{
            //    while (SQL.read.Read())
            //    {
            //        if (SQL.read[0].ToString() == null) { break; }
            //        count = int.Parse(SQL.read[0].ToString());
            //        count++;
            //    }
            //}
            int count = 0;
            SQL.selectQuery("select count(id) from appointment");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    if (int.Parse(SQL.read[0].ToString()) == 0) { count = 1; }
                    else {
                        SQL.selectQuery("select max(id) from appointment");

                        if (SQL.read.HasRows)
                        {
                            while (SQL.read.Read())
                            {
                                count = int.Parse(SQL.read[0].ToString());
                                count++;

                            }
                        }
                    }
                }
            }
            //MessageBox.Show("Insert appointment values (" + count + " , null, null, " + id + ", '" +  s + "', '" + date + "', null, '" + username + "')");
            DateTime testDay = DateTime.Parse(date);
            if (testDay.DayOfWeek.ToString() == "Saturday")
            {
                id = "1";
            }
            SQL.executeQuery("Insert appointment values (" + count + " , null, null, " + id + ", '" + s + "', '" + date + "', null, '" + username + "')");
            RefreshListBox();
            //buttonAvailable_Click(sender, e);
            //listBoxInstructor.s
        }

        private void buttonRemoveAvail_Click(object sender, EventArgs e)
        {
            labelNotify.Text = "";
            if (listBoxEmpty.SelectedIndex == -1)
            {
                labelNotify.Text = "*Please select a timeslot.";
                labelNotify.Show();
                return;
            }
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            
            string s = listBoxEmpty.SelectedItem.ToString();
            //SQL.selectQuery("select timeslot_id, set_date, set_time from appointment");

            //if (SQL.read.HasRows)
            //{
            //    while (SQL.read.Read())
            //    {
            //        if (id == SQL.read[0].ToString() && date == SQL.read[1].ToString() && s == SQL.read[2].ToString()) {
            DateTime testDay = DateTime.Parse(date);
            if (testDay.DayOfWeek.ToString() == "Saturday")
            {
                id = "1";
            }
            // MessageBox.Show("Delete from Appointment where timeslot_id = " + id + " and set_date = '" + date + "' and set_time = '" + s + "'");
            SQL.executeQuery("Delete from Appointment where timeslot_id = " + id + " and set_date = '" + date + "' and set_time = '" + s + "'");
                        RefreshListBox();
                //        break;
                //    }
                    
                //}
            //}
            
            //MessageBox.Show("Insert appointment values (" + count + " , null, null, " + id + ", '" +  s + "', '" + date + "', null, '" + username + "')");
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Hides the login page
            this.Hide();

            InstructorMainView back = new InstructorMainView(username);
            //show the register page
           back.ShowDialog();
            //close the login page
            this.Close();
        }
    }
}
