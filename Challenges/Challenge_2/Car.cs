namespace Challenge_2
{
    class Car
    {
        public string? Brand { get; set; }
        public string? Model { get; set; }

        private int _year;
        public int Year 
        {
            get => _year;
            set
            {
                if (value < 1960 || value > 2023)
                    throw new ArgumentOutOfRangeException(nameof(Year), "O ano deve estar entre 1960 e 2023.");
                _year = value;
            }
        }

        public string? Manufacturer { get; set; }
        public string? Color { get; set; }
        public double Price { get; set; }
        public double Mileage { get; set; }
        public int NumberOfDoors { get; set; }
        public string? FuelType { get; set; }
        public string DetailedDescription => $"Fabricante: {Manufacturer} \nModelo: {Model} \nAno: {Year}";
    }
}
