namespace ScreenSound
{
    class Band
    {
        private List<Album> _albums = [];

        #region CONSTRUCTOR
        public Band(string bandName) => BandName = bandName;

        #endregion CONSTRUCTOR

        public string? BandName { get; }

        #region ADD ALBUM
        public void AddAlbum(Album album) => _albums.Add(album);

        #endregion ADD ALBUM

        #region VIEW DISCOGRAPHY
        public void ViewDiscography()
        {
            ScreenFormatter.Section($"Discografia da banda {BandName}", ConsoleColor.Green);

            foreach (Album album in _albums)
            {
                Console.WriteLine($" Álbum: {album.AlbumName} com duração total de ({album.TotalDuration}) segundos");
            }
        }
        #endregion VIEW DISCOGRAPHY
    }
}
