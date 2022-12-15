CREATE DATABASE ShopDB;
GO

USE ShopDB;

CREATE TABLE Shops (
	ShopId INT IDENTITY (1, 1) PRIMARY KEY,
	Phone VARCHAR (25),
	Email VARCHAR (255),
	Street VARCHAR (255),
	City VARCHAR (255),
	ZipCode VARCHAR (5)
);
CREATE TABLE Staffs (
	StaffId INT IDENTITY (1, 1) PRIMARY KEY,
	FirstName VARCHAR (50) NOT NULL,
	LastName VARCHAR (50) NOT NULL,
	Email VARCHAR (255) NOT NULL UNIQUE,
	Phone VARCHAR (25),
	Active BIT NOT NULL,
	ShopId INT NOT NULL,
	FOREIGN KEY (ShopId) 
        REFERENCES Shops (ShopId) 

);
CREATE TABLE Customers (
	CustomerId INT IDENTITY (1, 1) PRIMARY KEY,
	FirstName VARCHAR (255) NOT NULL,
	LastName VARCHAR (255) NOT NULL,
	Phone VARCHAR (25),
	Email VARCHAR (255) NOT NULL,
	Street VARCHAR (255),
	City VARCHAR (50),
	ZipCode VARCHAR (5)
);
CREATE TABLE Orders (
	OrderId INT IDENTITY (1, 1) PRIMARY KEY,
	CustomerId INT,
	OrderStatus tinyint NOT NULL,
	-- Order status: 1 = Processing; 2 = Rejected; 3 = Completed
	OrderDate DATE NOT NULL,
	ShopId INT NOT NULL,
	StaffId INT NOT NULL,
	FOREIGN KEY (CustomerId) 
        REFERENCES Customers (CustomerId) 
        ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (ShopId) 
        REFERENCES Shops (ShopId) 
        ON DELETE CASCADE ON UPDATE CASCADE,
	FOREIGN KEY (StaffId) 
        REFERENCES Staffs (StaffId) 
        ON DELETE NO ACTION ON UPDATE NO ACTION
);



CREATE TABLE Items(
	Name VARCHAR (255),
	OrderId INT,
	ItemId INT,
	Quantity INT NOT NULL,
	PRIMARY KEY (OrderId, ItemId),
	FOREIGN KEY (OrderId) 
        REFERENCES Orders (OrderId) 
        ON DELETE CASCADE ON UPDATE CASCADE
);



INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Wade','Williams','3453465476','Wade_Williams@mail.com','742 Main Street','San Antonio',11690);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Dave','Harris','5653465437','Dave_Harris@mail.com','72 Main St','Aguas Buenas',71103);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Seth','Thomas','7853465398','Seth_Thomas@mail.com','200 Otis Street','Aibonito',11705);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Ivan','Robinson','1053465359','Ivan_Robinson@mail.com','180 North King Street','La Plata',11786);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Riley','Walker','1223465320','Riley_Walker@mail.com','555 East Main St','Anasco',11610);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Gilbert','Scott','1445365281','Gilbert_Scott@mail.com','555 Hubbard Ave-Suite 12','Angeles',11611);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Jorge','Nelson','1663465242','Jorge_Nelson@mail.com','300 Colony Place','Arecibo',11612);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Dan','Mitchell','1883465203','Dan_Mitchell@mail.com','301 Falls Blvd','Ciales',11638);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Brian','Morgan','2105365164','Brian_Morgan@mail.com','36 Paramount Drive','Cidra',11739);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Roberto','Cooper','2253465125','Roberto_Cooper@mail.com','450 Highland Ave','Coamo',11769);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Ramon','Howard','2545365086','Ramon_Howard@mail.com','1180 Fall River Avenue','Comerio',11782);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Miles','Davis','2765365047','Miles_Davis@mail.com','1105 Boston Road','Corozal',11783);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Liam','Miller','2953465008','Liam_Miller@mail.com','100 Charlton Road','Culebra',11775);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Nathaniel','Martin','3205346969','Nathaniel_Martin@mail.com','262 Swansea Mall Dr','Dorado',11646);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Ethan','Smith','3253464930','Ethan_Smith@mail.com','333 Main Street','Fajardo',11738);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Lewis','Anderson','3645346481','Lewis_Anderson@mail.com','550 Providence Hwy','Puerto Real',11740);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Milton','White','3863464852','Milton_White@mail.com','352 Palmer Road','Florida',11650);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Claude','Perry','4085344813','Claude_Perry@mail.com','3005 Cranberry Hwy Rt 6 28','Gurabo',11778);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Joshua','Clark','4305346474','Joshua_Clark@mail.com','250 Rt 59','Hatillo',11659);
INSERT INTO Customers(FirstName, LastName, Phone, Email, Street, City, ZipCode) VALUES('Glen','Richards','4525464735','Glen_Richards@mail.com','141 Washington Ave Extension','Hormigueros',11660);

INSERT INTO Shops(Phone, Email, Street, City, ZipCode)
VALUES('4764321','FrankBlvdShop@mail.com','601 Frank Stottile Blvd', 'San Antonio',75643),
      ('(516) 379-8888','LaPlataShop@mail.com','4975 Transit Rd', 'La Plata',86535),
      ('(972) 530-5555','StateRtShop@mail.com','7155 State Rt 12 S', 'San Antonio',97630);

INSERT INTO Staffs(FirstName, LastName, Email, Phone, Active, ShopId) VALUES('Fabiola','Jackson','fabiola.jackson@mail.com','555-5554',1,1);
INSERT INTO Staffs(FirstName, LastName, Email, Phone, Active, ShopId) VALUES('Mireya','Copeland','mireya.copeland@mail.com','555-5555',1,1);
INSERT INTO Staffs(FirstName, LastName, Email, Phone, Active, ShopId) VALUES('Genna','Serrano','genna.serrano@mail.com','555-5556',1,1);
INSERT INTO Staffs(FirstName, LastName, Email, Phone, Active, ShopId) VALUES('Virgie','Wiggins','virgie.wiggins@mail.com','555-5557',0,1);
INSERT INTO Staffs(FirstName, LastName, Email, Phone, Active, ShopId) VALUES('Jannette','David','jannette.david@mail.com','379-4444',1,2);
INSERT INTO Staffs(FirstName, LastName, Email, Phone, Active, ShopId) VALUES('Marcelene','Boyer','marcelene.boyer@mail.com','379-4445',1,2);
INSERT INTO Staffs(FirstName, LastName, Email, Phone, Active, ShopId) VALUES('Venita','Daniel','venita.daniel@mail.com','379-4446',1,2);
INSERT INTO Staffs(FirstName, LastName, Email, Phone, Active, ShopId) VALUES('Kali','Vargas','kali.vargas@mail.com','530-5555',1,3);
INSERT INTO Staffs(FirstName, LastName, Email, Phone, Active, ShopId) VALUES('Layla','Terrell','layla.terrell@mail.com','530-5556',1,3);
INSERT INTO Staffs(FirstName, LastName, Email, Phone, Active, ShopId) VALUES('Bernardine','Houston','bernardine.houston@mail.com','530-5557',0,3);

INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(6,2,'20160519',3,5);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(12,3,'20190729',1,8);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(6,2,'20160512',3,9);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(9,2,'20190519',3,9);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(12,2,'20200909',2,1);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(15,2,'20150413',2,10);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(1,2,'20180105',3,10);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(2,2,'20161009',2,10);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(3,2,'20160519',1,2);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(5,2,'20180310',1,2);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(4,2,'20190709',1,2);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(7,2,'20190925',1,2);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(8,2,'20160919',3,3);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(9,2,'20170820',3,3);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(10,2,'20170630',3,3);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(11,2,'20181220',2,3);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(12,2,'20191106',2,10);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(13,2,'20160519',3,4);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(12,3,'20190729',1,4);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(13,2,'20160512',3,5);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(14,2,'20190519',1,5);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(15,2,'20200909',1,5);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(16,2,'20150413',3,10);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(17,2,'20180105',2,5);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(18,2,'20161009',2,6);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(19,2,'20160519',2,6);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(12,2,'20180310',3,6);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(15,2,'20190709',2,6);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(14,2,'20190925',3,6);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(18,2,'20160919',2,6);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(11,2,'20170820',3,6);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(19,2,'20170630',2,6);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(18,2,'20181220',3,6);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(15,2,'20191106',1,7);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(15,2,'20160519',3,7);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(1,3,'20190729',1,8);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(2,2,'20160512',1,7);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(3,2,'20190519',1,7);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(4,2,'20200909',3,8);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(5,2,'20150413',1,8);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(6,2,'20180105',1,8);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(7,2,'20161009',2,8);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(8,2,'20160519',2,9);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(9,2,'20180310',2,9);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(10,2,'20190709',2,9);
INSERT INTO Orders(CustomerId, OrderStatus, OrderDate, ShopId, StaffId) VALUES(11,2,'20190925',2,9);


INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(1,1,1,'Orbit Sander');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(2,2,2,'Cordless Drill');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(3,3,2,'Air Compressor');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(4,4,3,'Circular');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(5,5,4,'Cordless Vacuum');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(6,6,5,'Brushless Planer');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(7,7,2,'Brushless Cut Off Tool');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(8,8,2,'Jig Saw');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(9,9,3,'Glue Gun');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(10,10,3,'Angle Grinder');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(11,11,4,'Nailer Kit');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(12,12,5,'Staple Gun');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(13,13,6,'Inflator for Tires');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(14,14,1,'Oscillating Too');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(15,15,2,'Waxer/Polisher');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(16,1,2,'Orbit Sander');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(17,2,3,'Cordless Drill');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(18,3,3,'Air Compressor');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(19,4,3,'Circular');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(20,5,3,'Cordless Vacuum');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(21,6,2,'Brushless Planer');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(22,7,2,'Brushless Cut Off Tool');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(23,8,2,'Jig Saw');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(24,9,2,'Glue Gun');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(25,10,2,'Angle Grinder');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(26,11,1,'Nailer Kit');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(27,12,1,'Staple Gun');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(28,13,1,'Inflator for Tires');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(29,14,1,'Oscillating Too');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(30,15,1,'Waxer/Polisher');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(31,1,1,'Orbit Sander');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(32,2,4,'Cordless Drill');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(33,3,4,'Air Compressor');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(34,4,4,'Circular');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(35,5,4,'Cordless Vacuum');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(36,6,4,'Brushless Planer');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(37,7,2,'Brushless Cut Off Tool');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(38,8,2,'Jig Saw');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(26,9,2,'Glue Gun');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(27,10,2,'Angle Grinder');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(28,11,1,'Nailer Kit');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(29,12,1,'Staple Gun');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(31,13,1,'Inflator for Tires');
INSERT INTO Items(OrderId, ItemId, Quantity, Name)VALUES(32,14,1,'Oscillating Too');
