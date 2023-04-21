using Microsoft.AspNetCore.Mvc;
using baithuchanh2003.Models;
using baithuchanh2003.Data;
using Microsoft.EntityFrameworkCore;

namespace baithuchanh2003.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController (ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Customers.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Customer std)
        {
            if(ModelState.IsValid)
            {
                _context.Add(std);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
        private bool CustomerExists(string id)
        {
            return _context.Customers.Any(e=>e.CustomerCode == id);
        }
        //Edit
        public async Task<IActionResult> Edit(string id)
        {
            if (id==null)
            {
                return NotFound();
            }
            var customer=await _context.Customers.FindAsync(id);
            if(customer==null)
            {
                return NotFound();
            }
            return View(customer);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult>Edit(string id ,[Bind("CustomerCode,FullName,Address,PhoneNumber")]Customer std)
        {
            if(id != std.CustomerCode)
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
                    if(!CustomerExists(std.CustomerCode))
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
            var std=await _context.Customers
                .FirstOrDefaultAsync(m=>m.CustomerCode == id);
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
            var std=await _context.Customers.FindAsync(id);
            _context.Customers.Remove(std);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}

