//Gerando Builder
using CadastroClienteRepos;

var builder = WebApplication.CreateBuilder(args);
//Pipelines
//Middlewares
//Services

//Application
var app = builder.Build();

RepositorioClientes repositorioClientes = new RepositorioClientes();
repositorioClientes.CadastrarNome();
string msg = repositorioClientes.ImprimirClientes();

//Configurações de comportamento
app.MapGet("/", () => msg);


app.Run();
