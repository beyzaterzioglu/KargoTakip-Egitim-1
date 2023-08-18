using KargoTakip_Egitim_1.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KargoTakip_Egitim_1.Pages
{
    public class DeleteModel : PageModel
    {
        ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet(int id)
        {
            var cargo = _context.Cargos.FirstOrDefault(p => p.Id == id);
			_context.Cargos.Remove(cargo);
            _context.SaveChanges();
            return RedirectToPage("/Index");
        }
    }
}
