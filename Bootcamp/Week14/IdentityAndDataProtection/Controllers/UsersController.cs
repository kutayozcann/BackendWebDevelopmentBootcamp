using IdentityAndDataProtection.DTO;
using IdentityAndDataProtection.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityAndDataProtection.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly UserManager<UserEntity> _userManager;

    public UsersController(UserManager<UserEntity> userManager)
    {
        _userManager = userManager;
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] RegisterUserDto model)
    {
        if (!ModelState.IsValid) return BadRequest(ModelState);

        var user = new UserEntity()
        {
            Email = model.Email,
            UserName = model.Email,
        };
        
        var result = await _userManager.CreateAsync(user, model.Password);
        
        if (!result.Succeeded) return BadRequest(result.Errors);
        
        return Ok(new {message = "User created successfully"});
    }
}