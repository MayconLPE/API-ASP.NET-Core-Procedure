using API_ASP.NET_Core_Procedure.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace API_ASP.NET_Core_Procedure.Repository;

public class UserRepository : IUserRepository
{
    private readonly IConfiguration _configuration;
    private readonly string connectionString;
    public UserRepository(IConfiguration configuration)
    {
        _configuration = configuration;
        connectionString = _configuration.GetConnectionString("SqlConnection");
    }

    public async Task<IEnumerable<UserResponse>> BuscarUser()
    {
        string sql = @"	SELECT id, name, texto
	                    FROM tb_user;";
        using (var con = new SqlConnection(connectionString))
        {
            return await con.QueryAsync<UserResponse>(sql);
        }

    }

    public Task<UserResponse> BuscarUserId(int id)
    {
        throw new NotImplementedException();
    }
    public Task<bool> AdicionarUser(UserRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<bool> AtualizarUser(UserRequest request, int id)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeletarUser(int id)
    {
        throw new NotImplementedException();
    }
}
