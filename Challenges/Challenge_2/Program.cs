using Challenge_2;

Console.Clear();

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n DADOS DO VEICULO \n");
Console.ResetColor();

Car car = new Car();
car.Manufacturer = "Fiat";
car.Model = "Fiat Uno";
car.Year = 2000;
Console.WriteLine(car.DetailedDescription);

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n DADOS DO PRODUTO \n");
Console.ResetColor();

Product product = new Product();
product.Name = "Vassoura";
product.Brand = "Phillips";
product.Price = 100;
product.Stock = 5;
Console.WriteLine(product.ProductDetails);

// Refatoração função usando lambda
Console.WriteLine();

int Somar(int a, int b) => a + b;
Console.WriteLine($"O resultado da soma é: {Somar(5, 10)}");