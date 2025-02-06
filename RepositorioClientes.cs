using System.Text;

namespace CadastroClienteRepos
{
	public class RepositorioClientes
	{
		static Clientes clientes = new Clientes();
		public List<Clientes> listaClientes = new List<Clientes>();
		public void CadastrarNome()
		{
			
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



		public void ExibirClientes()
		{
            if (listaClientes != null)
            {
                foreach (var clientes in listaClientes)
                {
					//ImprimirClientes(clientes);
                }
            }
            else
            {
				Console.WriteLine("Lista de clientes vazia.");
            }
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
