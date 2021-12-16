using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frame_Modeling.ucPanel
{
    public partial class ucScreen2 : UserControl
    {
        public event delLogSender eventdelLogSender;

        public ucScreen2()
        {
            InitializeComponent();
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            eventdelLogSender("Screen2", enLogLevel.Info, "Button Click");
        }
    }
}
