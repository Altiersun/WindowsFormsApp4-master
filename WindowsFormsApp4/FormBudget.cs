using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormBudget : Form
    {
        private DataTable budgetTable;

        public FormBudget()
        {
            InitializeComponent();
            InitializeBudgetTable();
        }

        // ============================
        //    1. DataTable 생성
        // ============================
        private void InitializeBudgetTable()
        {
            budgetTable = new DataTable();
            budgetTable.Columns.Add("월", typeof(string));
            budgetTable.Columns.Add("카테고리", typeof(string));
            budgetTable.Columns.Add("예산 금액", typeof(int));

            dgvBudget.DataSource = budgetTable;

            dgvBudget.CellClick += dgvBudget_CellClick;
        }

        // ============================
        //    2. 추가 버튼
        // ============================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbCategory.Text == "" || txtAmount.Text == "" || cmbMonth.Text == "")
            {
                MessageBox.Show("모든 항목을 입력하세요.");
                return;
            }

            DataRow row = budgetTable.NewRow();
            row["월"] = cmbMonth.Text;
            row["카테고리"] = cmbCategory.Text;
            row["예산 금액"] = int.Parse(txtAmount.Text);

            budgetTable.Rows.Add(row);
            ClearInput();
        }

        // ============================
        //    3. 수정 버튼
        // ============================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvBudget.CurrentRow == null)
            {
                MessageBox.Show("수정할 항목을 선택하세요.");
                return;
            }

            int idx = dgvBudget.CurrentRow.Index;

            budgetTable.Rows[idx]["월"] = cmbMonth.Text;
            budgetTable.Rows[idx]["카테고리"] = cmbCategory.Text;
            budgetTable.Rows[idx]["예산 금액"] = int.Parse(txtAmount.Text);

            ClearInput();
        }

        // ============================
        //    4. 삭제 버튼
        // ============================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBudget.CurrentRow == null)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
                return;
            }

            int idx = dgvBudget.CurrentRow.Index;
            budgetTable.Rows.RemoveAt(idx);

            ClearInput();
        }

        // ============================
        //    5. 행 클릭 → 입력값 로드
        // ============================
        private void dgvBudget_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            cmbMonth.Text = dgvBudget.Rows[e.RowIndex].Cells["월"].Value.ToString();
            cmbCategory.Text = dgvBudget.Rows[e.RowIndex].Cells["카테고리"].Value.ToString();
            txtAmount.Text = dgvBudget.Rows[e.RowIndex].Cells["예산 금액"].Value.ToString();
        }

        // ============================
        //    6. 입력창 초기화
        // ============================
        private void ClearInput()
        {
            cmbMonth.SelectedIndex = -1;
            cmbCategory.SelectedIndex = -1;
            txtAmount.Clear();
        }
    }
}
