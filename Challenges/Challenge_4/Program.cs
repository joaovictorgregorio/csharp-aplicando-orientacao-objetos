using Challenge_4;

Holder accountHolder = new Holder("João Victor", "999111234-45", null);

Account bankAccount = new Account(accountHolder, 0004, 0685853, 78000, 120000);
Console.WriteLine(bankAccount.Information);