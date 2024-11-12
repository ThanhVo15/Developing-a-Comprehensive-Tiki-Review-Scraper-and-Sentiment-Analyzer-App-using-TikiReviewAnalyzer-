using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml;
using System.Security.Policy;
using Newtonsoft.Json.Linq;
using GUI.Main;
using System.Text.RegularExpressions;
using GUI.frmTest;

namespace GUI
{
    public partial class frmSubCrawlData : Form
    {
        private readonly ProductBLL _productBLL;
        private readonly ProductDetailBLL _productDetailBLL;
        private readonly ReviewBLL _reviewBLL;
        private readonly ReviewAIBLL _reviewAIBLL;

        public frmSubCrawlData()
        {
            InitializeComponent();
            InitializeUIElements();

            _productBLL = new ProductBLL();
            _productDetailBLL = new ProductDetailBLL();
            _reviewBLL = new ReviewBLL();
            _reviewAIBLL = new ReviewAIBLL();
        }

        private void InitializeUIElements()
        {
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            radNo.BackColor = Color.Transparent;
            radYes.BackColor = Color.Transparent;
            lblLoadingPercent.BackColor = Color.Transparent;
            panel2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            panel3.BackColor = Color.Transparent;
            panel5.BackColor = Color.Transparent;
        }

        private async void btnCrawlNow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rtxtURL.Text))
            {
                MessageBox.Show("Vui lòng nhập URL.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNumberofPageFrom.Text) || string.IsNullOrWhiteSpace(txtNumberofPageTo.Text))
            {
                MessageBox.Show("Vui lòng nhập số trang từ và đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDataName.Text))
            {
                MessageBox.Show("Vui lòng đặt tên cho tập dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                lblLoadingPercent.Text = "0%";
                progressBar1.Value = 0;

                lblNotification.Text = "Crawling Product IDs...";
                string categoryUrl = rtxtURL.Text;
                List<ProductDTO> allProducts = await Crawl_ProductID(rtxtURL.Text, int.Parse(txtNumberofPageFrom.Text), int.Parse(txtNumberofPageTo.Text));

                if (allProducts != null && allProducts.Count > 0)
                {
                    if (radYes.Checked)
                    {
                        await SaveToDatabaseAsync(allProducts, categoryUrl);
                        btnSaveToDatabases.Enabled = false;
                    }

                    string folderPath = @"E:\\Developing-a-Comprehensive-Tiki-Review-Scraper-and-Sentiment-Analyzer-App-using-TikiReviewAnalyzer-\\JSon";
                    string jsonFilePath = Path.Combine(folderPath, $"{txtDataName.Text.Trim()}_{DateTime.Now:yyyyMMddHHmmss}.json");
                    File.WriteAllText(jsonFilePath, Newtonsoft.Json.JsonConvert.SerializeObject(allProducts));

                    LoadProductsFromJson(jsonFilePath);

                    lblNotification.Text = "Crawling Product Details...";
                    await CrawlDetailForAllProducts(allProducts);

                    lblNotification.Text = "Crawling Reviews...";
                    await CrawlReviewsForProductsAsync(allProducts);

                    lblNotification.Text = "Crawling AI Reviews...";
                    await CrawlReviewAITiki(allProducts);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu được cào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                lblNotification.Text = "Data Crawling Completed";
                progressBar1.Value = 100;
                lblLoadingPercent.Text = "100%";
                MessageBox.Show("Data Crawling and Saving Completed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task CrawlReviewAITiki(List<ProductDTO> products)
        {
            int totalProducts = products.Count;
            int completedProducts = 0;

            foreach (var product in products)
            {
                ProductDetailDTO productDetail = _productDetailBLL.GetProductDetailByProductID(product.ProductID);
                if (productDetail == null || string.IsNullOrEmpty(productDetail.spid) || string.IsNullOrEmpty(productDetail.SellerID))
                {
                    Console.WriteLine($"Skipping product {product.ProductID} due to missing spid or SellerID.");
                    continue;
                }

                string reviewAiUrl = $"https://api.tiki.vn/falcon/ext/v1/review-analysis?product_id={product.ProductID}&spid={productDetail.spid}&seller_id={productDetail.SellerID}";

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("accept", "application/json, text/plain, */*");
                    client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/130.0.0.0 Safari/537.36");

                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(reviewAiUrl);
                        if (response.IsSuccessStatusCode)
                        {
                            string jsonData = await response.Content.ReadAsStringAsync();
                            JObject jsonObject = JObject.Parse(jsonData);

                            var sections = jsonObject["data"]?["sections"];
                            if (sections != null)
                            {
                                foreach (var section in sections)
                                {
                                    var reviewCate = new ReviewGPTCateDTO
                                    {
                                        ProductID = product.ProductID,
                                        Title = section["title"]?.ToString(),
                                        SubTitle = section["sub_title"]?.ToString()
                                    };

                                    int gptCateId = _reviewAIBLL.SaveReviewCate(reviewCate);

                                    var reviews = section["reviews"];
                                    if (reviews != null)
                                    {
                                        foreach (var reviewItem in reviews)
                                        {
                                            var reviewText = reviewItem["text"]?.ToString();

                                            var review = new ReviewGPTDTO
                                            {
                                                GPTCateID = gptCateId,
                                                Text = reviewText
                                            };

                                            _reviewAIBLL.SaveReview(review);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                var emptyReviewCate = new ReviewGPTCateDTO
                                {
                                    ProductID = product.ProductID,
                                    Title = null,
                                    SubTitle = null
                                };
                                _reviewAIBLL.SaveReviewCate(emptyReviewCate);
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Failed to fetch data for ProductID: {product.ProductID} - Status Code: {response.StatusCode}");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error accessing URL: {reviewAiUrl} - {ex.Message}");
                    }
                }

                completedProducts++;
                int progress = (int)((completedProducts / (double)totalProducts) * 100);
                progressBar1.Value = progress;
                lblLoadingPercent.Text = $"{progress}%";
                await Task.Delay(100);
            }

            lblNotification.Text = "Crawl Review AI Completed!";
            lblNotification.ForeColor = Color.Green;
            MessageBox.Show("AI Review data crawling completed!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private async Task<List<ProductDTO>> Crawl_ProductID(string inputUrls, int pageFrom, int pageTo)
        {
            List<ProductDTO> allProducts = new List<ProductDTO>();
            string[] urls = inputUrls.Split(',');
            int totalProducts = urls.Length * (pageTo - pageFrom + 1);
            int completedProducts = 0;

            lblNotification.Text = "Crawling Product ID...";
            lblNotification.ForeColor = Color.Blue;

            foreach (string url in urls)
            {
                string trimmedUrl = url.Trim();
                string categoryId = ExtractCategoryFromUrl(trimmedUrl);
                string urlKey = ExtractUrlKeyFromUrl(trimmedUrl);

                for (int page = pageFrom; page <= pageTo; page++)
                {
                    var queryParams = new FormUrlEncodedContent(new[]
                    {
                        new KeyValuePair<string, string>("limit", "40"),
                        new KeyValuePair<string, string>("include", "advertisement"),
                        new KeyValuePair<string, string>("aggregations", "2"),
                        new KeyValuePair<string, string>("version", "home-persionalized"),
                        new KeyValuePair<string, string>("trackity_id", "unique_trackity_id"),
                        new KeyValuePair<string, string>("category", categoryId),
                        new KeyValuePair<string, string>("page", page.ToString()),
                        new KeyValuePair<string, string>("urlKey", urlKey)
                    });

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Add("accept", "application/json, text/plain, */*");
                        client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64)");

                        string urlWithParams = $"https://tiki.vn/api/personalish/v1/blocks/listings?{await queryParams.ReadAsStringAsync()}";
                        HttpResponseMessage response = await client.GetAsync(urlWithParams);

                        if (response.IsSuccessStatusCode)
                        {
                            string responseData = await response.Content.ReadAsStringAsync();
                            var products = ParseProductsFromJson(responseData);

                            foreach (var product in products)
                            {
                                product.ProductCategoryID = categoryId;
                            }

                            allProducts.AddRange(products);
                        }
                    }

                    completedProducts++;
                    int progress = (int)((completedProducts / (double)totalProducts) * 100);
                    progressBar1.Value = progress;
                    lblLoadingPercent.Text = $"{progress}%";
                    await Task.Delay(100);
                }
            }

            lblNotification.Text = "Crawl Product ID Completed!";
            lblNotification.ForeColor = Color.Green;
            return allProducts;
        }

        private async Task CrawlDetailForAllProducts(List<ProductDTO> products)
        {
            lblNotification.Text = "Crawling Product Detail...";
            lblNotification.ForeColor = Color.Blue;

            int totalProducts = products.Count;
            int completedProducts = 0;

            foreach (var product in products)
            {
                string url = $"https://tiki.vn/api/v2/products/{product.ProductID}?platform=web&spid={product.ProductID}&version=3";

                using (HttpClient client = new HttpClient())
                {
                    client.DefaultRequestHeaders.Add("accept", "application/json, text/plain, */*");
                    client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/130.0.0.0 Safari/537.36");

                    try
                    {
                        HttpResponseMessage response = await client.GetAsync(url);

                        if (response.IsSuccessStatusCode && response.Content.Headers.ContentType.MediaType == "application/json")
                        {
                            string responseData = await response.Content.ReadAsStringAsync();
                            dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(responseData);

                            string shortUrl = data.short_url != null ? data.short_url.ToString() : null;
                            string spid = null;

                            if (shortUrl != null)
                            {
                                var match = Regex.Match(shortUrl, @"spid=(\d+)");
                                if (match.Success)
                                {
                                    spid = match.Groups[1].Value;
                                }
                            }

                            string sellerId = data.current_seller != null && data.current_seller.id != null ? data.current_seller.id.ToString() : null;

                            var productDetail = new ProductDetailDTO
                            {
                                ProductID = data.id != null ? data.id.ToString() : null,
                                ProdDescriptions = data.description != null ? data.description.ToString() : null,
                                ProdShortDescriptions = data.short_description != null ? data.short_description.ToString() : null,
                                ProdURL = $"https://tiki.vn/{product.UrlPath}",
                                SellerID = sellerId,
                                spid = spid
                            };

                            if (!_productDetailBLL.CheckDuplicateProductDetail(productDetail.ProductID))
                            {
                                _productDetailBLL.SaveProductDetail(productDetail);
                            }
                            else
                            {
                                Console.WriteLine($"Chi tiết cho sản phẩm ID: {productDetail.ProductID} đã tồn tại.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Không thể lấy JSON cho sản phẩm ID: {product.ProductID}. Để trống các trường chi tiết.");

                            var productDetail = new ProductDetailDTO
                            {
                                ProductID = product.ProductID,
                                ProdDescriptions = null,
                                ProdShortDescriptions = null,
                                ProdURL = $"https://tiki.vn/{product.UrlPath}",
                                SellerID = null,
                                spid = null
                            };

                            if (!_productDetailBLL.CheckDuplicateProductDetail(productDetail.ProductID))
                            {
                                _productDetailBLL.SaveProductDetail(productDetail);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Lỗi khi cào dữ liệu cho sản phẩm ID: {product.ProductID}. Lỗi: {ex.Message}");

                        var productDetail = new ProductDetailDTO
                        {
                            ProductID = product.ProductID,
                            ProdDescriptions = null,
                            ProdShortDescriptions = null,
                            ProdURL = $"https://tiki.vn/{product.UrlPath}",
                            SellerID = null,
                            spid = null
                        };

                        if (!_productDetailBLL.CheckDuplicateProductDetail(productDetail.ProductID))
                        {
                            _productDetailBLL.SaveProductDetail(productDetail);
                        }
                    }
                }

                completedProducts++;
                int progress = (int)((completedProducts / (double)totalProducts) * 100);
                progressBar1.Value = progress;
                lblLoadingPercent.Text = $"{progress}%";
                await Task.Delay(500);
            }

            lblNotification.Text = "Crawl Product Detail Completed!";
            lblNotification.ForeColor = Color.Green;
        }

        public async Task CrawlReviewsForProductsAsync(List<ProductDTO> products)
        {
            int totalProducts = products.Count;
            int completedProducts = 0;
            List<ReviewDTO> allReviews = new List<ReviewDTO>();

            foreach (var product in products)
            {
                completedProducts++;

                ProductDetailDTO productDetail = _productDetailBLL.GetProductDetailByProductID(product.ProductID);
                if (productDetail == null || string.IsNullOrEmpty(productDetail.spid) || string.IsNullOrEmpty(productDetail.SellerID))
                {
                    Console.WriteLine($"Skipping product {product.ProductID} due to missing spid or SellerID.");
                    continue;
                }

                for (int page = 1; page <= 1; page++)
                {
                    string reviewUrl = $"https://tiki.vn/api/v2/reviews?limit=5&include=comments,contribute_info,attribute_vote_summary&sort=score|desc,id|desc,stars|all&page={page}&spid={productDetail.spid}&product_id={product.ProductID}&seller_id={productDetail.SellerID}";

                    using (HttpClient client = new HttpClient())
                    {
                        client.DefaultRequestHeaders.Add("accept", "application/json, text/plain, */*");
                        client.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/130.0.0.0 Safari/537.36");

                        try
                        {
                            HttpResponseMessage response = await client.GetAsync(reviewUrl);
                            if (response.IsSuccessStatusCode)
                            {
                                string jsonData = await response.Content.ReadAsStringAsync();
                                JObject jsonObject = JObject.Parse(jsonData);

                                var reviewData = jsonObject["data"];
                                if (reviewData != null)
                                {
                                    foreach (var item in reviewData)
                                    {
                                        try
                                        {
                                            var review = new ReviewDTO
                                            {
                                                ProductID = product.ProductID,
                                                ReviewID = item["id"]?.ToString(),
                                                Title = item["title"]?.ToString(),
                                                Content = item["content"]?.ToString(),
                                                CreatedTime = item["timeline"]?["review_created_date"]?.ToString(),
                                                CustomerID = item["created_by"]?["id"]?.ToString(),
                                                ImagesURL = item["images"] != null ? item["images"].ToString() : null,
                                                Rating = item["rating"] != null ? (decimal?)item["rating"] : null
                                            };

                                            allReviews.Add(review);
                                            Console.WriteLine($"Added review ID: {review.ReviewID} for product {product.ProductID}");
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine($"Error adding review: {ex.Message}");
                                        }
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error accessing URL: {reviewUrl} - {ex.Message}");
                        }
                    }
                }

                int progress = (int)((completedProducts / (double)totalProducts) * 100);
                progressBar1.Value = progress;
                lblLoadingPercent.Text = $"{progress}%";
                await Task.Delay(100);
            }

            _reviewBLL.SaveReviews(allReviews);
            Console.WriteLine("All reviews have been saved to the database.");

            lblNotification.Text = "Crawl Reviews Completed!";
            lblNotification.ForeColor = Color.Green;
        }

        private void LoadProductsFromJson(string jsonFilePath)
        {
            var products = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ProductDTO>>(File.ReadAllText(jsonFilePath));
            LoadProducts(products);
        }

        private string ExtractUrlKeyFromUrl(string url)
        {
            var uri = new Uri(url);
            var segments = uri.Segments;
            return segments.Length > 1 ? segments[segments.Length - 1].Trim('/') : "nha-sach-tiki";
        }

        private string ExtractCategoryFromUrl(string url)
        {
            var match = System.Text.RegularExpressions.Regex.Match(url, @"c(\d+)");
            return match.Success ? match.Groups[1].Value : "8322";
        }

        private List<ProductDTO> ParseProductsFromJson(string json)
        {
            var productList = new List<ProductDTO>();

            dynamic data = Newtonsoft.Json.JsonConvert.DeserializeObject(json);
            foreach (var item in data.data)
            {
                var product = new ProductDTO
                {
                    ProductID = item.id,
                    ProductSKU = item.sku,
                    ProductName = item.name,
                    ProductOriginalPrice = item.original_price,
                    ProductPrice = item.price,
                    ProductQuantitySold = item.quantity_sold != null ? (int?)item.quantity_sold.value ?? 0 : 0,
                    RatingAverage = item.rating_average,
                    ReviewCount = item.review_count,
                    UrlPath = item.url_path
                };
                productList.Add(product);
            }
            return productList;
        }

        private void LoadProducts(List<ProductDTO> products)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            int autoIncrementId = 1;

            foreach (var product in products)
            {
                int rowIndex = dataGridView1.Rows.Add();
                var row = dataGridView1.Rows[rowIndex];

                row.Cells["ID"].Value = autoIncrementId++;
                row.Cells["ProductCategoryID"].Value = product.ProductCategoryID;
                row.Cells["ProductID"].Value = product.ProductID;
                row.Cells["ProductSKU"].Value = product.ProductSKU;
                row.Cells["ProductName"].Value = product.ProductName;
                row.Cells["ProductOriginalPrice"].Value = product.ProductOriginalPrice;
                row.Cells["ProductPrice"].Value = product.ProductPrice;
                row.Cells["ProductQuantitySold"].Value = product.ProductQuantitySold;
                row.Cells["RatingAverage"].Value = product.RatingAverage;
                row.Cells["ReviewCount"].Value = product.ReviewCount;
                row.Cells["UrlPath"].Value = product.UrlPath;
            }
        }

        private async Task SaveToDatabaseAsync(List<ProductDTO> products, string categoryUrl)
        {
            await Task.Run(() =>
            {
                _productBLL.SaveProducts(products, categoryUrl);
                Invoke(new Action(() =>
                {
                    MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu.");
                    btnSaveToDatabases.Enabled = false;
                }));
            });
        }

        private bool hasDataBeenSaved = false;

        private async void btnSaveToDatabases_Click(object sender, EventArgs e)
        {
            if (hasDataBeenSaved)
            {
                MessageBox.Show("Dữ liệu đã được lưu, không thể lưu thêm.");
                return;
            }

            List<ProductDTO> products = GetProductsFromDataGridView();
            string categoryUrl = rtxtURL.Text;

            if (_productBLL.CheckDuplicateProducts(products))
            {
                MessageBox.Show("Dữ liệu đã tồn tại trong cơ sở dữ liệu.");
            }
            else
            {
                await SaveToDatabaseAsync(products, categoryUrl);
                hasDataBeenSaved = true;
            }
        }

        private List<ProductDTO> GetProductsFromDataGridView()
        {
            var products = new List<ProductDTO>();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["ProductID"].Value != null)
                {
                    var product = new ProductDTO
                    {
                        ProductCategoryID = row.Cells["ProductCategoryID"].Value?.ToString(),
                        ProductID = row.Cells["ProductID"].Value.ToString(),
                        ProductSKU = row.Cells["ProductSKU"].Value.ToString(),
                        ProductName = row.Cells["ProductName"].Value.ToString(),
                        ProductOriginalPrice = Convert.ToInt32(row.Cells["ProductOriginalPrice"].Value),
                        ProductPrice = Convert.ToInt32(row.Cells["ProductPrice"].Value),
                        ProductQuantitySold = Convert.ToInt32(row.Cells["ProductQuantitySold"].Value),
                        RatingAverage = Convert.ToDecimal(row.Cells["RatingAverage"].Value),
                        ReviewCount = row.Cells["ReviewCount"].Value != null ? Convert.ToInt32(row.Cells["ReviewCount"].Value) : 0,
                        UrlPath = row.Cells["UrlPath"].Value?.ToString()
                    };
                    products.Add(product);
                }
            }
            return products;
        }

        private void ExportToExcel(string filePath)
        {
            using (var package = new OfficeOpenXml.ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Products");
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataGridView1.Columns[i].HeaderText;
                }

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView1.Rows[i].Cells[j].Value;
                    }
                }

                package.SaveAs(new FileInfo(filePath));
            }
        }

        private async void btnExportExcel_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                using (SaveFileDialog sfd = new SaveFileDialog { Filter = "Excel Workbook|*.xlsx" })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        ExportToExcel(sfd.FileName);
                        MessageBox.Show("Dữ liệu đã được xuất ra file Excel.");
                    }
                }
            });
        }

        private void frmSubCrawlData_Load(object sender, EventArgs e)
        {
            txtDateCrawl.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rtxtURL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
