using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATM
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        //Initialize strings
        public static string AN;
        public static string Pin;

        //Connection String
        protected string cs = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\the-d\source\repos\ATM\ATM\BankDB.mdf;Integrated Security=True;Connect Timeout=30";
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //Log-in information for indentifing which Customer data to show up.
            AN = txt_AN.Text;
            Pin = txt_PIN.Text;

            if (txt_AN.Text == "" || txt_PIN.Text == "")
            {
                MessageBox.Show("Please provide Account Number and Pin");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cs);
                SqlCommand cmd = new SqlCommand("Select * from CustomerDB where Account=@account and PIN=@pin", con);
                cmd.Parameters.AddWithValue("@account", txt_AN.Text);
                cmd.Parameters.AddWithValue("@pin", txt_PIN.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                
                //If count is equal to 1, than show Account Form
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    frmAccount fm = new frmAccount();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("Login Failed!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
