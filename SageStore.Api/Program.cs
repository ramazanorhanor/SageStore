var builder = WebApplication.CreateBuilder(args);

// Add services to the container. burası dependency injection için gerekli olan servisleri eklediğimiz yerdir. Örneğin, veri tabanı bağlantısı, servisler, repositoryler gibi işlemler burada yapılır.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline. burası pipeline için gerekli olan middleware'leri eklediğimiz yerdir. Örneğin, hata sayfaları, yönlendirme, yetkilendirme gibi işlemler burada yapılır.

app.UseAuthorization();

app.MapControllers();

app.Run();
