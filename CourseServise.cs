namespace ExamSystem
{
    public static class CourseService
    {
        public static List<Course> Courses = new List<Course>();

        public static void Add()
        {
            Course course = new Course();
            course.Id = IdGenerator.GenerateId();

            Console.Write("Course Name: ");
            course.Name = Console.ReadLine();

            Console.Write("Description: ");
            course.Description = Console.ReadLine();

            Courses.Add(course);

            Console.WriteLine("Course added. Id: " + course.Id);
        }

        public static void ViewAll()
        {
            foreach (Course course in Courses)
            {
                string teacherName = "None";

                foreach (Teacher teacher in TeacherService.Teachers)
                {
                    if (teacher.Id == course.TeacherId)
                        teacherName = teacher.Name;
                }

                Console.WriteLine("Id: " + course.Id +
                " | Name: " + course.Name +
                " | Teacher: " + teacherName);
            }
        }

        public static void Remove()
        {
            ViewAll();
            Console.Write("Course Id: ");
            string id = Console.ReadLine();

            Courses.RemoveAll(c => c.Id == id);
        }

        public static void Update()
        {
            ViewAll();
            Console.Write("Course Id: ");
            string id = Console.ReadLine();

            foreach (Course course in Courses)
            {
                if (course.Id == id)
                {
                    Console.Write("New Name: ");
                    course.Name = Console.ReadLine();

                    Console.Write("New Description: ");
                    course.Description = Console.ReadLine();
                }
            }
        }

        public static void AssignTeacher()
        {
            ViewAll();
            Console.Write("Course Id: ");
            string courseId = Console.ReadLine();

            TeacherService.ViewAll();
            Console.Write("Teacher Id: ");
            string teacherId = Console.ReadLine();

            foreach (Course course in Courses)
            {
                if (course.Id == courseId)
                    course.TeacherId = teacherId;
            }
        }
    }
}