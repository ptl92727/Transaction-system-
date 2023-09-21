namespace Customers_accounts
{
    partial class Main_frm
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
            this.txtFields = new System.Windows.Forms.TextBox();
            this.txtTable_Query = new System.Windows.Forms.TextBox();
            this.txtWhereClause = new System.Windows.Forms.TextBox();
            this.chkUseSQL = new System.Windows.Forms.CheckBox();
            this.txtSQL_Script = new System.Windows.Forms.TextBox();
            this.dgrdResult = new System.Windows.Forms.DataGridView();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdResult)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFields
            // 
            this.txtFields.Location = new System.Drawing.Point(28, 75);
            this.txtFields.Name = "txtFields";
            this.txtFields.Size = new System.Drawing.Size(150, 20);
            this.txtFields.TabIndex = 0;
            // 
            // txtTable_Query
            // 
            this.txtTable_Query.Location = new System.Drawing.Point(242, 75);
            this.txtTable_Query.Name = "txtTable_Query";
            this.txtTable_Query.Size = new System.Drawing.Size(100, 20);
            this.txtTable_Query.TabIndex = 1;
            // 
            // txtWhereClause
            // 
            this.txtWhereClause.Location = new System.Drawing.Point(451, 75);
            this.txtWhereClause.Name = "txtWhereClause";
            this.txtWhereClause.Size = new System.Drawing.Size(119, 20);
            this.txtWhereClause.TabIndex = 2;
            this.txtWhereClause.TextChanged += new System.EventHandler(this.txtWhereClause_TextChanged);
            // 
            // chkUseSQL
            // 
            this.chkUseSQL.AutoSize = true;
            this.chkUseSQL.Location = new System.Drawing.Point(28, 166);
            this.chkUseSQL.Name = "chkUseSQL";
            this.chkUseSQL.Size = new System.Drawing.Size(69, 17);
            this.chkUseSQL.TabIndex = 3;
            this.chkUseSQL.Text = "Use SQL";
            this.chkUseSQL.UseVisualStyleBackColor = true;
            // 
            // txtSQL_Script
            // 
            this.txtSQL_Script.Location = new System.Drawing.Point(103, 163);
            this.txtSQL_Script.Name = "txtSQL_Script";
            this.txtSQL_Script.Size = new System.Drawing.Size(366, 20);
            this.txtSQL_Script.TabIndex = 4;
            // 
            // dgrdResult
            // 
            this.dgrdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdResult.Location = new System.Drawing.Point(28, 245);
            this.dgrdResult.Name = "dgrdResult";
            this.dgrdResult.Size = new System.Drawing.Size(555, 288);
            this.dgrdResult.TabIndex = 5;
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Location = new System.Drawing.Point(498, 161);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(85, 21);
            this.btnRunQuery.TabIndex = 6;
            this.btnRunQuery.Text = "Run Query";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnRunQuery_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(438, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 20);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(519, 219);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // Main_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 545);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnRunQuery);
            this.Controls.Add(this.dgrdResult);
            this.Controls.Add(this.txtSQL_Script);
            this.Controls.Add(this.chkUseSQL);
            this.Controls.Add(this.txtWhereClause);
            this.Controls.Add(this.txtTable_Query);
            this.Controls.Add(this.txtFields);
            this.Name = "Main_frm";
            this.Text = "Run SQL to check backend DB";
            ((System.ComponentModel.ISupportInitialize)(this.dgrdResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFields;
        private System.Windows.Forms.TextBox txtTable_Query;
        private System.Windows.Forms.TextBox txtWhereClause;
        private System.Windows.Forms.CheckBox chkUseSQL;
        private System.Windows.Forms.TextBox txtSQL_Script;
        private System.Windows.Forms.DataGridView dgrdResult;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
    }
}