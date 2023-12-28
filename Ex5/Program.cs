namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei (n): ");
            int n = int.Parse(Console.ReadLine());

            int count = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i}: ");
                int numar = int.Parse(Console.ReadLine());

                if (numar == i)
                {
                    count++;
                }
            }

            Console.WriteLine($"Numarul de elemente egale cu pozitia lor în secventa este: {count}");
        }
    }
}