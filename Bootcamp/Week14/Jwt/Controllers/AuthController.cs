using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Jwt.Context;
using Jwt.Models;
using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Jwt.Controllers;

[Route("api/auth")]
[ApiController]
public class AuthController : ControllerBase
{
    private readonly JwtDbContext _context;
    private readonly IConfiguration _configuration;

    public AuthController(JwtDbContext context, IConfiguration configuration)
    {
        _context = context;
        _configuration = configuration;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] User loginUser)
    {
        var user = _context.Users.SingleOrDefault(u => u.Email == loginUser.Email && u.Password == loginUser.Password);
        if(user == null) return Unauthorized();

        var tokenHandler = new JwtSecurityTokenHandler();
        var key = Encoding.ASCII.GetBytes(_configuration["JWT:Key"]);
        var tokenDesc = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Email, user.Email) }),
            Expires = DateTime.UtcNow.AddHours(1),
            SigningCredentials =
                new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
        };
        var token = tokenHandler.CreateToken(tokenDesc);
        return Ok(new { token = tokenHandler.WriteToken(token) });
    }
}