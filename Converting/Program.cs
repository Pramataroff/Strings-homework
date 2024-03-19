namespace Converting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter broina sistema: ");
            int baseNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());

            string result = "";

            while (num > 0)
            {
                int remainder = num % baseNumber;
                result = remainder.ToString() + result;
                num /= baseNumber;
            }
            Console.WriteLine(result);
        }
    }
}
