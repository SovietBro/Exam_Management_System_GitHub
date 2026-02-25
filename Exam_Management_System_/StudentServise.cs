namespace ExamSystem
{
    public static class StudentService
    {
        public static List<Student> Students = new List<Student>();

        public static void Add()
        {
            Student student = new Student();
            student.Id = IdGenerator.GenerateId();

            Console.Write("Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Age: ");
            student.Age = int.Parse(Console.ReadLine());

            Students.Add(student);

            Console.WriteLine("Student added. Id: " + student.Id);
        }

        public static void ViewAll()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine("Id: " + student.Id +
                " | Name: " + student.Name +
                " | Age: " + student.Age);
            }
        }

        public static void Remove()
        {
            ViewAll();
            Console.Write("Student Id: ");
            string id = Console.ReadLine();

            Students.RemoveAll(s => s.Id == id);
        }

        public static void Update()
        {
            ViewAll();
            Console.Write("Student Id: ");
            string id = Console.ReadLine();

            foreach (Student student in Students)
            {
                if (student.Id == id)
                {
                    Console.Write("New Name: ");
                    student.Name = Console.ReadLine();

                    Console.Write("New Age: ");
                    student.Age = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}