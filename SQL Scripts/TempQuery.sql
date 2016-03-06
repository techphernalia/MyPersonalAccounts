CREATE DATABASE MyPersonalAccountsManager
GO
USE MyPersonalAccountsManager
GO

CREATE TABLE StockUnits
(
	stock_unit_id int not null identity ,
	stock_unit_name varchar(100) not null,
	stock_unit_symbol varchar(100) not null,
	stock_unit_decimal_places int not null,
	CONSTRAINT pk_stock_unit_id PRIMARY KEY CLUSTERED(stock_unit_id)
)
GO

CREATE TABLE StockGroups
(
	stock_group_id int not null identity,
	stock_group_name varchar(100) not null,
	parent_stock_group int not null,
	allow_quantity_add BIT not null,
	CONSTRAINT pk_stock_group_id PRIMARY KEY CLUSTERED(stock_group_id)
)
GO

CREATE TABLE StockItems
(
	stock_item_id int not null identity,
	stock_item_name varchar(100) not null,
	parent_stock_group int not null,
	parent_stock_unit int not null,
	opening_balance numeric(36,8) not null,
	opening_rate numeric(36,8) not null,
	CONSTRAINT fk_parent_stock_group FOREIGN KEY (parent_stock_group) REFERENCES StockGroups(stock_group_id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT fk_parent_stock_unit FOREIGN KEY (parent_stock_unit) REFERENCES StockUnits(stock_unit_id) ON DELETE CASCADE ON UPDATE CASCADE,
	CONSTRAINT pk_stock_item_id PRIMARY KEY CLUSTERED(stock_item_id)
)
GO

CREATE TABLE LedgerGroups
(
	ledger_group_id int not null identity,
	ledger_group_name varchar(100) not null,
	parent_ledger_group_id int not null,
	ledger_type int not null,
	ledger_effect int not null,
	CONSTRAINT pk_ledger_group_id PRIMARY KEY CLUSTERED(ledger_group_id )
)
GO

CREATE PROCEDURE DeleteStockUnit
	@stock_unit_id INT
AS
BEGIN
	DELETE FROM StockUnits where stock_unit_id = @stock_unit_id
END
GO

CREATE PROCEDURE DeleteStockItem
	@stock_item_id INT
AS
BEGIN
	DELETE FROM StockItems where stock_item_id = @stock_item_id
END
GO

CREATE PROCEDURE DeleteStockGroup
	@stock_group_id INT
AS
BEGIN
	DECLARE @parent_stock_group_id INT

	SELECT @parent_stock_group_id = parent_stock_group FROM StockGroups where stock_group_id = @stock_group_id

	UPDATE StockGroups set parent_stock_group = @parent_stock_group_id where parent_stock_group = @stock_group_id
	UPDATE StockItems set parent_stock_group = @parent_stock_group_id where parent_stock_group = @stock_group_id

	DELETE FROM StockGroups where stock_group_id = @stock_group_id
END
GO

CREATE PROCEDURE AddStockUnit
	@stock_unit_name varchar(100),
	@stock_unit_symbol varchar(100),
	@stock_unit_decimal_places int
AS
BEGIN
	DECLARE @id INT

	INSERT INTO StockUnits(stock_unit_name,stock_unit_symbol,stock_unit_decimal_places)
	VALUES(@stock_unit_name,@stock_unit_symbol,@stock_unit_decimal_places)

	SET @id = @@IDENTITY

	SELECT @id
END
GO

CREATE PROCEDURE AddStockGroup
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

CREATE PROCEDURE AddStockItem
	@stock_item_name varchar(100),
	@parent_stock_group INT,
	@parent_stock_unit INT,
	@opening_balance numeric(36,8),
	@opening_rate numeric(36,8)
AS
BEGIN
	DECLARE @id INT
	INSERT INTO StockItems(stock_item_name,parent_stock_group,parent_stock_unit,opening_balance,opening_rate)
	VALUES(@stock_item_name,@parent_stock_group,@parent_stock_unit,@opening_balance,@opening_rate)

	SET @id = @@IDENTITY

	SELECT @id
END
GO

CREATE PROCEDURE EditStockItem
	@stock_item_id int,
	@stock_item_name varchar(100),
	@parent_stock_group INT,
	@parent_stock_unit INT,
	@opening_balance numeric(36,8),
	@opening_rate numeric(36,8)
as
begin
	update StockItems set 
		stock_item_name = @stock_item_name ,
		parent_stock_group = @parent_stock_group,
		parent_stock_unit = @parent_stock_unit,
		opening_balance = @opening_balance,
		opening_rate = @opening_rate
	where stock_item_id = @stock_item_id
end
GO

CREATE PROCEDURE EditStockGroup
	@stock_group_id int,
	@stock_group_name varchar(100),
	@parent_stock_group INT,
	@allow_quantity_add BIT
as
begin
	update StockGroups set
		stock_group_name = @stock_group_name ,
		parent_stock_group = @parent_stock_group ,
		allow_quantity_add = @allow_quantity_add 
	where stock_group_id = @stock_group_id
end
GO

CREATE PROCEDURE EditStockUnit
	@stock_unit_id int,
	@stock_unit_name varchar(100),
	@stock_unit_symbol varchar(100),
	@stock_unit_decimal_places int
AS
BEGIN
	update StockUnits set
		stock_unit_name = @stock_unit_name ,
		stock_unit_symbol = @stock_unit_symbol ,
		stock_unit_decimal_places = @stock_unit_decimal_places 
	where stock_unit_id = @stock_unit_id
END
GO

CREATE PROCEDURE GetStockUnits
	@stock_unit_id INT = NULL
as
begin
	select * from StockUnits WITH (NOLOCK)
	where (@stock_unit_id IS NULL OR @stock_unit_id = 0 OR stock_unit_id = @stock_unit_id)
end
GO

CREATE PROCEDURE GetStockGroups
	@stock_group_id INT = NULL,
	@parent_stock_group_id INT = NULL
as
begin
	select * from StockGroups WITH (NOLOCK)
	where 
		(@stock_group_id IS NULL OR @stock_group_id = 0 OR stock_group_id = @stock_group_id) AND
		(@parent_stock_group_id IS NULL OR @parent_stock_group_id = 0 OR parent_stock_group = @parent_stock_group_id)
end
GO

CREATE PROCEDURE GetStockItems
	@stock_item_id INT = NULL,
	@parent_stock_group_id INT = NULL
as
begin
	select * from StockItems WITH (NOLOCK)
	where 
		(@stock_item_id IS NULL OR @stock_item_id = 0 OR stock_item_id = @stock_item_id) AND
		(@parent_stock_group_id IS NULL OR @parent_stock_group_id = 0 OR parent_stock_group = @parent_stock_group_id)
end
GO

CREATE PROCEDURE DeleteLedgerGroup
	@ledger_group_id INT
AS
BEGIN
	DELETE FROM LedgerGroups where ledger_group_id = @ledger_group_id
END
GO

CREATE PROCEDURE GetLedgerGroups
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

CREATE PROCEDURE EditLedgerGroup
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

CREATE PROCEDURE AddLedgerGroup
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

insert into LedgerGroups(ledger_group_name,parent_ledger_group_id,ledger_type,ledger_effect) values
('Assets - Primary',0,1,0),
('Liabilities - Primary',0,1,1),
('Income (In-Direct) - Primary',0,1,2),
('Expences (In-Direct) - Primary',0,1,3),
('Income (Direct) - Primary',0,1,4),
('Expences (Direct) - Primary',0,1,5);
