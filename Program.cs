//Gerando Builder
using CadastroClienteRepos;
using DemoVS;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();


//RepositorioClientes repositorioClientes = new RepositorioClientes();
//repositorioClientes.CadastrarNome();
//string msg = repositorioClientes.ImprimirClientes();

app.UseMiddleware<MeuMiddleware>();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGet("/", async context =>
    {
        await context.Response.WriteAsync("Olá, mundo!");
    });
});

//Configurações de comportamento
//app.MapGet("/", () => msg);


app.Run();
