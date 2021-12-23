using Tarefas.Api.Dapper.Endpoint;
using Tarefas.Api.Dapper.Extensions;

var builder = WebApplication.CreateBuilder(args);
builder.AddPersistence();

var app = builder.Build();
app.MapTarefasEndpoints();


app.Run();
