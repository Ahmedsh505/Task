use iti

-- problem 1:-

create or alter proc SP_GetStuNum_ByDepId @ID int
with encryption
as 
	select count(St_Id)
	from Student
	where Dept_Id = @ID
--------
execute SP_GetStuNum_ByDepId 10

--------------------------------------------

--problem 2:-

use MyCompany

create or alter proc SP_CheckEmpNum_InProject @Pnum int
with encryption
as 
   declare @EmpNum int
	select @EmpNum = count(*)
			from Employee EMP
			join Departments Dept on Dept.Dnum=EMP.Dno
			join Project P on p.Dnum=Dept.Dnum
			where Pnumber = @Pnum
	if @EmpNum >= 3
	begin
	select 'The Number Of Employees In This Project Is 3 or more'
	end
	else 
	begin
	select 'The Following Employees Work For This Project'
	select  Fname, Lname
			from Employee EMP
			join Departments Dept on Dept.Dnum=EMP.Dno
			join Project P on p.Dnum=Dept.Dnum
			where Pnumber = @Pnum
end
------
execute SP_CheckEmpNum_InProject 400

----------------------------------------------

-- problem 3:-

create or alter proc Replace_EmpOnProject  @OldEmpNo INT, @NewEmpNo INT, @ProjectNo INT
with encryption
AS
    UPDATE [dbo].[Works_for]
    SET [ESSn] = @NewEmpNo
    WHERE [ESSn] = @OldEmpNo
      AND [Pno]= @ProjectNo

exec Replace_EmpOnProject 112233, 512463, 100
