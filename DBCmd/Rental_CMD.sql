CREATE DATABASE ProjectOOP;
use ProjectOOP;


--CREATING TABLE [Rental]
CREATE TABLE ProjectOOP.dbo.Rentals(
	rentalId INT NOT NULL PRIMARY KEY,
	rentalDate Date NOT NULL,
	returnDate Date NOT NULL
);

--creating junction table 
CREATE TABLE ProjectOOP.dbo.VehRentCustPay(
	customerId INT NOT NULL,
	rentalId INT NOT NULL,
	paymentId INT NOT NULL,
	rentStatus INT NOT NULL,
	numberPlate VARCHAR(20)



	CONSTRAINT vrcp_fk1 FOREIGN KEY(customerId) REFERENCES ProjectOOP.dbo.Customers(customerId),
	CONSTRAINT vrcp_fk2 FOREIGN KEY(rentalId) REFERENCES ProjectOOP.dbo.Rentals(rentalId),
	CONSTRAINT vrcp_fk3 FOREIGN KEY(paymentId) REFERENCES ProjectOOP.dbo.Payments(paymentId)
);


--Get next rental id
CREATE PROCEDURE GetNewRentalID
AS 
BEGIN

	SELECT MAX(ProjectOOP.dbo.Rentals.rentalId)+1 
	AS ID
	FROM ProjectOOP.dbo.Rentals;

END;

CREATE PROCEDURE Get_FullRentalData
AS
BEGIN
	
	SELECT ProjectOOP.dbo.VehRentCustPay.customerId,  ProjectOOP.dbo.VehRentCustPay.rentalId,
	ProjectOOP.dbo.VehRentCustPay.paymentId,
	ProjectOOP.dbo.Customers.customerName, ProjectOOP.dbo.Rentals.rentalDate, 
	ProjectOOP.dbo.Rentals.returnDate,
	ProjectOOP.dbo.VehRentCustPay.numberPlate,
	ProjectOOP.dbo.Payments.paymentAmount, ProjectOOP.dbo.Payments.paymentStatus
	FROM ProjectOOP.dbo.VehRentCustPay 
	INNER JOIN ProjectOOP.dbo.Customers 
	ON ProjectOOP.dbo.VehRentCustPay.customerId = ProjectOOP.dbo.Customers.customerId 
	INNER JOIN ProjectOOP.dbo.Rentals 
	ON ProjectOOP.dbo.VehRentCustPay.rentalId = ProjectOOP.dbo.Rentals.rentalId
	INNER JOIN ProjectOOP.dbo.Payments
	ON ProjectOOP.dbo.VehRentCustPay.paymentId = ProjectOOP.dbo.Payments.paymentId;

END;

--UPDATE full data into junction table

CREATE PROCEDURE Update_FullRentalsData(
	@RentalId INT, 
	@RentalDate Date,
	@ReturnDate Date,
	@CustomerID INT,
	@CustomerName VARCHAR(70),
	@VehicleNumbPlate VARCHAR(20),
	@PaymentId INT,
	@PaymentStatus INT,
	@CardNumber VARCHAR(50),
	@PaymentAmount VARCHAR(13),
	@RentStatus INT
)
AS
BEGIN
	
	UPDATE ProjectOOP.dbo.Rentals 
	SET ProjectOOP.dbo.Rentals.rentalDate = @RentalDate,
	ProjectOOP.dbo.Rentals.returnDate = @ReturnDate
	WHERE ProjectOOP.dbo.Rentals.rentalId = @RentalId;


	EXEC Update_Payments @PaymentId, @RentalId, @CustomerID, @PaymentStatus, @CardNumber, @PaymentAmount;


END;


--Insert full data into junction table

CREATE PROCEDURE Insert_FullRentalsData(
	@RentalId INT, 
	@RentalDate Date,
	@ReturnDate Date,
	@CustomerID INT,
	@CustomerName VARCHAR(70),
	@VehicleNumbPlate VARCHAR(20),
	@PaymentId INT,
	@PaymentStatus INT,
	@CardNumber VARCHAR(50),
	@PaymentAmount VARCHAR(13),
	@RentStatus INT
)
AS
BEGIN
	
	INSERT INTO ProjectOOP.dbo.Rentals 
	VALUES (
		@RentalId,
		@RentalDate,
		@ReturnDate
	) ;

	EXEC Insert_Payments @PaymentId, @RentalId, @CustomerID, @PaymentStatus, @CardNumber, @PaymentAmount;

	INSERT INTO ProjectOOP.dbo.VehRentCustPay 
	VALUES (
		@CustomerID,
		@RentalId,
		@PaymentId,
		@RentStatus,
		@VehicleNumbPlate
	);

END;


--Procedure [Insert_Rentals]
CREATE PROCEDURE Insert_Rentals(
	@Id INT, 
	@RentalDate Date,
	@ReturnDate Date
)
AS
BEGIN
	
	INSERT INTO ProjectOOP.dbo.Rentals 
	VALUES (
		@Id,
		@RentalDate,
		@RentalDate
	) ;

END;

--displaying [Rentals]
CREATE PROCEDURE Get_Rentals
AS
BEGIN
	
	SELECT * FROM ProjectOOP.dbo.Rentals;

END;

