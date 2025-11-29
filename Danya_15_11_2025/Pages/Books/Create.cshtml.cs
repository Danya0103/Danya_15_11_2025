using Microsoft.AspNetCore.Mvc.RazorPages;
using Danya_15_11_2025.Data;
using Danya_15_11_2025.Models;
using Microsoft.AspNetCore.Mvc;

namespace Danya_15_11_2025.Pages.Books;

public class CreateModel : PageModel
{
    private readonly LibraryContext _context;

    public CreateModel(LibraryContext context)
    {
        _context = context;
    }
    
    
    [BindProperty]
    public Book BookItem { get; set; }

    public void OnGet()
    {
        
    }

    public async Task<IActionResult> OnPostAsync()
    {
        _context.Books.Add(BookItem);
        await _context.SaveChangesAsync();
        return RedirectToPage("Index");
    }
    
    
}

