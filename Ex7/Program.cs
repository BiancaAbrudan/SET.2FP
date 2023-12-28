namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei (n): ");
            int n = int.Parse(Console.ReadLine());

            int maxim = int.MinValue; 
            int minim = int.MaxValue; 

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int numar = int.Parse(Console.ReadLine());

                
                if (numar > maxim)
                {
                    maxim = numar;
                }

               
                if (numar < minim)
                {
                    minim = numar;
                }
            }

            Console.WriteLine($"Cea mai mare valoare din secventa: {maxim}");
            Console.WriteLine($"Cea mai mică valoare din secventa: {minim}");
        }
    }
}