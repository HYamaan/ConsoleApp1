namespace ConsoleApp1.Helper
{
    public static class ValidChoiceHelper
    {
        public static int GetValidChoice()
        {
            int choice;
            while (true)
            {
                Console.Write("Seciminiz: ");
                string input = ReadOnlyNumbers();
                if (int.TryParse(input, out choice))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Gecersiz giris. Lutfen bir sayi girin.");
                }
            }
            return choice;
        }

        public static int GetValidId()
        {
            int id;
            while (true)
            {
                string input = ReadOnlyNumbers();
                if (int.TryParse(input, out id))
                {
                    break;
                }
            }
            return id;
        }

        private static string ReadOnlyNumbers()
        {
            string input = string.Empty;
            ConsoleKeyInfo key;

            do
            {
                key = Console.ReadKey(intercept: true);
                if (char.IsDigit(key.KeyChar) && key.KeyChar >= '0' && key.KeyChar <= '9')
                {
                    input += key.KeyChar;
                    Console.Write(key.KeyChar);  // Display the character
                }
                else if (key.Key == ConsoleKey.Backspace && input.Length > 0)
                {
                    input = input[0..^1];
                    Console.Write("\b \b");  // Erase the character from the console
                }
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine();  // Move to the next line after pressing Enter
            return input;
        }
    }
}