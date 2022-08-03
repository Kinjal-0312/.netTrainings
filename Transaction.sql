CREATE TABLE Department
(
 DeptID int PRIMARY KEY, 
 DeptName varchar(50) NULL,
 Location varchar(100) NULL,
 )
GO
 CREATE TABLE Employees
(
 EmpID int PRIMARY KEY, 
 Name varchar(50) NULL,
 Salary int NULL, 
 Address varchar(100) NULL,
 DeptID int foreign Key references Department(DeptID)
) 
--Now Insert data
INSERT INTO Department(DeptID,DeptName,Location)VALUES(1,'IT','Delhi')
GO
INSERT INTO Employees(EmpID,Name,Salary,Address,DeptID)VALUES(1,'Mohan',15000,'Delhi',3)

begin transaction trans
begin try
insert into department(DeptID,DeptName,location)values(2,'AS','AP')
insert into Employees(EmpID,Name,Salary,Address,DeptID) values(2,'Mohan',16000,'AP',2)

if @@TRANCOUNT>0
begin commit transaction trans
end
end try
begin catch
print 'Error Occured'
if @@TRANCOUNT>0
begin rollback transaction trans
end
end catch

--now select data to see transaction affects
select*from Employees
select*from department

--transaction with save point begin transactions trans
begin try
insert into department(DeptID,DeptName,Location)values(2,'HR','Delhi')
if @@TRANCOUNT>0
begin save transaction trans;
end
insert into department(DeptID,DeptName,location)values(3,'Admin','Delhi')
insert into Employees(EmpID,Name,Salary,Address,DeptID) values(1,'Mohan',16000,'AP',1)
if @@TRANCOUNT>0
begin commit transaction trans
end
end try
begin catch
print 'Error Occured'
if @@TRANCOUNT>0
begin rollback transaction trans
end
end catch