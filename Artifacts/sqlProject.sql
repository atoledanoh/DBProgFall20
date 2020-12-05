--------------------------------------
--CREATES SECTION
--------------------------------------

CREATE DATABASE Tournaments;
GO

USE Tournaments;

CREATE TABLE Prizes(
	PRIMARY KEY[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaceNumber] [int] NOT NULL,
	[PlaceName] [varchar](50) NOT NULL,
	[PrizeAmount] [money] NOT NULL,
	[PrizePercentage] [float] NOT NULL,
 CONSTRAINT [PK_Prizes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE People(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[EmailAddress] [varchar](100) NULL,
	[PhoneNumber] [varchar](20) NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

CREATE TABLE TeamMembers(
	Id int IDENTITY NOT NULL,
	TeamId int FOREIGN KEY REFERENCES Teams(Id),
	PersonId int FOREIGN KEY REFERENCES People(Id),
	PRIMARY KEY (Id)
);

--------------------------------------
--TESTING INSERTS SECTION
--------------------------------------

INSERT INTO dbo.Prizes (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
	VALUES
	(1, 'First Place', 100, 0),
	(2, 'Second Place', 50, 0),
	(3, 'Third Place', 25, 0)
	;

INSERT INTO dbo.People(FirstName, LastName, EmailAddress, PhoneNumber)
	VALUES
	('Emily', 'Adkins', 'em@ad.com', '5552233'),
	('Kiki ', 'Hamer', 'ki@ha.com', '5557799'),
	('Lewis', 'Betts', 'le@be.com', '5551144'),
	('Izaac', 'Gordon', 'iz@go.com', '5558866')
	;
GO

--------------------------------------
--STORE PROCEDURES SECTION
--------------------------------------
CREATE PROCEDURE dbo.spPrizes_Insert
	@PlaceNumber INT,
	@PlaceName NVARCHAR(50),
	@PrizeAmount MONEY,
	@PrizePercentage FLOAT,
	@Id INT = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.Prizes (PlaceNumber, PlaceName, PrizeAmount, PrizePercentage)
	VALUES (@PlaceNumber, @PlaceName, @PrizeAmount, @PrizePercentage);
	select @id = SCOPE_IDENTITY();
END
GO

--------------------------------------
CREATE PROCEDURE dbo.spPeople_Insert
	@FirstName NVARCHAR(50),
	@LastName NVARCHAR(50),
	@EmailAddress NVARCHAR(100),
	@PhoneNumber NVARCHAR(20),
	@Id INT = 0 OUTPUT
AS
BEGIN
	SET NOCOUNT ON;
	INSERT INTO dbo.People (FirstName, LastName, EmailAddress, PhoneNumber)
	VALUES (@FirstName, @LastName, @EmailAddress, @PhoneNumber);
	select @id = SCOPE_IDENTITY();
END
GO

--------------------------------------
CREATE PROCEDURE dbo.spPeople_GetAll
AS
BEGIN
	SET NOCOUNT ON;
    SELECT * FROM People;
END
GO

--------------------------------------
CREATE PROCEDURE spTeams_Insert
	@TeamName varchar(100),
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Teams (TeamName)
	values (@TeamName);

	select @Id = SCOPE_IDENTITY();
END
GO

--------------------------------------
CREATE PROCEDURE spTeamMembers_Insert
	@TeamId int,
	@PersonId int,
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.TeamMembers(TeamId, PersonId)
	values (@TeamId, @PersonId);

	select @Id = SCOPE_IDENTITY();
END
GO

--------------------------------------
CREATE PROCEDURE spTeamMembers_GetByTeam
	@TeamId int
AS
BEGIN
	SET NOCOUNT ON;
	select p.*
	from dbo.TeamMembers m
	inner join dbo.People p on m.PersonId = p.Id
	where m.TeamId = @TeamId;
END
GO