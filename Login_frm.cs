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
    public partial class Login_frm : Form
    {
        public Login_frm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private bool checkLogin(string username, string user_pass)
        {
            bool ret = false;
            string sSQL = "select * from tblUser WHERE Status ='A' and username = '" +
                username + "'";
            OleDbConnection cn = new OleDbConnection();
            // @ used for literal to ignore escape sequence or "\\myDB.accdb"
            // Provider=Microsoft.ACE.OLEDB.12.0;Data Source="AccountsDB.accdb"
            try
            {
                cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" +
                Application.StartupPath + @"\AccountsDB.accdb";
                //open connection if not opened already
                if (cn.State == ConnectionState.Closed) { cn.Open(); }
                OleDbCommand cmd = new OleDbCommand(sSQL, cn); //pass SQL script on cn connection
                OleDbDataReader reader = cmd.ExecuteReader(); //execute the SQL on the database
                if (reader.HasRows)
                {
                    //record found
                    while (reader.Read())
                    {
                        if (reader["Userpassword"].ToString() == user_pass)
                        {
                            ret = true;
                        }
                    }
                    if (cn.State == ConnectionState.Open) { cn.Close(); }
                }
                else
                {
                    MessageBox.Show("Please see your system administrator!");
                }
                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ret;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (checkLogin(txtUsername.Text.ToString(), txtPassword.Text.ToString())== true)
            {
                MessageBox.Show("Welcome");
                this.Hide();
                Transaction_frm frm = new Transaction_frm();
                frm.ShowDialog();
                this.Close();
            } else
            {
                MessageBox.Show("Invalid User/Password");
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ret;
            ret = MessageBox.Show("Are you sure","Please Confirm",MessageBoxButtons.YesNo,MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (ret == DialogResult.Yes) {Application.Exit(); }
        }

        private void Login_frm_Load(object sender, EventArgs e)
        {

        }
    }
}
