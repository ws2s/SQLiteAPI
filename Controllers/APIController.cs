using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLiteAPI.Data;
using SQLiteAPI.Models;

namespace SQLiteAPI.Controllers;

[Route("specials")]
[ApiController]
public class APIController : Controller
{
    private readonly APIContext _db;

    public APIController(APIContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<PizzaSpecial>>> GetSpecials()
    {
        return (await _db.Specials.ToListAsync()).OrderByDescending(s => s.BasePrice).ToList();
    }
}