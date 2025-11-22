namespace ServerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Kory's UVUMajor/UVUFact server application");
            Console.WriteLine("-----------------------------------------------------");

            SynchronousSocketListener listener = new();
            listener.StartSession();
        }
    }
}