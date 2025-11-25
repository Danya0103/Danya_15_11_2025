using Microsoft.EntityFrameworkCore;
using Danya_15_11_2025.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddDbContext<LibraryContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("LibraryDB")));

var app = builder.Build();
app.MapRazorPages();
app.Run();
