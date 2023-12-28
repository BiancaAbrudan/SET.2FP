namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei (n): ");
            int n = int.Parse(Console.ReadLine());

            int lungimeMaxima = 1; 
            int lungimeCurenta = 1;

            int numarPrecedent = 0; 

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Introduceti numarul {i}: ");
                int numar = int.Parse(Console.ReadLine());

                if (numar == numarPrecedent)
                {
                    lungimeCurenta++;
                }
                else
                {
                    lungimeCurenta = 1; 
                }

                if (lungimeCurenta > lungimeMaxima)
                {
                    lungimeMaxima = lungimeCurenta;
                }

                numarPrecedent = numar;
            }

            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este: {lungimeMaxima}");
        }
    }
    
}