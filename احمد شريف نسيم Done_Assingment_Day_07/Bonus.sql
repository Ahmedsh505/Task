use iti

-- problem 1:-

create or alter proc SP_Get_MonthName_ByDate @Date date
with encryption
as
		 DECLARE @Month varchar(max)
		 SET @Month = DATENAME(MONTH, @Date)
         select @Month

	
	exec SP_Get_MonthName_ByDate '4-4-2004'
	--------------------------------------------------------------------------------
-- problem 2:-
create or alter proc SP_Get_nums_Between @first int,@last int
 with encryption		
		as
 CREATE TABLE T1 (Value INT)
    DECLARE @Current_value INT
    SET @Current_value = @first

    WHILE @Current_value < @last-1
    BEGIN
        SET @Current_value = @Current_value + 1
        INSERT INTO T1 (value)
        VALUES (@Current_value)
    END
		SELECT * FROM T1


exec SP_Get_nums_Between 2,8
-------------------------------------------------------------------------
-- problem 3:-
create or alter proc SP_GetDeptN_stName_byStId @st_Id int
with encryption
	as 
			select d.Dept_Name,s.St_Fname+' '+s.St_Lname as [Full name]
			from Student s
			join Department d on s.Dept_Id=d.Dept_Id
			where St_Id=@st_Id
		
	exec  SP_GetDeptN_stName_byStId 3
--------------------------------------------------------------------------------------------
-- problem 4:-
create or alter proc  SP_MessageToUser_ByID @ID int
with encryption
as	
		 DECLARE @Messages varchar(max) ,@first varchar(max) ,@last varchar(max)
		 
		
	set	@first = (select St_Fname isnull from Student where St_Id=@ID)
	set @last = (select St_Lname isnull from Student where St_Id=@ID)

        if @ID = (select St_Id from Student where St_Id=@ID) 
	begin
		 if @first is NULL and @last is NULL
	         SET @Messages = 'First name & last name are null'
		 else if @first is NULL
			SET @Messages = 'First name is null'
	   	 else if @last is NULL
		    SET @Messages = 'Last name is null'
	     else if @first is not NULL and @last is not NULL
		    SET @Messages = 'First name & last name are not null'
	end 
		else 	
		    SET @Messages = 'ID not found'
	select @Messages

  exec SP_MessageToUser_ByID 5
  -------------------------------------------------------------------------------------------------
-- problem 5:-
create or alter proc SP_GetDeptN_ManagerN_HiringDate @format int
with encryption
	as 
			select Dept_Name,Dept_Manager,
			CASE @format
            WHEN 1 THEN FORMAT(manager_hiredate, 'dd-MM-yyyy')
            WHEN 2 THEN FORMAT(manager_hiredate, 'MMMM dd, yyyy') 
            WHEN 3 THEN FORMAT(manager_hiredate, 'yyyy/MM/dd')
            WHEN 4 THEN FORMAT(manager_hiredate, 'ddd, dd MMM yyyy') 
            ELSE FORMAT(manager_hiredate, 'yyyy-MM-dd')             
        END AS FormattedHiringDate
			from Department 


exec  SP_GetDeptN_ManagerN_HiringDate 5
-----------------------------------------------------------------------------------------------------
-- problem 6:-

create or alter proc SP_GetStuedntName_ByPattern @Patterns varchar(30)
with encryption
	as 
			if @Patterns = 'First_Name'

			select st_id,St_Fname
			from Student
			else if @Patterns = 'Last_Name'

			select st_id,St_Lname
			from Student
			else if @Patterns = 'Full_Name'

			select st_id,St_Fname+' '+St_Lname
			from Student
			

exec SP_GetStuedntName_ByPattern 'First_Name'
------------------------------------------------------------------------------------------------------
-- problem 7:-
   use MyCompany

   create or alter proc SP_Get_Employees_BYProjectNum @Pnum int
   with encryption
	as 
			select Fname+' '+Lname as [Full Name]
			from Employee Emp
			join Departments D on D.Dnum=Emp.Dno
			join Project P on p.Dnum=d.Dnum
			where Pnumber = @Pnum
 
exec SP_Get_Employees_BYProjectNum 700







