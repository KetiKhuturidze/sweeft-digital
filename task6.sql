create table Teacher
(
  Teacher_id NVARCHAR(20)primary key,
  name_t NVARCHAR(20),
  lname nvarchar(20),
  gender nvarchar(20),
  subject_ nvarchar(50)
)

create table Pupil(
Student_id NVARCHAR(20) primary key,
  name_p nVarchar(20),
  lname nvarchar(20),
  gender nvarchar(20),
  grade int
)

create table Teacher_Pupil (
Teacher_id nvarchar(20) constraint fk1 foreign key references Teacher(Teacher_id),
Student_id NVARCHAR(20) constraint fk2 foreign key references Pupil(Student_id)
)

insert into Teacher values ('1a','maia','todua','female','math')
insert into Teacher values ('3a','masho','kvirikia','female','art')

insert into Teacher values('4a', 'dato', 'gvari','male','physics')  --does not teach giorgi

insert into Pupil values ('1b','keti', 'kh','female',12)
insert into Pupil values ('2b','giorgi', 'kh','male',12)

select Teacher_id
from Teacher_Pupil tp,Pupil p
where tp.Student_id=p.Student_id and p.name_p like 'giorgi'

truncate table teacher_pupil
