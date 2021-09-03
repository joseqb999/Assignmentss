SET IDENTITY_INSERT DEPARTMENT ON;
insert into DEPARTMENT (ID,DepartmentName,Manager,InsertDate,ModifiedDate) values(100,'Infrastructure','NULL',GETDATE(),GETDATE());

SELECT * FROM DEPARTMENT;