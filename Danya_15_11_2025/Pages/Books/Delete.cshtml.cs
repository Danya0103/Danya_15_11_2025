using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using Danya_15_11_2025.Data;
using Danya_15_11_2025.Models;
namespace Danya_15_11_2025.Pages.Books;

public class DeleteModel : PageModel
{
    private readonly LibraryContext _context;

    public DeleteModel(LibraryContext context)
    {
        _context = context;
    }

    public Book bookItem { get; set; }
    
    public async Task<IActionResult> OnGetAsync(int ID)
    {
        bookItem = await _context.Books.FindAsync(ID);
        if (bookItem == null)
        {
            return NotFound();
        }

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int ID)
    {
        var book = await _context.Books.FindAsync(ID);
        if (book != null)
        {
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
        }
         return RedirectToPage("Index");
        
    }
    
  
}