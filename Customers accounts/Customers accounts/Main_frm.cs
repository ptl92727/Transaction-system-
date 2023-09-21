using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Customers_accounts
{
    public partial class Main_frm : Form
    {
        public Main_frm()
        {
            InitializeComponent();
        }
        private OleDbDataAdapter adapter = new OleDbDataAdapter();
        private DataSet ds = new DataSet();
        private void txtWhereClause_TextChanged(object sender, EventArgs e)
        {

        }
        private string fetchSQLResult(bool UseSQL, string strSQL_Flds, string strTable = "", string strCriteria = "")
        {
            string sql = "";
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\AccountsDB.accdb";

            if (cn.State == ConnectionState.Open) { cn.Close(); }

            ds.Reset();
            this.dgrdResult.DataBindings.Clear(); //Remove binding
            this.dgrdResult.DataSource = null;
            this.dgrdResult.Rows.Clear();
            this.dgrdResult.Refresh();

            try
            {
                if (cn.State == ConnectionState.Closed) { cn.Open(); }
                if (UseSQL == true)
                {
                    sql = strSQL_Flds;
                }
                else
                {
                    sql = "SELECT " + strSQL_Flds + "FROM " + strTable;
                    if (strCriteria != "") { sql += " WHERE " + strCriteria; }

                }
                adapter.SelectCommand = new OleDbCommand(sql, cn);
                adapter.Fill(ds);
                dgrdResult.DataSource = ds.Tables[0];
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return sql;
        }
        private void btnRunQuery_Click(object sender, EventArgs e)
        {
            if (chkUseSQL.Checked == true) {
                txtSQL_Script.Text = fetchSQLResult(true, txtSQL_Script.Text.ToString());
            } else {
                txtSQL_Script.Text = fetchSQLResult(false,txtFields.Text.ToString(), txtTable_Query.Text.ToString() , txtWhereClause.Text.ToString());
            }
        }
    } 
}
