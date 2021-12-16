using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frame_Modeling    //namespace 동일하게. 전역으로 사용할 class
{
    class cGlobal
    {

    }

    public enum enLogLevel
    {
        Info,
        Warning,
        Error,
    }

    //ucScreen1~3 의 delegate. Main으로 Log를 전달하기 위함
    public delegate void delLogSender(object oSender, enLogLevel eLevel, string strLog);
}
