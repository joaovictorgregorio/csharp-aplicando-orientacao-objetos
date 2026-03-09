namespace ScreenSound
{
    class Music
    {
        public string? Name { get; set; }
        public string? Artistic { get; set; }
        public int Duration { get; set; }
        public bool Available { get; set; }
        public string? BriefDescription => $"A música {Name} pertence à banda {Artistic}";


        #region VIEW TECHNICAL SPECIFICATIONS
        public void ViewTechnicalSpecifications()
        {
            Console.WriteLine($"Nome: {Name}");
            Console.WriteLine($"Artista: {Artistic}");
            Console.WriteLine($"Duração: {Duration} segundos");

            if (Available == true) Console.WriteLine("Disponível no plano!");
            else Console.WriteLine("Assina o plano Plus");

            Console.WriteLine($"{BriefDescription}");
        }
        #endregion VIEW TECHNICAL SPECIFICATIONS
    }
}
