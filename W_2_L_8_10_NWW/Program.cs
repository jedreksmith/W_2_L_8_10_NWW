namespace W_2_L_8_10_NWW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("obliczanie NWW");

           

            Console.WriteLine("Podaj pierwszą liczbę: ");
            int a= int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj drugą liczbę: ");
            int b = int.Parse(Console.ReadLine());


            int iloczyn = a * b;

            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }


            Console.WriteLine(("Najmniejsza wspolna wielokrotnosc to: ") + iloczyn / a );

        }
    }
}
