using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Projekti
{
    class VARAUKSET
    {
        CONN yhteys = new CONN();

        public DataTable haeVaraukset()
        {
            MySqlCommand komento = new MySqlCommand("SELECT * FROM varaukset", yhteys.otaYhteys());
            MySqlDataAdapter adapteri = new MySqlDataAdapter();
            DataTable taulu = new DataTable();
            adapteri.SelectCommand = komento;
            adapteri.Fill(taulu);
            return taulu;
        }

        public DataTable haeVaraukset2()
        {
            MySqlCommand komento2 = new MySqlCommand("SELECT asiakasID, etuNimi, sukuNimi FROM asiakkaat", yhteys.otaYhteys());
            MySqlDataAdapter adapteri2 = new MySqlDataAdapter();
            DataTable taulu2 = new DataTable();
            adapteri2.SelectCommand = komento2;
            adapteri2.Fill(taulu2);
            return taulu2;
        }

        public DataTable haeVaraukset3()
        {
            MySqlCommand komento3 = new MySqlCommand("SELECT huoneNro, huoneTyyppi, vapaa FROM huoneet", yhteys.otaYhteys());
            MySqlDataAdapter adapteri3 = new MySqlDataAdapter();
            DataTable taulu3 = new DataTable();
            adapteri3.SelectCommand = komento3;
            adapteri3.Fill(taulu3);
            return taulu3;
        }

        public bool lisaaVaraus(int asiakasID, string huoneTyyppi, int huoneNumero, DateTime tuloPaiva, DateTime menoPaiva)
        {
            MySqlCommand kysely = new MySqlCommand();
            MySqlCommand kysely2 = new MySqlCommand();
            string lisakysely = "INSERT INTO varaukset " +
          "(AsiakasID, huoneTyyppi, huoneNro, tuloPvm, menoPvm) VALUES " +
          "(@asid, @huonetyyppi, @huonenro, @tulo, @meno);";

            string lisakysely2 = "INSERT INTO huoneet " +
         "(vapaa) VALUES " +
         "(@vap) WHERE huoneNro=@huonenro2;";

            kysely.CommandText = lisakysely;
            kysely.Connection = yhteys.otaYhteys();

            kysely2.CommandText = lisakysely2;
            kysely2.Connection = yhteys.otaYhteys();

            kysely.Parameters.Add("@asid", MySqlDbType.Int32).Value = asiakasID;
            kysely.Parameters.Add("@huonetyyppi", MySqlDbType.VarChar).Value = huoneTyyppi;
            kysely.Parameters.Add("@huonenro", MySqlDbType.Int32).Value = huoneNumero;
            kysely.Parameters.Add("@tulo", MySqlDbType.DateTime).Value = tuloPaiva;
            kysely.Parameters.Add("@meno", MySqlDbType.DateTime).Value = menoPaiva;

            kysely2.Parameters.Add("@huonenro2", MySqlDbType.Int32).Value = huoneNumero;
            kysely2.Parameters.Add("@vap", MySqlDbType.Bit).Value = 1;

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

        public bool muokkaaVarausta(int varausID, int asiakasID, int huoneNumero, string huoneTyyppi, DateTime tuloDate, DateTime menoDate)
        {
            MySqlCommand kysely = new MySqlCommand();
            string paivityskysely = "UPDATE varaukset SET AsiakasID=@aid, huoneNro=@huonenro, huoneTyyppi=@huonetyyppi, tuloPvm=@tulo, menoPvm=@meno" +
        "WHERE varausID=@varausid";


            kysely.CommandText = paivityskysely;
            kysely.Connection = yhteys.otaYhteys();

            kysely.Parameters.Add("@aid", MySqlDbType.Int32).Value = asiakasID;
            kysely.Parameters.Add("@huonenro", MySqlDbType.Int32).Value = huoneNumero;
            kysely.Parameters.Add("@huonetyyppi", MySqlDbType.VarChar).Value = huoneTyyppi;
            kysely.Parameters.Add("@tulo", MySqlDbType.DateTime).Value = tuloDate;
            kysely.Parameters.Add("@meno", MySqlDbType.DateTime).Value = menoDate;
            kysely.Parameters.Add("@varausid", MySqlDbType.Int32).Value = varausID;

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

        public bool poistaVaraus(int varausID)
        {
            MySqlCommand kysely = new MySqlCommand();
            string poistokysely = "DELETE FROM varaukset WHERE varausID=@vid";

            kysely.CommandText = poistokysely;
            kysely.Connection = yhteys.otaYhteys();

            kysely.Parameters.Add("@vid", MySqlDbType.Int32).Value = varausID;

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
