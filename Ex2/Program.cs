
namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dati secventa de numere (n): ");
            int n = int.Parse(Console.ReadLine());

            int negativeCount = 0;
            int zeroCount = 0;
            int positiveCount = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1} : ");
                int num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    negativeCount++;
                }
                else
                if (num == 0)
                {
                    zeroCount++;
                }
                else
                {
                    positiveCount++;
                }
            }
            Console.WriteLine($"Numere negative: {negativeCount}");
            Console.WriteLine($"Numere zero: {zeroCount}");
            Console.WriteLine($"Numere pozitive {positiveCount}");

                
        }
    }
}