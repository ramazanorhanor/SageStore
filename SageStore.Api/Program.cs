using Microsoft.EntityFrameworkCore;
using SageStore.Application.CQRS.SupplierManagement.Commands;
using SageStore.Application.Legacy.Abstract;
using SageStore.Application.Legacy.Concrete;
using SageStore.Application.Legacy.Profiles;
using SageStore.Persistence.Contexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container. burası dependency injection için gerekli olan servisleri eklediğimiz yerdir. Örneğin, veri tabanı bağlantısı, servisler, repositoryler gibi işlemler burada yapılır.

builder.Services.AddControllers();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddDbContext<StoreContext>(opt=> { 
    opt.UseSqlServer(builder.Configuration.GetConnectionString("StoreDb"));
});
builder.Services.AddAutoMapper(opt=> { },typeof(CategoryProfile).Assembly);
builder.Services.AddMediatR(opt => { 
opt.RegisterServicesFromAssemblyContaining<CategoryProfile>();
});
var app = builder.Build();

// Configure the HTTP request pipeline. burası pipeline için gerekli olan middleware'leri eklediğimiz yerdir. Örneğin, hata sayfaları, yönlendirme, yetkilendirme gibi işlemler burada yapılır.

app.UseAuthorization();
app.MapPost("create-database", async (StoreContext context) =>
{
    await context.Database.EnsureCreatedAsync();
});
app.MapControllers();

app.Run();
