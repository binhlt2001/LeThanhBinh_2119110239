create database HR
go
use HR
create table Employee_2119110239(IdEmployee nvarchar(50), Name nvarchar(255), DateBirth nvarchar(50), Gender bit, PlaceBirth nvarchar(50), IdDepartment nvarchar(20))
go
create table Department_2119110239(IdDepartment nvarchar(20), Name nvarchar(50))
go
insert into Department_2119110239 values('IT', N'Công nghệ thông tin')
insert into Department_2119110239 values('KT', N'Kế toán')
insert into Department_2119110239 values('KSNB', N'Kiểm soát nội bộ')
go
insert into Employee_2119110239 values('53418', N'Trần Tiến','11/10/2000', 1, N'Hà Nội', 'IT')
insert into Employee_2119110239 values('53416', N'Nguyễn Cường','21/07/1996', 0, N'Đắk Lắk', 'KT')
insert into Employee_2119110239 values('53417', N'Nguyễn Hào','25/12/1996', 1, N'TP.Hồ Chí Minh', 'KSNB')

select * from Employee_2119110239

go
create proc Employee
as
begin
	select * from Employee_2119110239
end

go
create proc Department
as
begin
	select * from Department_2119110239
end

go

create procedure AddEmployee
	@IdEmployee nvarchar(50),
	@Name nvarchar(225),
	@DateBirth nvarchar(50),
	@Gender bit,
	@PlaceBirth nvarchar(50),
	@IdDepartment nvarchar(20)
as
begin
	insert Employee_2119110239(IdEmployee ,Name, DateBirth, Gender, PlaceBirth, IdDepartment) 
	values (@IdEmployee, @Name, @DateBirth, @Gender, @PlaceBirth, @IdDepartment)
end

go
create procedure EditEmployee
	@IdEmployee nvarchar(50),
	@Name nvarchar(225),
	@DateBirth nvarchar(50),
	@Gender bit,
	@PlaceBirth nvarchar(50),
	@IdDepartment nvarchar(20)
as
begin
    update Employee_2119110239
    set
        IdEmployee = @IdEmployee,
        Name = @Name,
        DateBirth = @DateBirth,
		Gender = @Gender,
		PlaceBirth = @PlaceBirth,
		IdDepartment = @IdDepartment
    where IdEmployee = @IdEmployee
end

go
create procedure DeleteEmployee
	@IdEmployee nvarchar(50)
as
begin
	delete Employee_2119110239 where IdEmployee = @IdEmployee
end