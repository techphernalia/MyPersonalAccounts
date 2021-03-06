IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EditStockGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EditStockGroup]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EditStockGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EditStockGroup] AS' 
END
GO
ALTER PROCEDURE [dbo].[EditStockGroup]
	@stock_group_id int,
	@stock_group_name varchar(100),
	@parent_stock_group INT,
	@allow_quantity_add BIT
as
begin
	update StockGroups set
		stock_group_name = @stock_group_name ,
		parent_stock_group = @parent_stock_group ,
		allow_quantity_add = @allow_quantity_add 
	where stock_group_id = @stock_group_id
end
GO
