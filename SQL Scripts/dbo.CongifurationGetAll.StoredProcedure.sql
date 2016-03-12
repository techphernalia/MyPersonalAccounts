IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CongifurationGetAll]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[CongifurationGetAll]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CongifurationGetAll]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[CongifurationGetAll] AS' 
END
GO
ALTER procedure [dbo].[CongifurationGetAll]
as
begin
	select * from NameConfiguration
end

GO
