namespace Ex_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei (n): ");
            int n = int.Parse(Console.ReadLine());

            bool ordineCrescatoare = true;

            for (int i = 1; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i}: ");
                int numarAnterior = int.Parse(Console.ReadLine());

                Console.Write($"Introduceti numarul {i + 1}: ");
                int numarCurent = int.Parse(Console.ReadLine());

                if (numarCurent < numarAnterior)
                {
                    ordineCrescatoare = false;
                    break;
                }
            }

            if (ordineCrescatoare)
            {
                Console.WriteLine("Numerele sunt în ordine crescatoare.");
            }
            else
            {
                Console.WriteLine("Numerele nu sunt în ordine crescatoare.");
            }
        }
    }
}