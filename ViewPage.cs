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
        
        string str;
        OleDbCommand com;
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
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\pc\OneDrive\Aero_Material_Handling.accdb");

            try
            {
                con.Open();
                string searchQuery = "SELECT AMH_Entries.entryTitle, AMH_Entries.entryDescShort, AMH_Entries.entryDescLong, AMH_Tags.tagName " +
                                     "FROM AMH_Tags INNER JOIN (AMH_Entries INNER JOIN AMH_Tag_Entry ON AMH_Entries.entryID = AMH_Tag_Entry.entryID)" +
                                     "ON AMH_Tags.tagID = AMH_Tag_Entry.tagID  " +
                                     "where entryTitle = '" + tbSearch.Text + "'";
                OleDbCommand com = new OleDbCommand(searchQuery, con);

                OleDbDataReader accessReader = com.ExecuteReader();

                while (accessReader.Read())
                {
                    lbViewTitle.Text = accessReader.GetValue(0).ToString();
                    tbViewShortDescription.Text = accessReader.GetValue(1).ToString();
                    tbViewLongDescription.Text = accessReader.GetValue(2).ToString();
                    lblTags.Text = accessReader.GetValue(3).ToString();                 
                }
                
                accessReader.Close();
                com.Dispose();
                con.Close();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show(ex.Message);
            }


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
                listItems[i].Tags = "Tag";
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void lblTags_Click(object sender, EventArgs e)
        {

        }
    }
}
