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
        public fLogIn()
        {
            InitializeComponent();
        }

        private void btLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            string userName = tbUserNameLogIn.Text.ToUpper(); 
            string password = tbPasswordLogIn.Text;
            string holderpw = "";
            string holderun = "";

            lblUserErrorLogIn.Visible = false;
            lblPasswordErrorLogIn.Visible = false;
            if (userName!=holderun)
            {
                lblUserErrorLogIn.Text = "Error: User Name is Incorrect";
                lblUserErrorLogIn.Visible = true;
                tbUserNameLogIn.Text = "";
                lblPasswordErrorLogIn.Text = "Error: User Name Error";
                lblPasswordErrorLogIn.Visible = true;
                tbPasswordLogIn.Text = "";
            }

            else if (password!=holderpw)
            {
                lblPasswordErrorLogIn.Text = "Error: Password is Incorrect";
                lblPasswordErrorLogIn.Visible = true;
                tbPasswordLogIn.Text = "";
            }
            else
            {

                //Close LogIn,the current open form.
                this.Hide();
                //Opens ViewPage
                fViewPage f = new fViewPage();
                f.ShowDialog();
                

            }
        }

        private void lblUserError_Click(object sender, EventArgs e)
        {

        }

        private void fLogIn_Load(object sender, EventArgs e)
        {

        }
    }
}
