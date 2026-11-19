
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Kutuphane.Models;
using Kutuphane.Data;

public class UyelersController : Controller
{
    private readonly AppDbContext _context;

    public UyelersController(AppDbContext context)
    {
        _context = context;
    }

    // GET: UYELERS
    public async Task<IActionResult> Index()    
    {
        return View(await _context.Uyelers.ToListAsync());
    }

    // GET: UYELERS/Details/5
    public async Task<IActionResult> Details(int? uyeid)
    {
        if (uyeid == null)
        {
            return NotFound();
        }

        var uyeler = await _context.Uyelers
            .FirstOrDefaultAsync(m => m.UyeId == uyeid);
        if (uyeler == null)
        {
            return NotFound();
        }

        return View(uyeler);
    }

    // GET: UYELERS/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: UYELERS/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("UyeId,Ad,Soyad,Email,Telefon,Adres,KayitTarihi,Oduncler")] Uyeler uyeler)
    {
        if (ModelState.IsValid)
        {
            _context.Add(uyeler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(uyeler);
    }

    // GET: UYELERS/Edit/5
    public async Task<IActionResult> Edit(int? uyeid)
    {
        if (uyeid == null)
        {
            return NotFound();
        }

        var uyeler = await _context.Uyelers.FindAsync(uyeid);
        if (uyeler == null)
        {
            return NotFound();
        }
        return View(uyeler);
    }

    // POST: UYELERS/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to.
    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int? uyeid, [Bind("UyeId,Ad,Soyad,Email,Telefon,Adres,KayitTarihi,Oduncler")] Uyeler uyeler)
    {
        if (uyeid != uyeler.UyeId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(uyeler);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UyelerExists(uyeler.UyeId))
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
        return View(uyeler);
    }

    // GET: UYELERS/Delete/5
    public async Task<IActionResult> Delete(int? uyeid)
    {
        if (uyeid == null)
        {
            return NotFound();
        }

        var uyeler = await _context.Uyelers
            .FirstOrDefaultAsync(m => m.UyeId == uyeid);
        if (uyeler == null)
        {
            return NotFound();
        }

        return View(uyeler);
    }

    // POST: UYELERS/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int? uyeid)
    {
        var uyeler = await _context.Uyelers.FindAsync(uyeid);
        if (uyeler != null)
        {
            _context.Uyelers.Remove(uyeler);
        }

        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }

    private bool UyelerExists(int? uyeid)
    {
        return _context.Uyelers.Any(e => e.UyeId == uyeid);
    }
}
