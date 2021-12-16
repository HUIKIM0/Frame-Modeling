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
    public partial class ucScreen1 : UserControl
    {

        public event delLogSender eventdelLogSender;

        public ucScreen1()
        {
            InitializeComponent();
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            //Main에 줄 정보
            eventdelLogSender("Screen1", enLogLevel.Info, "Button Click");
        }
    }
}
