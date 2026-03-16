namespace Challenge_4
{
    public class GameCatalog
    {
        private List<Game> _games { get; set; }
        public string CatalogName { get; set; }

        public GameCatalog(string catalogName)
        {
            CatalogName = catalogName;
            _games = [];
        }

        public void AddGame(Game game) => _games.Add(game);

        public void Remove(Game game) => _games.Remove(game);

        public List<Game> ListGames() => _games;
    }
}
