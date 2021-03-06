IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EditStockUnit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EditStockUnit]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EditStockUnit]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EditStockUnit] AS' 
END
GO
ALTER PROCEDURE [dbo].[EditStockUnit]
	@stock_unit_id int,
	@stock_unit_name varchar(100),
	@stock_unit_symbol varchar(100),
	@stock_unit_decimal_places int
AS
BEGIN
	update StockUnits set
		stock_unit_name = @stock_unit_name ,
		stock_unit_symbol = @stock_unit_symbol ,
		stock_unit_decimal_places = @stock_unit_decimal_places 
	where stock_unit_id = @stock_unit_id
END

GO
