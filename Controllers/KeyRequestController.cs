using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLiteAPI.Data;
using SQLiteAPI.Models;

namespace SQLiteAPI.Controllers;

[Route("KeyRequest")]
[ApiController]
public class KeyRequestController : Controller
{
    private readonly APIContext _db;

    public KeyRequestController(APIContext db)
    {
        _db = db;
    }

    [HttpGet("{compId}")]
    public async Task<ActionResult<LookupSpecialApprover>> GetSpecialApprover(string compId)
    {        
        var approver = await _db.SpecialApprovers
            .Where(o => o.ApproverComputingID == compId)
            .FirstOrDefaultAsync();

        return approver == null ? NotFound() : approver;
        //return await _db.SpecialApprovers.FirstOrDefaultAsync();
    }

    /*[HttpGet("ApprovalTypes")]
    public async Task<ActionResult<IEnumerable<LookupApprovalType>>> GetApprovalTypes()
    {
        return (await _db.ApprovalTypes.ToListAsync()).OrderByDescending(s => s.ApprovalTypeID).ToList();
    }

    [HttpGet("Justifications")]
    public async Task<ActionResult<IEnumerable<LookupJustification>>> GetJustifications()
    {
        return (await _db.Justifications.ToListAsync()).OrderByDescending(s => s.JustificationID).ToList();
    }

    [HttpGet("PickupLocations")]
    public async Task<ActionResult<IEnumerable<LookupPickupLocation>>> GetPickupLocations()
    {
        return (await _db.PickupLocations.ToListAsync()).OrderByDescending(s => s.PickupLocationID).ToList();
    }

    [HttpGet("RequestTypes")]
    public async Task<ActionResult<IEnumerable<LookupRequestType>>> GetRequestTypes()
    {
        return (await _db.RequestTypes.ToListAsync()).OrderByDescending(s => s.RequestTypeID).ToList();
    }*/
}