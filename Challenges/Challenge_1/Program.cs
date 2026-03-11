using Challenge_1;

BankAccount accountType = new BankAccount();

accountType.IndicatorNumber = 12;
accountType.AccountHolder = "João Victor";
accountType.Balance = 56000;
accountType.Password = "12345678";
accountType.ViewAccountDetails();

//Console.WriteLine($"Titular: {accountType.AccountHolder} \nSaldo: {accountType.Balance:C}");

Console.WriteLine();

Car car = new Car();

car.Accelerate();
car.Brake();
car.Honk();