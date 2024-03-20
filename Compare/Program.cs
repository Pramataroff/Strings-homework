namespace Compare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter second: ");
            string input2 = Console.ReadLine();

            int sravni = string.Compare(input1, input2, false);
            if (sravni < 0)
            {
                Console.WriteLine("First Input > Second Input");
            }
            if (sravni > 0)
            {
                Console.WriteLine("First Input < Second Input");
            }
            else
            {
                Console.WriteLine("First Input == Second Input");
            }
        }
    }
}
