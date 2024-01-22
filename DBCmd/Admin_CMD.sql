CREATE DATABASE ProjectOOP;
use ProjectOOP;

--CREATING  TABLE [ADMINS]

CREATE TABLE ProjectOOP.dbo.Admins(
	username VARCHAR(11) NOT NULL PRIMARY KEY,
	passwd VARCHAR(80) NOT NULL,
	name_ VARCHAR(40) NOT NULL,
	email VARCHAR(40) NOT NULL,
	address_ VARCHAR(100) NOT NULL,
	cell VARCHAR(15),
	activeStatus INT DEFAULT 0,
);


--Handling sign up
CREATE PROCEDURE HandleSignUp(
	@Username VARCHAR(11),
	@Passwd VARCHAR(80),
	@Name_ VARCHAR(40),
	@Email VARCHAR(40),
	@Address_ VARCHAR(100),
	@Cell VARCHAR(15)
)
AS
BEGIN
	INSERT INTO ProjectOOP.dbo.Admins
	VALUES(
		@Username, @Passwd,
		@Name_, @Email,
		@Address_, @Cell,
		0
	);
END;


--Handle Login
CREATE PROCEDURE HandleLogin(
	@Username VARCHAR(11),
	@Passwd VARCHAR(80)
)
AS
BEGIN

	SELECT name_, username, cell, address_, email FROM ProjectOOP.dbo.Admins
	WHERE 
	ProjectOOP.dbo.Admins.username = @Username
	AND ProjectOOP.dbo.Admins.Passwd = @Passwd
	AND ProjectOOP.dbo.Admins.activeStatus = 1;
	
END;

--Get un approved admin
CREATE PROCEDURE Get_UnAppAdmin
AS
BEGIN
	
	SELECT ProjectOOP.dbo.Admins.username,
	ProjectOOP.dbo.Admins.name_, 
	ProjectOOP.dbo.Admins.email, 
	ProjectOOP.dbo.Admins.address_, 
	ProjectOOP.dbo.Admins.cell
	FROM ProjectOOP.dbo.Admins
	WHERE  ProjectOOP.dbo.Admins.activeStatus = 0;

END;

--Aprove admin
CREATE PROCEDURE Approve_Admin
(
	@Username  VARCHAR(11)
)
AS 
BEGIN
	UPDATE ProjectOOP.dbo.Admins
	SET activeStatus = 1
	WHERE ProjectOOP.dbo.Admins.username = @Username;
END;


--Check Available Username

CREATE PROCEDURE Check_Username(
	@Username VARCHAR(11)
)
AS
BEGIN
	SELECT COUNT(ProjectOOP.dbo.Admins.username) AS US FROM ProjectOOP.dbo.Admins WHERE ProjectOOP.dbo.Admins.username = @Username ;
END;


--Update Admin Procedure

CREATE PROCEDURE Update_AdminDate(
	@Username VARCHAR(11),
	@Passwd VARCHAR(80),
	@Name_ VARCHAR(40),
	@Email VARCHAR(40),
	@Address_ VARCHAR(100),
	@Cell VARCHAR(15)
)
AS
BEGIN
	UPDATE ProjectOOP.dbo.Admins 
	SET
		ProjectOOP.dbo.Admins.email = @Email,
		ProjectOOP.dbo.Admins.cell = @Cell,
		ProjectOOP.dbo.Admins.address_ = @Address_,
		ProjectOOP.dbo.Admins.passwd = @Passwd,
		ProjectOOP.dbo.Admins.name_ = @Name_
	WHERE ProjectOOP.dbo.Admins.username = @Username;

	EXEC HandleLogin @Username, @Passwd;

END;
