using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

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


        /* ComboBox선택한 거 Chart Type으로 -> delegate event 통해 Main으로 넘김 */
        private void cboxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            edelLogSender("Screen3", enLogLevel.Info, "Button Click");

            SeriesChartType cType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), cboxType.SelectedIndex.ToString());
            edelChartTypeSender(this, cType);

        }


        /* Loading시 Chart Type을 ComboBox에 넣어준다*/
        private void ucScreen3_Load(object sender, EventArgs e)
        {
            foreach (SeriesChartType oType in Enum.GetValues(typeof(SeriesChartType)))
            {
                cboxType.Items.Add(oType.ToString());
            }

            cboxType.SelectedIndex = 0;
        }


    }
}
