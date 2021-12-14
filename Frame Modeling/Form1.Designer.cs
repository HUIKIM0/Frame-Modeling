
namespace Frame_Modeling
{
    partial class Form1
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

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnConSc3 = new System.Windows.Forms.Button();
            this.btnChaSc2 = new System.Windows.Forms.Button();
            this.btnInputSc1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lboxLog = new System.Windows.Forms.ListBox();
            this.pMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lboxLog, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pMain, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(813, 557);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.btnConSc3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnChaSc2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnInputSc1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnExit, 4, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 480);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(807, 74);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // btnConSc3
            // 
            this.btnConSc3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConSc3.Location = new System.Drawing.Point(163, 3);
            this.btnConSc3.Name = "btnConSc3";
            this.btnConSc3.Size = new System.Drawing.Size(74, 68);
            this.btnConSc3.TabIndex = 2;
            this.btnConSc3.Text = "Config";
            this.btnConSc3.UseVisualStyleBackColor = true;
            // 
            // btnChaSc2
            // 
            this.btnChaSc2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChaSc2.Location = new System.Drawing.Point(83, 3);
            this.btnChaSc2.Name = "btnChaSc2";
            this.btnChaSc2.Size = new System.Drawing.Size(74, 68);
            this.btnChaSc2.TabIndex = 1;
            this.btnChaSc2.Text = "Chart";
            this.btnChaSc2.UseVisualStyleBackColor = true;
            // 
            // btnInputSc1
            // 
            this.btnInputSc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInputSc1.Location = new System.Drawing.Point(3, 3);
            this.btnInputSc1.Name = "btnInputSc1";
            this.btnInputSc1.Size = new System.Drawing.Size(74, 68);
            this.btnInputSc1.TabIndex = 0;
            this.btnInputSc1.Text = "Input";
            this.btnInputSc1.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExit.Location = new System.Drawing.Point(730, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 68);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // lboxLog
            // 
            this.lboxLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lboxLog.FormattingEnabled = true;
            this.lboxLog.ItemHeight = 15;
            this.lboxLog.Location = new System.Drawing.Point(3, 3);
            this.lboxLog.Name = "lboxLog";
            this.lboxLog.Size = new System.Drawing.Size(807, 94);
            this.lboxLog.TabIndex = 1;
            // 
            // pMain
            // 
            this.pMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pMain.Location = new System.Drawing.Point(3, 103);
            this.pMain.Name = "pMain";
            this.pMain.Size = new System.Drawing.Size(807, 371);
            this.pMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 557);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ListBox lboxLog;
        private System.Windows.Forms.Panel pMain;
        private System.Windows.Forms.Button btnConSc3;
        private System.Windows.Forms.Button btnChaSc2;
        private System.Windows.Forms.Button btnInputSc1;
        private System.Windows.Forms.Button btnExit;
    }
}

