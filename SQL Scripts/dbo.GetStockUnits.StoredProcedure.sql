IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetStockUnits]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetStockUnits]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetStockUnits]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetStockUnits] AS' 
END
GO
ALTER PROCEDURE [dbo].[GetStockUnits]
	@stock_unit_id INT = NULL
as
begin
	select * from StockUnits WITH (NOLOCK)
	where (@stock_unit_id IS NULL OR @stock_unit_id = 0 OR stock_unit_id = @stock_unit_id)
end

GO
