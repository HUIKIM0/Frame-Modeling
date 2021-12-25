using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frame_Modeling
{
    public partial class Form1 : Form
    {
        #region 전역변수 유저컨트롤러 new / cGlobal.cs의 class ChartData
        ucPanel.ucScreen1 Sc1 = new ucPanel.ucScreen1();
        ucPanel.ucScreen2 Sc2 = new ucPanel.ucScreen2();
        ucPanel.ucScreen3 Sc3 = new ucPanel.ucScreen3();

        ChartData cData = new ChartData();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pMain.Controls.Add(Sc1);
            Sc1.Dock = DockStyle.Fill;
            Sc2.Dock = DockStyle.Fill;
            Sc3.Dock = DockStyle.Fill;

            Sc1.edelLogSender += Sc_edelLogSender;
            Sc2.edelLogSender += Sc_edelLogSender;
            Sc3.edelLogSender += Sc_edelLogSender;

            Sc1.edelDataSender += Sc1_edelDataSender;
            Sc3.edelChartTypeSender += Sc3_edelChartTypeSender;
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch (btn.Name)
            {
                case "btnInputSc1":
                    pMain.Controls.Clear();
                    pMain.Controls.Add(Sc1);

                    break;
                case "btnChaSc2":
                    pMain.Controls.Clear();
                    pMain.Controls.Add(Sc2);

                    break;
                case "btnConSc3":
                    pMain.Controls.Clear();
                    pMain.Controls.Add(Sc3);
                    break;
                case "btnExit":
                    Application.Exit();
                    break;

                default:
                    break;
            }

        }


        #region delegate event
        //ucScreen1~3 Log
        private void Sc_edelLogSender(object oSender, enLogLevel eLevel, string strLog)
        {
            Log(eLevel,$"[{oSender}] {strLog}");

        }

        //ucScreen1
        private void Sc1_edelDataSender(object oSender, DataTable dt)
        {
            cData.Sc1Data = dt;
        }

        private void Sc3_edelChartTypeSender(object oSender, System.Windows.Forms.DataVisualization.Charting.SeriesChartType ct)
        {
            cData.Sc3ChartType = ct;
        }
        #endregion


        #region Log OverLoading
        private void Log(enLogLevel eLevel, string LogDesc)
        {
            DateTime dTime = DateTime.Now;
            string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
            lboxLog.Items.Insert(0, LogInfo);
        }
        private void Log(DateTime dTime, enLogLevel eLevel, string LogDesc)
        {
            string LogInfo = $"{dTime:yyyy-MM-dd hh:mm:ss.fff} [{eLevel.ToString()}] {LogDesc}";
            lboxLog.Items.Insert(0, LogInfo);
        }
        #endregion

    }
}
