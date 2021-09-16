create database hospital_management_system3
GO
use hospital_management_system3

create table patient
(
PID int,
first_name varchar(10),
last_name varchar(10),
gender char(1),
birthdate date,

Pusername nvarchar(250),
Ppassword nvarchar(100),
contact_num char(11),
Paddress varchar(300)

Primary key (PID),
)

create table Employee
(
EID int,
first_name varchar(10),
last_name varchar(10),
Estatus bit,
Eusername nvarchar(250),
Epassword nvarchar(100),
birthdate date,

contact_num char(11),
Paddress varchar(300),
gender char(1),
Etype varchar(15),

primary key (EID)
)


create table doctor
(
DID int,
specialization varchar(150),

primary key (DID),
foreign key (DID) references Employee

)

create table Nurse
(
NID int,
specialization varchar(150),
primary key (NID),
foreign key (NID) references Employee

)
-----------------------------------------------------
---
create table deleted_patient
(
PID int,
first_name varchar(10),
last_name varchar(10),
gender char(1),

Pusername nvarchar(250),
Ppassword nvarchar(100),
contact_num int,
Paddress varchar(300)

Primary key (PID),

)

create table deleted_Employee
(
EID int,
first_name varchar(10),
last_name varchar(10),
Estatus bit,
Eusername nvarchar(250),
Epassword nvarchar(100),

contact_num int,
Paddress varchar(300),
gender char(1),
Etype varchar(15),

primary key (EID)
)

create table deleted_doctor
(
DID int,
specialization varchar(150),
primary key (DID),

)
-----------------------------------------------------
create table hcase
(
case_num int,
diagnosis nvarchar(1000),
c_status bit,
casedate date,
primary key (case_num)

)

-----------------------------------------------------
create table Doctor_attend
(
DID int,
a_case_number int,
D_date date
foreign key (DID) references doctor,
foreign key (a_case_number) references hcase,
primary key(DID,a_case_number)                                         -- check for repetition       ???

)
-----
create table deleted_Doctor_attend
(
DID int,
a_case_number int,
primary key(DID,a_case_number)

)
-------
create table Patient_attend
(
PID int,
a_case_number int,
P_date date
foreign key (PID) references patient,
foreign key (a_case_number) references hcase,
primary key(PID,a_case_number)

)
---
create table deleted_Patient_attend
(
PID int,
a_case_number int,
primary key(PID,a_case_number)

)

--------------------------------------------------------------------------------------------------------------


create table room
(
RID INT,
current_num_of_patients int,
capacity int,
r_type varchar(50),
primary key (RID)

)

create table assigned
(
case_num int,
RID int,
checkin date,
checkout date,

foreign key (case_num) references hcase,
foreign key (RID) references room,

primary key (case_num,RID) 

)
create table govern
(
RID int,
NID int,
g_date date,

foreign key (NID) references nurse,
foreign key (RID) references room,
primary key(NID,RID)
)


create table lab_test
(
LID int,
L_name varchar(100),
L_status bit,
case_num int,

primary key(LID,case_num),
foreign key (case_num)  references hcase

)

create table treatment
(
    t_id int,
t_name nvarchar(300),
case_num int,
foreign key (case_num)  references hcase,
PRIMARY KEY(case_num,t_id)
)

create table surgery
(
S_ID int,
S_name varchar(100),

s_status bit,
case_num int,
foreign key (case_num)  references hcase,
primary key(S_ID,case_num)
)

-----------------------------------------------------------------------------------
use hospital_management_system3
insert into patient 
values
(0,'default','default','M','1000-01-01','default','default','00000000000','default'),
(1,'Hossam','Hassan','M','1976-07-17','hhassan','weakpassword','11111111111','12 Giza'),
(2,'Magnus','Carlsen','M','1990-11-17','magzy','thegoat','22222222222','17 Oslo'),
(3,'Alicia','Wallace','F','1967-10-01','awallace','whereswallace','33333333333','980 Dallas'),
(4,'Joyce','Borg','F','1999-09-09','jborg','jBJbJbbJb','44444444444','3311 Castle'),
(5,'Jacob','Wheeler','M','1995-11-25','jwheeler','shamelessnerd','55555555555','4541 Austin'),
(6,'Carol','Bitner','F','1980-10-10','cbitner','UQueed7zei9r','66666666666','1132 Jenna Lane'),
(7,'Katie','Burke','F','1991-12-03','kburke','aiZaejiet1','77777777777','2276 Barnes Street'),
(8,'Kevin','Mars','M','1996-02-03','kmars','Il7wohbeep','88888888888','212 Edsel Road'),
(9,'Robert','Pratt','M','1994-12-10','rpratt','aehoht7ua3J','99999999999','2716 Beechwood Drive'),
(10,'Jason','Cano','M','1996-06-11','jcano','io8haeGee','43552854180','2033 Austin Secret Lane'),
(11,'Michael','Hill','M','1989-01-03','mhill','quaiSh0nief','66101810150','1359 Gateway Avenue'),
(12,'Brandon','Francis','M','1982-02-13','bfrancis','Thaibu3ae','30942242901','933 Coburn Hollow Road'),
(13,'Sheryl','Jackson','F','1969-06-19','sherylj','MahL3Dahgh','61438301853','53 James Martin Circle'),
(14,'Cassandra','Brown','F','1999-02-17','cassandrab','aeghe4Eiroo','23145076957','4389 Twin Oaks Drive'),
(15,'Charles','Jernigan','M','1959-10-22','charlesj','aiL5aitoh4Ju','70396698453','1445 White Pine Lane'),
(16,'Carlotta','Johnson','F','1956-07-23','carlottaj','Ic5quoo6','25327274839','1178 Hillcrest Drive'),
(17,'Alan','Neville','M','1972-11-11','aneville','IRohX1eiYee','60950438112','1424 Lee Avenue'),
(18,'Michael','Beltran','M','1983-06-30','mbeltran','nae8Johg','40798103918','1110 County Line Road'),
(19,'Charles','Rudy','M','1979-12-23','crudy','ooGai9aexaa','62651590107','4351 Woodstock Drive'),
(20,'Gary','Gomez','M','1994-11-25','ggomez','Au8xohGoo','97287764506','2396 Olen Thomas Drive')

insert into Employee 
values
(0,'default','default',0,'default','default','1000-01-01','00000000000','default','M','default'),
(1,'Seth','Long',0,'slong','shahcieX1u','1977-12-22','32396575851','1837 Felosa Drive','M','admin'),
(2,'Seth','Long',0,'aslong','ashahcieX1u','1977-12-22','32396575851','1837 Felosa Drive','M','receptionist'),
(3,'Charles','Horn',0,'chorn','ees6AiZeic','1976-05-17','30191274516','1699 Del Dew Drive','M','admin'),
(4,'Sharon','Williams',1,'sharonw','ieh8ePhoop','1997-03-08','95469756336','2673 Foley Street','F','nurse'),
(5,'Sharon','Carter',0,'sharonc','Pae6johSh','1994-02-08','81478930829','1127 Spadafore Drive','F','nurse'),
(6,'Mary','Hamilton',1,'maryh','vo6ViLeech','1968-09-29','41934757801','1251 Olive Street','F','doctor'),
(7,'Rose','Monroe',0,'rosem','AHiJiyo3O','1992-03-22','50577065065','3007 Cooks Mine Road','F','admin'),
(8,'Denise','Henson',1,'deniseh','Ohchaigoo5ch','1952-06-23','66278019378','4664 Tanglewood Road','M','doctor'),
(9,'Ethel','Miller',0,'ethelm','gohiec1ohV','1990-05-13','31029241950','1 Prospect Valley Road','F','nurse'),
(10,'Colin','Moore',1,'cmoore','eevaWal2aagh','1944-05-25','72036827658','1052 Davis Lane','M','doctor'),
(11,'Michelle','Tomlinson',0,'michellet','iesae8Lus8','1989-06-24','71651534507','4172 Nuzum Court','F','admin'),
(12,'Vernice','Knowles',1,'vernicek','uqu3Loosh8e','1968-08-15','30975147657','958 Simpson Street','F','doctor'),
(13,'Stephen','Lambert',0,'slambert','ohH5zoesaej7','1963-02-13','93633727029','2718 Woodrow Way','M','doctor'),
(14,'Robert','Rector',1,'rrector','shai2ooW9oh','1945-08-31','57066013027','2033 Coal Road','M','doctor'),
(15,'Robert','Cone',0,'rcone','Eo7Yie3uqu1','1992-02-20','30238061321','3821 Argonne Street','M','nurse'),
(16,'Joe','Primm',1,'jprimm','euv7Ua9Oehe','1977-02-22','31529426073','1640 Oak Street','M','admin'),
(17,'Randy','Ross',0,'rross','Raiph8uazi7a','1975-11-19','27653163216','3273 Douglas Dairy Road','M','admin'),
(18,'Timothy','Procopio',1,'timothyp','aeZafuv9heiqu','1994-10-06','35415064705','27 Haymond Rocks Road','M','nurse'),
(19,'John','Braun',0,'jbraun','geehu0Eis','1975-12-03','37655219000','2308 Capitol Avenue','M','admin'),
(20,'Sue','Pittman',1,'suep','hei5aeGhoo','1971-08-07','65598427691','2053 Half and Half Drive','F','admin')


insert into doctor
values
(6,'Pediatrician'),
(8,'Pediatrician'),
(10,'ENT'),
(12,'Gynecologist'),
(13,'ENT'),
(14,'Cardiologist')

insert into nurse
values
(4,'Pediatrician'),
(5,'Gynecologist'),
(9,'Cardiologist'),
(15,'ENT'),
(18,'Pediatrician')

use hospital_management_system3
go
insert into hcase
values
(0,'default',0,'1001-11-11'),
(1,'Diabetes',0,'2021-06-05'),
(2,'Hepatitis',0,'2021-06-05'),
(3,'Influenza',0,'2021-06-05'),
(4,'Leukemia',0,'2021-06-05'),
(5,'Lupus',0,'2021-06-05'),
(6,'Pneumonia',0,'2021-06-05'),
(7,'Stroke',0,'2021-06-05'),
(8,'Liver Failure',0,'2021-06-05'),
(9,'Arthritis',0,'2021-06-05'),
(10,'Asthma',0,'2021-06-05'),
(11,'Back pain',0,'2021-06-05'),
(12,'Osteoarthritis',0,'2021-06-05'),
(13,'Nail fungus',0,'2021-06-05'),
(14,'Hyperlipidemia',0,'2021-06-05'),
(15,'bronchitis',0,'2021-06-05'),
(16,'Hypertension',0,'2021-06-05'),
(17,'IBS',0,'2021-06-05'),
(18,'Insulin Resistance',0,'2021-06-05'),
(19,'Multiple Sclerosis',0,'2021-06-05'),
(20,'Osteoporosis',0,'2021-06-05')


use hospital_management_system3
go
insert into room
values (0,0,3,'surgery'),
(1,0,3,'surgery'),
(2,0,4,'surgery'),
(3,0,5,'surgery'),
(4,0,3,'surgery'),
(5,0,4,'surgery'),
(6,0,5,'surgery'),
(7,0,3,'surgery'),
(8,0,4,'surgery'),
(9,0,5,'surgery'),
(10,0,6,'surgery'),
(11,0,3,'surgery'),
(12,0,4,'surgery'),
(13,0,5,'surgery'),
(14,0,6,'surgery'),
(15,0,3,'surgery'),
(16,0,4,'surgery'),
(17,0,5,'surgery'),
(18,0,10,'surgery'),
(19,0,6,'surgery'),
(20,0,8,'surgery')


use hospital_management_system3
go
insert into Doctor_attend
values
(14,14,'2021-6-10'),
(14,7,'2021-6-11'),
(13,3,'2021-6-12')

insert into Patient_attend
values
(11,14,'2021-6-10'),
(17,7,'2021-6-11'),
(19,3,'2021-6-12')

insert into assigned
values
(14,1,'2021-6-10','2021-6-10'),
(7,2,'2021-6-11','2021-6-11'),
(3,3,'2021-6-12','2021-6-12')

insert into lab_test
values
(1,'cbc',1,3)

insert into surgery
values
(1,'cholecystectomy',1,3)

insert into treatment
values
(1,'panadol',3)

