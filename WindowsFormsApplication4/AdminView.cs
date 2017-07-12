using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class AdminView : Form
    {
        public AdminView()
        {
            InitializeComponent();
            listBoxBill.Items.Clear();
            RefreshView();
            
        }
        private void RefreshView()
        {
            listBoxBill.Items.Clear();
            SQL.selectQuery("select id, Convert(varchar(10),doc_date, 21), client_username from document where doc_type = 'Bill' and pay is null");
            if (SQL.read.HasRows)
            {
                while (SQL.read.Read())
                {

                    listBoxBill.Items.Add(SQL.read[0].ToString() + "        " + SQL.read[1].ToString() + "        " + SQL.read[2].ToString() );
                }
            }
            else
            {
                listBoxBill.Items.Add("No Bill outstanding.");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //Hides the login page
            this.Hide();
            AdminSchedulingView admin = new AdminSchedulingView();
            //show the register page
            admin.ShowDialog();
            //close the login page
            this.Close();
        }

        private void buttonUnregister_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonConfirmPay_Click(object sender, EventArgs e)
        {
            int id = 0;
            labelError.Text = "";
            string[] selected = Regex.Split(listBoxBill.SelectedItem.ToString(), @"\s+");
            id = int.Parse(selected[0]);
            if (listBoxBill.SelectedIndex == -1)
            {
                labelError.Text = "*Please select a bill.";
                labelError.Show();
                return;
            }
            SQL.executeQuery("Update document set pay = 'Yes' where id = " + id);
            RefreshView();
        }

        private void buttonStat_Click(object sender, EventArgs e)
        {

            //Hides the login page
            this.Hide();
           StatisticView stat = new StatisticView();
            //show the register page
            stat.ShowDialog();
            //close the login page
            this.Close();
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
