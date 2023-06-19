using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_accounts
{
    internal class AccountClass
    {
        private Single _dblBalance = 0;
        private string mstrCnString;    //set during instantiation; see constructors below
        private OleDbConnection cn = new OleDbConnection();


        // class constructor
        public AccountClass()
        {
            //Environment.CurrentDirectory is same as Application.StartupPath
            // @ used for literal to ignore escape sequence or "\\SinhaBank.accdb"
            //cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\SinhaBank.accdb";
            //Application.StartupPath is not available from a a class library so use AppDomain.CurrentDomain.BaseDirectory
            //mstrCnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            //                     + AppDomain.CurrentDomain.BaseDirectory + @"AccountsDB.accdb";
            mstrCnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\\AccountsDB.accdb";
            AccountNo = "-1";   //accountNo not set
            _dblBalance = 0;
        }
        //overloading constructor with AccountNo provided
        public AccountClass(string AccountNumber)
        {
            //Environment.CurrentDirectory is same as Application.StartupPath
            mstrCnString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\\AccountsDB.accdb";
            AccountNo = AccountNumber;
            _dblBalance = getAccountBalance(AccountNumber);
        }
        //properties or fields of the class object
        public string AccountNo { get; set; } //using variable name to set and get automatically
        public string ConnectionString
        {
            //read and write property
            get { return mstrCnString; }
            set { mstrCnString = value; }
        }
        public Single AccountBalance
        {
            get { return _dblBalance; } //read only
        }

        //methods of the objectH
        public Single Deposit(string AccountNumber, Single Amount)
        {
            bool SaveTransaction = insertTransaction(AccountNumber, Amount, "Cr");
            _dblBalance = getAccountBalance(AccountNumber, Amount);
            return _dblBalance;
        }
        public Single Withdraw(string AccountNumber, Single Amount)
        {
            bool SaveTransaction = insertTransaction(AccountNumber, Amount, "Dr");
            _dblBalance = getAccountBalance(AccountNumber, -(Amount));
            return _dblBalance;
        }
        public Single getAccountBalance(string AccountRef, Single OptionAddToBalance = 0)
        {
            Single ret = 0;
            this.AccountNo = AccountRef;
            string sql = "SELECT * From tblAccount Where AccountNo = '" + AccountRef + "'";
            cn.ConnectionString = mstrCnString;
            try
            {
                //open connection if not opened already
                if (cn.State == ConnectionState.Closed) { cn.Open(); }
                //pass SQL script on cn connection
                OleDbCommand cmd = new OleDbCommand(sql, cn);
                //execute the SQL on the database
                OleDbDataReader rdr = cmd.ExecuteReader();
                if (rdr.HasRows)
                {
                    //record found
                    while (rdr.Read())
                    {
                        if (rdr["AcStatus"].ToString() != "A") //compare
                        {
                            MessageBox.Show("Please note that this account is locked!");
                        }
                        //update balance
                        if (OptionAddToBalance != 0)
                        {
                            Single tempBal = Convert.ToSingle(rdr["AcBalance"].ToString()) + OptionAddToBalance;
                            string updateSQL = String.Format("UPDATE tblAccount SET AcBalance = {0} WHERE AccountNo = '{1}'", tempBal.ToString(), AccountRef.ToString());
                            OleDbCommand cmdUpdate = new OleDbCommand(updateSQL, cn);  //pass SQL script on cn connection
                            cmdUpdate.ExecuteNonQuery();
                            //New Balance
                            _dblBalance = tempBal;
                            ret= _dblBalance;
                        }
                        else
                        {
                            //Balance
                            _dblBalance = Convert.ToSingle(rdr["AcBalance"].ToString()) + OptionAddToBalance;
                            ret = _dblBalance;
                        }

                    }
                    if (cn.State == ConnectionState.Open) { cn.Close(); }
                }
                else
                {
                    MessageBox.Show("Please see your Accounts Manager");
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
            finally
            {
                if (cn.State == ConnectionState.Open) { cn.Close(); }
            }
            return ret;
        }
        private bool insertTransaction(string AccountNumber, Single Amount, string TransactionFormType)
        {
            bool ret = false;
            /*EITHER USING ADAPTOR
            OleDbDataAdapter adapter = new OleDbDataAdapter();
            adapter.InsertCommand = new OleDbCommand(sql, cn);
            adapter.InsertCommand.ExecuteNonQuery();
            OR using oldDBCommand object
            */
            string sql = "INSERT INTO tblAccTransaction"
                + " (AccountNo, TrxDate, TrxType, TrxAmount, TrxNote)"
                + " VALUES (?, ?, ?, ?, '')";
            OleDbCommand cmd = new OleDbCommand(sql, cn);

            cmd.Parameters.Add("AccountNumber", OleDbType.Char).Value = AccountNumber;
            cmd.Parameters.Add("TrxDate", OleDbType.DBDate).Value = DateTime.Now;
            cmd.Parameters.Add("TrxType", OleDbType.Char).Value = TransactionFormType;
            if (TransactionFormType=="Cr")
            {
                cmd.Parameters.Add("TrxAmount", OleDbType.Currency).Value = Amount;
            } else 
            {
                cmd.Parameters.Add("TrxAmount", OleDbType.Currency).Value = -(Amount);
            }
            

            try
            {
                if (cn.State == ConnectionState.Closed) { cn.Open(); }
                int count = cmd.ExecuteNonQuery();
                MessageBox.Show("{0} transaction saved !! ", count.ToString());
                ret = true;
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally { if (cn.State == ConnectionState.Open) { cn.Close(); } }
            return ret;
        }
    }
}
