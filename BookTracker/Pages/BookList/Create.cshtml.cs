using Microsoft.AspNetCore.Mvc;
using BookTracker.Model;
using BookTracker.Data;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookTracker.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public Book Book { get; set; }

        public void OnGet()
        {
        }
    }
}
