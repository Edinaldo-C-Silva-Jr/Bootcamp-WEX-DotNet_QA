namespace Hospedagem.Models
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string? Sobrenome { get; set; }
        public string NomeCompleto { get { return $"{Nome} {Sobrenome}".ToUpper(); } }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome) 
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}
