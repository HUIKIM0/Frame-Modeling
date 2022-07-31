using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Frame_Modeling    //namespace 동일하게. 전역으로 사용할
{
    class cGlobal
    {

    }

    
    /* 외부에서도 바로 사용 가능한 publit class 모아놓음 */

    public enum enLogLevel
    {
        Info,
        Warning,
        Error,
    }

    public enum enKor_Week
    {
        월,
        화,
        수,
        목,
        금,
        토,
        일,
    }

    #region delegate 선언부분. event가 아닌, 선언이므로 여기에 써줘도OK 공통으로 가져갈것
   
    //ucScreen1~3 의 delegate. Main으로 Log를 전달
    public delegate void delLogSender(object oSender, enLogLevel eLevel, string strLog);

    //ucScreen1의 delegate. Main으로 Data값을 전달
    public delegate void delDataTableSender(object oSender, DataTable dt);
    //ucScreen3의 delegate. Main으로 Chart종류를 전달
    public delegate void delChartTypeSender(object oSender, SeriesChartType ct);

    #endregion

    // Screen1/Screen3의 값을 가질 class
    public class ChartData
    {
        DataTable _Sc1Data;
        SeriesChartType _Sc3ChartType = SeriesChartType.Area;

        public DataTable Sc1Data { get => _Sc1Data; set => _Sc1Data = value; }
        public SeriesChartType Sc3ChartType { get => _Sc3ChartType; set => _Sc3ChartType = value; }
    }

}
