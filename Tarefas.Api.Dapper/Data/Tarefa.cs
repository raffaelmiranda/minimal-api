using System.ComponentModel.DataAnnotations.Schema;

namespace Tarefas.Api.Dapper.Data;

[Table("Tarefas")]
public record Tarefa(int Id, string Atividade, string Status);


