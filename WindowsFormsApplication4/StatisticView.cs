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
    public partial class StatisticView : Form
    {
        public StatisticView()
        {
            InitializeComponent();
            radioButtonToday.Select();
            radioButtonClient.Select();
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            string startDate = "";
            string endDate = "";
            textBoxInfo.Clear();
            if(radioButtonToday.Checked == true)
            {
                startDate = DateTime.Today.ToString("yyyy-MM-dd");
            }
            else if(radioButtonWeek.Checked == true)
            {
               
                    DateTime startOfWeek = DateTime.Today.AddDays(-1 * (int)(DateTime.Today.DayOfWeek));
                    startDate = startOfWeek.ToString("yyyy-MM-dd");
                    endDate = startOfWeek.AddDays(6).ToString("yyyy-MM-dd");               

            }
            else {
                DateTime startofMonth = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
                startDate = startofMonth.ToString("yyyy-MM-dd");
                endDate = startofMonth.AddMonths(1).AddDays(-1).ToString("yyyy-MM-dd");
            }


            if(radioButtonClient.Checked == true)
            {
                if (endDate == "")
                {
                    SQL.selectQuery("select count(distinct client_username) from appointment where set_date = '" + startDate + "'");
                    if (SQL.read.HasRows)
                    {
                        while (SQL.read.Read())
                        {
                            //MessageBox.Show(SQL.read[0].ToString());
                            if (SQL.read[0].ToString() != "")
                            {
                                textBoxInfo.Text = "Number of client that booked appointment today: " + SQL.read[0].ToString();
                            }
                        }
                    }
                }
                else
                {
                    SQL.selectQuery("select count(distinct client_username) from appointment where set_date between '" + startDate + "' and '" + endDate + "'");
                    if (SQL.read.HasRows)
                    {
                        while (SQL.read.Read())
                        {
                            //MessageBox.Show(SQL.read[0].ToString());
                            if (SQL.read[0].ToString() != "")
                            {
                                if (radioButtonMonth.Checked == true)
                                {
                                    textBoxInfo.Text = "Number of client that booked appointment this month: " + SQL.read[0].ToString();
                                }
                                else
                                {
                                    textBoxInfo.Text = "Number of client that booked appointment this week: " + SQL.read[0].ToString();
                                }
                            }
                        }
                    }
                }
            }
            else if (radioButtonApp.Checked == true)
            {
                if (endDate == "")
                {
                    SQL.selectQuery("select instructor_name, COUNT(client_username)from appointment where set_date = '" + startDate + "' group by instructor_name");
                    if (SQL.read.HasRows)
                    {
                        while (SQL.read.Read())
                        {
                            //MessageBox.Show(SQL.read[0].ToString());
                            if (SQL.read[0].ToString() != "")
                            {
                                textBoxInfo.Text += SQL.read[0].ToString() + "                     " + SQL.read[1].ToString() + "\r\n";
                            }
                        }
                    }
                    SQL.selectQuery("select COUNT(client_username)from appointment where set_date = '" + startDate + "'");
                    if (SQL.read.HasRows)
                    {
                        while (SQL.read.Read())
                        {
                            //MessageBox.Show(SQL.read[0].ToString());
                            if (SQL.read[0].ToString() != "")
                            {
                                textBoxInfo.Text += "Total:                    " + SQL.read[0].ToString();
                            }
                        }
                    }
                }
                else
                {
                    SQL.selectQuery("select instructor_name, COUNT(client_username)from appointment where set_date between '" + startDate + "' and '" + endDate + "' group by instructor_name");
                    if (SQL.read.HasRows)
                    {
                        while (SQL.read.Read())
                        {
                            //MessageBox.Show(SQL.read[0].ToString());
                            if (SQL.read[0].ToString() != "")
                            {
                                textBoxInfo.Text += SQL.read[0].ToString() + "                     " + SQL.read[1].ToString() + "\r\n";
                            }
                        }

                    }
                    SQL.selectQuery("select COUNT(client_username)from appointment where set_date between '" + startDate + "' and '" + endDate + "'");
                    if (SQL.read.HasRows)
                    {
                        while (SQL.read.Read())
                        {
                            //MessageBox.Show(SQL.read[0].ToString());
                            if (SQL.read[0].ToString() != "")
                            {
                                textBoxInfo.Text += "Total:                    " + SQL.read[0].ToString();
                            }
                        }
                    }
                }
            }
            else
            {
                if (endDate == "")
                {
                    SQL.selectQuery("select instructor_name, COUNT(id)from appointment where set_date = '" + startDate + "' group by instructor_name");
                    if (SQL.read.HasRows)
                    {
                        while (SQL.read.Read())
                        {
                            //MessageBox.Show(SQL.read[0].ToString());
                            if (SQL.read[0].ToString() != "")
                            {
                                textBoxInfo.Text += SQL.read[0].ToString() + "                     " + SQL.read[1].ToString() + "\r\n";
                            }
                        }
                    }
                    SQL.selectQuery("select COUNT(id)from appointment where set_date = '" + startDate + "'");
                    if (SQL.read.HasRows)
                    {
                        while (SQL.read.Read())
                        {
                            //MessageBox.Show(SQL.read[0].ToString());
                            if (SQL.read[0].ToString() != "")
                            {
                                textBoxInfo.Text += "Total:                    " + SQL.read[0].ToString();
                            }
                        }
                    }
                }
                else
                {
                    SQL.selectQuery("select instructor_name, COUNT(id)from appointment where set_date between '" + startDate + "' and '" + endDate + "' group by instructor_name");
                    if (SQL.read.HasRows)
                    {
                        while (SQL.read.Read())
                        {
                            //MessageBox.Show(SQL.read[0].ToString());
                            if (SQL.read[0].ToString() != "")
                            {
                                textBoxInfo.Text += SQL.read[0].ToString() + "                     " + SQL.read[1].ToString() + "\r\n";
                            }
                        }

                    }
                    SQL.selectQuery("select COUNT(id)from appointment where set_date between '" + startDate + "' and '" + endDate + "'");
                    if (SQL.read.HasRows)
                    {
                        while (SQL.read.Read())
                        {
                            //MessageBox.Show(SQL.read[0].ToString());
                            if (SQL.read[0].ToString() != "")
                            {
                                textBoxInfo.Text += "Total:                    " + SQL.read[0].ToString();
                            }
                        }
                    }
                }
            }
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
