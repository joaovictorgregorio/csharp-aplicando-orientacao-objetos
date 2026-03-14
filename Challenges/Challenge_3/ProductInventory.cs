namespace Challenge_3
{
    class ProductInventory
    {
        public int Code { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Category { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        private List<ProductInventory> _products = [];
        public void AddProduct(ProductInventory product)
        {
            _products.Add(product);
            Console.WriteLine($"Produto '{product.Name}' adicionado ao estoque!");
        }

        public void DisplayProducts()
        {
            if (_products.Count == 0)
            {
                Console.WriteLine("Nenhum produto cadastrado no estoque.");
                return;
            }

            Console.WriteLine("\n===== PRODUTOS EM ESTOQUE =====");
            foreach (var product in _products)
            {
                Console.WriteLine($"[{product.Code}] {product.Name}");
                Console.WriteLine($"    Categoria  : {product.Category}");
                Console.WriteLine($"    Descrição  : {product.Description}");
                Console.WriteLine($"    Preço      : {product.Price:C}");
                Console.WriteLine($"    Quantidade : {product.Quantity}");
                Console.WriteLine(new string('-', 35));
            }
        }
    }
}
