IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetLedgerGroups]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[GetLedgerGroups]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[GetLedgerGroups]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[GetLedgerGroups] AS' 
END
GO
ALTER PROCEDURE [dbo].[GetLedgerGroups]
	@ledger_group_id INT = NULL,
	@parent_ledger_group_id INT = NULL
as
begin
	select * from LedgerGroups WITH (NOLOCK)
	where 
		(@ledger_group_id IS NULL OR @ledger_group_id = 0 OR ledger_group_id = @ledger_group_id) AND
		(@parent_ledger_group_id IS NULL OR @parent_ledger_group_id = 0 OR parent_ledger_group_id = @parent_ledger_group_id)
end

GO
