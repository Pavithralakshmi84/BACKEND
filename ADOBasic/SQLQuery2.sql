select @@SERVERNAME
create Database ADO
use ADO


create table Emp1(eno int constraint pk_emp primary key,ename varchar(30),desg char(3),salary int)

create procedure InsEmp(@eno int ,@ename varchar(30),@desg char(3),@salary int)
as
insert into emp values(@eno,@ename,@desg,@salary)

execute InsEmp 100,'John','Eng',22000
exec InsEmp 101,'Jency','Hr',25000
exec InsEmp 102,'George','Prg',20000
exec InsEmp 103,'SAM','GM',82000
exec InsEmp 104,'Paul','VP',100000
exec InsEmp 105,'Stefy','HR',26000

create procedure UpdEmp(@eno int ,@ename varchar(30),@desg char(3),@salary int)
as
update emp set ename =@ename,desg=@desg,salary =@salary where eno=@eno

create procedure delemp(@eno int)
as
delete from emp where eno=@eno

create procedure p1
as
select * from emp

exec p1

create procedure p2
as
select count(*) from emp

exec p2



create procedure p33 (@eno int)
as
select * from emp where eno=@eno

exec p33 500

select * from sys.procedures

