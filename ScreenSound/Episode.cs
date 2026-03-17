namespace ScreenSound
{
    public class Episode
    {
        public List<string> _guests = [];

        #region CONSTRUCTOR
        public Episode(int order, string title, int duration) 
        {
            Order = order;
            Title = title;
            Duration = duration;
        }
        #endregion CONSTRUCTOR

        public int Order { get; }
        public string Title { get; }
        public int Duration { get; }
        public string Resume => $" \nOrdem: {Order} \nTitulo: {Title} \nDuração: {Duration}s  \nConvidados: {string.Join(", ", _guests)}";

        #region ADD GUESTS
        public void AddGuests(string guest) => _guests.Add(guest);

        #endregion ADD GUESTS
    }
}
