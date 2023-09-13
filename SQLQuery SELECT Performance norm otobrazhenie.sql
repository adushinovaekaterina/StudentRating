﻿SELECT Students.student_name, Subjects.subject_name, Grades.grade_value, Types_Of_Certification.typeOfCertification_name, Semesters.semester_number FROM Performance INNER JOIN Students ON Performance.student_id = Students.student_id INNER JOIN Subjects ON Performance.subject_id = Subjects.subject_id INNER JOIN Grades ON Performance.grade_id = Grades.grade_id INNER JOIN Types_Of_Certification ON Performance.typeOfCertification_id = Types_Of_Certification.typeOfCertification_id INNER JOIN Semesters ON Performance.semester_id = Semesters.semester_id