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

namespace GUI.Main
{
    public partial class frmReviewResult : Form
    {
        public frmReviewResult(List<ReviewDTO> reviews)
        {
            InitializeComponent();
            LoadReviews(reviews);
            AddAutoIncrementIdColumn();
        }

        private void AddAutoIncrementIdColumn()
        {
            // Thêm cột ID tự động tăng
            var idColumn = new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "ID",
                ReadOnly = true
            };
            dataGridView1.Columns.Add(idColumn);
        }

        private void LoadReviews(List<ReviewDTO> reviews)
        {
            dataGridView1.DataSource = null; // Đặt DataSource về null để thêm từng hàng thủ công

            // Duyệt qua từng review và thêm vào DataGridView
            int autoIncrementId = 1; // Bắt đầu từ 1
            foreach (var review in reviews)
            {
                int rowIndex = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[rowIndex];

                row.Cells["ID"].Value = autoIncrementId++; // Gán giá trị ID tự động tăng
                row.Cells["ProductID"].Value = review.ProductID;
                row.Cells["ReviewID"].Value = review.ReviewID;
                row.Cells["Title"].Value = review.Title;
                row.Cells["Content"].Value = review.Content;
                row.Cells["CreatedTime"].Value = review.CreatedTime;
                row.Cells["CustomerID"].Value = review.CustomerID;
                row.Cells["ImagesURL"].Value = review.ImagesURL;
                row.Cells["Rating"].Value = review.Rating;
            }
        }

        private void frmReviewResult_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
