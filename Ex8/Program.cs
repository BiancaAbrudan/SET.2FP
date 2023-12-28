namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti valoarea pentru n: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 0)
            {
                Console.WriteLine("n trebuie să fie un numar pozitiv.");
            }
            else
            {
                int fibN = Fibonacci(n);

                Console.WriteLine($"Al {n}-lea numar din sirul lui Fibonacci este: {fibN}");
            }
        }

        static int Fibonacci(int n)
        {
            if (n == 1)
            {
                return 0;
            }
            else if (n == 2)
            {
                return 1;
            }
            else
            {
                int fibNMinus1 = 1;
                int fibNMinus2 = 0;
                int fibN = 0;

                for (int i = 3; i <= n; i++)
                {
                    fibN = fibNMinus1 + fibNMinus2;

                    fibNMinus2 = fibNMinus1;
                    fibNMinus1 = fibN;
                }

                return fibN;
            }
        }
    }
}