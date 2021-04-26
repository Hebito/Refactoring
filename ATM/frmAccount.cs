using System;
using System.Windows.Forms;

namespace ATM
{
    public partial class frmAccount : Form
    {
        public static string ID;
        public static string CBalance;
        public static string SBalance;
        public static int Checking;
        public static int Saving;
        public static int CBalChecker;
        
        public frmAccount()
        {
            InitializeComponent();
        }

        
        private void frmAccount_Load(object sender, EventArgs e)
        {
            //Grabs Log-In information and displays account for Customer
            string GetAccount = frmLogin.AN;
            string GetPin = frmLogin.Pin;
            SQLHelper.CustomerID(GetAccount, GetPin);
            SQLHelper.DisplayDatabase(ID, label_Checking, label_saving);
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin fl = new frmLogin();
            fl.Show();
        }

        private void btn_WChecking_Click(object sender, EventArgs e)
        {
            CheckingAccount C1 = new CheckingAccount();
            C1.WithdrawValue = int.Parse(txt_WChecking.Text);
            int CheckingWithdraw = C1.WithdrawValue;
            if (CheckingWithdraw > CBalChecker)
            {
                //If-statement for not enough funds to pull from checkings
                MessageBox.Show("Insufficient Amount in Checking, withdrawing amount from Savings.");
                SQLHelper.WithdrawSaving(ID, CheckingWithdraw);
                SQLHelper.TransactionOfSaving(ID, SBalance);
                SQLHelper.DisplayDatabase(ID, label_Checking, label_saving);
                return;
            }
            try
            {
                SQLHelper.WithdrawChecking(ID, CheckingWithdraw);
                SQLHelper.TransactionOfChecking(ID, CBalance);
                SQLHelper.DisplayDatabase(ID, label_Checking, label_saving);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_DChecking_Click(object sender, EventArgs e)
        {
            //Triggers Deposit into Checking
            CheckingAccount C1 = new CheckingAccount();
            C1.DepositValue = int.Parse(txt_DChecking.Text);
            int CheckingDeposit = C1.DepositValue;
            SQLHelper.DepositChecking(ID, CheckingDeposit);
            SQLHelper.TransactionOfChecking(ID, CBalance);
            SQLHelper.DisplayDatabase(ID, label_Checking, label_saving);
        }

        private void btn_CtoS_Click(object sender, EventArgs e)
        {
            //Transfers Checking to Saving Account
            SavingAccount S1 = new SavingAccount();
            S1.SavingValue = int.Parse(txt_Transfer.Text);
            SQLHelper.TransferCheckingtoSaving(ID, S1.SavingValue);
            SQLHelper.GeneralTransaction(ID, Checking.ToString(), Saving.ToString());
            SQLHelper.DisplayDatabase(ID, label_Checking, label_saving);
        }

        private void btn_WSaving_Click(object sender, EventArgs e)
        {
            //Triggers Withdraw from Saving
            SavingAccount S1 = new SavingAccount();
            S1.WithdrawValue = int.Parse(txt_WSaving.Text);
            int SW = S1.WithdrawValue;
            SQLHelper.WithdrawSaving(ID, SW);
            SQLHelper.TransactionOfSaving(ID, SBalance);
            SQLHelper.DisplayDatabase(ID, label_Checking, label_saving);
        }

        private void btn_DSaving_Click(object sender, EventArgs e)
        {
            //Triggers Deposit into Saving
            SavingAccount S1 = new SavingAccount();
            S1.DepositValue = int.Parse(txt_DSaving.Text);
            int SavingDeposit = S1.DepositValue;
            SQLHelper.DepositSaving(ID, SavingDeposit);
            SQLHelper.TransactionOfSaving(ID, SBalance);
            SQLHelper.DisplayDatabase(ID, label_Checking, label_saving);
        }

        private void btn_StoC_Click(object sender, EventArgs e)
        {
            //For Transfering from Saving to Checking Account
            CheckingAccount C1 = new CheckingAccount();
            C1.CheckingValue = int.Parse(txt_Transfer.Text);
            SQLHelper.TransferSavingtoChecking(ID, C1.CheckingValue);
            SQLHelper.GeneralTransaction(ID, Checking.ToString(), Saving.ToString());
            SQLHelper.DisplayDatabase(ID, label_Checking, label_saving);
        }
    }
}
