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
        #region 전역변수 유저컨트롤러
        ucPanel.ucScreen1 Sc1 = new ucPanel.ucScreen1();
        ucPanel.ucScreen2 Sc2 = new ucPanel.ucScreen2();
        ucPanel.ucScreen3 Sc3 = new ucPanel.ucScreen3();
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pMain.Controls.Add(Sc1);
            Sc1.Dock = DockStyle.Fill;
        }
    }
}
