using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fmMain : Form
    {
        frmHomepage homepage;
        frmSubCrawlData subCrawlData;
        frmSubDatabase subDatabase;
        frmSubTrainModel subTrainModel;
        frmSubUsingModel subUsingModel;

        public fmMain()
        {
            InitializeComponent();
        }
        bool manageDataExpand = false;
        private void ManageDataTransition_Tick(object sender, EventArgs e)
        {
            if (manageDataExpand == false)
            {
                ManageDataContainer.Height += 10;
                if (ManageDataContainer.Height >= 237)
                {
                    ManageDataTransition.Stop();
                    manageDataExpand = true;
                }
            }
            else
            {
                ManageDataContainer.Height -= 10;
                if (ManageDataContainer.Height <= 75)
                {
                    ManageDataTransition.Stop();
                    manageDataExpand = false;
                }
            }
        }
        private void btnDataManagement_Click(object sender, EventArgs e)
        {
            ManageDataTransition.Start();
        }

        

        bool manageModelExpand = false;
        private void ManageModelTransition_Tick(object sender, EventArgs e)
        {
            if (!manageModelExpand)
            {
                ManageModelContainer.Height += 10;
                if (ManageModelContainer.Height >= 237)
                {
                    manageModelExpand = true;
                    ManageModelTransition.Stop();
                }
            }
            else
            {
                ManageModelContainer.Height -= 10;
                if (ManageModelContainer.Height <= 75)
                {
                    manageModelExpand = false;
                    ManageModelTransition.Stop();
                }
            }

        }
        private void btnManageModel_Click(object sender, EventArgs e)
        {
            ManageModelTransition.Start();
        }

        bool sideBarExpand = false;
        private void SideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sideBarExpand)
            {
                Sidebar.Width -= 10;
                if (Sidebar.Width <= 64)
                {
                    sideBarExpand = false;
                    SideBarTransition.Stop();

                    //pnHomepage.Width = Sidebar.Width;
                    //ManageDataContainer.Width = Sidebar.Width;
                    //ManageModelContainer.Width = Sidebar.Width;
                    //pnExit.Width = Sidebar.Width;
                }
            }
            else
            {
                Sidebar.Width += 10;
                if (Sidebar.Width >= 214)
                {
                    sideBarExpand = true;
                    SideBarTransition.Stop();

                    //pnHomepage.Width = Sidebar.Width;
                    //ManageDataContainer.Width = Sidebar.Width;
                    //ManageModelContainer.Width = Sidebar.Width;
                    //pnExit.Width = Sidebar.Width;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm to leave!", "Exit Sign", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            this.Show();
        }

        private void picSidebar_Click(object sender, EventArgs e)
        {
            SideBarTransition.Start();
        }

        private void btnCrawlData_Click(object sender, EventArgs e)
        {
            if (subCrawlData == null)
            {
                subCrawlData = new frmSubCrawlData();
                subCrawlData.FormClosed += subCrawlData_FormClosed;
                subCrawlData.MdiParent = this;
                subCrawlData.Dock = DockStyle.Fill;
                subCrawlData.Show();
                lblTitle.Text = "Crawl Data";
            }
            else
            {
                subCrawlData.Activate();
                lblTitle.Text = "Crawl Data";
            }
        }

        private void subCrawlData_FormClosed(object sender, FormClosedEventArgs e)
        {
            subCrawlData = null;
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            if (homepage == null)
            {
                homepage = new frmHomepage();
                homepage.FormClosed += Homepage_FormClosed;
                homepage.MdiParent = this;
                homepage.Dock = DockStyle.Fill;
                homepage.Show();
                lblTitle.Text = "Homepage";
            }
            else
            {
                homepage.Activate();
                homepage.Dock= DockStyle.Fill;
                lblTitle.Text = "Homepage";
            }
                

        }

        private void Homepage_FormClosed(object sender, FormClosedEventArgs e)
        {
            homepage = null;
        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            if (subDatabase == null)
            {
                subDatabase = new frmSubDatabase();
                subDatabase.FormClosed += subDatabasea_FormClosed;
                subDatabase.MdiParent = this;
                subDatabase.Dock = DockStyle.Fill;
                subDatabase.Show();
                lblTitle.Text = "Database";
            }
            else
            {
                subDatabase.Activate();
                lblTitle.Text = "Database";
            }
        }

        private void subDatabasea_FormClosed(object sender, FormClosedEventArgs e)
        {
            subDatabase = null;
        }

        private void btnTrainModel_Click(object sender, EventArgs e)
        {
            if (subTrainModel == null)
            {
                subTrainModel = new frmSubTrainModel();
                subTrainModel.FormClosed += subTrainModel_FormClosed;
                subTrainModel.MdiParent = this;
                subTrainModel.Dock = DockStyle.Fill;
                subTrainModel.Show();
                lblTitle.Text = "Train Model";
            }
            else
            {
                subDatabase.Activate();
                lblTitle.Text = "Train Model";
            }
        }

        private void subTrainModel_FormClosed(object sender, FormClosedEventArgs e)
        {
            subTrainModel = null;
        }

        private void btnUsingModel_Click(object sender, EventArgs e)
        {
            if (subUsingModel == null)
            {
                subUsingModel = new frmSubUsingModel();
                subUsingModel.FormClosed += subUsingModel_FormClosed;
                subUsingModel.MdiParent = this;
                subUsingModel.Dock = DockStyle.Fill;
                subUsingModel.Show();
                lblTitle.Text = "Using Model";
            }
            else
            {
                subUsingModel.Activate();
                lblTitle.Text = "Using Model";
            }
        }

        private void subUsingModel_FormClosed(object sender, FormClosedEventArgs e)
        {
            subUsingModel = null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnHomepage_Click(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        bool profileExpand = false;
        private void ProfileTransition_Tick(object sender, EventArgs e)
        {
            if (profileExpand)
            {
                ProfileSideBar.Width -= 10;
                if (ProfileSideBar.Width <= 10)
                {
                    profileExpand = false;
                    ProfileTransition.Stop();

                    //pnHomepage.Width = Sidebar.Width;
                    //ManageDataContainer.Width = Sidebar.Width;
                    //ManageModelContainer.Width = Sidebar.Width;
                    //pnExit.Width = Sidebar.Width;
                }
            }
            else
            {
                ProfileSideBar.Width += 10;
                if (ProfileSideBar.Width >= 205
                    )
                {
                    profileExpand = true;
                    ProfileTransition.Stop();

                    //pnHomepage.Width = Sidebar.Width;
                    //ManageDataContainer.Width = Sidebar.Width;
                    //ManageModelContainer.Width = Sidebar.Width;
                    //pnExit.Width = Sidebar.Width;
                }
            }
        }

        private void picProfile_Click(object sender, EventArgs e)
        {
            ProfileTransition.Start();
        }
    }
}
