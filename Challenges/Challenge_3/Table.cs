// TÓPICO 5 DO DESAFIO

namespace Challenge_3
{
    class Table
    {
        public int Number { get; set; }
        public int Seats { get; set; }
        public bool isReserved { get; set; }
        public List<Order>? Orders { get; set; }
    }
}
