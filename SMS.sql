--CREATE DATABASE SMS
--USE SMS


CREATE TABLE Parent
(
  Id INT primary key identity,
  FirstName VARCHAR(100) NOT NULL,
  FathersName VARCHAR(100) NOT NULL,
  GrandFathersName VARCHAR(100) NOT NULL,
  Gender VARCHAR(6) NOT NULL,
  Email VARCHAR(100) NOT NULL,
  Phone VARCHAR(20) NOT NULL,
  DateOfBirth DATE NOT NULL 
);


insert into Parent values 
('Solomon', 'Mulugeta', 'Samuel', 'M', 'solomonm@gmail.com', '+251977654390', '1980-05-02'),
('Arsema', 'Elias', 'Abera', 'M', 'arsemasworking@gmail.com', '+251956432189', '1984-04-12'),
('Tibebu', 'Gashaw', 'Mola', 'M', 'ttebibu@gmail.com', '+251998765430', '1960-06-02'),
('Getachew', 'Molalign', 'Niguse', 'M', 'getchoo@gmail.com', '+251911345678', '1990-01-11'),
('Zenebech', 'Assefa', 'Hunew', 'M', 'Zeni2021@gmail.com', '+251987451123', '1963-08-10')

CREATE TABLE Subject
(
  Id INT primary key identity,
  Name VARCHAR(100) NOT NULL
);

insert into Subject values
('English'),
('Math'),
('Biology'),
('Physics'),
('Chemistry'),
('Science'),
('Social Studies'),
('Geography'),
('History'),
('Amharic'),
('Economics'),
('Business'),
('IT'),
('HPE'),
('Civics')

CREATE TABLE Grade
(
  Id INT primary key identity,
  Value INT NOT NULL
);

insert into Grade values
(1),
(2),
(3),
(4),
(5),
(6),
(7),
(8),
(9),
(10),
(11),
(12)


CREATE TABLE Section
(
  Id INT primary key identity,
  Value VARCHAR(6) NOT NULL,
);

insert into Section values
('A'),
('B'),
('C'),
('D'),
('E'),
('F')



CREATE TABLE SubjectForGrade
(
  Id INT NOT NULL primary key identity,
  SubjectId INT NOT NULL  FOREIGN KEY REFERENCES Subject(Id),
  GradeId INT NOT NULL FOREIGN KEY  REFERENCES Grade(Id)
);

insert into SubjectForGrade values --subjects for grade 8
(1,9),
(2,9),
(3,9),
(4,9),
(5,9),
(6,9),
(7,9),
(8,9)



CREATE TABLE Teacher
(
  Id INT NOT NULL primary key identity,
  FirstName VARCHAR(100) NOT NULL,
  FathersName VARCHAR(100) NOT NULL,
  GrandFathersName VARCHAR(100) NOT NULL,
  Gender VARCHAR(6) NOT NULL,
  Email VARCHAR(100) NOT NULL,
  Phone VARCHAR(20) NOT NULL,
  DateOfBirth DATE NOT NULL,
  SubjectForGradeId INT NOT NULL FOREIGN KEY REFERENCES SubjectForGrade(Id)
);
insert into Teacher values 
('Kylie', 'Jenner', 'Scott', 'F', 'kyliejenner@gmail.com', '+251923456577', '2000-09-05', 1),
('Khloe', 'Kardashian', 'Dissick', 'F', 'khloejenner@gmail.com', '+251911456799', '1995-08-03', 2),
('Kim', 'Kardashian', 'West', 'F', 'kimskins@gmail.com', '+251921567799', '1998-07-13', 3),
('Rob', 'Kardashian', 'Simpson', 'M', 'Robheretoteach@gmail.com', '+251911009978', '1999-06-11', 4),
('Tesfalem', 'Abebe', 'Teshalew', 'M', 'tesfalemabebe@gmail.com', '+251911561322', '1980-10-15', 5),
('Albert', 'Einstein', 'Germanson', 'M', 'alerteinstein@gmail.com', '+251970564322', '1978-10-11', 6),
('Micheal', 'Branson', 'Faraday', 'M', 'michealfaraday@gmail.com', '+251911213489', '1995-08-03', 7),
('Marie', 'Gottanobel', 'Curie', 'F', 'mariecurie@gmail.com', '+251911512344', '1987-10-13', 8)

CREATE TABLE OfficeStaff
(
  Id INT NOT NULL primary key identity, 
  FirstName VARCHAR(100) NOT NULL,
  FathersName VARCHAR(100) NOT NULL,
  GrandFathersName VARCHAR(100) NOT NULL,
  Gender VARCHAR(6) NOT NULL,
  Email VARCHAR(100) NOT NULL,
  Phone VARCHAR(20) NOT NULL,
  DateOfBirth DATE NOT NULL
);

insert into OfficeStaff values 
('Tariku', 'Mehari', 'Gebru', 'M', 'tarikum@gmail.com', '+251911213789', '1989-03-12'),
('Tesemash', 'Mikru', 'Maru', 'F', 'tesemashm@gmail.com', '+251911457800', '1988-04-02'),
('Tesfaye', 'Lemlem', 'Workneh', 'M', 'tesfayel@gmail.com', '+251911987601', '1969-05-12'),
('Tenagne', 'Muluneh', 'Ali', 'F', 'tenagnem@gmail.com', '+251911301928', '1999-06-10'),
('Tewabech', 'Daniel', 'Gebremedhin', 'F', 'tewabechd@gmail.com', '+251911203941', '1960-07-11')


CREATE TABLE Announcement
(
  Id INT NOT NULL primary key identity,
  Title VARCHAR(100) NOT NULL,
  Detail VARCHAR(250) NOT NULL,
  OfficeStaffId INT NULL REFERENCES OfficeStaff(Id)
);

insert into Announcement values
('Annual Carnival', 'Come and enjoy our carnival with special perfomances, foods, drinks and games. Time: 3:00LT on Sept 25th 2022', 1),
('Report Card Day ', 'Please come to school and collect your childrens grades starting from 3:00LT on Sunday Sept 30th 2022', 1),
('Registration for 2015', 'Registration for students will begin on October 1 and end on Oct 15. Please register
your child within that time.' , 2),
('Textbook Release', 'Tectbooks for students of all grades have been restocked. Please go to the book shop infront of the school
to collect them', 2)






CREATE TABLE Class
(
  Id INT NOT NULL primary key identity,
  SectionId INT NOT NULL  FOREIGN KEY REFERENCES Section(Id),
  GradeId INT NOT NULL FOREIGN KEY REFERENCES Grade(Id),
  HomeroomId INT NULL FOREIGN KEY REFERENCES Teacher(Id)
);



insert into Class values --we only have a section A for all grades
(1,1,1),
(1,2,2),
(1,3,3),
(1,4,4),
(1,5,5),
(1,6,6),
(1,7,7),
(1,8,8)



CREATE TABLE Student
(
  Id INT NOT NULL primary key identity, 
  FirstName VARCHAR(100) NOT NULL,
  FathersName VARCHAR(100) NOT NULL,
  GrandFathersName VARCHAR(100) NOT NULL,
  Gender VARCHAR(6) NOT NULL,
  Phone VARCHAR(20) NOT NULL,
  Email VARCHAR(100) NOT NULL,
  DateOfBirth DATE NOT NULL,
  ParentId INT NOT NULL FOREIGN KEY REFERENCES Parent(Id),
  ClassId INT NOT NULL FOREIGN KEY REFERENCES Class(Id)
);

insert into Student Values 
('Sarah', 'Solomon', 'Mulugeta', 'F', '+251923546688', 'sarahshere@gmail.com', '2005-10-11', 1,  8),
('Eyuel', 'Berihun', 'Taye', 'M', '+251945786654', 'eyubeup@gmail.com', '2005-2-13', 2, 8),
('Kidus', 'Tibebu', 'Gashaw', 'M', '+251913456799', 'kiddylit@gmail.com', '2005-5-23', 3, 8),
('Mehari', 'Getachew', 'Molalign', 'M' , '+251923435566', 'mercyformehari@gmail.com', '2005-4-19', 4, 8),
('Salem', 'Getachew', 'Molalign', 'F', '+251923435566', 'salemselelech@gmail.com', '2005-3-10', 4, 8)

CREATE TABLE Appointment --no title?
(
  Id INT NOT NULL primary key identity,
  AppointmentDate DATE NOT NULL,
  Detail VARCHAR(250) NOT NULL,
  OfficeStaffId INT NULL FOREIGN KEY REFERENCES OfficeStaff(Id),
  StudentId INT NOT NULL FOREIGN KEY (StudentId) REFERENCES Student(Id)
);

insert into Appointment values
('2022-09-18', 'Eyuel has been showing very poor conduct, we would like to discuss this issue with you. We have set
an appointment for Sept 23rd 2022 at 3:00LT. Please arrive on time at the directors office so we can discuss. 
Thank you.', 1, 2),
('2022-09-18', 'Kidus has been showing very poor conduct, we would like to discuss this issue with you. We have set
an appointment for Sept 23rd 2022 at 4:00LT. Please arrive on time at the directors office so we can discuss. 
Thank you.', 1, 3)




CREATE TABLE Assessment
(
  Id INT NOT NULL primary key identity,
  Name VARCHAR(100) NOT NULL,
  OutOf INT NOT NULL,
  Score FLOAT NOT NULL,
  StudentId INT NOT NULL FOREIGN KEY REFERENCES Student(Id),
  SubjectId INT NOT NULL FOREIGN KEY REFERENCES Subject(Id)
);

insert into Assessment values
('Mid-exam', 25, 20, 1, 1),
('Mid-exam', 25, 19, 2, 1),
('Mid-exam', 25, 16, 3, 1),
('Mid-exam', 25, 23, 4, 1),
('Mid-exam', 25, 18, 5, 1)



CREATE TABLE AttendanceMissed
(
  Id INT NOT NULL primary key identity,
  Period VARCHAR(50) NOT NULL,
  SubjectName VARCHAR(100) NOT NULL,
  Date DATE NOT NULL,
  StudentId INT NOT NULL FOREIGN KEY REFERENCES Student(Id)
);


insert into AttendanceMissed values
('3rd','Math','2022-9-17', 2),
('4th', 'English', '2022-9-17', 2),
('1st', 'Science', '2022-9-17', 3),
('2nd', 'IT', '2022-9-17', 3)
