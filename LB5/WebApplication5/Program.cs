using WebApplication5;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddLogging();

var app = builder.Build();

app.UseErrorLogging(); // Додаємо middleware для логування помилок

app.MapPost("/save", async (HttpContext context) => {
    var form = await context.Request.ReadFormAsync();
    var value = form["value"].ToString();
    var expiration = DateTime.Parse(form["expiration"]);
    context.Response.Cookies.Append("myCookie", value, new CookieOptions
    {
        Expires = expiration
    });
    context.Response.Redirect("/check");
});

app.MapGet("/check", async (HttpContext context) => {
    context.Response.ContentType = "text/html";
    var value = context.Request.Cookies["myCookie"];
    await context.Response.WriteAsync("<html><body>");
    if (value != null)
    {
        await context.Response.WriteAsync($"The value in the cookie: {value}");
    }
    else
    {
        await context.Response.WriteAsync("No value found in the cookie");
    }
    await context.Response.WriteAsync("</body></html>");
});

app.UseStaticFiles();

app.Run();
