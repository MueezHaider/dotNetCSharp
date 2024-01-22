CREATE DATABASE ProjectOOP;
use ProjectOOP;


--CREATE TABLE [Payments]
CREATE TABLE ProjectOOP.dbo.Payments(
	paymentId INT NOT NULL PRIMARY KEY,
	cardNumber VARCHAR(50)  CHECK ( cardNumber > 0 ),
	paymentAmount VARCHAR(13) CHECK ( paymentAmount > 0 ),
	paymentStatus INT NOT NULL,
	customerId INT NOT NULL,
	rentalId INT NOT NULL

	CONSTRAINT pay_fk1 FOREIGN KEY(customerId) REFERENCES ProjectOOP.dbo.Customers(customerId),
	CONSTRAINT pay_fk2 FOREIGN KEY(rentalId) REFERENCES ProjectOOP.dbo.Rentals(rentalId)
);


-- Get mew payment id 
CREATE PROCEDURE GetNewPaymentID
AS 
BEGIN

	SELECT MAX(ProjectOOP.dbo.Payments.paymentId)+1 
	AS ID
	FROM ProjectOOP.dbo.Payments;

END;

--Procedure [Insert_Payments]
CREATE PROCEDURE Insert_Payments(
	@Id INT,
	@RentalId INT,
	@CustomerId INT,
	@PaymentStatus INT,
	@CardNumber VARCHAR(50),
	@PaymentAmount VARCHAR(13)
)
AS
BEGIN
	
	INSERT INTO ProjectOOP.dbo.Payments 
	VALUES (
		@Id,
		@CardNumber,
		@PaymentAmount,
		@PaymentStatus,
		@CustomerId,
		@RentalId
	) ;

END;

CREATE PROCEDURE Update_Payments(
	@Id INT,
	@RentalId INT,
	@CustomerId INT,
	@PaymentStatus INT,
	@CardNumber VARCHAR(50),
	@PaymentAmount VARCHAR(13)
)
AS
BEGIN
	
	UPDATE ProjectOOP.dbo.Payments 
	SET ProjectOOP.dbo.Payments.cardNumber = @CardNumber,
	ProjectOOP.dbo.Payments.paymentAmount = @PaymentAmount,
	ProjectOOP.dbo.Payments.paymentStatus = @PaymentStatus
	WHERE ProjectOOP.dbo.Payments.paymentId = @Id;



END;
