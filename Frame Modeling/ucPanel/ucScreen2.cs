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
    public partial class ucScreen2 : UserControl
    {
        public event delLogSender edelLogSender;

        ChartData _cData = new ChartData();   // ChartData,SeriesChartType


        public ucScreen2()
        {
            InitializeComponent();

            ChartSales.Titles.Add("판매량");

        }

        private void btnChartLoad_Click(object sender, EventArgs e)
        {
            edelLogSender("Screen2", enLogLevel.Info, "Chart Load Button Click");

            ChartDataCreate(_cData);
        }


        private void ChartDataCreate(ChartData cData)
        {
            ChartSales.Series.Clear();

            DataTable dt = cData.Sc1Data;
            if (dt != null && dt.Rows.Count > 0)
            {
                // Row들을 가져옴
                foreach (DataRow oRow in dt.Rows)
                {
                    Series series = ChartSales.Series.Add(oRow["제품"].ToString()); // 음료수,고기,라면,김(오른쪽에 적힘)
                    series.ChartType = cData.Sc3ChartType;  // 차트 종류
                    series.Points.AddXY(enKor_Week.월.ToString(), oRow[enKor_Week.월.ToString()]); //차트의 아랫줄에 표기할 텍스트
                    series.Points.AddXY(enKor_Week.화.ToString(), oRow[enKor_Week.화.ToString()]);
                    series.Points.AddXY(enKor_Week.수.ToString(), oRow[enKor_Week.수.ToString()]);
                    series.Points.AddXY(enKor_Week.목.ToString(), oRow[enKor_Week.목.ToString()]);
                    series.Points.AddXY(enKor_Week.금.ToString(), oRow[enKor_Week.금.ToString()]);
                    series.Points.AddXY(enKor_Week.토.ToString(), oRow[enKor_Week.토.ToString()]);
                    series.Points.AddXY(enKor_Week.일.ToString(), oRow[enKor_Week.일.ToString()]);
                    //series.Points.AddXY("일", oRow["일"]);  //이름,데이터
                }
            }
        }


        /* 원본 틀은 cGlobal에
           ucScreen1,3의 데이터를 delegate event 로 모아서 class에 넣은건 Main
           Main에서 모은 class(데이터)를 받는다 */
        public void SetData(ChartData cData)
        {
            _cData = cData;
        }
    }
}
