

namespace mathcalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("Math Calculator");
            Console.WriteLine("You can select what type of calculation\nyou would like to do by pressing the number next to it");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Binary();
                    break;
                case 2:
                    Geometryvector();
                    break;
                case 3:
                    Matrices();
                    break;
                case 4:
                    Numbertheory();
                    break;
                case 5:
                    Crypto();
                    break;
                default:
                    Console.WriteLine("Wrong entry");
                    break;

            }
        }
        public static void Binary()
        {

        }
        public static void Geometryvector()
        {

        }
        public static void Matrices()
        {

        }
        public static void Numbertheory()
        {

        }
        public static void Crypto()
        {

        }

    }
}
