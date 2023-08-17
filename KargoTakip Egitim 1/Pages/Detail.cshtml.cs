using KargoTakip_Egitim_1.Data.Context;
using KargoTakip_Egitim_1.Data.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace KargoTakip_Egitim_1.Pages
{
    public class DetailModel : PageModel
    {
        [BindProperty]
        public Cargo Cargo { get; set; }
        ApplicationDbContext _context;

        public DetailModel(ApplicationDbContext context)
        {
            _context = context; 
        }
        public List<Cargo> Cargos { get; set; }
        public void OnGet()
        {

        }

        public IActionResult OnPost()
        {
            var cargo = Cargo;
            if(ModelState != null)
            {
                return Page();
            }
            var result = _context.Add(Cargo);
            _context.SaveChanges();
            return RedirectToRoute("/detail"); 
        }
    }
}
