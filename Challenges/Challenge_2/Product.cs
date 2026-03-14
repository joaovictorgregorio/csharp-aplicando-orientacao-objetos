namespace Challenge_2
{
    class Product
    {
        public string? Name { get; set; }
        public string? Brand { get; set; }

        private double _price;
        public double Price
        {
            get => _price;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Price), "O preço deve ser um valor positivo.");
                _price = value;
            }
        }

        private int _stock;
        public int Stock
        {
            get => _stock;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException(nameof(Stock), "O estoque deve ser um valor positivo.");
                _stock = value;
            }
        }

        public string? ProductDetails => $"Nome: {Name} \nMarca: {Brand} \nPreço: {Price:C} \nEstoque: {Stock}";
    }
}
