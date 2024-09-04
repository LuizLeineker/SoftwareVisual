//Testar API: Rest Client - Extensão do VSCODE, SOFTWARE: Postman, Insomnia
using WEB.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapGet("/user", () => "USER: H!!");

app.MapGet("/retornar", () => 
{
    dynamic endereco = new {
        rua = "Deputado Olivio Belich",
        num = 403,
        cep = "83750-000"
    };
    return endereco;
});

List<Produto> produtos =
[
    new Produto(){
        Nome = "Notebook",
        Preco = 5000,
        Quantidade = 54
},
    new Produto(){
        Nome = "Computador",
        Preco = 2900,
        Quantidade = 16
},
    new Produto(){
        Nome = "Batata",
        Preco = 300,
        Quantidade = 6
},
];

//GET
app.MapGet("/produto/list", () => {
    return Results.Ok(produtos);
});

app.MapPost("/produto/cadastrar/{nome}", (string nome) => {
    Produto produto = new Produto();
    produto.Nome = nome;
    produtos.Add(produto);
    return Results.Ok(produtos);
});

//Criar um Funcionalidade para receber informação
// Receber Informação pela URL da req
// Receber informação pelo corpo da req
// Guardar Informação


app.Run();

/*Produto produto = new Produto();

produto.Preco = 5;

Console.WriteLine("Preço: " + produto.Preco);

*/