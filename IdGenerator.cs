namespace ExamSystem
{
    public static class IdGenerator
    {
        private static Random random = new Random();

        public static string GenerateId()
        {
            string id = "";

            for (int i = 0; i < 11; i++)
            {
                id += random.Next(0, 10).ToString();
            }

            return id;
        }
    }
}