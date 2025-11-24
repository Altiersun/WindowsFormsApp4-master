namespace WindowsFormsApp4
{
    partial class FormIncome
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;

        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblMemo;

        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtMemo;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView dgvIncome;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblMemo = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.panelTop.SuspendLayout();
            this.panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.SteelBlue;
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
            this.lblTitle.Size = new System.Drawing.Size(290, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📘 수입 내역 관리";
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelInput.Controls.Add(this.lblDate);
            this.panelInput.Controls.Add(this.lblCategory);
            this.panelInput.Controls.Add(this.lblAmount);
            this.panelInput.Controls.Add(this.lblMemo);
            this.panelInput.Controls.Add(this.dtpDate);
            this.panelInput.Controls.Add(this.cmbCategory);
            this.panelInput.Controls.Add(this.txtAmount);
            this.panelInput.Controls.Add(this.txtMemo);
            this.panelInput.Controls.Add(this.btnAdd);
            this.panelInput.Controls.Add(this.btnUpdate);
            this.panelInput.Controls.Add(this.btnDelete);
            this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInput.Location = new System.Drawing.Point(0, 55);
            this.panelInput.Name = "panelInput";
            this.panelInput.Padding = new System.Windows.Forms.Padding(20);
            this.panelInput.Size = new System.Drawing.Size(800, 160);
            this.panelInput.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblDate.Location = new System.Drawing.Point(20, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 23);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "날짜";
            // 
            // lblCategory
            // 
            this.lblCategory.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblCategory.Location = new System.Drawing.Point(20, 60);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(100, 23);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "카테고리";
            // 
            // lblAmount
            // 
            this.lblAmount.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblAmount.Location = new System.Drawing.Point(20, 100);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 23);
            this.lblAmount.TabIndex = 2;
            this.lblAmount.Text = "금액";
            // 
            // lblMemo
            // 
            this.lblMemo.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.lblMemo.Location = new System.Drawing.Point(350, 20);
            this.lblMemo.Name = "lblMemo";
            this.lblMemo.Size = new System.Drawing.Size(100, 23);
            this.lblMemo.TabIndex = 3;
            this.lblMemo.Text = "메모";
            // 
            // dtpDate
            // 
            this.dtpDate.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.dtpDate.Location = new System.Drawing.Point(110, 17);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 34);
            this.dtpDate.TabIndex = 4;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.cmbCategory.Items.AddRange(new object[] {
            "월급",
            "용돈",
            "보너스",
            "기타"});
            this.cmbCategory.Location = new System.Drawing.Point(110, 57);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 36);
            this.cmbCategory.TabIndex = 5;
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.txtAmount.Location = new System.Drawing.Point(110, 97);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 34);
            this.txtAmount.TabIndex = 6;
            // 
            // txtMemo
            // 
            this.txtMemo.Font = new System.Drawing.Font("맑은 고딕", 10F);
            this.txtMemo.Location = new System.Drawing.Point(350, 50);
            this.txtMemo.Multiline = true;
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(280, 80);
            this.txtMemo.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(660, 25);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Silver;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(660, 65);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 35);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Silver;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(660, 105);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 35);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvIncome
            // 
            this.dgvIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncome.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvIncome.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvIncome.ColumnHeadersHeight = 36;
            this.dgvIncome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIncome.EnableHeadersVisualStyles = false;
            this.dgvIncome.Location = new System.Drawing.Point(0, 215);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.RowHeadersWidth = 62;
            this.dgvIncome.RowTemplate.Height = 28;
            this.dgvIncome.Size = new System.Drawing.Size(800, 385);
            this.dgvIncome.TabIndex = 0;
            this.dgvIncome.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncome_CellClick);
            // 
            // FormIncome
            // 
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.dgvIncome);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIncome";
            this.Text = "FormIncome";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
    }
}
