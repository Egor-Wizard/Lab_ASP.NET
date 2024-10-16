using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// ������ ������ �� ����������.
builder.Services.AddRazorPages();

var app = builder.Build();

// ������������ ������� HTTP ������.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // �������� HSTS �� ������������� - 30 ���. �������, �� �������� ������ �� ��� ���������� �������.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// ������������ ������������� ��� Razor Pages.
app.MapRazorPages();

app.Run();
