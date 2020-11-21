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
    public partial class fViewPage : Form
    {
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\pc\\OneDrive\\Aero_Material_Handling.accdb");
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataTable dt;
        public fViewPage()
        {
            InitializeComponent();
        }

        private void ViewPage_Load(object sender, EventArgs e)
        {
            

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scDivide_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btNewEntry_Click(object sender, EventArgs e)
        {
            //Opens EditPage
            fEditPage f = new fEditPage();
            f.ShowDialog();
        }

        private void pbUser_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnSearchResult_MouseClick(object sender, MouseEventArgs e)
        {
            //This Code will set the splitter distance split panal2
            scDivide.SplitterDistance = 200;
        }

        private void flowLayoutPanel_MouseClick(object sender, MouseEventArgs e)
        {
            //This Code will set the splitter distance to focus on split panal1
            scDivide.SplitterDistance = 900;
        }
        private void scDivide_Panel1_MouseClick(object sender, MouseEventArgs e)
        {
            //This Code will set the splitter distance to focus on split panal1
            scDivide.SplitterDistance = 900;
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            //automatically start populating the flow planel
            populateItems();
            



        }
        
        
        //Poplulate the flowpanel left side
        private void populateItems()
        {
            ListItem[] listItems = new ListItem[20];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ListItem();
                listItems[i].Title = "Title -- Lorum Ipsum";
                listItems[i].Tags = "Tags";
                listItems[i].shortDesc = "This is a short descriptino of the product -- Lorum Ipsum";

                if (flp1.Controls.Count < 0)
                {
                    flp1.Controls.Clear();
                }
                else
                    flp1.Controls.Add(listItems[i]);

            }
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            fLogIn f = new fLogIn();
            f.Show();
        }
    }
}
