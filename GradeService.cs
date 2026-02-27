namespace ExamSystem
{
    public static class GradeService
    {
        public static List<Grade> Grades = new List<Grade>();

        public static void Add()
        {
            Grade grade = new Grade();

            StudentService.ViewAll();
            Console.Write("Student Id: ");
            grade.StudentId = Console.ReadLine();

            CourseService.ViewAll();
            Console.Write("Course Id: ");
            grade.CourseId = Console.ReadLine();

            Console.Write("Score: ");
            grade.Score = double.Parse(Console.ReadLine());

            Grades.Add(grade);

            Console.WriteLine("Grade added.");
        }

        public static void ViewAll()
        {
            foreach (Grade grade in Grades)
            {
                Console.WriteLine("StudentId: " + grade.StudentId +
                                  " | CourseId: " + grade.CourseId +
                                  " | Score: " + grade.Score);
            }
        }

        public static void Remove()
        {
            ViewAll();
            Console.Write("Student Id: ");
            string studentId = Console.ReadLine();

            Console.Write("Course Id: ");
            string courseId = Console.ReadLine();

            Grades.RemoveAll(g =>
                g.StudentId == studentId &&
                g.CourseId == courseId);
        }

        public static void Update()
        {
            ViewAll();
            Console.Write("Student Id: ");
            string studentId = Console.ReadLine();

            Console.Write("Course Id: ");
            string courseId = Console.ReadLine();

            foreach (Grade grade in Grades)
            {
                if (grade.StudentId == studentId &&
                    grade.CourseId == courseId)
                {
                    Console.Write("New Score: ");
                    grade.Score = double.Parse(Console.ReadLine());
                }
            }
        }
    }
}