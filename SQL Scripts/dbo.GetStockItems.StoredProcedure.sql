IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetStockItems]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetStockItems]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetStockItems]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetStockItems] AS' 
END
GO
ALTER PROCEDURE [dbo].[GetStockItems]
	@stock_item_id INT = NULL,
	@parent_stock_group_id INT = NULL
as
begin
	select * from StockItems WITH (NOLOCK)
	where 
		(@stock_item_id IS NULL OR @stock_item_id = 0 OR stock_item_id = @stock_item_id) AND
		(@parent_stock_group_id IS NULL OR @parent_stock_group_id = 0 OR parent_stock_group = @parent_stock_group_id)
end

GO
