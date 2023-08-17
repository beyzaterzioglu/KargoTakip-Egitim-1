using KargoTakip_Egitim_1.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KargoTakip_Egitim_1.Pages
{
    public class LoginModel : PageModel
    {
        ApplicationDbContext _context;
        [BindProperty]
        public string UserName { get; set; }

        [BindProperty]
        public string Password { get; set; }

        public string Msg { get; set; }
        public LoginModel(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult OnGet()
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                return RedirectToPage("/index");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            var user = _context.Users.FirstOrDefault(p=>p.UserName==this.UserName);
            if (user == null)
            {
                Msg = "kullanıcı bulunamadı";
                return Page();
            }
            if (user.Password!=this.Password)
            {
                Msg = "Hatalı şifre girdiniz";
                return Page();
            }
            HttpContext.Session.SetString("UserName", this.UserName);
            return RedirectToPage("/index");
        }
    }
}
