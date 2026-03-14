// TÓPICO 5 DO DESAFIO

namespace Challenge_3
{
    class Order
    {
        public int Id { get; set; }
        public Table? Table { get; set; }
        public List<MenuItem>? Items { get; set; }
        public string? Status { get; set; }
        public decimal Total { get; set; }
    }
}
