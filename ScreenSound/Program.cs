using ScreenSound;

Console.Clear();

/*
Band queen = new Band("Queen");

Album queenAlbum  = new Album("A night at the opera");

Music musicOne = new Music("Love of my life", queen)
{
    Duration = 213,
    Available = true,
};

Music musicTwo = new Music("Bohemian Rhapsody", queen)
{
    Duration = 354,
    Available = false,
};

queenAlbum.AddMusic(musicOne);
queenAlbum.AddMusic(musicTwo);
queen.AddAlbum(queenAlbum);

queenAlbum.ShowAlbumSongs();
musicOne.ViewTechnicalSpecifications();
musicTwo.ViewTechnicalSpecifications();
queen.ViewDiscography();
*/

Podcast podcast = new("João Silva", "Tech Talks");

Episode ep3 = new(3, "Clean Code", 150);
ep3.AddGuests("Robert Martin");
ep3.AddGuests("Kent Beck");

Episode ep1 = new(1, "Introdução à OOP", 120);
ep1.AddGuests("Martin Fowler");

Episode ep2 = new(2, "Padrões de Design", 90);
ep2.AddGuests("Gang of Four");
ep2.AddGuests("Christopher Alexander");

podcast.AddEpisode(ep3);
podcast.AddEpisode(ep1);
podcast.AddEpisode(ep2);
podcast.ShowDetails();

Console.WriteLine("\n--- Resumos dos Episódios ---");
Console.WriteLine(ep1.Resume);
Console.WriteLine(ep2.Resume);
Console.WriteLine(ep3.Resume);