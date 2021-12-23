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
    public partial class ucScreen3 : UserControl
    {
        public event delLogSender edelLogSender;
        public event delChartTypeSender edelChartTypeSender;

        public ucScreen3()
        {
            InitializeComponent();
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            edelLogSender("Screen3", enLogLevel.Info, "Button Click");
        }
    }
}
