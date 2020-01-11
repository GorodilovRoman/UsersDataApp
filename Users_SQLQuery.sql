drop table [Users_db].[Users];
GO
DROP SCHEMA [Users_db];
GO
CREATE SCHEMA [Users_db]  
    AUTHORIZATION [dbo];  
GO
create table [Users_db].[Users]
(
	[User_ID] int,
	[First_Name] nvarchar(100)	NOT NULL,
	[Last_Name] nvarchar(100)	NOT NULL,
	[Gender] bit				NOT NULL,
	[Email] varchar(100)
);
GO
create or alter procedure [Users_db].[User_Insert]
(
	@User_ID int output,
	@First_Name nvarchar(100),
	@Last_Name nvarchar(100),
	@Gender bit,
	@Email varchar(100)
)
as
begin
	insert into [Users_db].[Users](First_Name, Last_Name,  Gender,  Email)
	values(@First_Name, @Last_Name, @Gender, @Email);
	set @User_ID = SCOPE_IDENTITY();
end
GO
create or alter procedure [Users_db].[User_Update]
(
	@User_ID int output,
	@First_Name nvarchar(100),
	@Last_Name nvarchar(100),
	@Gender bit,
	@Email varchar(100)
)
as
begin
	update [Users_db].[Users]
	set [First_Name] = @First_Name, [Last_Name] = @Last_Name, [Gender] = @Gender, [Email] = @Email
	where [User_ID] = @User_ID;
end
GO
create or alter procedure Show_User_Info
	@User_ID int=0
as
begin
	select * from [Users_db].[Users] where [Users].[User_ID] = @User_ID
end
GO