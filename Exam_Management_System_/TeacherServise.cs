namespace ExamSystem
{
    public static class TeacherService
    {
        public static List<Teacher> Teachers = new List<Teacher>();

        public static void Add()
        {
            Teacher teacher = new Teacher();
            teacher.Id = IdGenerator.GenerateId();

            Console.Write("Name: ");
            teacher.Name = Console.ReadLine();

            Console.Write("Email: ");
            teacher.Email = Console.ReadLine();

            Teachers.Add(teacher);

            Console.WriteLine("Teacher added. Id: " + teacher.Id);
        }

        public static void ViewAll()
        {
            foreach (Teacher teacher in Teachers)
            {
                Console.WriteLine("Id: " + teacher.Id +
                " | Name: " + teacher.Name +
                " | Email: " + teacher.Email);
            }
        }

        public static void Remove()
        {
            ViewAll();
            Console.Write("Teacher Id: ");
            string id = Console.ReadLine();

            Teachers.RemoveAll(t => t.Id == id);
        }

        public static void Update()
        {
            ViewAll();
            Console.Write("Teacher Id: ");
            string id = Console.ReadLine();

            foreach (Teacher teacher in Teachers)
            {
                if (teacher.Id == id)
                {
                    Console.Write("New Name: ");
                    teacher.Name = Console.ReadLine();

                    Console.Write("New Email: ");
                    teacher.Email = Console.ReadLine();
                }
            }
        }
    }
}