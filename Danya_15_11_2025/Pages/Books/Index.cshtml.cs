using Microsoft.AspNetCore.Mvc.RazorPages;
using Danya_15_11_2025.Data;
using Danya_15_11_2025.Models;
using Microsoft.EntityFrameworkCore;

namespace Danya_15_11_2025.Pages.Books;

public class IndexModel : PageModel
{
    private readonly LibraryContext _context;

    public IndexModel(LibraryContext context)
    {
        _context = context;
    }

    public List<Book> Books { get; set; }
    
    
    // GET - процес отримання інформації
    // POST - процес дій
    
    // Task - клас EF для асинхроних операцій
    // назви прцоесів - починаємо з On + Get/Post/Delete/... + *null*/Async
    public async Task OnGetAsync()
    {
        Books = await _context.Books.ToListAsync();
    }
}