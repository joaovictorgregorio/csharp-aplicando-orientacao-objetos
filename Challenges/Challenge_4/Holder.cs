namespace Challenge_4
{
    public class Holder
    {
        #region CONSTRUCTOR
        public Holder(string name, string cpf, string? endereco)
        {
            Name = name;
            Cpf = cpf;
            Endereco = endereco;
        }
        #endregion CONSTRUCTOR

        public string Name { get; set; }
        public string Cpf { get; set; }
        public string? Endereco { get; set; }
    }
}
