namespace Y9_CharEncoding
{
    internal class Program
    {
        static void CharToCodeToChar()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine()!;
            int[] char_codes = new int[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                char_codes[i] = Convert.ToInt32(str[i]);
                Console.WriteLine(str[i] + ": " + char_codes[i]);
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
