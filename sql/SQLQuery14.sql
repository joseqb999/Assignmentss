CREATE VIEW emp
AS SELECT employee.FullName
FROM employee,DEPARTMENT
WHERE employee.DepartmentId=DEPARTMENT.ID
AND DepartmentName='Sales';

select * from emp;

CREATE VIEW emp1
AS SELECT employee.FullName
FROM employee,DEPARTMENT
WHERE employee.DepartmentId=DEPARTMENT.ID
AND DepartmentName='Accounts';

select * from emp1;