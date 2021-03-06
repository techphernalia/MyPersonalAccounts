IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EditStockItem]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EditStockItem]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EditStockItem]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EditStockItem] AS' 
END
GO
ALTER PROCEDURE [dbo].[EditStockItem]
	@stock_item_id int,
	@stock_item_name varchar(100),
	@parent_stock_group INT,
	@parent_stock_unit INT,
	@opening_balance numeric(36,8),
	@opening_rate numeric(36,8)
as
begin
	update StockItems set 
		stock_item_name = @stock_item_name ,
		parent_stock_group = @parent_stock_group,
		parent_stock_unit = @parent_stock_unit,
		opening_balance = @opening_balance,
		opening_rate = @opening_rate
	where stock_item_id = @stock_item_id
end

GO
