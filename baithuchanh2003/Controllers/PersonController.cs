using Microsoft.AspNetCore.Mvc;
using baithuchanh2003.Models;
using baithuchanh2003.Data;
using Microsoft.EntityFrameworkCore;

namespace baithuchanh2003.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PersonController (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Persons.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Person std)
        {
            if(ModelState.IsValid)
            {
                _context.Add(std);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        private bool PersonExists(string id)
        {
            return _context.Persons.Any(e=>e.PersonCode == id);
        }
        //Edit
        public async Task<IActionResult> Edit(string id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var person=await _context.Persons.FindAsync(id);
            if(person==null)
            {
                return NotFound();
            }
            return View(person);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit(string id ,[Bind("PersonCode,PersonName,PersonSex,PhoneNumber,Address")]Person std)
        {
            if(id != std.PersonCode)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                try
                {
                    _context.Update(std);
                    await _context.SaveChangesAsync();
                }
                catch(DbUpdateConcurrencyException)
                {
                    if(!PersonExists(std.PersonCode))
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
            return View(std);
        }
        //delete
        public async Task<IActionResult> Delete(string id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var std=await _context.Persons
                .FirstOrDefaultAsync(m=>m.PersonCode == id);
            if(std==null)
            {
                return NotFound();
            }
            return View(std);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>DeleteConfirmed(string id)
        {
            var std=await _context.Persons.FindAsync(id);
            _context.Persons.Remove(std);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

