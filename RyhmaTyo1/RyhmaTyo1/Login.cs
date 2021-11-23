using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace RyhmaTyo1
{
    public partial class Login : Form
    {
        private MySqlConnection connect = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=hoteli");
        public Login()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string user = UserTB.Text;
            string pass = PassTB.Text;
            DataTable data = new DataTable();

            try
            {
                adapter.SelectCommand = new MySqlCommand("SELECT * FROM login WHERE username = '" + user + "' AND password = '" + pass + "'", connect);
                adapter.Fill(data);
                if (data.Rows.Count <= 0)
                {
                    MessageBox.Show("Username or password is invalid", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Unable to establish connection", "Authentication Runtime Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           

        }

      
    }
}
