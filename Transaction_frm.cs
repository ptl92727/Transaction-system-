using Customer_accounts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customers_accounts
{
    public partial class Transaction_frm : Form
    {
        public Transaction_frm()
        {
            InitializeComponent();
        }

        private void lblAccount_Click(object sender, EventArgs e)
        {

        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main_frm frm=new Main_frm();
            frm.ShowDialog();
        }

        private void passTheTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            AccountClass test= new AccountClass(txtAccountNumber.Text.ToString());
            lblBalance1.Text = test.getAccountBalance(txtAccountNumber.Text).ToString();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            AccountClass updateTransaction = new AccountClass(txtAccountNumber.Text.ToString());
            string TrType = cboAction.Text.ToString();
            Single amt = Convert.ToSingle(txtAmount.Text);
            string ac = txtAccountNumber.Text.ToString();
            switch (TrType)
            {
                case "Deposit":
                    lblBalance1.Text = updateTransaction.Deposit(ac, amt).ToString();
                    break;
                case "Withdraw":
                    lblBalance1.Text = updateTransaction.Withdraw(ac, amt).ToString();
                    break;
                default:
                    break;
            }
            txtAmount.Text = "0";







        }
    }
}
