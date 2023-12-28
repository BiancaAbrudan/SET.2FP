namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti lungimea secventei: ");
            int n = int.Parse(Console.ReadLine());

            int stareaAnterioara = 0;
            bool esteBitonica = true;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti numarul {i + 1}: ");
                int numar = int.Parse(Console.ReadLine());

                if (i > 0)
                {
                    if (stareaAnterioara == 0)
                    {
                        if (numar > stareaAnterioara)
                        {
                            stareaAnterioara = 1;
                        }
                        else if (numar < stareaAnterioara)
                        {
                            esteBitonica = false;
                            break;
                        }
                    }
                    else if (stareaAnterioara == 1)
                    {
                        if (numar < stareaAnterioara)
                        {
                            stareaAnterioara = -1;
                        }
                        else if (numar == stareaAnterioara)
                        {
                            stareaAnterioara = 0;
                        }
                    }
                    else if (stareaAnterioara == -1)
                    {
                        if (numar >= stareaAnterioara)
                        {
                            esteBitonica = false;
                            break;
                        }
                    }
                }
                else
                {
                    stareaAnterioara = 0;
                }
            }

            if (esteBitonica)
            {
                Console.WriteLine("Secventa este bitonica.");
            }
            else
            {
                Console.WriteLine("Secventa nu este bitonica.");
            }
        }
    }
}