namespace projetoConsumoAPI
{
    public class tarefa
    {
        public int userId;
        public int id;
        public string title;
        public bool completed;

        public void Exibir()
        {
            Console.WriteLine("");
            Console.WriteLine("Objeto Tarefa");
            Console.WriteLine($"User id: {userId}");
            Console.WriteLine($"id: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Finalizou? {completed}");
            Console.WriteLine("");
            Console.WriteLine("=================================");
        }
    }
}