IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddLedgerGroup]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[AddLedgerGroup]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AddLedgerGroup]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AddLedgerGroup] AS' 
END
GO
ALTER PROCEDURE [dbo].[AddLedgerGroup]
	@ledger_group_name varchar(100),
	@parent_ledger_group_id INT,
	@ledger_type INT
AS
BEGIN
	DECLARE @id INT

	INSERT INTO LedgerGroups(ledger_group_name,parent_ledger_group_id,ledger_type, ledger_effect)
	VALUES(@ledger_group_name,@parent_ledger_group_id,@ledger_type,-1)

	SET @id = @@IDENTITY

	Update G set 
		G.ledger_effect = P.ledger_effect 
	from LedgerGroups G 
	INNER JOIN LedgerGroups P ON P.ledger_group_id = G.parent_ledger_group_id 
	where G.ledger_group_id = @id

	SELECT @id
END

GO
