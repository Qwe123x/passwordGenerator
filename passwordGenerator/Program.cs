namespace passwordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" [>] Enter password lenght: ");
            var lenght = Convert.ToInt32(Console.ReadLine());

            var sym = @"QWERTYUIOPASDFGHJKLZXCVBNMqwertyuiop[]asdfghjkl;'\zxcvbnm,./1234567890-=!@#$%^&*()_+";
            Random random = new Random();
            var stringChars = new char[lenght];

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = sym[random.Next(sym.Length)];
            }

            var finalString = new String(stringChars);
            Console.WriteLine($" [*] Password: {finalString}");
        }
    }
}