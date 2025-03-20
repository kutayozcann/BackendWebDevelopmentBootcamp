using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace IdentityAndDataProtection.Entities;

public class UserEntity : IdentityUser
{
    public int Id { get; set; }
    
    [Required] [EmailAddress] public string Email { get; set; }

    [Required] public string Password { get; set; }
}