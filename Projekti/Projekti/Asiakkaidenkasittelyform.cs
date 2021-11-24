using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekti
{
    public partial class Asiakkaidenkasittelyform : Form
    {
        public bool onAuki = false;
        public Asiakkaidenkasittelyform()
        {
            InitializeComponent();
        }

        private void Asiakkaidenkasittelyform_FormClosed(object sender, FormClosedEventArgs e)
        {
            onAuki = false;
        }

        private void Asiakkaidenkasittelyform_Activated(object sender, EventArgs e)
        {
            onAuki = true;
        }
    }
}
