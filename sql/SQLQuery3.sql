create table employee
(
ID INT PRIMARY KEY IDENTITY(10,5),
FIRSTNAME VARCHAR(20) NOT NULL,
LASTNAME VARCHAR(20) NOT NULL,
DepartmentId INT FOREIGN KEY REFERENCES DEPARTMENT(ID),
DESIGNATION VARCHAR(50),
Gender varchar(9) check(Gender in('M','F')),
ContactNumber int UNIQUE,
ACTIVE NVARCHAR, 
InsertDate DATE,
ModifiedDate DATE
);
