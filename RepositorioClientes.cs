using System.Text;

namespace CadastroClienteRepos
{
	public class RepositorioClientes
	{
		public List<Clientes> listaClientes = new List<Clientes>();


		public void CadastrarNome()
		{
			Clientes clientes = new Clientes();

			Random random = new Random();
			clientes.Id = random.Next(10, 1000);
			clientes.Nome = SolicitarNome();
			clientes.DataNascimento = SolicitarDataNasc();
			clientes.DataHoraCadastro = DateTime.Now;
			clientes.Desconto = SolicitarDesconto();

			listaClientes.Add(clientes);
		}


		public string ImprimirClientes()
		{
			StringBuilder clientesBuilder = new StringBuilder();
			foreach (var item in listaClientes)
            {
				clientesBuilder.AppendLine($@"
					ID..............: {item.Id}
					Nome............: {item.Nome}
					Data de Nasc....: {item.DataNascimento:dd/MM/yyyy}
					Data de Cadastro: {item.DataHoraCadastro:dd/MM/yyyy HH:mm:ss}
					Desconto........: {item.Desconto}%");

			}
			return clientesBuilder.ToString();
		}


		public void ExcluirCliente() 
		{
			Console.WriteLine("Informe o ID do cliente:");
            if (!int.TryParse(Console.ReadLine(), out int idPesquisa))
            {
                Console.WriteLine("ID inválido. Por favor informe um ID válido."); return;
            }

            if (!listaClientes.Any(c => c.Id == idPesquisa))
            {
				Console.WriteLine("Cliente não encontrado"); return;
            }
			listaClientes.RemoveAll(c => c.Id == idPesquisa);
			Console.WriteLine("Cliente removido com sucesso.");

        }






		public string SolicitarNome()
		{
			Console.WriteLine("Informe seu nome:");
			return Console.ReadLine();
		}
		public DateOnly SolicitarDataNasc()
		{
			Console.WriteLine("Informe data nasc:");
			return DateOnly.Parse(Console.ReadLine());
		}
		public decimal SolicitarDesconto()
		{
			Console.WriteLine("Informe desconto:");
			return Decimal.Parse(Console.ReadLine());
		}

	}
}
