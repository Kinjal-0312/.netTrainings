--create a table
create table Employee_Test(
Emp_ID int identity,
Emp_name varchar(55),
Emp_Technology varchar(55),
Emp_Sal decimal(10,2),
Emp_Designation varchar(20))

--to view detailed information of columns of table employee_test
select*from INFORMATION_SCHEMA.COLUMNS
where Table_Name='Employee_Test'

select*from sys.tables
--to see all sql server connections
select connection_id,session_id,client_net_address,auth_scheme
from sys.dm_exec_connections

--now insert data to table employee test
insert into Employee_Test values ('Amit','PHP',12000,'SE')
insert into Employee_Test values ('Mohan','ASP.NET',15000,'TL')
insert into Employee_Test values ('Avin','C#',14000,'SE')
insert into Employee_Test values ('Manoj','JAVA',22000,'SSE')
insert into Employee_Test values ('Riyaz','VB',18000,'TH')

--now create view on single table Employee_Test
create view vw_Employee_Test
as
select Emp_ID,Emp_name ,Emp_Designation
from Employee_Test

--Query view like as table
select*from vw_Employee_Test

--in the simple view we can insert, update,delete data
--we can only insert data in a simple view
--if we have a primary key and all null fields in the view
--insert data to view vw_Employee_Test
insert into vw_Employee_Test(Emp_name,Emp_Designation) values('Shailu','SSE')

--now see the affected view
select*from vw_Employee_Test
select*from Employee_Test

--update data to view vw_employee_test
update vw_Employee_Test set Emp_name ='Pawan' where Emp_ID=6
--now see the affected view
select*from vw_Employee_Test