using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Додати сервіси до контейнера.
builder.Services.AddRazorPages();

var app = builder.Build();

// Налаштування конвеєра HTTP запитів.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // Значення HSTS за замовчуванням - 30 днів. Можливо, ви захочете змінити це для виробничих сценаріїв.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Налаштування маршрутизації для Razor Pages.
app.MapRazorPages();

app.Run();
