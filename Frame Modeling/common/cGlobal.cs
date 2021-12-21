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

    
    /* 외부에서도 바로 사용 가능하게 class밖에 */

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

    //ucScreen1~3 의 delegate. Main으로 Log를 전달하기 위함
    public delegate void delLogSender(object oSender, enLogLevel eLevel, string strLog);

    //ucScreen1의 delegate Main으로 Data값을 전달하기 위함
    public delegate void delDataTableSender(object oSender, DataTable dt);
    //ucScreen3의 delegate Main으로 Chart종류를 전달하기 위함
    public delegate void delChartTypeSender(object oSender, SeriesChartType ct);


}
