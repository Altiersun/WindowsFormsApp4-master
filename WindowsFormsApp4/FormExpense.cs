using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormExpense : Form
    {
        private DataTable expenseTable;

        public FormExpense()
        {
            InitializeComponent();
            InitializeExpenseTable();
        }

        // ============================
        //     1. DataTable 생성
        // ============================
        private void InitializeExpenseTable()
        {
            expenseTable = new DataTable();
            expenseTable.Columns.Add("날짜", typeof(string));
            expenseTable.Columns.Add("카테고리", typeof(string));
            expenseTable.Columns.Add("금액", typeof(int));
            expenseTable.Columns.Add("메모", typeof(string));

            dgvExpense.DataSource = expenseTable;

            dgvExpense.CellClick += dgvExpense_CellClick;
        }

        // ============================
        //     2. 추가
        // ============================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "" || cmbCategory.Text == "")
            {
                MessageBox.Show("금액과 카테고리를 입력하세요.");
                return;
            }

            DataRow row = expenseTable.NewRow();
            row["날짜"] = dtpDate.Value.ToString("yyyy-MM-dd");
            row["카테고리"] = cmbCategory.Text;
            row["금액"] = int.Parse(txtAmount.Text);
            row["메모"] = txtMemo.Text;

            expenseTable.Rows.Add(row);
            ClearInput();
        }

        // ============================
        //     3. 수정
        // ============================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvExpense.CurrentRow == null)
            {
                MessageBox.Show("수정할 항목을 선택하세요.");
                return;
            }

            int index = dgvExpense.CurrentRow.Index;

            expenseTable.Rows[index]["날짜"] = dtpDate.Value.ToString("yyyy-MM-dd");
            expenseTable.Rows[index]["카테고리"] = cmbCategory.Text;
            expenseTable.Rows[index]["금액"] = int.Parse(txtAmount.Text);
            expenseTable.Rows[index]["메모"] = txtMemo.Text;

            ClearInput();
        }

        // ============================
        //     4. 삭제
        // ============================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvExpense.CurrentRow == null)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
                return;
            }

            int index = dgvExpense.CurrentRow.Index;

            expenseTable.Rows.RemoveAt(index);
            ClearInput();
        }

        // ============================
        //     5. 행 클릭 → 입력창 로드
        // ============================
        private void dgvExpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            dtpDate.Value = DateTime.Parse(dgvExpense.Rows[e.RowIndex].Cells["날짜"].Value.ToString());
            cmbCategory.Text = dgvExpense.Rows[e.RowIndex].Cells["카테고리"].Value.ToString();
            txtAmount.Text = dgvExpense.Rows[e.RowIndex].Cells["금액"].Value.ToString();
            txtMemo.Text = dgvExpense.Rows[e.RowIndex].Cells["메모"].Value.ToString();
        }

        // ============================
        //     6. 입력 초기화
        // ============================
        private void ClearInput()
        {
            dtpDate.Value = DateTime.Now;
            cmbCategory.SelectedIndex = -1;
            txtAmount.Clear();
            txtMemo.Clear();
        }
    }
}
