using Microsoft.AspNetCore.Mvc;

namespace API_ASP.NET_Core_Procedure.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AgendaController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("funcionando");
    }

}
