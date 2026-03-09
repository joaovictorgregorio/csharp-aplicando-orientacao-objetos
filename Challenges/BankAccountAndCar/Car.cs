namespace BankAccountAndCar
{
    class Car
    {
        public void Accelerate()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Acelerando o carro!");
            Console.ResetColor();
        }

        public void Brake()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Freando o carro!");
            Console.ResetColor();
        }

        public void Honk()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Buzinando o carro!");
            Console.ResetColor();
        }
    }
}
