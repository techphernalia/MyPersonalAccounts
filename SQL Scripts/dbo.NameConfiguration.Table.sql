IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NameConfiguration]') AND type in (N'U'))
DROP TABLE [dbo].[NameConfiguration]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[NameConfiguration]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[NameConfiguration](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[system_name] [varchar](500) NOT NULL,
	[name_prefix] [varchar](10) NOT NULL,
	[name_suffix] [varchar](10) NOT NULL,
	[id_length] [int] NOT NULL,
 CONSTRAINT [PK__NameConf__3213E83F5D271CEA] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
