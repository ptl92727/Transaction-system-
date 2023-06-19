namespace Customers_accounts
{
    partial class Transaction_frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAccount = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblbalance = new System.Windows.Forms.Label();
            this.lblBalance1 = new System.Windows.Forms.Label();
            this.dataGridTransaction = new System.Windows.Forms.DataGridView();
            this.lblAction = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAccountNumber = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.cboAction = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblTransactionHistory = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passTheTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaction)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Location = new System.Drawing.Point(12, 31);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(47, 13);
            this.lblAccount.TabIndex = 0;
            this.lblAccount.Text = "Account";
            this.lblAccount.Click += new System.EventHandler(this.lblAccount_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(397, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(93, 36);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lblbalance
            // 
            this.lblbalance.AutoSize = true;
            this.lblbalance.Location = new System.Drawing.Point(12, 67);
            this.lblbalance.Name = "lblbalance";
            this.lblbalance.Size = new System.Drawing.Size(61, 13);
            this.lblbalance.TabIndex = 2;
            this.lblbalance.Text = "Balance   £";
            // 
            // lblBalance1
            // 
            this.lblBalance1.AutoSize = true;
            this.lblBalance1.Location = new System.Drawing.Point(79, 67);
            this.lblBalance1.Name = "lblBalance1";
            this.lblBalance1.Size = new System.Drawing.Size(13, 13);
            this.lblBalance1.TabIndex = 3;
            this.lblBalance1.Text = "0";
            // 
            // dataGridTransaction
            // 
            this.dataGridTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransaction.Location = new System.Drawing.Point(37, 264);
            this.dataGridTransaction.Name = "dataGridTransaction";
            this.dataGridTransaction.Size = new System.Drawing.Size(418, 150);
            this.dataGridTransaction.TabIndex = 4;
            // 
            // lblAction
            // 
            this.lblAction.AutoSize = true;
            this.lblAction.Location = new System.Drawing.Point(269, 110);
            this.lblAction.Name = "lblAction";
            this.lblAction.Size = new System.Drawing.Size(37, 13);
            this.lblAction.TabIndex = 5;
            this.lblAction.Text = "Action";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(269, 155);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 6;
            this.lblAmount.Text = "Amount";
            // 
            // txtAccountNumber
            // 
            this.txtAccountNumber.Location = new System.Drawing.Point(89, 28);
            this.txtAccountNumber.Name = "txtAccountNumber";
            this.txtAccountNumber.Size = new System.Drawing.Size(100, 20);
            this.txtAccountNumber.TabIndex = 7;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(397, 105);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 8;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(394, 152);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(77, 22);
            this.btnTest.TabIndex = 9;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cboAction
            // 
            this.cboAction.FormattingEnabled = true;
            this.cboAction.Items.AddRange(new object[] {
            "Deposit",
            "Withdraw"});
            this.cboAction.Location = new System.Drawing.Point(312, 107);
            this.cboAction.Name = "cboAction";
            this.cboAction.Size = new System.Drawing.Size(79, 21);
            this.cboAction.TabIndex = 10;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(318, 152);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(70, 20);
            this.txtAmount.TabIndex = 11;
            // 
            // lblTransactionHistory
            // 
            this.lblTransactionHistory.AutoSize = true;
            this.lblTransactionHistory.Location = new System.Drawing.Point(38, 248);
            this.lblTransactionHistory.Name = "lblTransactionHistory";
            this.lblTransactionHistory.Size = new System.Drawing.Size(151, 13);
            this.lblTransactionHistory.TabIndex = 12;
            this.lblTransactionHistory.Text = "Account\'s Transaction History:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.passTheTimeToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // passTheTimeToolStripMenuItem
            // 
            this.passTheTimeToolStripMenuItem.Name = "passTheTimeToolStripMenuItem";
            this.passTheTimeToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.passTheTimeToolStripMenuItem.Text = "Pass the Time";
            this.passTheTimeToolStripMenuItem.Click += new System.EventHandler(this.passTheTimeToolStripMenuItem_Click);
            // 
            // Transaction_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(502, 450);
            this.Controls.Add(this.lblTransactionHistory);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.cboAction);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtAccountNumber);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblAction);
            this.Controls.Add(this.dataGridTransaction);
            this.Controls.Add(this.lblBalance1);
            this.Controls.Add(this.lblbalance);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblAccount);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Transaction_frm";
            this.Text = "Transaction_frm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaction)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAccount;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblbalance;
        private System.Windows.Forms.Label lblBalance1;
        private System.Windows.Forms.DataGridView dataGridTransaction;
        private System.Windows.Forms.Label lblAction;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAccountNumber;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ComboBox cboAction;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblTransactionHistory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passTheTimeToolStripMenuItem;
    }
}