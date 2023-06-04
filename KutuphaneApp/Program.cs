using KutuphaneApp.Business.Abstract;
using KutuphaneApp.Business.Concrate;
using KutuphaneApp.Entity.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<KutuphaneAppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));
builder.Services.AddScoped<IBookDetailService, BookDetailService>();
builder.Services.AddScoped<IBookService, BookService>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IPhotoService, PhotoService>();
builder.Services.AddScoped<IAuthorService, AuthorService>();
builder.Services.AddIdentity<User, IdentityRole>(opt =>
{
	opt.Password.RequiredLength = 7;
	opt.Password.RequireDigit = false;
	opt.Password.RequireUppercase = false;
	opt.User.RequireUniqueEmail = true;
})
.AddEntityFrameworkStores<KutuphaneAppContext>()
.AddDefaultTokenProviders();
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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
