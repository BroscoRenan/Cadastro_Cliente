using Cadastro_Cliente.Data;
using Cadastro_Cliente.Repositorio;
using Microsoft.EntityFrameworkCore;



    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
    builder.Services.AddControllersWithViews();

    builder.Services.AddDbContext<BancoContext>(options =>
    {
        options.UseMySQL(builder.Configuration.GetConnectionString("DataBase"));
    });

    builder.Services.AddScoped<IClienteRepositorio, ClienteRepositorio>();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
    }
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();
