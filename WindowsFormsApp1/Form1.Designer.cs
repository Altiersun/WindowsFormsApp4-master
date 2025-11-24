namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelNav = new System.Windows.Forms.Panel();
            this.btnStats = new System.Windows.Forms.Button();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnBudget = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelNav.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelNav
            // 
            this.panelNav.BackColor = System.Drawing.Color.White;
            this.panelNav.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelNav.Controls.Add(this.btnStats);
            this.panelNav.Controls.Add(this.btnExpense);
            this.panelNav.Controls.Add(this.btnBudget);
            this.panelNav.Controls.Add(this.btnIncome);
            this.panelNav.Controls.Add(this.lblLogo);
            this.panelNav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelNav.Location = new System.Drawing.Point(0, 0);
            this.panelNav.Name = "panelNav";
            this.panelNav.Size = new System.Drawing.Size(190, 600);
            this.panelNav.TabIndex = 0;
            // 
            // btnIncome
            // 
            this.btnIncome.FlatAppearance.BorderSize = 0;
            this.btnIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncome.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.btnIncome.Location = new System.Drawing.Point(0, 100);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(190, 55);
            this.btnIncome.TabIndex = 1;
            this.btnIncome.Text = "📥   수입내역";
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIncome.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnIncome.UseVisualStyleBackColor = true;
            // 
            // btnBudget
            // 
            this.btnBudget.FlatAppearance.BorderSize = 0;
            this.btnBudget.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnBudget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBudget.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.btnBudget.Location = new System.Drawing.Point(0, 160);
            this.btnBudget.Name = "btnBudget";
            this.btnBudget.Size = new System.Drawing.Size(190, 55);
            this.btnBudget.TabIndex = 2;
            this.btnBudget.Text = "💰   예산관리";
            this.btnBudget.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBudget.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBudget.UseVisualStyleBackColor = true;
            // 
            // btnExpense
            // 
            this.btnExpense.FlatAppearance.BorderSize = 0;
            this.btnExpense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpense.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.btnExpense.Location = new System.Drawing.Point(0, 220);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(190, 55);
            this.btnExpense.TabIndex = 3;
            this.btnExpense.Text = "📤   지출내역";
            this.btnExpense.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpense.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnExpense.UseVisualStyleBackColor = true;
            // 
            // btnStats
            // 
            this.btnStats.FlatAppearance.BorderSize = 0;
            this.btnStats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btnStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStats.Font = new System.Drawing.Font("맑은 고딕", 11F);
            this.btnStats.Location = new System.Drawing.Point(0, 280);
            this.btnStats.Name = "btnStats";
            this.btnStats.Size = new System.Drawing.Size(190, 55);
            this.btnStats.TabIndex = 4;
            this.btnStats.Text = "📊   자료통계";
            this.btnStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStats.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnStats.UseVisualStyleBackColor = true;
            // 
            // lblLogo
            // 
            this.lblLogo.Font = new System.Drawing.Font("맑은 고딕", 16F, System.Drawing.FontStyle.Bold);
            this.lblLogo.Location = new System.Drawing.Point(0, 20);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(190, 40);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "📘 가계부";
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.White;
            this.panelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(190, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(810, 60);
            this.panelHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.Font = new System.Drawing.Font("맑은 고딕", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.Location = new System.Drawing.Point(25, 15);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(500, 30);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "가계부 관리 시스템";
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(190, 60);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(810, 540);
            this.panelMain.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "가계부 관리 시스템";
            this.panelNav.ResumeLayout(false);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelNav;
        private System.Windows.Forms.Button btnStats;
        private System.Windows.Forms.Button btnExpense;
        private System.Windows.Forms.Button btnBudget;
        private System.Windows.Forms.Button btnIncome;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelMain;
    }
}
