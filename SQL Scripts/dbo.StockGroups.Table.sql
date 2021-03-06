IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockGroups]') AND type in (N'U'))
DROP TABLE [dbo].[StockGroups]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StockGroups]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StockGroups](
	[stock_group_id] [int] IDENTITY(1,1) NOT NULL,
	[stock_group_name] [varchar](100) NOT NULL,
	[parent_stock_group] [int] NOT NULL,
	[allow_quantity_add] [bit] NOT NULL,
 CONSTRAINT [pk_stock_group_id] PRIMARY KEY CLUSTERED 
(
	[stock_group_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
