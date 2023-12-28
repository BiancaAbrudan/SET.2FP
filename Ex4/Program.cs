namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea secventei (n): ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti numarul cautat (a): ");
            int a = int.Parse(Console.ReadLine());
            int pozitie = -1;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Introduceti numarul {i + 1}");
                int numar = int.Parse(Console.ReadLine());

                if (numar == a)
                {
                    pozitie = i;
                    break;
                }
            }
            Console.WriteLine($"Numarul a se afla pe pozitia: {pozitie}");
        }
    }
}