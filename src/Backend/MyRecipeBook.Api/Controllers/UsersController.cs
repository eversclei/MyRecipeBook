using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication.Requests;

namespace MyRecipeBook.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    [HttpPost]
    public IActionResult Register(RequestUserAccountJson request)
    {
        return Created();
    }
}
