using Microsoft.AspNetCore.Mvc;
using victor.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

AppDbContext dataContext = new();


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}


// //Cadastrar Funcionário
// app.MapPost("/api/funcionario/cadastrar", ([FromRoute] string nome, [FromRoute] string cpf, [FromServices] AppDbContext context) =>
//   {
//     Funcionario funcionario = new(nome, cpf);
//     context.Funcionarios.Add(funcionario);
//     context.SaveChanges();
//     return Results.Created("Funcionário inserido com sucesso", funcionario);
//   }
// );

// //Listar Funcionários
// app.MapGet("/produto/listar", ([FromServices] AppDbContext context) =>
// {
//   if(context.Funcionarios.Any())
//   {
//     return Results.Ok(context.Funcionarios.ToList());
//   }
//   return Results.NotFound("Não existe funcionários cadastrados.");
// });

// //Cadastrar folha
// app.MapPost("/api/folha/cadastrar", ([FromRoute] double valor, [FromRoute] double quantidade, [FromRoute] int mes, [FromRoute] int ano, [FromRoute] int funcionario, [FromServices] AppDbContext context) =>
//   {
//     Folha folha = new(valor, quantidade, mes, ano, funcionario);
//     context.Folhas.Add(folha);
//     context.SaveChanges();
//     return Results.Created("Folha cadastrada com sucesso", folha);
//   }
// );

// //Listar folhas
// app.MapGet("/api/folha/listar", ([FromServices] AppDbContext context) =>
// {
//   if(context.Folhas.Any())
//   {
//     return Results.Ok(context.Folhas.ToList());
//   }
//   return Results.NotFound("Não existe folhas cadastradas.");
// });

// app.MapGet("/api/folha/buscar/{cpf}/{mes}/{ano}", ([FromRoute] string cpf, [FromRoute] string mes, [FromRoute] string ano,[FromServices] AppDbContext context) =>
//   {

//     Folha? folha = context.Folhas.Find(id);

//     if (produto is null)
//     {
//       return Results.NotFound("Produto não encontrado.");
//     }

//     return Results.Ok(produto);
//   }
// );
app.Run();