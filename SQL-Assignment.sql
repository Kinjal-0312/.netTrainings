create table EmployeeeTable1(
[EmpId] [int] not null,
[fullname] [varchar] (30) not null,
[managerid] [int]  not null,
[DateOfJoining] [datetime] not null,
[city] [varchar] (30) not null
)

insert EmployeeeTable1 values(121,'Lakshmi Kumar',321,'01/31/2001','Hyderabad')
insert EmployeeeTable1 values(321,'Damodaran',986,'01/30/2002','Chennai')
insert EmployeeeTable1 values(421,'Priyadarshini',876,'11/27/2002','Banglore')
insert EmployeeeTable1 values(521,'Mahesh',768,'08/09/2004','Mumbai')
insert EmployeeeTable1 values(621,'Mrinalini',456,'09/10/2005','Thiruvanthapuram')
insert EmployeeeTable1 values(721,'Yuvraj',654,'06/08/2006','Bhopal')
insert EmployeeeTable1 values(821,'Shruthi',546,'05/05/2007','Chandigarh')
insert EmployeeeTable1 values(921,'Nandini',256,'09/06/2008','Shimla')
insert EmployeeeTable1 values(221,'Santhya',345,'07/11/2009','Shillong')
insert EmployeeeTable1 values(122,'Priyavarshini',324,'08/12/2010','Amaravathi')

select*from EmployeeeTable1

create table EmployeeSalary(
EmpId int,
Project varchar(5),
Salary int,
Variable int);

insert EmployeeSalary values(121,'P1',15000,500)
insert EmployeeSalary values(321,'P2',10000,1000)
insert EmployeeSalary values(421,'P1',12000,0)
insert EmployeeSalary values(521,'P2',9000,600)
insert EmployeeSalary values(621,'Null',11000,0)
insert EmployeeSalary values(721,'P1',9000,850)
insert EmployeeSalary values(821,'P2',14000,478)
insert EmployeeSalary values(921,'P1',13000,0)
insert EmployeeSalary values(221,'P2',9000,586)
insert EmployeeSalary values(122,'Null',7000,750)

select*from EmployeeSalary

--nth highest salary
select max(Salary) from EmployeeSalary

--different projects available from employeesalary table

-- salary lies betweer 9000 & 15000
select*from EmployeeSalary where Salary between 9000 and 15000

--fetch count of employees working in project P1
select count(EmpId) from EmployeeSalary where Project='P1'

--max,min,avg salary
select max(Salary) from EmployeeSalary
select min(Salary) from EmployeeSalary
select avg(Salary) from EmployeeSalary

--either hyderabad or managerid-321
select*from EmployeeeTable1 where city='Hyderabad' or managerid='321';

--both empid & msanagerid
select EmpId , managerid from EmployeeeTable1

--fetch all who are not working on any project
Select * from EmployeeSalary where Project = 'Null';

--fetch all employee records from EmployeeDetails table who have a salary record in EmployeeSalary table
select * from EmployeeeTable1 E where exists (select * from EmployeeSalary S where E.EmpId = S.EmpId);

--fetch all the Employees who are also managers from the EmployeeDetails table
SELECT E.fullname FROM EmployeeeTable1 E Join EmployeeeTable1 M ON E.EmpId = M.managerid;

