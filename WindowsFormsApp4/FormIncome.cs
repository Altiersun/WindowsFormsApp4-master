using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormIncome : Form
    {
        private DataTable incomeTable;

        public FormIncome()
        {
            InitializeComponent();
            InitializeIncomeTable();
        }

        // ============================
        //     1. 데이터 테이블 생성
        // ============================
        private void InitializeIncomeTable()
        {
            incomeTable = new DataTable();
            incomeTable.Columns.Add("날짜", typeof(string));
            incomeTable.Columns.Add("카테고리", typeof(string));
            incomeTable.Columns.Add("금액", typeof(int));
            incomeTable.Columns.Add("메모", typeof(string));

            dgvIncome.DataSource = incomeTable;

            dgvIncome.CellClick += dgvIncome_CellClick;
        }

        // ============================
        //     2. 추가 버튼
        // ============================
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text.Trim() == "")
            {
                MessageBox.Show("금액을 입력하세요.");
                return;
            }

            DataRow row = incomeTable.NewRow();
            row["날짜"] = dtpDate.Value.ToString("yyyy-MM-dd");
            row["카테고리"] = cmbCategory.Text;
            row["금액"] = int.Parse(txtAmount.Text);
            row["메모"] = txtMemo.Text;

            incomeTable.Rows.Add(row);
            ClearInput();
        }

        // ============================
        //     3. 수정 버튼
        // ============================
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvIncome.CurrentRow == null)
            {
                MessageBox.Show("수정할 항목을 선택하세요.");
                return;
            }

            int index = dgvIncome.CurrentRow.Index;

            incomeTable.Rows[index]["날짜"] = dtpDate.Value.ToString("yyyy-MM-dd");
            incomeTable.Rows[index]["카테고리"] = cmbCategory.Text;
            incomeTable.Rows[index]["금액"] = int.Parse(txtAmount.Text);
            incomeTable.Rows[index]["메모"] = txtMemo.Text;

            ClearInput();
        }

        // ============================
        //     4. 삭제 버튼
        // ============================
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvIncome.CurrentRow == null)
            {
                MessageBox.Show("삭제할 항목을 선택하세요.");
                return;
            }

            int index = dgvIncome.CurrentRow.Index;
            incomeTable.Rows.RemoveAt(index);

            ClearInput();
        }

        // ============================
        //     5. 행 클릭 → 입력창 채우기
        // ============================
        private void dgvIncome_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            dtpDate.Value = DateTime.Parse(dgvIncome.Rows[e.RowIndex].Cells["날짜"].Value.ToString());
            cmbCategory.Text = dgvIncome.Rows[e.RowIndex].Cells["카테고리"].Value.ToString();
            txtAmount.Text = dgvIncome.Rows[e.RowIndex].Cells["금액"].Value.ToString();
            txtMemo.Text = dgvIncome.Rows[e.RowIndex].Cells["메모"].Value.ToString();
        }

        // ============================
        //     6. 입력창 초기화
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
