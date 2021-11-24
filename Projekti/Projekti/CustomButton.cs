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
    public partial class CustomButton : Button
    {
        public CustomButton()
        {
            InitializeComponent();
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

        }

        private void CustomButton_Load(object sender, EventArgs e)
        {

        }
    }
}
