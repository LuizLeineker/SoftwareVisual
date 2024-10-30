//Testar API: Rest Client - Extensão do VSCODE, SOFTWARE: Postman, Insomnia
using WEB.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(options => 
    options.AddPolicy("Acesso Total", configs => configs
        .AllowAnyOrigin()
        .AllowAnyHeader()
        .AllowAnyMethod())
);
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
    if(produtos.Count > 0){
        return Results.Ok(produtos);
    }

    return Results.NotFound();
});

app.MapGet("/produto/buscar/{nome}", (string nome) => {
    foreach(Produto produtoIndex in produtos){
        if(produtoIndex.Nome == nome){
            return Results.Ok(produtoIndex);
        }
    }
    return Results.NotFound();
});

app.MapPost("/produto/cadastrar/", ([FromBody]Produto produto) => {
    
    
    produtos.Add(produto);
    return Results.Created("", produto);
});

app.MapGet("/produto/remove/{nome}", (string nome) => {
    int i = 0;
    foreach(Produto produtoIndex in produtos){
        if(produtoIndex.Nome == nome){
            produtos.RemoveAt(i);
            return Results.Ok();
        }
        i++;
    }
    return Results.NotFound();
});


app.MapPost("/produto/update/{nome}", ([FromBody]Produto produto, string nome) => {
    int i = 0;
    foreach(Produto produtoIndex in produtos){
        if(produtoIndex.Nome == nome){
            produtos.RemoveAt(i);
            produtos.Add(produto);
            return Results.Created("", produto);
        }
        i++;
    }
    return Results.NotFound();
    
});


//Criar um Funcionalidade para receber informação
// Receber Informação pela URL da req
// Receber informação pelo corpo da req
// Guardar Informação

app.UseCors("Acesso Total");

app.Run();

/*Produto produto = new Produto();

produto.Preco = 5;

Console.WriteLine("Preço: " + produto.Preco);

*/