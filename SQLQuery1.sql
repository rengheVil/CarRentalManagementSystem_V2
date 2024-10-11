create database CarRentalManagement; 
go

create table Car(
CarId NVARCHAR(100) Primary Key,
Brand NVARCHAR(50),
Model NVARCHAR(50),
RentalPrice Decimal(10,2)
)

INSERT INTO Car (CarId, Brand, Model, RentalPrice) VALUES('CAR_001', 'Honda', 'Vessel',10.00  );

SELECT * from Car;