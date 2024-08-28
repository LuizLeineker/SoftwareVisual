//Testar API: Rest Client - Extensão do VSCODE, SOFTWARE: Postman, Insomnia
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!!");

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


//Criar um Funcionalidade para receber informação
// Receber Informação pela URL da req
// Receber informação pelo corpo da req
// Guardar Informação


app.Run();
