namespace ScreenSound
{
    class Album
    {
        private List<Music> _songs = [];
        public string? Name { get; set; }
        public int TotalDuration => _songs.Sum(m => m.Duration);

        public void AddMusic(Music music) => _songs.Add(music);

        public void ShowAlbumSongs()
        {
            Console.WriteLine($" Lista de músicas do álbum {Name}: \n");

            foreach (var music in _songs)
            {
                Console.WriteLine($"  Música: {music.Name}");
            }

            Console.WriteLine($"\n Para ouvir este álbum completo é necessário: {TotalDuration} segundos");
        }
    }
}
