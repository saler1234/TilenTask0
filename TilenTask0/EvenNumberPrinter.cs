namespace TilenTask0
{
    public class EvenNumberPrinter
    {
        private int number;

        public void ReadFromConsole()
        {
            Console.Write("Enter a positive whole number: ");
            // If can't be parsed, notify that input is invalid and to try again
            while (!Int32.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.Write("Invalid input, please enter a positive whole number: ");
            }
        }

        public void Print()
        {
            Console.WriteLine("Even numbers from 0 to {0} are: ", number);
            // We should output all even number from 0 to n, but as we all know, 0 is neither negative nor positive
            // so we have to start with 1 instead 
            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}