using ScreenSound;

Console.Clear();

Album queenAlbum  = new Album();
queenAlbum.Name = "A night at the opera";

Music musicOne = new Music();
musicOne.Name = "Love of my life";
musicOne.Duration = 213;

Music musicTwo = new Music();
musicTwo.Name = "Bohemian Rhapsody";
musicTwo.Duration = 354;

queenAlbum.AddMusic(musicOne);
queenAlbum.AddMusic(musicTwo);

queenAlbum.ShowAlbumSongs();