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
        public event delLogSender edelLogSender;
        public event delDataTableSender edelDataSender;

        DataTable dt = new DataTable();   //DataTable dt;

        public ucScreen1()
        {
            InitializeComponent();
        }

        private void btnRandomSet_Click(object sender, EventArgs e)
        {
            //Main에 줄 Log 정보
            edelLogSender("Screen1", enLogLevel.Info, "Random Set Button Click");

            DataClear();
            DataCreate();

            DataTable dt = DGV.DataSource as DataTable;  //★
            edelDataSender(this, dt);
        }


        private void DataCreate()
        {
            dt = new DataTable();

            /* DataColumn 신규생성 */
            DataColumn colProduct = new DataColumn("제품",typeof(string));
            DataColumn colMon = new DataColumn("월",typeof(string));
            DataColumn colTue = new DataColumn("화", typeof(string));
            DataColumn colWen = new DataColumn("수", typeof(string));
            DataColumn colThu = new DataColumn("목", typeof(string));
            DataColumn colFri = new DataColumn("금", typeof(string));
            DataColumn colSat = new DataColumn("토", typeof(string));
            DataColumn colSun = new DataColumn("일", typeof(string));

            /* 생성된 DataColumn을 DataTable에 Add */
            dt.Columns.Add(colProduct);
            dt.Columns.Add(colMon);
            dt.Columns.Add(colTue);
            dt.Columns.Add(colWen);
            dt.Columns.Add(colThu);
            dt.Columns.Add(colFri);
            dt.Columns.Add(colSat);
            dt.Columns.Add(colSun);


            //DataRow row = dt.NewRow();
            //row["제품"] = "컵라면";     Column 월~일은 랜덤으로 반복해서 돌릴거라 함수만듦

            Random rd = new Random();

            DataRowCreate(dt, "샴푸", rd);
            DataRowCreate(dt, "장난감", rd);
            DataRowCreate(dt, "라면", rd);
            DataRowCreate(dt, "김", rd);


            DGV.DataSource = dt;    

        }

        private void DataRowCreate(DataTable dt,string strProduct,Random rd)
        { 
            /* DataRow 신규생성 */
            DataRow row = dt.NewRow();
            row["제품"] = strProduct;

            foreach (enKor_Week week in Enum.GetValues(typeof(enKor_Week)))
            {
                row[week.ToString()] = rd.Next(30, 301);
            }

            dt.Rows.Add(row);
        }

        private void DataClear()
        {
            dt.Clear();
            DGV.DataSource = null;
        }
    }
}
