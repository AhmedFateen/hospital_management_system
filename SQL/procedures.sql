use hospital_management_system3
GO

--------------------------------
CREATE PROCEDURE sp_viewAllPatients
as
select DISTINCT *
from patient
go

CREATE PROCEDURE sp_viewAllRooms
as
select DISTINCT *
from room
go

CREATE PROCEDURE sp_viewAllCases
as
select DISTINCT *
from hcase
go

CREATE PROCEDURE sp_viewAllEmployees
as
select DISTINCT *
from employee
go

create procedure sp_viewMedicalRecord
@PID int
as
select p.PID,p.a_case_number,c.diagnosis,c.c_status,t.t_id,t.t_name,l.LID,l.L_name,l.L_status,s.S_ID,s.S_name,s.s_status
from (((Patient_attend as p join hcase as c on p.a_case_number=c.case_num) join lab_test as l on c.case_num=l.case_num) join surgery as s on c.case_num=s.case_num) join treatment as t on t.case_num=c.case_num
where p.PID=@PID
go

--------------------------------
create procedure sp_num_patient_room
@RID int
as
select count(case_num) AS Number_patient_room
from assigned
where RID=@RID
go


create procedure spView_username_password_Employee
as
select DISTINCT Eusername ,Epassword ,Etype
from Employee
go

create procedure spView_username_password_patient
as
select DISTINCT Pusername,Ppassword
from patient
go

CREATE PROCEDURE spViewPatient
@PID int,
@first_name varchar(10) output,
@last_name varchar(10) output,
@gender char(1) output,
@birthdate date output,
@Pusername nvarchar(250) output,
@Ppassword nvarchar(100) output,
@contact_num char(11) output,
@Paddress varchar(300) output

AS
Select @first_name= first_name,
@last_name=last_name,
@gender=gender,
@birthdate=birthdate,
@Pusername=Pusername,
@Ppassword=Ppassword,
@contact_num=contact_num,
@Paddress=Paddress
FROM patient
WHERE PID=@PID
GO
----------

CREATE PROCEDURE spViewEmployee
@EID int,
@first_name varchar(10) output,
@last_name varchar(10) output ,
@Estatus bit output,
@Eusername nvarchar(250) output,
@Epassword nvarchar(100) output,
@birthdate date output,
@contact_num char(11) output,
@Paddress varchar(300) output,
@gender char(1) output,
@Etype varchar(15) output

AS
Select @first_name= first_name,
@last_name=last_name,
@Estatus=Estatus,
@Eusername=Eusername,
@Epassword=Epassword,
@birthdate=birthdate,
@contact_num=contact_num,
@Paddress=Paddress,
@gender=gender,
@Etype=Etype
FROM Employee
WHERE EID=@EID
GO

----------

CREATE PROCEDURE spAddPatient
@PID int,
@first_name varchar(10),
@last_name varchar(10),
@gender char(1),
@birthdate date,
@Pusername nvarchar(250),
@Ppassword nvarchar(100),
@contact_num char(11),
@Paddress varchar(300)

AS
BEGIN
Insert into patient
values (@PID,@first_name,@last_name,@gender,@birthdate,@Pusername,@Ppassword,@contact_num,@Paddress)
END
GO
----------------------------------------------- done
CREATE PROCEDURE spAddEmployee
@EID int,
@first_name varchar(10),
@last_name varchar(10),
@Estatus bit,
@Eusername nvarchar(250),
@Epassword nvarchar(100),
@birthdate date,
@contact_num char(11),
@Paddress varchar(300),
@gender char(1),
@Etype varchar(15)

AS
BEGIN
Insert into Employee
values (@EID,@first_name,@last_name,@Estatus,@Eusername,@Epassword,@birthdate,@contact_num,@Paddress,@gender,@Etype)
END
GO

CREATE PROCEDURE spUpdatePatient
@PID int,
@first_name varchar(10),
@last_name varchar(10),
@gender char(1),
@birthdate date,
@Pusername nvarchar(250),
@Ppassword nvarchar(100),
@contact_num char(11),
@Paddress varchar(300)
AS  
BEGIN  
    SET NOCOUNT ON
	UPDATE patient
	Set first_name=@first_name,
	last_name=@last_name,
	gender=@gender,
	birthdate=@birthdate,
	Pusername=@Pusername,
	Ppassword=@Ppassword,
	contact_num=@contact_num,
	Paddress=@Paddress
	WHERE PID=@PID
END
GO

CREATE PROCEDURE spUpdateEmployee
@EID int,
@first_name varchar(10),
@last_name varchar(10),
@Estatus bit,
@Eusername nvarchar(250),
@Epassword nvarchar(100),
@birthdate date,

@contact_num char(11),
@Paddress varchar(300),
@gender char(1),
@Etype varchar(15)
AS
BEGIN
	Set NOCOUNT ON
	UPDATE Employee
	Set first_name= @first_name,
	last_name=@last_name,
	Estatus=@Estatus,
	Eusername=@Eusername,
	Epassword=@Epassword,
	birthdate=@birthdate,
	contact_num=@contact_num,
	Paddress=@Paddress,
	gender=@gender,
	Etype=@Etype
	WHERE EID=@EID
END
GO
CREATE PROCEDURE spDeletePatient
@PID int
AS
BEGIN
	SET NOCOUNT ON

	DELETE from patient
	where PID=@PID
END
GO


CREATE PROCEDURE spDeleteEmployee
@EID int
AS
BEGIN
	SET NOCOUNT ON

	DELETE from Employee
	where EID=@EID
END
GO


CREATE PROCEDURE spAddRoom

@RID INT,
@current_num_of_patients int,
@capacity int,
@r_type varchar(50)

AS
BEGIN
Insert into room
values (@RID,@current_num_of_patients,@capacity,@r_type)
END
GO



CREATE PROCEDURE spDeleteRoom
@RID int
AS
BEGIN
	SET NOCOUNT ON

	DELETE from room
	where RID=@RID
END
GO


CREATE PROCEDURE spViewRoom
@RID INT,
@current_num_of_patients int output,
@capacity int output,
@r_type varchar(50) output
AS
Select @current_num_of_patients = current_num_of_patients,
@capacity=capacity,
@r_type=r_type
FROM room
WHERE RID=@RID
GO


CREATE PROCEDURE spUpdateRoom
@RID INT,
@current_num_of_patients int,
@capacity int,
@r_type varchar(50)
AS  
BEGIN  
    SET NOCOUNT ON
	UPDATE room
	Set current_num_of_patients=@current_num_of_patients,
	capacity=@capacity,
	r_type=@r_type
	WHERE RID=@RID
END
GO

----------------------------------------------------------------///////////////
CREATE PROCEDURE spAddCase

@case_num INT,
@diagnosis nvarchar(500),
@c_status bit,
@casedate date
AS
BEGIN
Insert into hcase(case_num,diagnosis,c_status,casedate)
values (@case_num,@diagnosis,@c_status,@casedate)
END
GO

CREATE PROCEDURE spViewCase
@case_num INT,
@diagnosis nvarchar(500) output,
@c_status bit output,
@casedate date output
AS
Select @diagnosis = diagnosis,
@c_status=c_status ,@casedate=casedate
FROM hcase
WHERE case_num=@case_num
GO



CREATE PROCEDURE spUpdateCase
@case_num INT,
@diagnosis nvarchar(500),
@c_status bit,
@casedate date
AS  
BEGIN  
    SET NOCOUNT ON
	UPDATE hcase
	Set diagnosis=@diagnosis,
	c_status=@c_status,@casedate=casedate
	WHERE case_num=@case_num
END
GO
---------------------------------------
CREATE PROCEDURE spDeleteCase
@case_num int
AS
BEGIN
	SET NOCOUNT ON

	DELETE from hcase
	where case_num=@case_num
END
GO
---------------------------------------

CREATE PROCEDURE spAdd_Doctor_Attend

@Ddate date,
@DID int,
@a_case_number int
AS
BEGIN
Insert into Doctor_attend(D_date,DID,a_case_number)
values (@Ddate,@DID,@a_case_number)
END
GO

CREATE PROCEDURE spDelete_Doctor_Attend
@DID int,
@a_case_number int
AS
BEGIN
	SET NOCOUNT ON

	DELETE from Doctor_attend
	where DID=@DID and a_case_number=@a_case_number
END
GO


CREATE PROCEDURE spUpdate_Doctor_Attend
@DID int,
@a_case_number int,
@Ddate date

AS  
BEGIN  
    SET NOCOUNT ON
	UPDATE Doctor_attend
	Set D_date=@Ddate
	WHERE DID=@DID AND a_case_number=@a_case_number
END
GO

CREATE PROCEDURE spViewDoctorAttend
@DID INT,
@a_case_number int
AS
Select * FROM Doctor_attend
WHERE DID=@DID AND a_case_number=@a_case_number
GO
-----------
CREATE PROCEDURE spAdd_Patient_attend

@Pdate date,
@PID int,
@a_case_number int
AS
BEGIN
Insert into Patient_attend(P_date,PID,a_case_number)
values (@Pdate,@PID,@a_case_number)
END
GO

CREATE PROCEDURE spDelete_Patient_attend
@PID int,
@a_case_number int
AS
BEGIN
	SET NOCOUNT ON

	DELETE from Patient_attend
	where PID=@PID and a_case_number=@a_case_number
END
GO


CREATE PROCEDURE spUpdate_Patient_attend
@PID int,
@a_case_number int,
@Pdate date

AS  
BEGIN  
    SET NOCOUNT ON;
	UPDATE Patient_attend
	Set P_date=@Pdate
	WHERE PID=@PID AND a_case_number=@a_case_number
END
GO


CREATE PROCEDURE spViewPatientAttend
@PID INT,
@a_case_number int

AS
Select * FROM Patient_attend
WHERE PID=@PID and a_case_number=@a_case_number
GO



------------------------------------------------------------------------------- ///
CREATE PROCEDURE spAddLabTest
@LID int,
@L_name varchar(100),
@L_status bit,
@case_num int
AS
BEGIN
Insert into lab_test
values (@LID,@L_name,@L_status,@case_num)
END
GO

create procedure spView_LabTest
@LID int,
@case_num int
AS
BEGIN
Select * FROM lab_test
WHERE LID=@LID and case_num=@case_num
END
GO

create procedure spDelete_LabTest
@LID int,
@case_num int

AS
BEGIN
	SET NOCOUNT ON
	DELETE from lab_test
	where LID=@LID and case_num=@case_num
END
go
---
CREATE PROCEDURE spUpdate_LabTest
@LID int,
@L_name varchar(100),
@L_status bit,
@case_num int

AS  
BEGIN  
    SET NOCOUNT ON;
	UPDATE lab_test
	Set 
	L_name=@L_name,
	L_status=@L_status
	WHERE LID=@LID AND case_num=@case_num
END
GO
----------
CREATE PROCEDURE spAddTreatment
@T_name varchar(300),
@case_num int,
@t_id int
AS
BEGIN
Insert into treatment(t_name,case_num,t_id)
values (@T_name,@case_num,@t_id)
END
GO

create procedure spView_Treatment
@case_num int,
@t_id int
AS
BEGIN
Select * FROM treatment
WHERE case_num=@case_num and t_id=@t_id
END
GO

create procedure spDelete_Treatment
@case_num int,
@t_id int
AS
BEGIN
	SET NOCOUNT ON
	DELETE from treatment
	where case_num=@case_num and t_id=@t_id
END
go
---
CREATE PROCEDURE spUpdate_Treatment
@case_num int,
@T_name varchar(100),
@t_id int
AS  
BEGIN  
    SET NOCOUNT ON;
	UPDATE treatment
	Set 
	t_name=@t_name
	WHERE case_num=@case_num and t_id=@t_id
END
GO


------------------------------------------------- start here
CREATE PROCEDURE spAddSurgery
@S_ID int,
@S_name varchar(100),
@s_status bit,
@case_num int
AS
BEGIN
Insert into surgery(S_ID,S_name,s_status,case_num)
values (@S_ID,@S_name,@s_status,@case_num)
END
GO

create procedure spView_Surgery
@S_ID int

AS
BEGIN
Select * FROM surgery
WHERE S_ID=@S_ID
END
GO

create procedure spDelete_Surgery
@S_ID int

AS
BEGIN
	SET NOCOUNT ON
	DELETE from surgery
	where S_ID=@S_ID
END
go
---
CREATE PROCEDURE spUpdate_Surgery
@S_ID int,
@S_name varchar(100),
@S_status bit,
@case_num int

AS  
BEGIN  
    SET NOCOUNT ON;
	UPDATE surgery
	Set 
	s_status=@S_status,
	S_name=@S_name
	WHERE S_ID=@S_ID and case_num=@case_num
END
GO

--------------------------------------------------------------------
CREATE PROCEDURE spAdd_AssignCaseToRoom
@case_num int,
@RID int,
@checkin date,
@checkout date
AS
BEGIN
Insert into assigned(case_num,RID,checkin,checkout)
values (@case_num,@RID,@checkin,@checkout)
END
GO


create procedure spView_AssignCaseToRoom
@case_num int,
@RID int
AS
BEGIN
select * from assigned
where case_num=@case_num and RID=@RID
END
go

create procedure spDelete_AssignCaseToRoom
@case_num int,
@RID int
AS
BEGIN
	SET NOCOUNT ON
	DELETE from assigned
where case_num=@case_num and RID=@RID
END
go

create procedure spUpdate_AssignCaseToRoom
@case_num int,
@RID int,
@checkin date,
@checkout date

AS  
BEGIN  
    SET NOCOUNT ON;
	UPDATE assigned
	Set 
	checkin=@checkin,
	checkout=@checkout
	WHERE  case_num=@case_num and RID=@RID
END
GO
--------------------------------------------///
CREATE PROCEDURE spAddGovern
@RID int,
@NID int,
@g_date date
AS
BEGIN
Insert into govern(RID,NID,g_date)
values (@RID,@NID,@g_date)
END
GO

create procedure spViewGovern
@RID int,
@NID int

AS
BEGIN
select*from govern
where RID=@RID and NID=@NID
END
go


create procedure spDeleteGovern
@RID int,
@NID int

as
BEGIN
delete from govern
where RID=@RID and NID=@NID
END
go

create procedure spUpdateGovern
@RID int,
@NID int,
@g_date date

AS  
BEGIN  
    SET NOCOUNT ON;
	UPDATE govern
	Set 
	g_date=@g_date

	WHERE RID=@RID and NID=@NID
END
GO

--------------------------------------------------------------------
ALTER PROCEDURE spViewPatient
@PID int
AS
BEGIN
	SET NOCOUNT ON;
	select * from Patient 
	where PID=@PID
	end
	GO

ALTER PROCEDURE spViewEmployee
@EID int
AS
BEGIN
	SET NOCOUNT ON;
	select * from employee 
	where EID=@EID
	end
	GO


ALTER TABLE hcase
ALTER COLUMN casedate date
go

alter procedure spAddCase
@case_num INT,
@diagnosis nvarchar(500),
@c_status bit,
@casedate date
AS
BEGIN
Insert into hcase(case_num,diagnosis,c_status,casedate)
values (@case_num,@diagnosis,@c_status,@casedate)
END
GO

----- 6-5-2021
alter procedure spViewCase
@case_num int
AS
BEGIN
	SET NOCOUNT ON;
	select * from hcase join Patient_attend on case_num=a_case_number
	where case_num=@case_num and a_case_number=@case_num
	end
	GO


alter PROCEDURE spUpdateCase
@case_num INT,
@diagnosis nvarchar(500),
@c_status bit,
@casedate date
AS  
BEGIN  
    SET NOCOUNT ON
	UPDATE hcase
	Set diagnosis=@diagnosis,
	c_status=@c_status,
	casedate=@casedate
	WHERE case_num=@case_num
END
GO

ALTER PROCEDURE spViewRoom
@RID int
AS
BEGIN
	SET NOCOUNT ON;
	select * from room 
	where RID=@RID
	END

	go

CREATE PROCEDURE spAddDoctor
@DID int,
@specialization varchar(150)
AS 
BEGIN
Insert into doctor
values (@DID,@specialization)
END
GO

CREATE PROCEDURE spAddNurse
@NID int,
@specialization varchar(150)
AS 
BEGIN
Insert into nurse
values (@NID,@specialization)
END
GO