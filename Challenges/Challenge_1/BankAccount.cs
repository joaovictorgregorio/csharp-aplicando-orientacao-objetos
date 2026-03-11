namespace Challenge_1
{
    class BankAccount
    {
        public int IndicatorNumber { get; set; }
        public string? AccountHolder { get; set; }
        public decimal Balance { get; set; }
        public string? Password { get; set; }

        public void ViewAccountDetails()
        {
            Console.Clear();

            Console.WriteLine($"Número Indicador: {IndicatorNumber}");
            Console.WriteLine($"Titular: {AccountHolder}");
            Console.WriteLine($"Saldo: {Balance:C}");
            Console.WriteLine($"Senha: {Password}");
        }
    }
}
