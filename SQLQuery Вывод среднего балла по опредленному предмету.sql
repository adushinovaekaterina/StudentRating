SELECT ROUND(AVG(CASE WHEN ISNUMERIC(Grades.grade_value) = 1 THEN CAST(Grades.grade_value AS decimal) END), 1) AS average_grade
FROM Performance 
INNER JOIN Grades ON Performance.grade_id = Grades.grade_id 
INNER JOIN Students ON Performance.student_id = Students.student_id
INNER JOIN Groups ON Groups.group_id = Students.group_id
INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id
WHERE Groups.group_id = 1 
AND Subjects.subject_id = 4