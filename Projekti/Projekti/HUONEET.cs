using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Projekti
{
    class HUONEET
    {
        CONN yhteys = new CONN();

        public DataTable haeHuoneet()
        {
            try
            {
                MySqlCommand komento = new MySqlCommand("SELECT * FROM huoneet", yhteys.otaYhteys());
                MySqlDataAdapter adapteri = new MySqlDataAdapter();
                DataTable taulu = new DataTable();

                adapteri.SelectCommand = komento;
                adapteri.Fill(taulu);

                return taulu;
            }
            catch
            {
                MessageBox.Show("VIRHE - Huoneita ei pystytty hakemaan!", "Huoneiden haku", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public bool lisaaHuone(int huoneNumero, string huoneTyyppi, string puhelin, bool vapaa)
        {
            MySqlCommand kysely = new MySqlCommand();
            string lisakysely = "INSERT INTO huoneet " +
            "(huoneNro, huoneTyyppi, puhelin, vapaa) VALUES " +
            "(@huonenro, @huonetyyppi, @puh, @vap);";

            kysely.CommandText = lisakysely;
            kysely.Connection = yhteys.otaYhteys();

            kysely.Parameters.Add("@huonenro", MySqlDbType.Int32).Value = huoneNumero;
            kysely.Parameters.Add("@huonetyyppi", MySqlDbType.VarChar).Value = huoneTyyppi;
            kysely.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin;
            kysely.Parameters.Add("@vap", MySqlDbType.Bit).Value = vapaa;

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

        public bool muokkaaHuonetta(int huoneID, int huoneNumero, string huoneTyyppi, string puhelin, bool vapaa)
        {
            MySqlCommand kysely = new MySqlCommand();
            string paivityskysely = "UPDATE huoneet SET huoneNro=@huonenro, huoneTyyppi=@huonetyyppi, puhelin=@puh, vapaa=@vap" +
        "WHERE huoneID=@huoneid";


            kysely.CommandText = paivityskysely;
            kysely.Connection = yhteys.otaYhteys();

            kysely.Parameters.Add("@huonenro", MySqlDbType.Int32).Value = huoneNumero;
            kysely.Parameters.Add("@huonetyyppi", MySqlDbType.VarChar).Value = huoneTyyppi;
            kysely.Parameters.Add("@puh", MySqlDbType.VarChar).Value = puhelin;
            kysely.Parameters.Add("@vap", MySqlDbType.Bit).Value = vapaa;
            kysely.Parameters.Add("@huoneid", MySqlDbType.Int32).Value = huoneID;

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

        public bool poistaHuone(int huoneID)
        {
            MySqlCommand kysely = new MySqlCommand();
            string poistokysely = "DELETE FROM huoneet WHERE huoneID=@hid";

            kysely.CommandText = poistokysely;
            kysely.Connection = yhteys.otaYhteys();

            kysely.Parameters.Add("@hid", MySqlDbType.Int32).Value = huoneID;

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
