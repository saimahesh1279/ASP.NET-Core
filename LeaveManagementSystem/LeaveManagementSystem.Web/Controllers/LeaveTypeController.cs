
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LeaveManagementSystem.Web.Data;

public class LeaveTypeController : Controller
{
    private readonly ApplicationDbContext _context;

    public LeaveTypeController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: LEAVETYPES
    public async Task<IActionResult> Index()    
    {
        var data = await _context.LeaveTypes.ToListAsync();
        return View(data);
    }

    // GET: LEAVETYPES/Details/5
    public async Task<IActionResult> Details(int? leaveid)
    {
        if (leaveid == null)
        {
            return NotFound();
        }

        var leavetype = await _context.LeaveTypes
            .FirstOrDefaultAsync(m => m.LeaveId == leaveid);
        if (leavetype == null)
        {
            return NotFound();
        }

        return View(leavetype);
    }

    // GET: LEAVETYPES/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: LEAVETYPES/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("LeaveId,LeaveTypeName,NumberOfDays,FromDate,ToDate")] LeaveType leavetype)
    {
        if (ModelState.IsValid)
        {
            _context.Add(leavetype);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(leavetype);
    }

    // GET: LEAVETYPES/Edit/5
    public async Task<IActionResult> Edit(int? leaveid)
    {
        if (leaveid == null)
        {
            return NotFound();
        }

        var leavetype = await _context.LeaveTypes.FindAsync(leaveid);
        if (leavetype == null)
        {
            return NotFound();
        }
        return View(leavetype);
    }

    // POST: LEAVETYPES/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? leaveid, [Bind("LeaveId,LeaveTypeName,NumberOfDays,FromDate,ToDate")] LeaveType leavetype)
    {
        if (leaveid != leavetype.LeaveId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(leavetype);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeaveTypeExists(leavetype.LeaveId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }
        return View(leavetype);
    }

    // GET: LEAVETYPES/Delete/5
    public async Task<IActionResult> Delete(int? leaveid)
    {
        if (leaveid == null)
        {
            return NotFound();
        }

        var leavetype = await _context.LeaveTypes
            .FirstOrDefaultAsync(m => m.LeaveId == leaveid);
        if (leavetype == null)
        {
            return NotFound();
        }

        return View(leavetype);
    }

    // POST: LEAVETYPES/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? leaveid)
    {
        var leavetype = await _context.LeaveTypes.FindAsync(leaveid);
        if (leavetype != null)
        {
            _context.LeaveTypes.Remove(leavetype);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool LeaveTypeExists(int? leaveid)
    {
        return _context.LeaveTypes.Any(e => e.LeaveId == leaveid);
    }
}
