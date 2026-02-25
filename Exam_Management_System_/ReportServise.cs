namespace ExamSystem
{
    public static class ReportService
    {
        public static void StudentGrades()
        {
            StudentService.ViewAll();
            Console.Write("Student Id: ");
            string id = Console.ReadLine();

            foreach (Grade grade in GradeService.Grades)
            {
                if (grade.StudentId == id)
                {
                    foreach (Course course in CourseService.Courses)
                    {
                        if (course.Id == grade.CourseId)
                        {
                            Console.WriteLine(course.Name + " | " + grade.Score);
                        }
                    }
                }
            }
        }

        public static void CoursesByTeacher()
        {
            TeacherService.ViewAll();
            Console.Write("Teacher Id: ");
            string id = Console.ReadLine();

            foreach (Course course in CourseService.Courses)
            {
                if (course.TeacherId == id)
                {
                    Console.WriteLine(course.Name);
                }
            }
        }

        public static void StudentsByCourse()
        {
            CourseService.ViewAll();
            Console.Write("Course Id: ");
            string id = Console.ReadLine();

            foreach (Student student in StudentService.Students)
            {
                if (student.CourseIds.Contains(id))
                {
                    Console.WriteLine(student.Name);
                }
            }
        }

        public static void GradesByCourse()
        {
            CourseService.ViewAll();
            Console.Write("Course Id: ");
            string id = Console.ReadLine();

            foreach (Grade grade in GradeService.Grades)
            {
                if (grade.CourseId == id)
                {
                    Console.WriteLine(grade.Score);
                }
            }
        }

        public static void StudentAverage()
        {
            StudentService.ViewAll();
            Console.Write("Student Id: ");
            string id = Console.ReadLine();

            double sum = 0;
            int count = 0;

            foreach (Grade grade in GradeService.Grades)
            {
                if (grade.StudentId == id)
                {
                    sum += grade.Score;
                    count++;
                }
            }

            if (count > 0)
                Console.WriteLine("Average: " + (sum / count));
        }
    }
}