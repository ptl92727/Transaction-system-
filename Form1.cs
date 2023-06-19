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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x;     //declare variable x with the data type "DialogResult"
            x = MessageBox.Show(this, "Are you sure?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (x==DialogResult.Yes) { System.Environment.Exit(1); }
        }
    }
}
