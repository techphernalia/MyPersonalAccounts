IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddStockGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AddStockGroup]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddStockGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AddStockGroup] AS' 
END
GO
ALTER PROCEDURE [dbo].[AddStockGroup]
@stock_group_name varchar(100),
@parent_stock_group INT,
@allow_quantity_add BIT
AS
BEGIN
	DECLARE @id INT

	INSERT INTO StockGroups(stock_group_name,parent_stock_group,allow_quantity_add)
	VALUES(@stock_group_name,@parent_stock_group,@allow_quantity_add)

	SET @id = @@IDENTITY

	SELECT @id
END

GO
