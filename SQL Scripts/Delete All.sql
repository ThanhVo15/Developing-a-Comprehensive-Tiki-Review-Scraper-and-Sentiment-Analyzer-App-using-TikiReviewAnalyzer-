DELETE FROM [TikiReviewAnalyzer].[Tiki].[Products]
DBCC CHECKIDENT ('[TikiReviewAnalyzer].[Tiki].[Products]', RESEED, 0);
DELETE FROM [TikiReviewAnalyzer].[Tiki].[ProductCategory]
DBCC CHECKIDENT ('[TikiReviewAnalyzer].[Tiki].[ProductCategory]', RESEED, 0);
DELETE FROM [TikiReviewAnalyzer].[Tiki].[ProductDetail]
DBCC CHECKIDENT ('[TikiReviewAnalyzer].[Tiki].[ProductDetail]', RESEED, 0);
DELETE FROM [TikiReviewAnalyzer].[Tiki].[ReviewGPT]
DBCC CHECKIDENT ('[TikiReviewAnalyzer].[Tiki].[ReviewGPT]', RESEED, 0);
DELETE FROM [TikiReviewAnalyzer].[Tiki].[ReviewGPTCate]
DBCC CHECKIDENT ('[TikiReviewAnalyzer].[Tiki].[ReviewGPTCate]', RESEED, 0);


