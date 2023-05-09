Create Database DemoDB

Use DemoDB  

Create Table Students
(
StudentId int Primary Key,
StudentName varchar(20),
StudentSubject varchar(10),
StudentMarks int
)

Create Table MarksList
(
StudentId int references Students(StudentId),
SubMat int,
SubPhy int,
Subche int,
TotalMarks int
)

Alter Table MarksList add Percentage int

Alter Table MarksList drop column Perentage

Alter Table MarksList drop constraint FK__MarksList__Stude__4AB81AF0

Alter Table MarksList add constraint FK1 foreign key(StudentId) references Students(StudentId)