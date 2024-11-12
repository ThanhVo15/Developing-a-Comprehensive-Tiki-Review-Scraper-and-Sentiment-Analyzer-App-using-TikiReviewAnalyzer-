from flask import Flask, request, jsonify
import requests
import pandas as pd
import time
import random

app = Flask(__name__)

# Thiết lập URL và headers
base_url = 'https://tiki.vn/api/personalish/v1/blocks/listings'
headers = {
    'User-Agent': 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/130.0.0.0 Safari/537.36',
    'Accept': 'application/json, text/plain, */*',
    'Referer': 'https://tiki.vn/nha-sach-tiki/c8322',
    'x-guest-token': '8VuwWprC4fBLAGlF2v1sNPyEcOIib9Xo',
}

# Hàm để cào dữ liệu sản phẩm từ API
def crawl_products(category, page_limit=1):
    params = {
        'limit': '40',
        'include': 'advertisement',
        'aggregations': '2',
        'version': 'home-persionalized',
        'trackity_id': 'c0489eb1-8858-d612-98e2-2b56f734ed23',
        'category': category,
        'urlKey': 'nha-sach-tiki'
    }
    products = []
    for page in range(1, page_limit + 1):
        params['page'] = str(page)  # Cập nhật số trang cho mỗi lần yêu cầu
        response = requests.get(base_url, headers=headers, params=params)
        
        if response.status_code == 200:
            data = response.json().get('data', [])
            for item in data:
                products.append({
                    'id': item.get('id'),
                    'name': item.get('name'),
                    'price': item.get('price'),
                    'original_price': item.get('original_price'),
                    'discount': item.get('discount'),
                    'rating_average': item.get('rating_average'),
                    'review_count': item.get('review_count'),
                    'url_path': item.get('url_path'),
                })
        else:
            print(f"Failed to crawl page {page}. Status code: {response.status_code}")
        
        # Đợi một khoảng ngẫu nhiên để tránh bị chặn
        time.sleep(random.uniform(2, 5))

    return products

# Endpoint API để cào dữ liệu từ Tiki
@app.route('/crawl_product_id', methods=['GET'])
def crawl_api():
    # Nhận các tham số từ request
    category = request.args.get('category', default='8322')
    page_limit = int(request.args.get('page_limit', default=1))
    save_to_csv = request.args.get('save_to_csv', default='false').lower() == 'true'
    
    # Cào dữ liệu
    products = crawl_products(category, page_limit)
    
    # Lưu vào CSV nếu được yêu cầu
    if save_to_csv:
        df = pd.DataFrame(products)
        csv_filename = f'tiki_products_{category}.csv'
        df.to_csv(csv_filename, index=False)
        return jsonify({"message": "Data saved to CSV", "filename": csv_filename})
    
    # Trả về dữ liệu dạng JSON
    return jsonify(products)

if __name__ == '__main__':
    app.run(debug=True)
