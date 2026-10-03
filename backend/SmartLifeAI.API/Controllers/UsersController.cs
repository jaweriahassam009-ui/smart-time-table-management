using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartLifeAI.API.Data;
using SmartLifeAI.API.Models;

namespace SmartLifeAI.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public UsersController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Users
    // Returns users WITHOUT their passwords
    [HttpGet]
    public async Task<ActionResult<IEnumerable<object>>> GetUsers()
    {
        var users = await _context.Users
            .Select(u => new
            {
                u.UserID,
                u.Name,
                u.Email,
                u.UserType,
                u.CreatedAt
            })
            .ToListAsync();

        return Ok(users);
    }

    // POST: api/Users
    [HttpPost]
    public async Task<ActionResult<User>> CreateUser(User user)
    {
        user.UserID = await GetNextUserID();
        user.CreatedAt = DateTime.Now;

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetUsers), new { id = user.UserID }, user);
    }

    // POST: api/Users/login
    [HttpPost("login")]
    public async Task<ActionResult<User>> Login(LoginRequest request)
    {
        var user = await _context.Users
            .FirstOrDefaultAsync(u =>
                u.Email == request.Email &&
                u.Password == request.Password);

        if (user == null)
        {
            return Unauthorized("Invalid email or password.");
        }

        return Ok(new
        {
            user.UserID,
            user.Name,
            user.Email,
            user.UserType,
            user.CreatedAt
        });
    }

    // POST: api/Users/register
    [HttpPost("register")]
    public async Task<ActionResult<User>> Register(RegisterRequest request)
    {
        var existingUser = await _context.Users
            .FirstOrDefaultAsync(u => u.Email == request.Email);

        if (existingUser != null)
        {
            return BadRequest("An account with this email already exists.");
        }

        var user = new User
        {
            UserID = await GetNextUserID(),
            Name = request.Name,
            Email = request.Email,
            Password = request.Password,
            UserType = request.UserType,
            CreatedAt = DateTime.Now
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync();

        return Ok(new
        {
            user.UserID,
            user.Name,
            user.Email,
            user.UserType,
            user.CreatedAt
        });
    }

    // Get the next available UserID
    private async Task<int> GetNextUserID()
    {
        var lastUserID = await _context.Users
            .Select(u => (int?)u.UserID)
            .MaxAsync();

        return (lastUserID ?? 0) + 1;
    }
}

// Login information
public class LoginRequest
{
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
}

// Registration information
public class RegisterRequest
{
    public string Name { get; set; } = "";
    public string Email { get; set; } = "";
    public string Password { get; set; } = "";
    public string UserType { get; set; } = "";
}