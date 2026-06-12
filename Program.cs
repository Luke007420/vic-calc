

namespace mathcalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mathmatics Calculator: Type 'help' for commands");

            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine().Trim();
                if (!string.IsNullOrEmpty(input))
                {
                    parseCommand(input);
                }
            }

            
            
        }
        public static void parseCommand(string input)
        {
            string[] parts = input.Split(' ');
            string command = parts[0].ToLower();

            if (command == "help")
            {

            }
            else if (command == "caesaren")
            {
                Crypto.CaesarEncrypt(parts);
            }
            else if (command == "caesarde")
            {
                Crypto.CaesarDecrypt(parts);
            }
            else
            {
                Console.WriteLine("Unknown command type 'help' for commands ");
            }
        }
        

    }
}
