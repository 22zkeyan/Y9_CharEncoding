namespace Y9_CharEncoding
{
    internal class Program
    {
        static void CharToCodeToChar()
        {
            Console.WriteLine("Type a number: \n" +
                " 1. Char to code \n" + 
                " 2. Code to char \n");
            Console.Write("Option: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.Write("Enter a string: ");
                    string str = Console.ReadLine()!; //prompts the user to enter a string
                    int[] char_codes = new int[str.Length]; //creates a new list of integers for all the ASCII character codes in the string
                    for (int i = 0; i < str.Length; i++) //repeats for the length of the string
                    {
                        char_codes[i] = Convert.ToInt32(str[i]); //stores the current character in the array, converted into integers to give the ASCII codes
                        Console.WriteLine(str[i] + ": " + char_codes[i]); //writes out each code for its corresponding character
                    }
                    break;

                case 2:
                    Console.Write("Enter an ASCII character code: ");
                    int code = Convert.ToInt32(Console.ReadLine());
                    char ch = Convert.ToChar(code);
                    Console.WriteLine((code) + ": " + ch);
                    break;

                default:
                    Console.WriteLine("Unhandled exception. Leave.");
                    break;
            }
        }
        static void Thing()
        {
            Console.Write("Please enter an integer x: ");
            int x = Convert.ToInt32(Console.ReadLine()!);
            Console.Write("Please enter a second integer y: ");
            int y = Convert.ToInt32(Console.ReadLine()!);
            int z = x + y;
            Console.WriteLine("x + y = " +z);
        }
        static void Main(string[] args)
        {
            CharToCodeToChar();
        }
    }
}
