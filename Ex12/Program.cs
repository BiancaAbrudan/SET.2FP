namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            int stareaAnterioara = 0; 
            int numarGrupuri = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int numar = int.Parse(Console.ReadLine());

                if (numar != 0)
                {
                    if (stareaAnterioara == 0)
                    {
                        numarGrupuri++;
                        stareaAnterioara = 1;
                    }
                }
                else
                {
                    stareaAnterioara = 0;
                }
            }

            Console.WriteLine($"Numarul de grupuri de numere consecutive diferite de zero este: {numarGrupuri}");
        }
    }
}