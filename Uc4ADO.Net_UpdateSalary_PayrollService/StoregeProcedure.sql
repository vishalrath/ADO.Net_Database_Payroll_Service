-- Insert Record data
Create Procedure spAddEmployeeDetails2
@name varchar(50),
@Basic_Pay  float,
@StartDate Date,
@gender char(1)

AS
BEGIN
insert into Employee_payroll1(Name, Basic_pay ,StartDate,Gender) values (@name,@Basic_Pay,@StartDate,@gender)
END;;
select *from Employee_payroll1;

--Update record
Create Procedure spUpdateEmployeeDetails
@name varchar(50),
@Basic_Pay  float
AS
BEGIN
update Employee_payroll1 Set Basic_pay=@Basic_Pay where Name=@name
END;;


--Delete Record
Create Procedure spDeleteEmployeeDetails1

@id_num int
AS
BEGIN
 DELETE Employee_payroll1 WHERE id_num = @id_num
END;;
