IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteLedgerGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[DeleteLedgerGroup]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeleteLedgerGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[DeleteLedgerGroup] AS' 
END
GO
ALTER PROCEDURE [dbo].[DeleteLedgerGroup]
	@ledger_group_id INT
AS
BEGIN
	DELETE FROM LedgerGroups where ledger_group_id = @ledger_group_id
END

GO
