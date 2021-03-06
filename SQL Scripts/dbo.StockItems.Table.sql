IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_parent_stock_unit]') AND parent_object_id = OBJECT_ID(N'[dbo].[StockItems]'))
ALTER TABLE [dbo].[StockItems] DROP CONSTRAINT [fk_parent_stock_unit]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_parent_stock_group]') AND parent_object_id = OBJECT_ID(N'[dbo].[StockItems]'))
ALTER TABLE [dbo].[StockItems] DROP CONSTRAINT [fk_parent_stock_group]
GO
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockItems]') AND type in (N'U'))
DROP TABLE [dbo].[StockItems]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockItems]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StockItems](
	[stock_item_id] [int] IDENTITY(1,1) NOT NULL,
	[stock_item_name] [varchar](100) NOT NULL,
	[parent_stock_group] [int] NOT NULL,
	[parent_stock_unit] [int] NOT NULL,
	[opening_balance] [numeric](36, 8) NOT NULL,
	[opening_rate] [numeric](36, 8) NOT NULL,
 CONSTRAINT [pk_stock_item_id] PRIMARY KEY CLUSTERED 
(
	[stock_item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_parent_stock_group]') AND parent_object_id = OBJECT_ID(N'[dbo].[StockItems]'))
ALTER TABLE [dbo].[StockItems]  WITH CHECK ADD  CONSTRAINT [fk_parent_stock_group] FOREIGN KEY([parent_stock_group])
REFERENCES [dbo].[StockGroups] ([stock_group_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_parent_stock_group]') AND parent_object_id = OBJECT_ID(N'[dbo].[StockItems]'))
ALTER TABLE [dbo].[StockItems] CHECK CONSTRAINT [fk_parent_stock_group]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_parent_stock_unit]') AND parent_object_id = OBJECT_ID(N'[dbo].[StockItems]'))
ALTER TABLE [dbo].[StockItems]  WITH CHECK ADD  CONSTRAINT [fk_parent_stock_unit] FOREIGN KEY([parent_stock_unit])
REFERENCES [dbo].[StockUnits] ([stock_unit_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[fk_parent_stock_unit]') AND parent_object_id = OBJECT_ID(N'[dbo].[StockItems]'))
ALTER TABLE [dbo].[StockItems] CHECK CONSTRAINT [fk_parent_stock_unit]
GO
