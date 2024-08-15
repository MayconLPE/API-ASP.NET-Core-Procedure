using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_ASP.NET_Core_Procedure.Models;

namespace API_ASP.NET_Core_Procedure.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<UserResponse>> BuscarUser();
        Task<UserResponse> BuscarUserId(int id);
        Task<bool> AdicionarUser(UserRequest request);
        Task<bool> AtualizarUser(UserRequest request, int id);
        Task<bool> DeletarUser(int id);
    }
}