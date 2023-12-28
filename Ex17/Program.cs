namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti secventa de 0 si 1 (delimitati numerele prin spatiu): ");
            string input = Console.ReadLine();

            string[] inputValues = input.Split(' ');

            int stiva = 0;
            int nivelMaxim = 0;
            bool esteCorecta = true;

            foreach (var valoare in inputValues)
            {
                int numar = int.Parse(valoare);

                if (numar == 0)
                {
                    stiva++;
                    if (stiva > nivelMaxim)
                    {
                        nivelMaxim = stiva;
                    }
                }
                else if (numar == 1)
                {
                    if (stiva > 0)
                    {
                        stiva--;
                    }
                    else
                    {
                        esteCorecta = false;
                        break;
                    }
                }
                else
                {
                    esteCorecta = false;
                    break;
                }
            }

            if (stiva == 0 && esteCorecta)
            {
                Console.WriteLine($"Secventa este corecta și nivelul maxim de încuibare este: {nivelMaxim}");
            }
            else
            {
                Console.WriteLine("Secventa nu este corecta.");
            }
        }
    }
}