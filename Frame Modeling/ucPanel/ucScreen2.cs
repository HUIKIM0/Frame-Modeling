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

        //원본 틀은 cGlobal에
        //uc1,3의 값을 delegate event 모은건 Main. Main에서 원본쪽에 값 넣어줌
        ChartData cData = new ChartData();

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
