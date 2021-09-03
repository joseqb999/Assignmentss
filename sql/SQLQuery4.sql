
  insert into [dbo].[DEPARTMENT] values('HR','A',GETDATE(),GETDATE());
  insert into [dbo].[DEPARTMENT] values('Finance','B',GETDATE(),GETDATE());
  insert into [dbo].[DEPARTMENT] values('Marketing','C',GETDATE(),GETDATE());
  insert into [dbo].[DEPARTMENT] values('Administration','D',GETDATE(),GETDATE());
  insert into [dbo].[DEPARTMENT] values('Accounts','E',GETDATE(),GETDATE());
  insert into [dbo].[DEPARTMENT] values('Management','F',GETDATE(),GETDATE());
  insert into [dbo].[DEPARTMENT] values('Sales','G',GETDATE(),GETDATE());
  insert into [dbo].[DEPARTMENT] values('Admin','H',GETDATE(),GETDATE());
  insert into [dbo].[DEPARTMENT] values('IT','I',GETDATE(),GETDATE());
  insert into [dbo].[DEPARTMENT] values('Support','J',GETDATE(),GETDATE());

  SELECT * FROM DEPARTMENT;

  INSERT INTO [dbo].[employee]
           ([FIRSTNAME]
           ,[LASTNAME]
           ,[DepartmentId]
           ,[DESIGNATION]
           ,[Gender]
           ,[ContactNumber]
           ,[ACTIVE]
           ,[InsertDate]
           ,[ModifiedDate])
     VALUES
           ('Jose','George',3,'Kottayam','M',482,1,GETDATE(),GETDATE())
insert into [dbo].[employee] values('virat','kohli',8,'mumbai','M',484,0,GETDATE(),GETDATE());
insert into [dbo].[employee] values('ben','stokes',5,'Kotta','M',485,1,GETDATE(),GETDATE());
insert into [dbo].[employee] values('gautham','gambir',6,'Kolkata','M',486,1,GETDATE(),GETDATE());
insert into [dbo].[employee] values('Cersei','stokes',5,'chennai','F',487,1,GETDATE(),GETDATE());
insert into [dbo].[employee] values('rohit','sharma',3,'cochin','M',488,1,GETDATE(),GETDATE());
insert into [dbo].[employee] values('ms','dhoni',4,'pala','M',489,0,GETDATE(),GETDATE());
insert into [dbo].[employee] values('sanju','samson',2,'delhi','M',490,1,GETDATE(),GETDATE());
insert into [dbo].[employee] values('ravindra','jadeja',4,'thrissur','M',491,1,GETDATE(),GETDATE());
insert into [dbo].[employee] values('sam','curran',9,'kannur','M',492,1,GETDATE(),GETDATE());

select * from employee;
