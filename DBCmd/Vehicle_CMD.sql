CREATE DATABASE ProjectOOP;
use ProjectOOP;


--CREATE TABLE [Cars]
CREATE TABLE ProjectOOP.dbo.Cars(
	numberPlate VARCHAR(20) NOT NULL PRIMARY KEY,
	vehicleBrand VARCHAR(50),
	vehicleModel VARCHAR(50),
	vehiclePrice VARCHAR(13) CHECK ( vehiclePrice > 0 ),
	numbOfPassenger INT NOT NULL
);

--CREATE TABLE [Truck]
CREATE TABLE ProjectOOP.dbo.Trucks(
	numberPlate VARCHAR(20) NOT NULL PRIMARY KEY,
	vehicleBrand VARCHAR(50),
	vehicleModel VARCHAR(50),
	vehiclePrice VARCHAR(13) CHECK ( vehiclePrice > 0 ),
	loadCapacity INT NOT NULL CHECK ( loadCapacity > 0 )
);


--View to get available car or truck
CREATE VIEW availableCarsView AS
SELECT * FROM ProjectOOP.dbo.Cars WHERE ProjectOOP.dbo.Cars.numberPlate NOT IN (
	SELECT ProjectOOP.dbo.VehRentCustPay.numberPlate FROM ProjectOOP.dbo.VehRentCustPay WHERE 
);

CREATE VIEW availableTruckView AS
SELECT * FROM ProjectOOP.dbo.Trucks WHERE ProjectOOP.dbo.Trucks.numberPlate NOT IN (
	SELECT ProjectOOP.dbo.VehRentCustPay.numberPlate FROM ProjectOOP.dbo.VehRentCustPay
);

--Get specific columns for combo box
CREATE PROCEDURE Get_BrandModelCar
AS
BEGIN

	SELECT ProjectOOP.dbo.Cars.numberPlate, vehicleBrand, vehicleModel FROM ProjectOOP.dbo.Cars 
	INNER JOIN ProjectOOP.dbo.VehRentCustPay
	ON ProjectOOP.dbo.Cars.numberPlate = ProjectOOP.dbo.VehRentCustPay.numberPlate
	INNER JOIN ProjectOOP.dbo.Rentals
	ON ProjectOOP.dbo.VehRentCustPay.rentalId = ProjectOOP.dbo.Rentals.rentalId

	WHERE ProjectOOP.dbo.Rentals.returnDate < GETDATE();
	

END;



CREATE PROCEDURE Get_BrandModelTruck
AS
BEGIN

	SELECT ProjectOOP.dbo.Trucks.numberPlate, vehicleBrand, vehicleModel FROM ProjectOOP.dbo.Trucks
	INNER JOIN ProjectOOP.dbo.VehRentCustPay
	ON ProjectOOP.dbo.Trucks.numberPlate = ProjectOOP.dbo.VehRentCustPay.numberPlate
	INNER JOIN ProjectOOP.dbo.Rentals
	ON ProjectOOP.dbo.VehRentCustPay.rentalId = ProjectOOP.dbo.Rentals.rentalId

	WHERE ProjectOOP.dbo.Rentals.returnDate < GETDATE();
	

END;



CREATE PROCEDURE Update_Car(
	@Brand VARCHAR(50),
	@Model VARCHAR(50),
	@Price VARCHAR(13),
	@NumbPlate VARCHAR(20),
	@NumbOfPassenger INT
)
AS
BEGIN
	
	UPDATE ProjectOOP.dbo.Cars
	SET numberPlate = @NumbPlate,
	vehicleBrand = @Brand,
	vehicleModel = @Model,
	vehiclePrice = @Price,
	numbOfPassenger = @NumbOfPassenger
	WHERE numberPlate = @NumbPlate;

END;



CREATE PROCEDURE Update_Truck(
	@Brand VARCHAR(50),
	@Model VARCHAR(50),
	@Price VARCHAR(13),
	@NumbPlate VARCHAR(20),
	@LoadCapacity INT
)
AS
BEGIN
	
	UPDATE ProjectOOP.dbo.Trucks
	SET numberPlate = @NumbPlate,
	vehicleBrand = @Brand,
	vehicleModel = @Model,
	vehiclePrice = @Price,
	loadCapacity = @LoadCapacity
	WHERE numberPlate = @NumbPlate;

END;
