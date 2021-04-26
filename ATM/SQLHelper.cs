using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM
{
    public static class SQLHelper
    {   //Displays Customer's Checking and Savings Balance from Database
        public static void DisplayDatabase(String ID, Label Checking, Label Savings)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\the-d\source\repos\ATM\ATM\BankDB.mdf;Integrated Security=True;Connect Timeout=30";
            
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Checking, Saving from CustomerDB where ID =@ID", con);
            cmd.Parameters.AddWithValue("@ID", int.Parse(ID));
            
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Checking.Text = da.GetValue(0).ToString(); //Set Checking to Text
                frmAccount.CBalChecker = (int)da.GetValue(0);
                Savings.Text = da.GetValue(1).ToString(); //Set Saving to Text
            }
            
            con.Close();
        }

        //Searches Database for Customer ID with Account and Pin
        public static void CustomerID(String Account, String Pin)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\the-d\source\repos\ATM\ATM\BankDB.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "Select ID from CustomerDB where Account = @Account AND Pin = @Pin";
            
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Account", Account);
            cmd.Parameters.AddWithValue("@Pin", Pin);
            
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                frmAccount.ID = da.GetValue(0).ToString();

            }
            con.Close();
        }

        //Following Two Methods (Withdraw and Deposit Checking) grabs the checkings balance and modifies it. (1 of 2)
        public static void WithdrawChecking(string ID, int CW)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\the-d\source\repos\ATM\ATM\BankDB.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "Select Checking from CustomerDB where ID = @ID";
            
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);
            
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                CheckingAccount C1 = new CheckingAccount();
                C1.Balance = (int)da.GetValue(0);
                frmAccount.CBalance = (C1.Balance - CW).ToString(); //Withdraw by Subtracting
            }
            
            cmd.Dispose();
            con.Close();
        }

        //Grabs checking balance and modifies it. (2 of 2)
        public static void DepositChecking(string ID, int CD)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\the-d\source\repos\ATM\ATM\BankDB.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "Select Checking from CustomerDB where ID = @ID";
            
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);

            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                CheckingAccount C1 = new CheckingAccount();
                C1.Balance = (int)da.GetValue(0);
                frmAccount.CBalance = (C1.Balance + CD).ToString();//Deposits by Adding
            }

            cmd.Dispose();
            con.Close();
        }

        //Completes modification and sets checking balance value into database
        public static void TransactionOfChecking(string ID, string cbalance)
        {
            string query = "UPDATE CustomerDB set Checking=@CB WHERE ID = @ID";
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\the-d\source\repos\ATM\ATM\BankDB.mdf;Integrated Security=True;Connect Timeout=30";
            
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@CB", cbalance);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Transaction completed successfully"); //Confirmation to User
            con.Close();
        }

        //Transfer set value from Checking to Saving in the Database
        public static void TransferCheckingtoSaving(string ID, int Value)
        {
            string query = "Select Checking, Saving from CustomerDB where ID = @ID";
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\the-d\source\repos\ATM\ATM\BankDB.mdf;Integrated Security=True;Connect Timeout=30";
            
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);

            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                CheckingAccount C1 = new CheckingAccount();
                C1.Balance = (int)da.GetValue(0);
                SavingAccount S1 = new SavingAccount();
                S1.Balance = (int)da.GetValue(1);
                frmAccount.Checking = (C1.Balance - Value); //Substract from Checking
                frmAccount.Saving = (S1.Balance + Value); //Add to Savings
            }

            cmd.Dispose();
            con.Close();
        }

        //Following Two Methods (Withdraw and Deposit Saving) grabs the saving balance and modifies it. (1 of 2)
        public static void WithdrawSaving(string ID, int SW)
        {
            string query = "Select Saving from CustomerDB where ID = @ID";
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\the-d\source\repos\ATM\ATM\BankDB.mdf;Integrated Security=True;Connect Timeout=30";
            
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);

            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                SavingAccount S1 = new SavingAccount();
                S1.Balance = (int)da.GetValue(0);
                frmAccount.SBalance = (S1.Balance - SW).ToString(); //Withdraw by Subtracting
            }
        
            cmd.Dispose();
            con.Close();
        }

        //Grabs saving balance and modifies it. (2 of 2)
        public static void DepositSaving(string ID, int SW)
        {
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\the-d\source\repos\ATM\ATM\BankDB.mdf;Integrated Security=True;Connect Timeout=30";
            string query = "Select Saving from CustomerDB where ID = @ID";

            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);

            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                SavingAccount S1 = new SavingAccount();
                S1.Balance = (int)da.GetValue(0);
                frmAccount.SBalance = (S1.Balance + SW).ToString(); //Deposit by Adding
            }

            cmd.Dispose();
            con.Close();
        }

        //Completes modification and sets saving balance value into database
        public static void TransactionOfSaving(string ID, string sbalance)
        {
            string query = "UPDATE CustomerDB set Saving=@SB WHERE ID = @ID";
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\the-d\source\repos\ATM\ATM\BankDB.mdf;Integrated Security=True;Connect Timeout=30";
            
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@SB", sbalance);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Transaction completed successfully"); //Confirmation to User
            con.Close();
        }

        //Transfer set value from Saving to Checking in the Database
        public static void TransferSavingtoChecking(string ID, int Value)
        {

            string query = "Select Checking, Saving from CustomerDB where ID = @ID";
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\the-d\source\repos\ATM\ATM\BankDB.mdf;Integrated Security=True;Connect Timeout=30";
            
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);

            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                CheckingAccount C1 = new CheckingAccount();
                C1.Balance = (int)da.GetValue(0);
                SavingAccount S1 = new SavingAccount();
                S1.Balance = (int)da.GetValue(1);
                frmAccount.Checking = (C1.Balance + Value); //Adds to Checking
                frmAccount.Saving = (S1.Balance - Value);   //Subtracts from Subtracts
            }

            cmd.Dispose();
            con.Close();
        }

        //Set balance value of both checking and savings into database
        public static void GeneralTransaction(string ID, string CB, string SB)
        {
            string query = "UPDATE CustomerDB set Checking=@CB, Saving=@SB WHERE ID = @ID";
            string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\the-d\source\repos\ATM\ATM\BankDB.mdf;Integrated Security=True;Connect Timeout=30";
            
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@CB", CB);
            cmd.Parameters.AddWithValue("@SB", SB);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Transaction completed successfully"); //Confirmation to User
            con.Close(); 
        }
    }
}

