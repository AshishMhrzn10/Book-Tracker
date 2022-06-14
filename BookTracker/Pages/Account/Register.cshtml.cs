using BookTracker.Data;
using BookTracker.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookTracker.Pages.BookList.Account
{
    public class RegisterModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public RegisterModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Register Model { get; set; }

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //await _db.Register.AddAsync(Model);
                //await _db.SaveChangesAsync();
                return RedirectToPage("Login");
            }
            else
            {
                return Page();
            }
        }
    }
}
