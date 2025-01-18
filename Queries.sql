-- tables-ka isku qabo procedures-kana kala reeb oo hal-hal u run grey, meel kastoo commernt eh ku istaag




create table Customer(
custId int primary key,
custName varchar(50),
address varchar(50),
phone varchar(50),
addedDate date default getdate()
)

create table Account(
accountNo int primary key identity(1,1),
accountType varchar(50),
balance decimal(18,2) default 0,
custId int foreign key references Customer(custId)
)

create table Transactions(
tranId int primary key identity(1,1),
tranType varchar(50),
description varchar(max),
amount decimal(18,2),
status int,
tranDate date default getdate(),
accountNo int foreign key references Account(accountNo)
)

create table users(
userId int primary key identity(1,2),
fullName varchar(50),
username varchar(50),
password varchar(50),
userType varchar(50)
);

insert into users(fullNamem, username, password, userType) values('your full name', 'admin','1234', 'admin');




-- procedure-ka 1aad CustomerAccount

create procedure CustomerAccount

@custName varchar(50),
@address varchar(50),
@phone varchar(50),
@accountType varchar(50)

AS

BEGIN
	Begin try
		begin transaction

		declare @lastId int
		set @lastId = (select max(custId) from Customer)
		if @lastId is null
			Begin
				set @lastId = 1010
				insert into Customer(custID, custName, Address, phone) values(@lastId, @custName, @address, @phone);
				insert into Account(accountType, custId) values(@accountType, @lastId);
			End
		else
			Begin
				set @lastId += 1
				insert into Customer(custID, custName, Address, phone) values(@lastId, @custName, @address, @phone);
				insert into Account(accountType, custId) values(@accountType, @lastId);
			End
		commit transaction
	End try
		Begin catch
			rollback transaction
		End catch
END

--procedure-ka 2aad GetCustomerAccount

CREATE procedure GetCustomerAccount
as 
begin
select
	C.custName as "Full name",
	C.address as "Address",
	C.phone as "Phone number",
	A.accountType as "Account type",
	A.balance as "Balance"
from 
	Customer C 
	inner join 
	Account A 
on 
	C.custId = A.custId

end

--procedure-ka 3aad MakeWithdraw

create procedure MakeWithdraw
@tranType varchar(50),
@description varchar(max),
@amount decimal(18,2),
@accountNo int
AS
	Begin
		begin try
			begin transaction

			insert into Transactions(tranType, description, amount, status, accountNo) values('Withdraw', @description, @amount, 2, @accountNo)
			update Account set balance -= @amount where accountNo = @accountNo
			commit transaction

		end try
		begin catch
			rollback transaction

		end catch

End

--procedure-ka 4aad MakeDeposit

create procedure MakeDeposit
@tranType varchar(50),
@description varchar(max),
@amount decimal(18,2),
@accountNo int
AS
	Begin
		begin try
			begin transaction

			insert into Transactions(tranType, description, amount, status, accountNo) values('Deposit', @description, @amount, 1, @accountNo)
			update Account set balance += @amount where accountNo = @accountNo
			commit transaction

		end try
		begin catch
			rollback transaction

		end catch

End

--procedure-ka 5aad cancelDepositTransaction

create procedure cancelDepositTransaction
@tranId int,
@amount decimal(18,2),
@accountNo int
AS

begin try
update Transactions set status=0 where tranId=@tranId
update Account set balance -= @amount where accountNo=@accountNo
end try

begin catch
rollback transaction
end catch

--procedure-ka 6aad cancelWithdrawTransaction

create procedure cancelWithdrawTransaction
@tranId int,
@amount decimal(18,2),
@accountNo int
AS

begin try
update Transactions set status=0 where tranId=@tranId
update Account set balance += @amount where accountNo=@accountNo
end try

begin catch
rollback transaction
end catch

--procedure-ka 7aad MakeTransfer

create procedure MakeTransfer
@tranType varchar(50),
@description varchar(max),
@amount decimal(18,2),
@accountNo1 int,
@accountNo2 int

AS
	Begin
		begin try
			begin transaction

			insert into Transactions(tranType, description, amount, status, accountNo) values('Withdraw', @description, @amount, 2, @accountNo1)
			update Account set balance -= @amount where accountNo = @accountNo1
			
			insert into Transactions(tranType, description, amount, status, accountNo) values('Deposit', @description, @amount, 1, @accountNo2)
			update Account set balance += @amount where accountNo = @accountNo2
			commit transaction

		end try
		begin catch
			rollback transaction

		end catch

End


/* hadda rabtid inaa xogta database-ka ku jirto inaa tirtid run garya cod-kaan 6-da sadar ha kla reebin */

delete Transactions
delete Account
delete Customer


DBCC CHECKIDENT ('Customer', RESEED, 0);
DBCC CHECKIDENT ('Account', RESEED, 0);
DBCC CHECKIDENT ('Transactions', RESEED, 0);


-- hadii code-kan cilad kaa qabsato wa i taqana 😉