namespace WindowsFormsApp1
{
    partial class FormBudget
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel panelInput;

        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMonth;

        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbMonth;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView dgvBudget;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvBudget = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudget)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.MediumSeaGreen;
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
            this.lblTitle.Text = "💰 예산 관리";
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInput.Controls.Add(this.lblCategory);
            this.panelInput.Controls.Add(this.lblAmount);
            this.panelInput.Controls.Add(this.lblMonth);
            this.panelInput.Controls.Add(this.cmbCategory);
            this.panelInput.Controls.Add(this.txtAmount);
            this.panelInput.Controls.Add(this.cmbMonth);
            this.panelInput.Controls.Add(this.btnAdd);
            this.panelInput.Controls.Add(this.btnUpdate);
            this.panelInput.Controls.Add(this.btnDelete);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 55);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(20);
            this.panelInput.Size = new System.Drawing.Size(800, 140);
            this.panelInput.TabIndex = 1;
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblCategory.Location = new System.Drawing.Point(20, 20);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 23);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "카테고리";
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblAmount.Location = new System.Drawing.Point(20, 60);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 23);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "예산 금액";
            // 
            // lblMonth
            // 
            this.lblMonth.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblMonth.Location = new System.Drawing.Point(300, 20);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(100, 23);
            this.lblMonth.TabIndex = 2;
            this.lblMonth.Text = "월 선택";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cmbCategory.Items.AddRange(new object[] {
            "식비",
            "교통비",
            "주거비",
            "교육",
            "의료",
            "취미",
            "기타"});
            this.cmbCategory.Location = new System.Drawing.Point(110, 17);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(150, 36);
            this.cmbCategory.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.txtAmount.Location = new System.Drawing.Point(110, 57);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(150, 34);
            this.txtAmount.TabIndex = 4;
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
            this.cmbMonth.Location = new System.Drawing.Point(370, 17);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(100, 36);
            this.cmbMonth.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(520, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(520, 52);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 35);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(520, 92);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // dgvBudget
            // 
            this.dgvBudget.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBudget.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.MediumSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBudget.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBudget.ColumnHeadersHeight = 36;
            this.dgvBudget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBudget.EnableHeadersVisualStyles = false;
            this.dgvBudget.Location = new System.Drawing.Point(0, 195);
            this.dgvBudget.Name = "dgvBudget";
            this.dgvBudget.RowHeadersWidth = 62;
            this.dgvBudget.Size = new System.Drawing.Size(800, 405);
            this.dgvBudget.TabIndex = 0;
            // 
            // FormBudget
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dgvBudget);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBudget";
            this.Text = "FormBudget";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBudget)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
