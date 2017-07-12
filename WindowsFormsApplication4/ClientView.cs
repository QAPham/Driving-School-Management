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
    public partial class ClientView : Form
    {
        private string username;
        public ClientView(string _username)
        {
            InitializeComponent();
            username = _username;
        }

        private void ClientView_Load(object sender, EventArgs e)
        {

        }

        private void buttonBook_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClientBook client = new ClientBook(username);
            client.ShowDialog();
            this.Close();
        }
    }
}
