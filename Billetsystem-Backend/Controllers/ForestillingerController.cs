using Billetsystem_Backend.Data;
using Billetsystem_Backend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Billetsystem_Backend.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ForestillingerController : ControllerBase
{
    private BilletDbContext _context;

    public ForestillingerController(BilletDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Forestillinger>> Get()
    {
        return Ok(_context.Forestillinger.AsNoTracking().ToList());
    }
}