using MaisonTelecomInventory.Components;
 
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
 
 
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?? throw new NullReferenceException("Connection string 'InventoryDatabase' not found.");
builder.Services.AddDbContext<InventoryDbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

// Seed the database with initial data
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<InventoryDbContext>();
    // Ensure the database is migrated to the latest version
    context.Database.Migrate();
    SeedData(context);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

// Seeding method to add default data
void SeedData(InventoryDbContext context)
{
    // Seed Brands if the table is empty
    if (!context.Brands.Any())
    {
        context.Brands.AddRange(
            new Brand { Name = "Apple" },
            new Brand { Name = "Samsung" },
            new Brand { Name = "Infinix" }
        );
    }

    // Seed Categories if the table is empty
    if (!context.Categories.Any())
    {
        context.Categories.AddRange(
            new Category { Name = "Phones" },
            new Category { Name = "Laptops" },
            new Category { Name = "Accessories" }
        );
    }

    // Save changes to the database
    context.SaveChanges();
}

// Inside Program.cs, at the very end of the file

public static class CurrencyHelper
{
    public static string FormatPrice(decimal price)
    {
        // This formats the number with comma separators and no decimals
        return $"FCFA {price:N0} XAF";
    }
}