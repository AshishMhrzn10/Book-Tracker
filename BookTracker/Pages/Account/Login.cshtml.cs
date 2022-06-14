using BookTracker.Data;
using BookTracker.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace BookTracker.Pages.BookList.Account
{
    public class LoginModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public LoginModel(ApplicationDbContext db)
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
               /* var result = await _db.Register.Where();
                if (result != null)
                {
                    return RedirectToPage("../Index");
                }
               */
                return Page();
            }
            else
            {
                return Page();
            }
        }

    }
}
