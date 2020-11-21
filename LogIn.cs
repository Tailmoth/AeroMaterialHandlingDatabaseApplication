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

namespace AeroMaterialHandlingDatabaseApplication
{
    public partial class fLogIn : Form
    {

        //This creates a connection between C# and AMH database. 
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataTable dt;
        string sql;
        public fLogIn()
        {
            InitializeComponent();                       
            this.AcceptButton = btlogin;
        }

        private int login(string sql) 
        {
            int maxrow = 0;
            //A try/catch/finally statement is used to ensure the application doesn't crash when login is unsuccessful.
            try
            {
                con.Open();
                cmd = new OleDbCommand();
                da = new OleDbDataAdapter();
                dt = new DataTable();
                cmd.Connection = con;
                cmd.CommandText = sql;
                da.SelectCommand = cmd;
                da.Fill(dt);

                maxrow = dt.Rows.Count;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                da.Dispose();
                con.Close();
            }
            return maxrow;
        }

        private void btLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            
            int maxrow = 0;
            sql = "select * from AMH_Users where username = '" + tbUserNameLogIn.Text + "' AND password ='" + tbPasswordLogIn.Text + "'";
            maxrow = login(sql);

            if (maxrow > 0)
            {
                //Opens view page when login is successful.
                this.Hide();               
                fViewPage f = new fViewPage();
                f.ShowDialog();
                
            }
            else
            {
                //Message box is shown stating that login was unsuccessful.
                MessageBox.Show("The username or password you entered is incorrect.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //This clears the textboxes when OK is clicked on message box.
                tbUserNameLogIn.Clear();
                tbPasswordLogIn.Clear();
                tbUserNameLogIn.Focus();
            }

           
            //string userName = tbUserNameLogIn.Text.ToUpper(); 
            //string password = tbPasswordLogIn.Text;
            //string holderpw = "";
            //string holderun = "";

            //lblUserErrorLogIn.Visible = false;
            //lblPasswordErrorLogIn.Visible = false;
            //if (userName!=holderun)
            //{
            //    lblUserErrorLogIn.Text = "Error: User Name is Incorrect";
            //    lblUserErrorLogIn.Visible = true;
            //    tbUserNameLogIn.Text = "";
            //    lblPasswordErrorLogIn.Text = "Error: User Name Error";
            //    lblPasswordErrorLogIn.Visible = true;
            //    tbPasswordLogIn.Text = "";
            //}

            //else if (password!=holderpw)
            //{
            //    lblPasswordErrorLogIn.Text = "Error: Password is Incorrect";
            //    lblPasswordErrorLogIn.Visible = true;
            //    tbPasswordLogIn.Text = "";
            //}
            //else
            //{

            //    //Close LogIn,the current open form.
            //    this.Hide();
            //    //Opens ViewPage
            //    fViewPage f = new fViewPage();
            //    f.ShowDialog();


            //}
        }

        private void lblUserError_Click(object sender, EventArgs e)
        {

        }

        private void fLogIn_Load(object sender, EventArgs e)
        {
                    
        }

        private void tbUserNameLogIn_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
