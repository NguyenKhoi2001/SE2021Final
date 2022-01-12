use CheckTheGood

--DESKTOP-KDIOCV5SQLEXPRESS--

create table AccountList(
	UserID int identity(1,1),
	Username nvarchar(30) Not null primary key,
	Password nvarchar(30) Not null,
	Fullname nvarchar(100) Not null,
	)

Insert Into AccountList(Username, Password, Fullname) values ('nguyenkhoi', '123','Nguyen Dinh Minh Khoi')
Insert Into AccountList(Username, Password, Fullname) values ('user2', 'k@3','user2')
Insert Into AccountList(Username, Password, Fullname) values ('Accountant1', '1234','Dr. Johnson')
--Select * from AccountList

create table Product(
	Pid nvarchar(5),
	PName nvarchar(50) not null,
	Pprice int not null,
	primary key (Pid)
	)

--adding canned food
Insert into Product values ('C001','canned fish',39000)
Insert into Product values ('C002','large canned fish',59000)
Insert into Product values ('C003','Korean spicy Instant noodle',25000)
--adding fruit food
Insert into Product values ('F001','bunch of banana',49000)
Insert into Product values ('F002','Apples',19000)
Insert into Product values ('F003','Brazilian Mango',79000)
--adding junk food
Insert into Product values ('J001','Lays potato chip x2 size',59000)
Insert into Product values ('J002','black chocolate heart size',79000)
Insert into Product values ('J003','Pringle steak',59000)
--select * from product

create table Import(
	ImportId int identity(1,1) primary key,
	money int not null,
	Username nvarchar(30) not null,
	foreign key (username) references AccountList(Username)
)
--select * from Import


create table ImportList(
	OrderID int,
	ImportID int,
	Pid nvarchar(5),
	Pname nvarchar(50),
	Quantity int,
	Price int,
	total int,
	primary key(OrderID, ImportID)
)

create table OrderProduct(
	Oid int identity(1,1) primary key, 
	money int not null,
	PaymentStatus nvarchar(1) not null,
	ShipmentStatus nvarchar(30) not null,
	Address nvarchar(100) not null,
)
--select * from OrderProduct

create table OrderList(
	OrderID int identity(1,1),
	Oid int,
	Pid nvarchar(5),
	Pname nvarchar(50),
	Quantity int,
	Price int,
	total int,
	primary key(OrderID, Oid)
)
--select * from OrderList

--drop table ImportList
--drop table Import
--drop table OrderProduct
--drop table OrderList
--drop table Product
--drop table AccountList

insert into OrderList(Oid,Pid,Pname,Quantity,Price,total) values (1,'C002','large canned fish',5,59000,295000)
insert into OrderList(Oid,Pid,Pname,Quantity,Price,total) values (1,'J002','black chocolate heart size',8,79000,632000)
insert Into OrderProduct(money,PaymentStatus,ShipmentStatus,Address) values (927000,'N','Undelivered','TPHCM')

insert into OrderList(Oid,Pid,Pname,Quantity,Price,total) values (2,'J002','black chocolate heart size',8,79000,632000)
insert into OrderList(Oid,Pid,Pname,Quantity,Price,total) values (2,'F003','Brazilian Mango',3,79000,237000)
insert Into OrderProduct(money,PaymentStatus,ShipmentStatus,Address) values (869000,'N','Undelivered','TPHCM')


--procedure to add new user account to database
--when user register through register form
create procedure UserAdd
	@Username nvarchar(30),
	@Password nvarchar(30),
	@Fullname nvarchar(100)
as
	Insert into AccountList(Username,Password,Fullname) 
	Values (@Username,@Password,@Fullname)
--drop procedure UserAdd

--procedure to get fullname from username
create procedure getUserName
	@Username nvarchar(30),
	@Fullname nvarchar(30) output
as
begin 
	select @Fullname = Fullname from AccountList where Username = @Username
end
--drop procedure getUserName

--procedure to get price of item with ID
create procedure getPrice
	@Pid nvarchar(5)
as
begin
	declare @Pprice as int
	select @Pprice = Pprice from Product where Pid = @Pid
return @Pprice
end


--procedure to get Name of item with ID
create procedure getName
	@Pid nvarchar(5),
	@Pname nvarchar(50) output
as
begin
	
	select @Pname = PName from Product where Pid = @Pid
end
--select Pname from Product where Pid = 'C002'
--drop procedure getName

create procedure ImportAdd
	@money int,
	@username nvarchar(30)

as
begin
	Insert into Import(money,username) output inserted.ImportId
	values(@money,@username);
end


create procedure ImportListAdd
	@OrderID int,
	@ImportID int,
	@Pid nvarchar(5),
	@Pname nvarchar(50),
	@Quantity int,
	@Price int,
	@total int
as 
	Insert Into ImportList(OrderID,ImportID,Pid,Pname,Quantity,Price,total)
	values (@OrderID,@ImportID,@Pid,@Pname,@Quantity,@Price,@total)
--drop procedure ImportListAdd