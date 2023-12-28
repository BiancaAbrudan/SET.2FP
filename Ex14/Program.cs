namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            int stareaAnterioara = 0; 
            bool esteMonotonaRotita = true;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int numar = int.Parse(Console.ReadLine());

                if (i > 0)
                {
                    if (numar < stareaAnterioara)
                    {
                        esteMonotonaRotita = false;
                        break;
                    }
                    else if (numar > stareaAnterioara)
                    {
                        stareaAnterioara = numar;
                    }
                }
                else
                {
                    stareaAnterioara = numar;
                }
            }

            if (esteMonotonaRotita)
            {
                Console.WriteLine("Secventa este o secventa monotona rotita.");
            }
            else
            {
                Console.WriteLine("Secventa nu este o secventa monotona rotita.");
            }
        }
    }
    
}