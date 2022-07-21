
namespace RequstHTTP
{
    internal class Tarefa
    {
        public int userId;
        public int id;
        public string title;
        public bool completed;

        public void Exibir()
        {
            Console.WriteLine($"\nUser ID: {userId}");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Completed? {completed}\n");
            Console.WriteLine("=========================");
        }

    }
}
