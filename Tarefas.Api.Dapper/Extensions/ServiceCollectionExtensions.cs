using System.Data.SqlClient;
using static Tarefas.Api.Dapper.Data.TarefaContext;

namespace Tarefas.Api.Dapper.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static WebApplicationBuilder AddPersistence(this WebApplicationBuilder builder)
        {
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            builder.Services.AddScoped<GetConnection>(sp =>
            async () =>
            {
                var connection = new SqlConnection(connectionString);
                await connection.OpenAsync();
                return connection;
            });
            return builder;
        }
    }
}
