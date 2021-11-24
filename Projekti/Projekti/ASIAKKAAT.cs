using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projekti
{
    class ASIAKKAAT
    {
        CONN yhteys = new CONN();

        public DataTable haeAsiakkaat()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM asiakkaat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();

            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);

            return taulu;
        }

        public bool lisaaAsiakas(string enimi, string snimi, string puhelin)
        {
            MySqlCommand kysely = new MySqlCommand();
            string lisakysely = "INSERT INTO asiakkaat " +
"(etuNimi, sukuNimi, puhelin) VALUES " +
"(@enim, @snim, @puh);";

            kysely.CommandText = lisakysely;
            kysely.Connection = yhteys.otaYhteys();

            kysely.Parameters.Add("@enim", MySqlDbType.VarChar).Value = enimi;
            kysely.Parameters.Add("@snim", MySqlDbType.VarChar).Value = snimi;
            kysely.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin;

            yhteys.avaaYhteys();
            if (kysely.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        public bool muokkaaAsiakasta(int asiakasID, string enimi, string snimi, string puhelin)
        {
            MySqlCommand kysely = new MySqlCommand();
            string paivityskysely = "UPDATE asiakkaat SET etuNimi=@enim, sukuNimi=@snim, puhelin=@puh" +
         "WHERE asiakasID=@aid";


            kysely.CommandText = paivityskysely;
            kysely.Connection = yhteys.otaYhteys();

            kysely.Parameters.Add("@enim", MySqlDbType.VarChar).Value = enimi;
            kysely.Parameters.Add("@snim", MySqlDbType.VarChar).Value = snimi;
            kysely.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin;
            kysely.Parameters.Add("@aid", MySqlDbType.Int32).Value = asiakasID;

            yhteys.avaaYhteys();
            if (kysely.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

        public bool poistaAsiakas(int asiakasID)
        {
            MySqlCommand kysely = new MySqlCommand();
            string poistokysely = "DELETE FROM asiakkaat WHERE asiakasID=@aid";

            kysely.CommandText = poistokysely;
            kysely.Connection = yhteys.otaYhteys();

            kysely.Parameters.Add("@aid", MySqlDbType.Int32).Value = asiakasID;

            yhteys.avaaYhteys();
            if (kysely.ExecuteNonQuery() == 1)
            {
                yhteys.suljeYhteys();
                return true;
            }
            else
            {
                yhteys.suljeYhteys();
                return false;
            }
        }

    }
}
