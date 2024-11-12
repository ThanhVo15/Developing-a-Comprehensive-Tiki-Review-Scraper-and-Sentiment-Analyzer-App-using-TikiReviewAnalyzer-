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
    public partial class frmReviewGPT : Form
    {
        public frmReviewGPT()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void LoadData(List<ReviewGPTDTO> reviewList)
        {
            dataGridView1.DataSource = reviewList;
        }
    }
}
