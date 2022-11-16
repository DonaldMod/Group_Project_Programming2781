Create Procedure spSelectStudentID
@ID int
As 
Begin
Select * from Students where StudentID = @ID
End
