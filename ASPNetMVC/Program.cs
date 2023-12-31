using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc(options => options.EnableEndpointRouting = false);
// Add services to the container.
builder.Services.AddRazorPages();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseStaticFiles();
app.UseMvc(routes =>
{
    routes.MapRoute(
        name: "default", template: "{controller=Home}/{action=Index}/{id?}"
    );
});

app.MapRazorPages();

app.Run();
