--CREATE DATABASE SMS
--USE SMS
--DROP DATABASE SMS

create table Staff( ------///////////
Role varchar (20),
Id int primary key identity,
FirstName varchar(30),
FatherName varchar(30),
GrandFatherName varchar(30),
Age int,
DateOfBirth date,
Gender char,
Email varchar(100) default null,
Phone varchar(20)
)


create table Class(-------homeroom Id should just be unique////////////////////////////
Id int primary key identity,
Grade smallint not null,
Section char not null,
StaffID int references Staff(Id) not null,
HomeroomID int references Staff(Id) unique not null,
)

create table Subject(--------/////////
Id int primary key identity, 
SubjectName varchar(50),
StaffID int references Staff(Id) not null
)

create table Parent(---- add instead of
Id int primary key identity,
FirstName varchar(50),
FatherName varchar(50),
GrandFatherName varchar(50),
Age int,
DateOfBirth date,
Gender char,
Email varchar(100) default null,
Phone varchar(20)
)

create table Student(---------
Id int primary key identity,
FirstName varchar(50),
FatherName varchar(50),
GrandFatherName varchar(50),
Age int,
DateOfBirth date,
Gender char,
Email varchar(100) default null,
Phone varchar(20),
ParentID int references Parent(Id) not null,
ClassId int not null,
FOREIGN KEY (ClassId) REFERENCES Class(Id)
)

create table Announcement( --------/////
Id int primary key identity,
Title text,
Detail text,
AnnouncementDate date,
StaffID int references Staff(Id) not null
)

create table Assessment(--------//////////
AssessmentID int primary key identity,
SubjectID int references Subject(Id) not null,
StudentID int references Student(Id) not null,
AssessmentType varchar(20),
AssessmentWeight varchar(4),
Score varchar(4), 
ClassId int not null,
foreign key (ClassId) references Class(Id),
StaffID int references Staff(Id) not null --add instead of
)

create table Appointment(------/////////////////////
AppointmentID int primary key identity,
AppointmentDate date,
AppointmentTime time,
ParentID int references Parent(Id) not null,
StaffID int references Staff(Id) not null,
Title text
)

create table Notification(-----------------//////////////////////////////
NotificationID int primary key identity,
Title text,
Details text,
NotificationDate date,
StaffID int references Staff(Id) not null,
ParentID int references Parent(Id) not null,
StudentID int references Student(Id) not null --add instead of
)

insert into Staff values('Teacher', 'Tadele', 'Gemechu', 'Asfaw', 50 , '2002-10-10', 'M', 'tadele@gmail.com', '0976554355')
insert into Staff values('Teacher', 'Tewoldebirhan', 'Assefa', 'Mulugeta', 30 , '1990-5-7', 'M', 'tesfaye@gmail.com', '0909887657')
insert into Staff values('Teacher', 'Tesfaye', 'Hunilachew', 'Amde', 30 , '1990-5-7', 'M', 'tesfaye@gmail.com', '0909887657')

insert into Staff values('Staff', 'Teklu', 'Kora', 'Bejigu', 28, '1988-4-6', 'M', 'teklu@gmail.com', '0987654533')

/*
UPDATE Staff  SET FirstName ='Tesfaye' , FatherName = 'Hunilachew', GrandFatherName= 'Amde' WHERE staffId = 3
SELECT FirstName, FatherName, GrandFatherName FROM Staff WHERE StaffID=3
*/

/*
UPDATE Subject SET StaffID = 3 WHERE SubjectID = 3
SELECT * FROM Subject
*/

insert into Class values (9, 'A', 1, 1)
insert into Class values (9, 'B', 2, 2)
INSERT INTO Class VALUES (9, 'C', 3, 3)

--SELECT * FROM Class

insert into Subject values ('Chemistry', 1)
insert into Subject values ('Physics', 2)
insert into Subject values ('Math', 3)

insert into Parent values('Solomon', 'Tariku', 'Tadele', 30, '1992-10-10', 'M', '@solomon@gmail.com', '0976543304')
insert into Parent values('Samuel', 'Muluneh', 'Berihun', 30, '1992-10-10', 'M', '@samuel@gmail.com', '0998765540')
insert into Parent values('Samson', 'Mulugeta', 'Bisrat', 30, '1992-10-10', 'M', '@samson@gmail.com', '0998443243')

--SELECT * FROM Parent

--DELETE Parent WHERE ParentID > 3

insert into Student values('Genet', 'Samson', 'Tadele', 15, '2007-10-10', 'F', '@solomon@gmail.com', '0976543304', 1, 1)
insert into Student values('Gifti', 'Solomon', 'Berihun', 15, '2007-10-10', 'F', '@samuel@gmail.com', '0998765540', 1, 2)
insert into Student values('Gabriella', 'Mulugeta', 'Belayneh', 15, '2007-10-10', 'F', '@samson@gmail.com', '0998443243', 2, 3)

--SELECT * FROM Student

insert into Announcement values ('Charity Club clothes Collection', 'For the poor and unfashionable, if its not cute 
dont bring it', '2022-5-9', 3)
insert into Announcement values ('Carnival', 'One day in the year when you actually want to come to school', '2022-5-9', 3)

insert into Assessment values (1, 1, 'Mid-Exam',  '20%',  '15', 1, 1)
insert into Assessment values (2, 2, 'Mid-Exam',  '20%',  '20', 2, 1)
insert into Assessment values (3, 3, 'Mid-Exam',  '20%',  '18', 2, 2)

--SELECT * FROM Notification

insert into Appointment values ('2022-8-9', '2:00', 1, 3, 'Expulsion')
insert into Appointment values ('2022-8-10', '3:00', 2, 3, 'Misconduct')
insert into Appointment values ('2022-8-11', '4:00', 2, 3, 'Child Lookin Whack')

insert into Notification values ('Missing Attendance', 'Child has not been in class, omg must be 
embarazzing for you, telling all your zemedoch how you got a good kid and something like this happens... yeesh. We gon pray for you
But in the mean time yaw asawikenal alsemanm endatilu... also dont worry only you get this notification not everyone will hear
of your social blunder', '2016-6-15', 1, 1, 1)
insert into Notification values ('Misconduct', 'The hell is up with your kid?! He needs an exorcism, come over and we can do it 
together', '2019-4-3', 1, 2, 1)
insert into Notification values ('Homework', 'English on the textbook, pg 200, #5', '2019-4-3', 1, 2, 1)




