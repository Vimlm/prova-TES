using Microsoft.AspNetCore.Mvc;
using victor.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>();
AppDbContext dataContext = new();


var app = builder.Build();

//Cadastrar Funcionário
app.MapPost("api/funcionario/cadastrar", ([FromBody] Funcionario funcionario, [FromServices] AppDbContext context) =>
{
  context.Funcionarios.Add(funcionario);
  context.SaveChanges();
  return Results.Created("Funcionário cadastrado com sucesso", funcionario);
});

// //Listar Funcionários
app.MapGet("/produto/listar", ([FromServices] AppDbContext context) =>
{
  if(context.Funcionarios.Any())
  {
    return Results.Ok(context.Funcionarios.ToList());
  }
  return Results.NotFound("Não existe funcionários cadastrados.");
});

// //Cadastrar folha
app.MapPost("/api/folha/cadastrar", ([FromBody] Folha folha, [FromServices] AppDbContext context) =>
  {
    Funcionario funcionario = new("Martins", "12332132111");
    Folha novaFolha = new(folha.Valor, folha.Quantidade, folha.Mes, folha.Ano, funcionario);

    context.Folhas.Add(novaFolha);
    context.SaveChanges();
    return Results.Created("Folha cadastrada com sucesso", folha);
  }
);

//Listar folhas
app.MapGet("/api/folha/listar", ([FromServices] AppDbContext context) =>
{
  if(context.Folhas.Any())
  {
    return Results.Ok(context.Folhas.ToList());
  }
  return Results.NotFound("Não existe folhas cadastradas.");
});
app.Run();