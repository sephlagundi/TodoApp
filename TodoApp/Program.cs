using TodoApp.Data;
using TodoApp.Repository;
using TodoApp.Repository.InMemory;
using TodoApp.Repository.MsSQL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(); // Validation framework, DI asp.net core

// configure asp.net the ef library to connect for a db
builder.Services.AddDbContext<TodoDbContext>();

// DI object is configured by a constructor inject the object defined here 

// if test environment then work with inmemroy object
// else work with database
// asp.net automatically configures objects using DI concept
builder.Services.AddSingleton<ITodoRepository, TodoInMemoryRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// it identifes the controllers folder list a set of url which it can prepare 
// /home
// /todo/GetAllTodos
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Todo}/{action=GetAllTodos}/{id?}");

app.Run();
