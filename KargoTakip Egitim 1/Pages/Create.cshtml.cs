using KargoTakip_Egitim_1.Data.Context;
using KargoTakip_Egitim_1.Data.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KargoTakip_Egitim_1.Pages
{
    public class CreateModel : PageModel
    {
        public Cargo? Cargo { get; set; }
        public ApplicationDbContext _context;

		public CreateModel(ApplicationDbContext context)
		{
			_context = context;
		}

		public void OnGet()
        {
            // almamız gereken herhangi bir paramter olmadığı için boş
        }
        public IActionResult OnPost(Cargo cargo) 
        {
            if (ModelState.IsValid)
            {
                _context.Add(cargo);
                _context.SaveChanges();
                return RedirectToPage("/Index");
            }
            return Page();
        }
    }
}
