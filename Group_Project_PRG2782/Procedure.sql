USE BCStudentsDB
ALTER TABLE Students
ALTER COLUMN Address VARCHAR(100)
GO


CREATE PROCEDURE spInsertStudents
@ID INT,
@FirstName NVARCHAR(50),
@LastName VARCHAR(50),
@Image IMAGE,
@DOB DATE,
@Gender VARCHAR(10),
@Phone INT,
@Address VARCHAR(100),
@MODULES NVARCHAR(MAX)
AS 
INSERT INTO Students (StudentID, FirstName, LastName, StudentImage,DOB,Gender,Phone ,Address, ModuleCodes) 
VALUES(@ID,@FirstName,@LastName,@Image,@DOB,@Gender,@Phone,@Address,@MODULES)