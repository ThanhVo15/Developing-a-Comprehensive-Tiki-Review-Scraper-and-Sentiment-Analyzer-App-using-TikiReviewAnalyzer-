# Tiki Review Scraper and Sentiment Analyzer App (TikiReviewAnalyzer)

## Overview
**TikiReviewAnalyzer** is a powerful application built in **C#** and **.NET** that scrapes and analyzes product reviews from Tiki, a leading e-commerce platform. Users can gather data by simply pasting a link, selecting options, and clicking download. The app automates the process of retrieving reviews, product details, and category information, followed by advanced sentiment analysis and topic clustering, providing valuable insights for businesses. The interface is user-friendly, designed with **Windows Forms**.

## Key Features
- **Easy Data Collection**: Paste a Tiki link to retrieve all product reviews, categories, and detailed product information.
- **User Authentication**: Secure login, signup, and password recovery functionalities.
- **Data Scraping**: Collects product details, categories, and user reviews in bulk. Exports data in formats like TXT/CSV.
- **Sentiment Analysis**: Trains and evaluates sentiment models to classify reviews as positive or negative.
- **Topic Clustering**: Organizes reviews into clusters (e.g., product quality, service feedback).
- **Model Management**: Enables saving, loading, and reusing trained models for ongoing analysis.
- **Reporting and Visualization**: Displays analysis results through user-friendly charts, facilitating data-driven insights.

## Technologies Used
- **Programming Language**: C#
- **Framework**: .NET
- **Database**: SQL Server for data storage
- **APIs and Libraries**: Shopee API, OpenAI API, ML.NET
- **Development Tools**: Visual Studio, Docker, Git
- **User Interface**: Windows Forms

## Challenges and Future Enhancements
- **Challenges**: Handling large data volumes, dependency on Tiki’s site structure, and model performance on nuanced feedback.
- **Future Enhancements**: Multi-language support, advanced NLP models, real-time sentiment monitoring, and offline functionality.

## Installation & Setup
1. Clone the repository.
2. Set up SQL Server for database storage.
3. Add API keys to `appsettings.json`.
4. Build and launch the app in Visual Studio.

With TikiReviewAnalyzer, businesses can efficiently monitor and analyze customer feedback on Tiki, enabling strategic insights and improvements.
