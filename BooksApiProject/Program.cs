/*using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using BooksApiProject.Data;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<BooksApiProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BooksApiProjectContext") ?? throw new InvalidOperationException("Connection string 'BooksApiProjectContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

*/


using System;
using BooksApiProject;
using BooksApiProject.Models;
using BooksApiProject.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Microsoft.Extensions.DependencyInjection;

partial class Program
{

    public static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);
        // Add services to the container.
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<BooksApiProjectContext>(options => options.UseNpgsql("Host=192.168.9.5; Port=55001; Database=Nochevnyi; Username=postgres; Password=postgrespw"));



        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();



    }

}

