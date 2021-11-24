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
    public partial class Jarjestelma : Form
    {
        CONN yhteys = new CONN();
        ASIAKKAAT asiakkaat = new ASIAKKAAT();
        HUONEET huoneet = new HUONEET();
        VARAUKSET varaukset = new VARAUKSET();
        

        bool formOnAuki = false;
        public Jarjestelma()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            asiakkaatDataBox.DataSource = asiakkaat.haeAsiakkaat();
            huoneetDataBox.DataSource = huoneet.haeHuoneet();
            varauksetDataBox1.DataSource = varaukset.haeVaraukset();
            varauksetDataBox2.DataSource = varaukset.haeVaraukset2();
            varauksetDataBox3.DataSource = varaukset.haeVaraukset3();
        }


        private void hallitseAsikkaitaBtn_Click(object sender, EventArgs e)
        {
            

            hallitseHuoneitaPanel.Visible = false;
            hallitseAsiakkaitaPanel.Visible = true;
            
            
            

        }

        private void hallitseHuoneitaBtn_Click(object sender, EventArgs e)
        {

            hallitseAsiakkaitaPanel.Visible = false;
            hallitseVarauksiaPanel.Visible = false;
            hallitseHuoneitaPanel.Visible = true;
           

        }

        private void hallitseVarauksiaBtn_Click(object sender, EventArgs e)
        {
            hallitseHuoneitaPanel.Visible = false;
            hallitseVarauksiaPanel.Visible = true;
            hallitseAsiakkaitaPanel.Visible = false;
           
        }

        private void tyhjennaVarausBtn_Click(object sender, EventArgs e)
        {
            asiakasVarausIDTB.Text = "";
            huoneNroVarausTB.Text = "";
            huoneTyyppiVarausTB.Text = "";
        }

        private void tyhjennaHuoneBtn_Click(object sender, EventArgs e)
        {
            huoneNroTB.Text = "";
            huoneTyyppiCB.Text = "Single";
            huonePuhTB.Text = "";
            huoneVapaaKylla.Checked = true;
            huoneVapaaEi.Checked = false;
        }

        private void tyhjennaAsiakasBtn_Click(object sender, EventArgs e)
        {
            etuNimiTB.Text = "";
            sukuNimiTB.Text = "";
            asiakasPuhTB.Text = "";
            //maa
        }

        private void lisaaVarausBtn_Click(object sender, EventArgs e)
        {
            int asiakasID = Convert.ToInt32(asiakasVarausIDTB.Text);
            int huoneNro = Convert.ToInt32(huoneNroVarausTB.Text);
            string huoneTyyppi = huoneTyyppiVarausTB.Text;
            DateTime tulo = varausTuloAikaDate.Value;
            DateTime meno = varausLahtoAikaDate.Value;

            if (asiakasID.Equals("") || huoneNro.Equals("") || huoneTyyppi.Trim().Equals("") || meno < DateTime.Now)
            {
                MessageBox.Show(asiakasID.ToString() + huoneNro.ToString() + huoneTyyppi + "VIRHE - Kaikki tiedot täytyy täyttää!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool lisaaVaraus = varaukset.lisaaVaraus(asiakasID, huoneTyyppi, huoneNro, tulo, meno);
                if (lisaaVaraus)
                {
                    MessageBox.Show("Uusi varaus lisätty onnistuneesti!", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta varausta ei pystytty lisäämään!", "Varauksen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                asiakkaatDataBox.DataSource = asiakkaat.haeAsiakkaat();
                huoneetDataBox.DataSource = huoneet.haeHuoneet();
                varauksetDataBox1.DataSource = varaukset.haeVaraukset();
                varauksetDataBox2.DataSource = varaukset.haeVaraukset2();
                varauksetDataBox3.DataSource = varaukset.haeVaraukset3();
            }
        }

        private void lisaaHuoneBtn_Click(object sender, EventArgs e)
        {
            int huoneNro = int.Parse(huoneNroTB.Text);
            string huoneTyyppi = huoneTyyppiCB.Text;
            string puhelin = huonePuhTB.Text;
            bool vapaa = false;


            if (huoneNro.Equals("") || puhelin.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Kaikki tiedot täytyy täyttää! Muista, että max oleskeluaika on 20 päivää!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*else if (huoneOn == 1)
{
MessageBox.Show("VIRHE - Huone on jo olemassa", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
}*/
            else
            {
                bool lisaaHuone = huoneet.lisaaHuone(huoneNro, huoneTyyppi, puhelin, vapaa);
                if (lisaaHuone)
                {
                    MessageBox.Show("Uusi huone lisätty onnistuneesti!", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta hunetta ei pystytty lisäämään!", "Huoneen lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                asiakkaatDataBox.DataSource = asiakkaat.haeAsiakkaat();
                huoneetDataBox.DataSource = huoneet.haeHuoneet();
                varauksetDataBox1.DataSource = varaukset.haeVaraukset();
                varauksetDataBox2.DataSource = varaukset.haeVaraukset2();
                varauksetDataBox3.DataSource = varaukset.haeVaraukset3();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string etuNimi = etuNimiTB.Text;
            string sukuNimi = sukuNimiTB.Text;
            string puhelin = asiakasPuhTB.Text;



            yhteys.suljeYhteys();

            if (etuNimi.Trim().Equals("") || sukuNimi.Trim().Trim().Equals("") || puhelin.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Kaikki tiedot täytyy täyttää! Muista, että max oleskeluaika on 20 päivää!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*else if (etuNimiOnJo != null && puhelinOnJo != null)
{
MessageBox.Show("VIRHE - Näillä tiedoilla löytyy jo asiakas!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
}*/
            else
            {
                bool lisaaAsiakas = asiakkaat.lisaaAsiakas(etuNimi, sukuNimi, puhelin);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas lisätty onnistuneesti!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty lisäämään!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                asiakkaatDataBox.DataSource = asiakkaat.haeAsiakkaat();
                huoneetDataBox.DataSource = huoneet.haeHuoneet();
                varauksetDataBox1.DataSource = varaukset.haeVaraukset();
                varauksetDataBox2.DataSource = varaukset.haeVaraukset2();
                varauksetDataBox3.DataSource = varaukset.haeVaraukset3();
            }
        }

        private void paivitaVarausBtn_Click(object sender, EventArgs e)
        {
            int asiakasID = Convert.ToInt32(asiakasVarausIDTB.Text);
            int huoneNro = Convert.ToInt32(huoneNroVarausTB.Text);
            string huoneTyyppi = huoneTyyppiVarausTB.Text;
            DateTime tulo = varausTuloAikaDate.Value;
            DateTime meno = varausLahtoAikaDate.Value;
            int varausID = Convert.ToInt32(varausIDTB.Text);

            if (asiakasID.Equals("") || huoneNro.Equals("") || huoneTyyppi.Trim().Equals("") || tulo < DateTime.Now || meno < DateTime.Now || meno > DateTime.Today.AddDays(20))
            {
                MessageBox.Show("VIRHE - Kaikki tiedot täytyy täyttää! Muista, että max oleskeluaika on 20 päivää!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool lisaaVaraus = varaukset.muokkaaVarausta(varausID, asiakasID, huoneNro, huoneTyyppi, tulo, meno);
                if (lisaaVaraus)
                {
                    MessageBox.Show("Varaus päivitetty onnistuneesti!", "Varauksen päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Varausta ei pystytty päivittämään!", "Varauksen päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                asiakkaatDataBox.DataSource = asiakkaat.haeAsiakkaat();
                huoneetDataBox.DataSource = huoneet.haeHuoneet();
                varauksetDataBox1.DataSource = varaukset.haeVaraukset();
                varauksetDataBox2.DataSource = varaukset.haeVaraukset2();
                varauksetDataBox3.DataSource = varaukset.haeVaraukset3();
            }
        }

        private void paivitaHuoneBtn_Click(object sender, EventArgs e)
        {
            int huoneNro = Convert.ToInt32(huoneNroVarausTB.Text);
            string huoneTyyppi = huoneTyyppiVarausTB.Text;
            string puhelin = huonePuhTB.Text;
            bool vapaa = false;
            int huoneID = Convert.ToInt32(huoneIDTB.Text);



            if (huoneNro.Equals("") || huoneTyyppi.Trim().Equals("") || puhelin.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Kaikki tiedot täytyy täyttää! Muista, että max oleskeluaika on 20 päivää!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool lisaaHuone = huoneet.muokkaaHuonetta(huoneID, huoneNro, huoneTyyppi, puhelin, vapaa);
                if (lisaaHuone)
                {
                    MessageBox.Show("Huone päivitetty onnistuneesti!", "Huoneen päivitys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Hunetta ei pystytty päivittämään!", "Huoneen päivitys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                asiakkaatDataBox.DataSource = asiakkaat.haeAsiakkaat();
                huoneetDataBox.DataSource = huoneet.haeHuoneet();
                varauksetDataBox1.DataSource = varaukset.haeVaraukset();
                varauksetDataBox2.DataSource = varaukset.haeVaraukset2();
                varauksetDataBox3.DataSource = varaukset.haeVaraukset3();
            }
        }

        private void paivitaAsiakasBtn_Click(object sender, EventArgs e)
        {
            string etuNimi = etuNimiTB.Text;
            string sukuNimi = sukuNimiTB.Text;
            string puhelin = asiakasPuhTB.Text;
            int asiakasID = Convert.ToInt32(asiakasIDTB.Text);

            if (etuNimi.Trim().Equals("") || sukuNimi.Trim().Trim().Equals("") || puhelin.Trim().Equals(""))
            {
                MessageBox.Show("VIRHE - Kaikki tiedot täytyy täyttää! Muista, että max oleskeluaika on 20 päivää!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool lisaaAsiakas = asiakkaat.muokkaaAsiakasta(asiakasID, etuNimi, sukuNimi, puhelin);
                if (lisaaAsiakas)
                {
                    MessageBox.Show("Uusi asiakas lisätty onnistuneesti!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Uutta asiakasta ei pystytty lisäämään!", "Asiakkaan lisäys", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                asiakkaatDataBox.DataSource = asiakkaat.haeAsiakkaat();
                huoneetDataBox.DataSource = huoneet.haeHuoneet();
                varauksetDataBox1.DataSource = varaukset.haeVaraukset();
                varauksetDataBox2.DataSource = varaukset.haeVaraukset2();
                varauksetDataBox3.DataSource = varaukset.haeVaraukset3();
            }
        }

        private void varauksetDataBox1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            varausIDTB.Text = varauksetDataBox1.CurrentRow.Cells[0].Value.ToString();
            asiakasVarausIDTB.Text = varauksetDataBox1.CurrentRow.Cells[1].Value.ToString();
            huoneTyyppiVarausTB.Text = varauksetDataBox1.CurrentRow.Cells[2].Value.ToString();
            huoneNroVarausTB.Text = varauksetDataBox1.CurrentRow.Cells[3].Value.ToString();
            varausTuloAikaDate.Value = (DateTime)varauksetDataBox1.CurrentRow.Cells[4].Value;
            varausLahtoAikaDate.Value = (DateTime)varauksetDataBox1.CurrentRow.Cells[5].Value;
        }

        private void varauksetDataBox2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            asiakasVarausIDTB.Text = varauksetDataBox2.CurrentRow.Cells[0].Value.ToString();
        }

        private void varauksetDataBox3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            huoneTyyppiVarausTB.Text = varauksetDataBox3.CurrentRow.Cells[1].Value.ToString();
            huoneNroVarausTB.Text = varauksetDataBox3.CurrentRow.Cells[0].Value.ToString();
        }

        private void huoneetDataBox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            huoneIDTB.Text = huoneetDataBox.CurrentRow.Cells[0].Value.ToString();
            huoneNroTB.Text = huoneetDataBox.CurrentRow.Cells[1].Value.ToString();
            huoneTyyppiCB.Text = huoneetDataBox.CurrentRow.Cells[2].Value.ToString();
            huonePuhTB.Text = huoneetDataBox.CurrentRow.Cells[3].Value.ToString();

            if (Convert.ToInt32(huoneetDataBox.CurrentRow.Cells[4].Value) == 1)
            {
                huoneVapaaEi.Checked = true;
                huoneVapaaKylla.Checked = false;
            }
            else
            {
                huoneVapaaKylla.Checked = true;
                huoneVapaaEi.Checked = false;
            }

        }

        private void asiakkaatDataBox_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            asiakasIDTB.Text = asiakkaatDataBox.CurrentRow.Cells[0].Value.ToString();
            etuNimiTB.Text = asiakkaatDataBox.CurrentRow.Cells[1].Value.ToString();
            sukuNimiTB.Text = asiakkaatDataBox.CurrentRow.Cells[2].Value.ToString();
            asiakasPuhTB.Text = asiakkaatDataBox.CurrentRow.Cells[3].Value.ToString();
            //maa
        }

        private void poistaAsiakasBtn_Click(object sender, EventArgs e)
        {
            int asiakasID = Convert.ToInt32(asiakasIDTB.Text);
            if (asiakkaat.poistaAsiakas(asiakasID))
            {
                asiakkaatDataBox.DataSource = asiakkaat.haeAsiakkaat();
                MessageBox.Show("Asiakas poistettiin onnistuneesti!", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Asiakasta ei pystytty poistamaan!", "Asiakkaan poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaAsiakasBtn.PerformClick();
        }

        private void poistaHuoneBtn_Click(object sender, EventArgs e)
        {
            int huoneID = Convert.ToInt32(huoneIDTB.Text);
            if (asiakkaat.poistaAsiakas(huoneID))
            {
                huoneetDataBox.DataSource = huoneet.haeHuoneet();
                MessageBox.Show("Huone poistettiin onnistuneesti!", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Huonetta ei pystytty poistamaan!", "Huoneen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaHuoneBtn.PerformClick();
        }

        private void poistaVarausBtn_Click(object sender, EventArgs e)
        {
            int varausID = Convert.ToInt32(varausIDTB.Text);
            if (asiakkaat.poistaAsiakas(varausID))
            {
                varauksetDataBox1.DataSource = varaukset.haeVaraukset();
                MessageBox.Show("Varaus poistettiin onnistuneesti!", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Varausta ei pystytty poistamaan!", "Varauksen poisto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tyhjennaVarausBtn.PerformClick();
        }
    }
}

