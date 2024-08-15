using API_ASP.NET_Core_Procedure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API_ASP.NET_Core_Procedure.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserRepository _repository;

    public UserController(IUserRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var users = await _repository.BuscarUser();
        return users.Any() ? Ok(users) : NoContent();
    }

}
