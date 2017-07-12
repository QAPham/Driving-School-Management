using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class AdminSchedulingView : Form
    {
        private string username;
        private string[] instructor;
        private string id = "";
        public AdminSchedulingView()
        {
            InitializeComponent();
            SetupComboBox();
            buttonSetAvailable.Enabled = false;
            buttonRemoveAvailable.Enabled = false;
            buttonAssign.Enabled = false;
            buttonViewCar.Enabled = false;
        }

        private void SetupComboBox()
        {
            comboBoxInstructor.Items.Add("All");
            SQL.selectQuery("Select username from instructor");
            if(SQL.read.HasRows)
            {
                while(SQL.read.Read())
                {
                    comboBoxInstructor.Items.Add(SQL.read[0].ToString());
                }
            }
            //SQL.selectQuery("Select license from car");
            //if (SQL.read.HasRows)
            //{
            //    while (SQL.read.Read())
            //    {
            //        comboBoxCar.Items.Add(SQL.read[0].ToString());
            //    }
            //}
        }
        private void AdminSchedulingView_Load(object sender, EventArgs e)
        {
            //SQL.selectQuery("select count(id) from appointment");
            //int count = int.Parse(SQL.read[0].ToString());
            //count++;
            //SQL.executeQuery();
        }

        private void buttonViewAvailabilty_Click(object sender, EventArgs e)
        {
            if (comboBoxInstructor.Text != "All")
            {
                buttonSetAvailable.Enabled = true;
                buttonRemoveAvailable.Enabled = true;
                buttonViewCar.Enabled = true;

                username = comboBoxInstructor.Text;
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
            else
            {
                RefreshListBoxAll();
                buttonSetAvailable.Enabled = false;
                buttonRemoveAvailable.Enabled = false;
                buttonAssign.Enabled = false;
                buttonViewCar.Enabled = false;
            }
        }

        private void RefreshListBox()
        {
            listBoxInstructor.Items.Clear();
            listBoxEmpty.Items.Clear();
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            DateTime testDay = DateTime.Parse(date);
            if(testDay.DayOfWeek.ToString() == "Saturday")
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
            SQL.selectQuery("select set_time from timeslot where id = " + id + " and set_date = '" + date + "' and set_time in (select set_time from appointment where set_date = '" + date + "' and timeslot_id = " + id + " and instructor_name ='" + username + "') order by set_time");
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
        private void RefreshListBoxAll()
        {
            listBoxInstructor.Items.Clear();
            listBoxEmpty.Items.Clear();
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");

            SQL.selectQuery("select set_time, instructor_name, car_license from appointment where set_date = '" + date + "'  order by set_time");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {
                    listBoxEmpty.Items.Add(SQL.read[0].ToString() + "        " + SQL.read[1].ToString() + "        " + SQL.read[2].ToString());
                }
            }
            else
            {
                listBoxEmpty.Items.Add("There are no slot to pick from on this day.");
            }
            //SQL.selectQuery("select set_time, instructor_name from timeslot where set_date = '" + date + "' and set_time in (select set_time from appointment where set_date = '" + date + "' ) order by set_time");
            //if (SQL.read.HasRows)
            //{
            //    while (SQL.read.Read())
            //    {
            //        listBoxEmpty.Items.Add(SQL.read[0].ToString() + " " + SQL.read[1].ToString());
            //    }
            //}
            //else
            //{
            //    listBoxEmpty.Items.Add("You have not pick any slot on this day");
            //}
        }
        private void buttonSetAvailable_Click(object sender, EventArgs e)
        {
            labelNotify.Text = "";
            if (listBoxInstructor.SelectedIndex == -1)
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
                    if (id == SQL.read[0].ToString() && date == SQL.read[1].ToString() && s == SQL.read[2].ToString())
                    {
                        return;
                    }
                }
            }
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
        }

        private void buttonRemoveAvailable_Click(object sender, EventArgs e)
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
            DateTime testDay = DateTime.Parse(date);
            if (testDay.DayOfWeek.ToString() == "Saturday")
            {
                id = "1";
            }
            SQL.executeQuery("Delete from Appointment where timeslot_id = " + id + " and set_date = '" + date + "' and set_time = '" + s + "'");
            RefreshListBox();
        }

        private void buttonViewCar_Click(object sender, EventArgs e)
        {
            labelNotifyCar.Text = "";
            if (listBoxEmpty.SelectedIndex == -1)
            {
                labelNotifyCar.Text = "*Please select a chosen timeslot.";
                return;
            }
            RefreshCar();
            buttonAssign.Enabled = true;

        }
        private void RefreshCar()
        {
            listBoxCar.Items.Clear();
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            string time = listBoxEmpty.SelectedItem.ToString();
            //MessageBox.Show(time);
            //SQL.executeQuery("SET ANSI_NULLS OFF");
            SQL.selectQuery("select license, make from car where license Not in (select car_license from appointment where set_date = '" + date + "' and set_time = '" + time + "' and car_license is not null)");


            if (SQL.read.HasRows)
            {

                while (SQL.read.Read())
                {
                    listBoxCar.Items.Add(SQL.read[0].ToString() + "        " + SQL.read[1].ToString());

                }

            }
            else
            {
                int row = 0;
                SQL.selectQuery("select car_license from appointment where set_date = '" + date + "' and set_time = '" + time + "'");
                if (SQL.read.HasRows)
                {

                    while (SQL.read.Read())
                    {
                        row++;
                    }

                }
                SQL.selectQuery("select car_license from appointment where set_date = '" + date + "' and set_time = '" + time + "'");
                if (SQL.read.HasRows)
                {

                    while (SQL.read.Read())
                    {
                        row++;
                        if (SQL.read[0].ToString().Equals("") )
                        {
                            SQL.selectQuery("select license, make from car");
                            if (SQL.read.HasRows)
                            {

                                while (SQL.read.Read())
                                {
                                    listBoxCar.Items.Add(SQL.read[0].ToString() + "        " + SQL.read[1].ToString());

                                }

                            }
                            break;
                        }

                    }

                }
                else {
                    listBoxCar.Items.Add("There are no car available at this timeslot.");
                }
            }

        }
        private void buttonAssign_Click(object sender, EventArgs e)
        {
            labelNotifyCar.Text = "";
            if (listBoxCar.SelectedIndex == -1)
            {
                labelNotifyCar.Text = "*Please select a car.";
                return;
            }
            //MessageBox.Show(listBoxCar.SelectedItem.ToString());
            string[] car = listBoxCar.SelectedItem.ToString().Split(' ');
            string license = car[0];
            string date = dateTimePicker.Value.ToString("yyyy-MM-dd");
            DateTime testDay = DateTime.Parse(date);
            if (testDay.DayOfWeek.ToString() == "Saturday")
            {
                id = "1";
            }
            //string[] x = listBoxEmpty.SelectedItem.ToString().Split(' ');
            //string s = x[1];
            string time = listBoxEmpty.SelectedItem.ToString();
            SQL.executeQuery("UPDATE appointment SET car_license = '" + license + "' where set_date = '" + date + "' and timeslot_id = " + id + " and set_time = '" + time+"'");

            RefreshCar();
        }

        private void buttonOut_Click(object sender, EventArgs e)
        {
            //Hides the login page
            this.Hide();
            AdminView off = new AdminView();
            //show the register page
            off.ShowDialog();
            //close the login page
            this.Close();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Hides the login page
            this.Hide();
            AdminView off = new AdminView();
            //show the register page
            off.ShowDialog();
            //close the login page
            this.Close();
        }
    }
}
