using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using notes.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<NotesContext>(options =>
        options.UseSqlite(builder.Configuration.GetConnectionString("NotesContext")));
}
else
{
    builder.Services.AddDbContext<NotesContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("ProductionNotesContext")));
}
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.MapGet("/", () => Results.Redirect("/Notes"));

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
