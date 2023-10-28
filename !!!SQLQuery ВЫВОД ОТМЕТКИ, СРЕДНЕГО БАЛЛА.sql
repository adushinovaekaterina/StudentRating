SELECT A.subject_name AS 'Предмет',
B.grade_value AS 'Моя отметка',
AVG(A.grade_value) AS 'Средний балл в группе',
A.typeOfCertification_name AS 'Вид аттестации',
A.semester_number AS 'Семестр'
FROM
(SELECT Subjects.subject_name,
ROUND(AVG(CASE WHEN ISNUMERIC(Grades.grade_value) = 1 THEN CAST(Grades.grade_value AS decimal) END), 1) AS grade_value,
Types_Of_Certification.typeOfCertification_name,
Semesters.semester_number
FROM Performance
INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id
INNER JOIN Grades ON Performance.grade_id = Grades.grade_id
INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id
INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id
INNER JOIN Students ON Performance.student_id = Students.student_id
INNER JOIN Groups ON Groups.group_id = Students.group_id
WHERE Groups.group_id = 1
GROUP BY Subjects.subject_name,
Types_Of_Certification.typeOfCertification_name,
Semesters.semester_number
) AS A
LEFT JOIN
(SELECT Subjects.subject_name,
Grades.grade_value
FROM
Subjects
INNER JOIN Performance ON Performance.subject_id = Subjects.subject_id
INNER JOIN Grades ON Performance.grade_id = Grades.grade_id
INNER JOIN Students ON Performance.student_id = Students.student_id
INNER JOIN Groups ON Groups.group_id = Students.group_id
WHERE Groups.group_id = 1
AND Students.student_id = 1
GROUP BY
Subjects.subject_name, Grades.grade_value, Students.student_name) AS B ON A.subject_name = B.subject_name
GROUP BY
A.subject_name,
A.typeOfCertification_name,
A.semester_number,
B.grade_value