IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EditLedgerGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[EditLedgerGroup]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EditLedgerGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[EditLedgerGroup] AS' 
END
GO
ALTER PROCEDURE [dbo].[EditLedgerGroup]
	@ledger_group_id int,
	@ledger_group_name varchar(100),
	@parent_ledger_group_id INT,
	@ledger_type INT
as
begin
	update LedgerGroups set
		ledger_group_name = @ledger_group_name ,
		parent_ledger_group_id = @parent_ledger_group_id ,
		ledger_type = @ledger_type
	where ledger_group_id = @ledger_group_id

	Update G set 
		G.ledger_effect = P.ledger_effect 
	from LedgerGroups G 
	INNER JOIN LedgerGroups P ON P.ledger_group_id = G.parent_ledger_group_id 
	where G.ledger_group_id = @ledger_group_id

end

GO
