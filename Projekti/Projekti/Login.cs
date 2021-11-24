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

namespace Projekti
{
    public partial class Login : Form
    {
        CONN yhteys = new CONN();
        private MySqlConnection connect = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=hotelli");
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        DataTable data = new DataTable();
        public Login()
        {
            InitializeComponent();
        }

        private void kirjauduBtn_Click(object sender, EventArgs e)
        {
            string user = usernameTB.Text;
            string pass = passwordTB.Text;

            try
            {
                adapter.SelectCommand = new MySqlCommand("SELECT * FROM login WHERE username = '" + user + "' AND password = '" + pass + "'", connect);
                adapter.Fill(data);
                if (data.Rows.Count <= 0)
                {
                    if (pass.Contains("Keuda") == true)
                    {
                        string passReal = pass.Replace("Keuda", "");
                        MySqlCommand kysely = new MySqlCommand();
                        string lisakysely = "INSERT INTO login (username, password) VALUES (@user, @pwd);";

                        kysely.CommandText = lisakysely;
                        kysely.Connection = yhteys.otaYhteys();

                        kysely.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
                        kysely.Parameters.Add("@pwd", MySqlDbType.VarChar).Value = passReal;


                        yhteys.avaaYhteys();
                        if (kysely.ExecuteNonQuery() == 1)
                        {
                            yhteys.suljeYhteys();
                            MessageBox.Show("Onnistui - Väärät tunnukset!", "Kirjautuminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            yhteys.suljeYhteys();
                            MessageBox.Show("Virhe - Väärät tunnukset!", "Kirjautuminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MessageBox.Show("Käyttäjä luotu! Paina uudestaan. Salasanasi on syöttämäsi salasana - 'Keuda'!", "Käyttäjän luonti", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        passwordTB.Text = passReal;
                    }
                    else
                    {
                        MessageBox.Show("Virhe - Väärät tunnukset!", "Kirjautuminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    Jarjestelma form = new Jarjestelma();
                    form.Show();
                    this.Hide();
                }
            } catch
            {
                MessageBox.Show("Virhe - Yhteytä ei pystynyt muodostaa", "Kirjautuminen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

           
        }

      
    }
}
