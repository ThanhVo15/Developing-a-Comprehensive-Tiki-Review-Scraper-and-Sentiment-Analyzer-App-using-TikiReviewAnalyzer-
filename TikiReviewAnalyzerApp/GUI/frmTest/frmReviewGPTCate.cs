using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.frmTest
{
    public partial class frmReviewGPTCate : Form
    {
        public frmReviewGPTCate()
        {
            InitializeComponent();
        }

        private void frmReviewGPTCate_Load(object sender, EventArgs e)
        {

        }
        public void LoadData(List<ReviewGPTCateDTO> reviewCateList)
        {
            dataGridView1.DataSource = reviewCateList;
        }
    }
}
