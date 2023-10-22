namespace Hospedagem.Models
{
    /// <summary>
    /// Uma classe que representa uma pessoa, que será um hóspede no hotel.
    /// </summary>
    internal class Pessoa
    {
        /// <summary>
        /// O primeiro nome do hóspede a ser cadastrado.
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// O sobrenome do hóspede a ser cadastrado. Pode ser nulo.
        /// </summary>
        public string? Sobrenome { get; set; }

        /// <summary>
        /// O nome completo do hóspede, que é a junção do primeiro nome com o sobrenome. É sempre retornado em Caps Lock.
        /// </summary>
        public string NomeCompleto { get { return $"{Nome} {Sobrenome}".ToUpper(); } }

        /// <summary>
        /// Construtor para um hóspede com apenas o primeiro nome.
        /// </summary>
        /// <param name="nome">O primeiro nome do hóspede.</param>
        public Pessoa(string nome)
        {
            Nome = nome;
        }

        /// <summary>
        /// Construtor para um hóspede com nome e sobrenome.
        /// </summary>
        /// <param name="nome">O primeiro nome do hóspede.</param>
        /// <param name="sobrenome">O sobrenome do hóspede.</param>
        public Pessoa(string nome, string sobrenome) 
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
    }
}
