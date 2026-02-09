select @@SERVERNAME
create table emp(eno int,ename varchar(30),desg char(3),salary int)

delete from emp

create procedure empdisplay
as
select * from emp

exec empdisplay

drop database ADO;