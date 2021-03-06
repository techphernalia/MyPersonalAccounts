IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LedgerGroups]') AND type in (N'U'))
DROP TABLE [dbo].[LedgerGroups]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[LedgerGroups]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[LedgerGroups](
	[ledger_group_id] [int] IDENTITY(1,1) NOT NULL,
	[ledger_group_name] [varchar](100) NOT NULL,
	[parent_ledger_group_id] [int] NOT NULL,
	[ledger_type] [int] NOT NULL,
	[ledger_effect] [int] NOT NULL,
 CONSTRAINT [pk_ledger_group_id] PRIMARY KEY CLUSTERED 
(
	[ledger_group_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
