namespace CadastroClienteRepos
{
	public class Clientes
	{
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public DateTime DataHoraCadastro{ get; set; }
        public decimal Desconto { get; set; }
    }
}
