IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteStockItem]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteStockItem]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteStockItem]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteStockItem] AS' 
END
GO
ALTER PROCEDURE [dbo].[DeleteStockItem]
	@stock_item_id INT
AS
BEGIN
	DELETE FROM StockItems where stock_item_id = @stock_item_id
END

GO
