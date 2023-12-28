namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul de elemente (n): ");
            int n = int.Parse(Console.ReadLine());

            int nrPare = 0;
            for(int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int numar = int.Parse(Console.ReadLine());
                if (EstePar(numar))
                {
                    nrPare++;
                }
            }

            Console.WriteLine($"Numerele pare sunt: {nrPare}");
        }

        private static bool EstePar(int numar)
        {
            return numar % 2 == 0;
        }
    }
}