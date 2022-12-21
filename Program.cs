using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Web2.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container. 相依性插入容器, 註冊資料庫內容.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Web2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Web2Context") ?? throw new InvalidOperationException("Connection string 'Web2Context' not found.")));

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

app.MapRazorPages();

app.Run();
