using System.Data;

namespace Tarefas.Api.Dapper.Data
{
    public class TarefaContext
    {
        public delegate Task<IDbConnection> GetConnection();
    }
}
