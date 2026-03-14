namespace ScreenSound
{
    class Album
    {
        private List<Music> _songs = [];
        public string? Name { get; set; }
        public int TotalDuration => _songs.Sum(m => m.Duration);

        #region ADD MUSIC
        public void AddMusic(Music music) => _songs.Add(music);

        #endregion ADD MUSIC

        #region SHOW ALBUM SONGS
        public void ShowAlbumSongs()
        {
            Console.WriteLine($" Lista de músicas do álbum {Name}: \n");

            foreach (var music in _songs)
            {
                Console.WriteLine($"  Música: {music.Name}");
            }

            Console.WriteLine($"\n Para ouvir este álbum completo é necessário: {TotalDuration} segundos");
        }
        #endregion SHOW ALBUM SONGS
    }
}
