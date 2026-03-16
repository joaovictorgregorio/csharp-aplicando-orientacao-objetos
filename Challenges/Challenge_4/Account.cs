namespace Challenge_4
{
    public class Account
    {
        #region CONSTRUCTOR
        public Account(Holder holder, int agency, int accountNumber, double balance, double limit)
        {
            Holder = holder;
            Agency = agency;
            AccountNumber = accountNumber;
            Balance = balance;
            Limit = limit;
        }
        #endregion CONSTRUCTOR

        public Holder Holder { get; set; }
        public int Agency { get; set; }
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public double? Limit { get; set; }
        public string Information => $" \nConta nº {this.AccountNumber} \nAgência {this.Agency} \nTitular: {this.Holder.Name} \nSaldo: {this.Balance:C}";
    }
}
