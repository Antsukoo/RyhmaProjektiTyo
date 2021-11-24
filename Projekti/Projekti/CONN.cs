using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projekti
{
    class CONN
    {
        private MySqlConnection yhteys = new MySqlConnection("datasource=localhost; port=3306; username=root; password=; database=hotelli");

        public MySqlConnection otaYhteys()
        {
            return yhteys;
        }

        public void suljeYhteys()
        {
            if (yhteys.State == ConnectionState.Open)
            {
                yhteys.Close();
            }
        }

        public void avaaYhteys()
        {
            if (yhteys.State == ConnectionState.Closed)
            {
                yhteys.Open();
            }
        }

    }
}
