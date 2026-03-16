using ScreenSound;

Console.Clear();

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