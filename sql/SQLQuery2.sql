CREATE TABLE DEPARTMENT
(
	ID int primary key identity(1,1), DepartmentName varchar(20) UNIQUE,Manager varchar(20) NOT NULL,InsertDate DATE,ModifiedDate DATE);