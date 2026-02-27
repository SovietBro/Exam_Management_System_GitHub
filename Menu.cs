namespace ExamSystem
{
    public static class Menu
    {
        private static string GetChoice()
        {
            Console.Write("Choose: ");
            return Console.ReadLine();
        }

        public static void Start()
        {
            while (true)
            {
                Console.WriteLine("\n-- Exam_Managmenet_System --");
                Console.WriteLine("1 - Students");
                Console.WriteLine("2 - Teachers");
                Console.WriteLine("3 - Courses");
                Console.WriteLine("4 - Grades");
                Console.WriteLine("5 - Reports");
                Console.WriteLine("0 - Exit");

                string choice = GetChoice();

                if (choice == "1") StudentMenu();
                else if (choice == "2") TeacherMenu();
                else if (choice == "3") CourseMenu();
                else if (choice == "4") GradeMenu();
                else if (choice == "5") ReportMenu();
                else if (choice == "0") break;
            }
        }

        private static void StudentMenu()
        {
            Console.WriteLine("\n1 Add" +
                "\n2 Update" +
                "\n3 Remove" +
                "\n4 View");
            string choice = GetChoice();

            if (choice == "1") StudentService.Add();
            else if (choice == "2") StudentService.Update();
            else if (choice == "3") StudentService.Remove();
            else if (choice == "4") StudentService.ViewAll();
        }

        private static void TeacherMenu()
        {
            Console.WriteLine("\n1 Add" +
                "\n2 Update" +
                "\n3 Remove" +
                "\n4 View");
            string choice = GetChoice();

            if (choice == "1") TeacherService.Add();
            else if (choice == "2") TeacherService.Update();
            else if (choice == "3") TeacherService.Remove();
            else if (choice == "4") TeacherService.ViewAll();
        }

        private static void CourseMenu()
        {
            Console.WriteLine("\n1 Add" +
                "\n2 Update" +
                "\n3 Remove" +
                "\n4 View" +
                "\n5 Assign Teacher");
            string choice = GetChoice();

            if (choice == "1") CourseService.Add();
            else if (choice == "2") CourseService.Update();
            else if (choice == "3") CourseService.Remove();
            else if (choice == "4") CourseService.ViewAll();
            else if (choice == "5") CourseService.AssignTeacher();
        }

        private static void GradeMenu()
        {
            Console.WriteLine("\n1 Add" +
                "\n2 Update" +
                "\n3 Remove" +
                "\n4 View");
            string choice = GetChoice();

            if (choice == "1") GradeService.Add();
            else if (choice == "2") GradeService.Update();
            else if (choice == "3") GradeService.Remove();
            else if (choice == "4") GradeService.ViewAll();
        }

        private static void ReportMenu()
        {
            Console.WriteLine("\n1 Student Grades");
            Console.WriteLine("2 Courses by Teacher");
            Console.WriteLine("3 Students by Course");
            Console.WriteLine("4 Grades by Course");
            Console.WriteLine("5 Student Average");

            string choice = GetChoice();

            if (choice == "1") ReportService.StudentGrades();
            else if (choice == "2") ReportService.CoursesByTeacher();
            else if (choice == "3") ReportService.StudentsByCourse();
            else if (choice == "4") ReportService.GradesByCourse();
            else if (choice == "5") ReportService.StudentAverage();
        }
    }
}