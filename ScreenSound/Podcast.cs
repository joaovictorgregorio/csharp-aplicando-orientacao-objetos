using static System.Net.WebRequestMethods;

namespace ScreenSound
{
    public class Podcast
    {
        private List<Episode> _episodes = [];

        #region CONSTRUCTOR
        public Podcast(string host, string name)
        {
            Host = host;
            Name = name;
        }
        #endregion CONSTRUCTOR

        public string Host { get; }
        public string Name { get; }
        public int TotalEpisodes => _episodes.Count;

        #region ADD EPISODE
        public void AddEpisode(Episode episode) => _episodes.Add(episode);

        #endregion ADD EPISODE

        #region SHOW DETAILS
        public void ShowDetails() 
        {
            ScreenFormatter.Section($" Podcast: {Name} | Host: {Host} |", ConsoleColor.Yellow);

            var episodesOrdered = _episodes.OrderBy(e => e.Order).ToList();

            foreach (Episode episode in episodesOrdered)
            {
                Console.WriteLine($"  Episódio {episode.Order}: {episode.Title} | Duração: {episode.Duration}s");
            }

            Console.WriteLine($"\nTotal de episódios: {TotalEpisodes}");
        }
        #endregion SHOW DETAILS
    }
}
