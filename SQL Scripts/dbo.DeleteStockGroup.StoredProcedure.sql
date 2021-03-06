IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteStockGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteStockGroup]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteStockGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteStockGroup] AS' 
END
GO
ALTER PROCEDURE [dbo].[DeleteStockGroup]
	@stock_group_id INT
AS
BEGIN
	DECLARE @parent_stock_group_id INT

	SELECT @parent_stock_group_id = parent_stock_group FROM StockGroups where stock_group_id = @stock_group_id

	UPDATE StockGroups set parent_stock_group = @parent_stock_group_id where parent_stock_group = @stock_group_id
	UPDATE StockItems set parent_stock_group = @parent_stock_group_id where parent_stock_group = @stock_group_id

	DELETE FROM StockGroups where stock_group_id = @stock_group_id
END

GO
