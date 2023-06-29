namespace TilenTask0
{
    public class Program
    {
        public static void Main()
        {
            EvenNumberPrinter printer = new EvenNumberPrinter();

            printer.ReadFromConsole();

            printer.Print();
        }
    }
}
