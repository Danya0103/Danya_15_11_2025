namespace Danya_15_11_2025.Data;
using Microsoft.EntityFrameworkCore;
using Danya_15_11_2025.Models;

public class LibraryContext : DbContext
{
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
        
    }
    
    public DbSet<Book> Books { get; set; }
    
    
}