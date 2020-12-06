--------------------------------------
--CREATES SECTION
--------------------------------------

CREATE DATABASE Tournaments;
GO

USE Tournaments;
GO

USE Tournaments;

CREATE TABLE Prizes(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaceNumber] [int] NOT NULL,
	[PlaceName] [varchar](50) NOT NULL,
	[PrizeAmount] [money] NOT NULL,
	[PrizePercentage] [float] NOT NULL,
	PRIMARY KEY (Id)
);

CREATE TABLE People(
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[EmailAddress] [varchar](100) NULL,
	[PhoneNumber] [varchar](20) NULL,
	PRIMARY KEY (Id)
);

CREATE TABLE  Teams(
	Id int IDENTITY NOT NULL,
	TeamName varchar(100) NOT NULL,
	PRIMARY KEY (Id)
);

CREATE TABLE TeamMembers(
	Id int IDENTITY NOT NULL,
	TeamId int FOREIGN KEY REFERENCES Teams(Id),
	PersonId int FOREIGN KEY REFERENCES People(Id),
	PRIMARY KEY (Id)
);

CREATE TABLE Tournaments(
	Id int IDENTITY NOT NULL,
	TournamentName varchar(200) NOT NULL,
	EntryFee float NOT NULL,
	Active bit NOT NULL,
	PRIMARY KEY (Id)
);

CREATE TABLE TournamentPrizes(
	Id int IDENTITY NOT NULL,
	TournamentId int FOREIGN KEY REFERENCES Tournaments(Id),
	PrizeId int FOREIGN KEY REFERENCES Prizes(Id),
	PRIMARY KEY (Id)
);

CREATE TABLE TournamentEntries(
	Id int IDENTITY NOT NULL,
	TournamentId int FOREIGN KEY REFERENCES Tournaments(Id),
	TeamId int FOREIGN KEY REFERENCES Teams(Id),
	PRIMARY KEY (Id)
);

CREATE TABLE Matchups(
	Id int IDENTITY NOT NULL,
	TournamentId int FOREIGN KEY REFERENCES Tournaments(Id),
	WinnerId int FOREIGN KEY REFERENCES Tournaments(Id),
	MatchupRound int NOT NULL,
	PRIMARY KEY (Id)
);

CREATE TABLE MatchupEntries(
	Id int IDENTITY NOT NULL,
	MatchupId int FOREIGN KEY REFERENCES Matchups(Id),
	ParentMatchupId int FOREIGN KEY REFERENCES Matchups(Id),
	TeamCompetingId int FOREIGN KEY REFERENCES Teams(Id),
	Score float,
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

INSERT INTO dbo.People(FirstName, LastName)
	VALUES
	('Emily', 'Adkins'),
	('Kiki ', 'Hamer'),
	('Lewis', 'Betts'),
	('Izaac', 'Gordon'),
	('Artur', 'Grimes'),
	('Amara', 'Nichols'),
	('Alistair', 'Fischer')
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
CREATE PROCEDURE dbo.spTeams_GetAll
AS
BEGIN
	SET NOCOUNT ON;
    SELECT * FROM Teams;
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

--------------------------------------
CREATE PROCEDURE dbo.spTournaments_Insert
	@TournamentName varchar(200),
	@EntryFee float,
	@Id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Tournaments(TournamentName,EntryFee, Active)
	values (@TournamentName, @EntryFee, 1);

	select @Id = SCOPE_IDENTITY();
END
GO

--------------------------------------
CREATE PROCEDURE dbo.spTournamentPrizes_Insert
	@TournamentId int,
	@PrizeId int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.TournamentPrizes(TournamentId,PrizeId)
	values (@TournamentId, @PrizeId);

	select @Id = SCOPE_IDENTITY();
END
GO

--------------------------------------
CREATE PROCEDURE dbo.spTournamentEntries_Insert
	@TournamentId int,
	@TeamId int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.TournamentEntries(TournamentId,TeamId)
	values (@TournamentId, @TeamId);

	select @Id = SCOPE_IDENTITY();
END
GO

--------------------------------------
CREATE PROCEDURE dbo.spMatchups_Insert
	@TournamentId int,
	@MatchupRound int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.Matchups(TournamentId, MatchupRound)
	values (@TournamentId, @MatchupRound);

	select @Id = SCOPE_IDENTITY();
END
GO

--------------------------------------
CREATE PROCEDURE dbo.spMatchupEntries_Insert
	@MatchupId int,
	@ParentMatchupId int,
	@TeamCompetingId int,
	@id int = 0 output
AS
BEGIN
	SET NOCOUNT ON;

	insert into dbo.MatchupEntries(MatchupId, ParentMatchupId, TeamCompetingId)
	values (@MatchupId, @ParentMatchupId, @TeamCompetingId);

	select @Id = SCOPE_IDENTITY();
END
GO
