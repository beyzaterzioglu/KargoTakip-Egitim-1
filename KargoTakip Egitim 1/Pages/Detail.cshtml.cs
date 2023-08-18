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
        public void OnGet(int id)
        {
           this.Cargo= _context.Cargos.FirstOrDefault(c => c.Id==id); //id alınmalı ki hangi kargo değişecek bulunsun
        }

        public IActionResult OnPost()
        {
        
            if(!ModelState.IsValid)
            {
                return Page();
            }
            var result = _context.Update(Cargo);
            _context.SaveChanges();
            return RedirectToPage("/index"); 
        }
    }
}
