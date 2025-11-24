using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormStats : Form
    {
        private DataTable incomeTable;
        private DataTable expenseTable;
        private DataTable budgetTable;

        public FormStats(DataTable income, DataTable expense, DataTable budget)
        {
            InitializeComponent();

            this.incomeTable = income;
            this.expenseTable = expense;
            this.budgetTable = budget;

            btnLoad.Click += btnLoad_Click;
        }

        // ===============================
        //     통계 버튼 클릭
        // ===============================
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex == -1)
            {
                MessageBox.Show("월을 선택하세요.");
                return;
            }

            int month = cmbMonth.SelectedIndex + 1;

            int incomeSum = GetMonthlySum(incomeTable, month);
            int expenseSum = GetMonthlySum(expenseTable, month);
            int budgetSum = GetMonthlySum(budgetTable, month);

            // 레이블 표시
            lblIncomeTotal.Text = $"수입 합계: {incomeSum:N0}원";
            lblExpenseTotal.Text = $"지출 합계: {expenseSum:N0}원";
            lblBudgetTotal.Text = $"예산 합계: {budgetSum:N0}원";

            // 차트 갱신
            UpdateChart(incomeSum, expenseSum, budgetSum);
        }

        // ===============================
        //      월별 합계 계산
        // ===============================
        private int GetMonthlySum(DataTable table, int month)
        {
            if (table == null || table.Rows.Count == 0)
                return 0;

            var rows = table.AsEnumerable()
                .Where(r =>
                {
                    DateTime date = DateTime.Parse(r["날짜"].ToString());
                    return date.Month == month;
                });

            if (!rows.Any())
                return 0;

            return rows.Sum(r => Convert.ToInt32(r["금액"]));
        }

        // ===============================
        //      차트 표시
        // ===============================
        private void UpdateChart(int income, int expense, int budget)
        {
            var s = chartStats.Series["Series1"];
            s.Points.Clear();

            s.Points.AddXY("수입", income);
            s.Points.AddXY("지출", expense);
            s.Points.AddXY("예산", budget);
        }
    }
}
