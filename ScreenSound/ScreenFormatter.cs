namespace ScreenSound
{
    public static class ScreenFormatter
    {
        public static void Section(string title, ConsoleColor color)
        {
            var previousColor = Console.ForegroundColor;

            Console.WriteLine();
            Console.ForegroundColor = color;
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine(title.ToUpperInvariant());
            Console.WriteLine("--------------------------------------------------");
            Console.ForegroundColor = previousColor;
        }
    }
}
