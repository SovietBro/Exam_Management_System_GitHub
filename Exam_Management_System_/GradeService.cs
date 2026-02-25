namespace ExamSystem
{
    public static class GradeService
    {
        public static List<Grade> Grades = new List<Grade>();

        public static void Add()
        {
            Grade grade = new Grade();
            grade.Id = IdGenerator.GenerateId();

            StudentService.ViewAll();
            Console.Write("Student Id: ");
            grade.StudentId = Console.ReadLine();

            CourseService.ViewAll();
            Console.Write("Course Id: ");
            grade.CourseId = Console.ReadLine();

            Console.Write("Score: ");
            grade.Score = double.Parse(Console.ReadLine());

            Grades.Add(grade);

            Console.WriteLine("Grade added. Id: " + grade.Id);
        }

        public static void ViewAll()
        {
            foreach (Grade grade in Grades)
            {
                Console.WriteLine("Id: " + grade.Id +
                " | StudentId: " + grade.StudentId +
                " | CourseId: " + grade.CourseId +
                " | Score: " + grade.Score);
            }
        }

        public static void Remove()
        {
            ViewAll();
            Console.Write("Grade Id: ");
            string id = Console.ReadLine();

            Grades.RemoveAll(g => g.Id == id);
        }

        public static void Update()
        {
            ViewAll();
            Console.Write("Grade Id: ");
            string id = Console.ReadLine();

            foreach (Grade grade in Grades)
            {
                if (grade.Id == id)
                {
                    Console.Write("New Score: ");
                    grade.Score = double.Parse(Console.ReadLine());
                }
            }
        }
    }
}