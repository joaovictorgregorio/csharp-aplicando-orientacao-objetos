namespace Challenge_3
{
    class BankAccount
    {
        public Holder? Holder { get; set; }
        public int Agency { get; set; }
        public string? AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public decimal Limit { get; set; }

        public void ShowAccountInformation()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@" 
                INFORMAÇÕES DA CONTA");
            Console.ResetColor();

            Console.WriteLine(@$"  
                Titular: {Holder?.Name}
                Agência: {Agency}
                Número da Conta: {AccountNumber}
                Saldo: {Balance:C}
                Limite Disponível: {Limit:C}");
        }
    }
}
