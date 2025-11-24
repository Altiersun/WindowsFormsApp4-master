namespace WindowsFormsApp1
{
    partial class FormStats
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelFilter;

        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.ComboBox cmbMonth;

        private System.Windows.Forms.Button btnLoad;

        private System.Windows.Forms.Label lblIncomeTotal;
        private System.Windows.Forms.Label lblExpenseTotal;
        private System.Windows.Forms.Label lblBudgetTotal;

        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblIncomeTotal = new System.Windows.Forms.Label();
            this.lblExpenseTotal = new System.Windows.Forms.Label();
            this.lblBudgetTotal = new System.Windows.Forms.Label();
            this.chartStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop.SuspendLayout();
            this.panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Peru;
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 55);
            this.panelTop.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📊 자료 통계";
            // 
            // panelFilter
            // 
            this.panelFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelFilter.Controls.Add(this.lblMonth);
            this.panelFilter.Controls.Add(this.cmbMonth);
            this.panelFilter.Controls.Add(this.btnLoad);
            this.panelFilter.Controls.Add(this.lblIncomeTotal);
            this.panelFilter.Controls.Add(this.lblExpenseTotal);
            this.panelFilter.Controls.Add(this.lblBudgetTotal);
            this.panelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Location = new System.Drawing.Point(0, 55);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Padding = new System.Windows.Forms.Padding(20);
            this.panelFilter.Size = new System.Drawing.Size(800, 110);
            this.panelFilter.TabIndex = 1;
            // 
            // lblMonth
            // 
            this.lblMonth.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblMonth.Location = new System.Drawing.Point(20, 20);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(100, 23);
            this.lblMonth.TabIndex = 0;
            this.lblMonth.Text = "월 선택";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cmbMonth.Items.AddRange(new object[] {
            "1월",
            "2월",
            "3월",
            "4월",
            "5월",
            "6월",
            "7월",
            "8월",
            "9월",
            "10월",
            "11월",
            "12월"});
            this.cmbMonth.Location = new System.Drawing.Point(100, 18);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(150, 36);
            this.cmbMonth.TabIndex = 1;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Silver;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(270, 15);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(120, 33);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "통계 불러오기";
            this.btnLoad.UseVisualStyleBackColor = false;
            // 
            // lblIncomeTotal
            // 
            this.lblIncomeTotal.AutoSize = true;
            this.lblIncomeTotal.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblIncomeTotal.Location = new System.Drawing.Point(20, 60);
            this.lblIncomeTotal.Name = "lblIncomeTotal";
            this.lblIncomeTotal.Size = new System.Drawing.Size(0, 28);
            this.lblIncomeTotal.TabIndex = 3;
            // 
            // lblExpenseTotal
            // 
            this.lblExpenseTotal.AutoSize = true;
            this.lblExpenseTotal.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblExpenseTotal.Location = new System.Drawing.Point(200, 60);
            this.lblExpenseTotal.Name = "lblExpenseTotal";
            this.lblExpenseTotal.Size = new System.Drawing.Size(0, 28);
            this.lblExpenseTotal.TabIndex = 4;
            // 
            // lblBudgetTotal
            // 
            this.lblBudgetTotal.AutoSize = true;
            this.lblBudgetTotal.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblBudgetTotal.Location = new System.Drawing.Point(380, 60);
            this.lblBudgetTotal.Name = "lblBudgetTotal";
            this.lblBudgetTotal.Size = new System.Drawing.Size(0, 28);
            this.lblBudgetTotal.TabIndex = 5;
            // 
            // chartStats
            // 
            chartArea2.Name = "ChartArea1";
            this.chartStats.ChartAreas.Add(chartArea2);
            this.chartStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartStats.Location = new System.Drawing.Point(0, 165);
            this.chartStats.Name = "chartStats";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.chartStats.Series.Add(series2);
            this.chartStats.Size = new System.Drawing.Size(800, 435);
            this.chartStats.TabIndex = 0;
            // 
            // FormStats
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.chartStats);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStats";
            this.Text = "FormStats";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
