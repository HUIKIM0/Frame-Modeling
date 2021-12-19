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
        public event delLogSender edelLogSender;

        public ucScreen2()
        {
            InitializeComponent();
        }

        private void btnChartLoad_Click(object sender, EventArgs e)
        {
            edelLogSender("Screen2", enLogLevel.Info, "Chart Load Button Click");
        }
    }
}
