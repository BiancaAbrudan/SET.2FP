namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei (n): ");
            int n = int.Parse(Console.ReadLine());

            bool monotonCrescatoare = true;
            bool monotonDescrescatoare = true;

            int prevNum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Introduceti numarul {i}: ");
                int numar = int.Parse(Console.ReadLine());

                if (i > 1)
                {
                    if (numar < prevNum)
                    {
                        monotonCrescatoare = false;
                    }

                    if (numar > prevNum)
                    {
                        monotonDescrescatoare = false;
                    }
                }

                prevNum = numar;
            }

            if (monotonCrescatoare)
            {
                Console.WriteLine("Secventa este monoton crescatoare.");
            }
            else if (monotonDescrescatoare)
            {
                Console.WriteLine("Secventa este monoton descrescatoare.");
            }
            else
            {
                Console.WriteLine("Secventa nu este monotona.");
            }
        }
    
    }
}