SELECT Students.Student_name, Subjects.subject_name, Grades.grade_value FROM Performance 
INNER JOIN Grades ON Performance.grade_id = Grades.grade_id
INNER JOIN Students ON Students.student_id = Performance.student_id
INNER JOIN Groups ON Groups.group_id = Students.group_id
INNER JOIN Subjects ON Subjects.subject_id = Performance.subject_id
where Groups.group_id = 1
