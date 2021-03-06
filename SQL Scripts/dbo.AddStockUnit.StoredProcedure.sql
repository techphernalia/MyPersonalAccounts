IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddStockUnit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AddStockUnit]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddStockUnit]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AddStockUnit] AS' 
END
GO
ALTER PROCEDURE [dbo].[AddStockUnit]
	@stock_unit_name varchar(100),
	@stock_unit_symbol varchar(100),
	@stock_unit_decimal_places int
AS
BEGIN
	DECLARE @id INT

	INSERT INTO StockUnits(stock_unit_name,stock_unit_symbol,stock_unit_decimal_places)
	VALUES(@stock_unit_name,@stock_unit_symbol,@stock_unit_decimal_places)

	SET @id = @@IDENTITY

	SELECT @id
END

GO
