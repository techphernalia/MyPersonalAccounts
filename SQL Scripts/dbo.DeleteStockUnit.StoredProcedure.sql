IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteStockUnit]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteStockUnit]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteStockUnit]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteStockUnit] AS' 
END
GO
ALTER PROCEDURE [dbo].[DeleteStockUnit]
	@stock_unit_id INT
AS
BEGIN
	DELETE FROM StockUnits where stock_unit_id = @stock_unit_id
END

GO
