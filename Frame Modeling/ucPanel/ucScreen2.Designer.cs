
namespace Frame_Modeling.ucPanel
{
    partial class ucScreen2
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnChartLoad = new System.Windows.Forms.Button();
            this.ChartSales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(23, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(745, 3);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chart Display";
            // 
            // btnChartLoad
            // 
            this.btnChartLoad.Location = new System.Drawing.Point(551, 7);
            this.btnChartLoad.Name = "btnChartLoad";
            this.btnChartLoad.Size = new System.Drawing.Size(217, 30);
            this.btnChartLoad.TabIndex = 4;
            this.btnChartLoad.Text = "Chart Load";
            this.btnChartLoad.UseVisualStyleBackColor = true;
            this.btnChartLoad.Click += new System.EventHandler(this.btnChartLoad_Click);
            // 
            // ChartSales
            // 
            chartArea1.Name = "ChartArea1";
            this.ChartSales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChartSales.Legends.Add(legend1);
            this.ChartSales.Location = new System.Drawing.Point(23, 52);
            this.ChartSales.Name = "ChartSales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ChartSales.Series.Add(series1);
            this.ChartSales.Size = new System.Drawing.Size(745, 295);
            this.ChartSales.TabIndex = 5;
            this.ChartSales.Text = "chart1";
            // 
            // ucScreen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.ChartSales);
            this.Controls.Add(this.btnChartLoad);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ucScreen2";
            this.Size = new System.Drawing.Size(789, 350);
            ((System.ComponentModel.ISupportInitialize)(this.ChartSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChartLoad;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartSales;
    }
}
