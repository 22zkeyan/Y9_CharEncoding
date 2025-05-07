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
        static void Th()
        {
            //convert CHAR_TO_CODE
            Console.WriteLine(Convert.ToInt32('a'));
            //convert CODE_TO_CHAR
            Console.WriteLine(Convert.ToChar(65));
            //convert CHAR_TO_CODE using a procedure
            CHAR_TO_CODE_PROCEDURE(Convert.ToChar(Convert.ToInt32('a')));
            //convert CODE_TO_CHAR using a procedure
            CODE_TO_CHAR_PROCEDURE(Convert.ToInt32('a'));
            //convert CHAR_TO_CODE using a function
            Console.WriteLine(CHAR_TO_CODE_FUNCTION('a'));
            //convert CODE_TO_CHAR using a function
            Console.WriteLine(CODE_TO_CHAR_FUNCTION(65));

            //Challenge 0: convert any input ASCII code to it's character and vice versa

            //Challenge 1: output the ASCII codes for any string input

            //Challenge 2: ouput the Character for any input character codes
        }
        static void CHAR_TO_CODE_PROCEDURE(char myCodeParam)
        {
            int code = Convert.ToInt32(myCodeParam);
            Console.WriteLine(code);
        }
        static void CODE_TO_CHAR_PROCEDURE(int myCodeParam)
        {
            char ch = Convert.ToChar(myCodeParam);
            Console.WriteLine(ch);
        }
        static int CHAR_TO_CODE_FUNCTION(int myCodeParam)
        {
            return Convert.ToInt32(myCodeParam);
        }
        static char CODE_TO_CHAR_FUNCTION(int myCodeParam)
        {
            return Convert.ToChar(myCodeParam);
        }
        static void Thing()
        {
            Console.Write("Please enter an integer x: ");
            string x = Console.ReadLine()!;
            Console.Write("Please enter a second integer y: ");
            string y = Console.ReadLine()!;
            string z = x + y;
            Console.WriteLine("x + y = " +z);
        }
        static void Main(string[] args)
        {
            Th();
        }
    }
}
