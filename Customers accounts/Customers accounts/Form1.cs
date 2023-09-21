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
        private int PicBoxIndex = 1;
        private HiLoGame cd = new HiLoGame();
        string exeFilepath = System.Reflection.Assembly.GetExecutingAssembly().Location;

        private void exitGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult x;     //declare variable x with the data type "DialogResult"
            x = MessageBox.Show(this, "Are you sure?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (x==DialogResult.Yes) { System.Environment.Exit(1); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pbx1.Load(Application.StartupPath +"\\CardImages\\rb2fv.jpg");
            pbx2.Load(Application.StartupPath + "\\CardImages\\rb2fv.jpg");
            pbx3.Load(Application.StartupPath + "\\CardImages\\rb2fv.jpg");
            pbx4.Load(Application.StartupPath + "\\CardImages\\rb2fv.jpg");
            lstDeck.Items.Clear();
            cd.NewGame();
            for (int x = 1; x < 53; x += 1)
            {
                lstDeck.Items.Add(cd.CardDeck[x]);
            }

            PicBoxIndex = 1;
            DisplayCard();
        }
        private bool DisplayCard()
        {
            int cardfile = cd.CardDeck[cd.GetCardDeckIndex];
            string FileToDisplay = Application.StartupPath + String.Format("\\CardImages\\{0}.jpg", cardfile);
            switch (PicBoxIndex)
            {
                case 1:
                    pbx1.Load(FileToDisplay); 
                    break;
                case 2:
                    pbx2.Load(FileToDisplay);
                    break;
                case 3:
                    pbx3.Load(FileToDisplay);
                    break;
                case 4:
                    pbx4.Load(FileToDisplay);
                    break;
                default:
                    MessageBox.Show("Game Over");
                    break;
            }
            txtBetAmount.Text = cd.BetAmount.ToString();
            lblScore.Text = cd.PlayerAmount.ToString();
            return true;
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            double x = Double.TryParse(txtBetAmount.Text.ToString(), out x) ? x : 0.00;
            txtBetAmount.Text = x.ToString();
            cd.BetAmount = x;
            PicBoxIndex += 1; if (PicBoxIndex > 4) { PicBoxIndex = 1; }
            cd.CheckResult(2);
            DisplayCard();
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            double x = Double.TryParse(txtBetAmount.Text.ToString(), out x) ? x : 0.00;
            txtBetAmount.Text = x.ToString();
            cd.BetAmount = x;
            PicBoxIndex += 1; if (PicBoxIndex > 4) { PicBoxIndex = 1; }
            cd.CheckResult(1);
            DisplayCard();
        }
    }
}
