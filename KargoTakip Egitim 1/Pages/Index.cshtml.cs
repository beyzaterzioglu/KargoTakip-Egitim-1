using KargoTakip_Egitim_1.Data.Context;
using KargoTakip_Egitim_1.Data.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KargoTakip_Egitim_1.Pages
{
    public class IndexModel : PageModel
    {
        ApplicationDbContext _context;
        public List<Cargo> Cargos { get; set; }
        public IndexModel(ApplicationDbContext context)
        {
            _context=context;
            Cargos = _context.Cargos.ToList();
        }

        public void OnGet()
        {
            Cargos = _context.Cargos.ToList();
        }
    }
}