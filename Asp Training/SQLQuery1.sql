create table Users
(
UserId int primary key,
Firstname varchar(25),
Lastname varchar(25),
Username varchar(35),
Email varchar(50),
Designation varchar(30),
Department varchar(30)
)

Create procedure AddUser_sp
@UserId int,
@Firstname varchar(25),
@Lastname varchar(25),
@Username varchar(35),
@Email varchar(50),
@Designation varchar(30),
@Department varchar(30)
as begin
Insert into Users(UserId, FirstName, Lastname, Username, Email, Designation, Department) values
(@UserId, @Firstname, @Lastname, @Username, @Email, @Designation, @Department)
end

exec AddUser_sp 1,'Arun','Joseph','Arun Joseph','arunjoseph@gmail.com','Developer','Development'

Create procedure ViewUsers_sp
as begin
select * from Users
end

exec ViewUsers_sp

Create procedure UpdateUser_sp
@UserId int,
@Firstname varchar(25),
@Lastname varchar(25),
@Username varchar(35),
@Email varchar(50),
@Designation varchar(30),
@Department varchar(30)
as begin
Update Users set FirstName = @Firstname, Lastname = @Lastname, Username = @Username, 
Email = @Email, Designation = @Designation, Department = @Department where UserId = @UserId
end

Create procedure DeleteUser_sp
@UserId int
as begin
Delete from Users where UserId = @UserId
end