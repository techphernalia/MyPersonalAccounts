IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddStockItem]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AddStockItem]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddStockItem]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AddStockItem] AS' 
END
GO
ALTER PROCEDURE [dbo].[AddStockItem]
	@stock_item_name varchar(100),
	@parent_stock_group INT,
	@parent_stock_unit INT,
	@opening_balance numeric(36,8),
	@opening_rate numeric(36,8)
AS
BEGIN
	DECLARE @id INT
	INSERT INTO StockItems(stock_item_name,parent_stock_group,parent_stock_unit,opening_balance,opening_rate)
	VALUES(@stock_item_name,@parent_stock_group,@parent_stock_unit,@opening_balance,@opening_rate)

	SET @id = @@IDENTITY

	SELECT @id
END

GO
