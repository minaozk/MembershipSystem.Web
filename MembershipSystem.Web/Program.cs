using MembershipSystem.Web.Extensions;
using MembershipSystem.Web.Models;
using Microsoft.EntityFrameworkCore;
using MembershipSystem.Web.Models;
using MembershipSystem.Web.OptionsModels;
using MembershipSystem.Web.Services;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
{
	options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});


builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
builder.Services.AddIdentityWithExt();
builder.Services.AddScoped<IEmailService, EmailService>();

builder.Services.ConfigureApplicationCookie(options =>
{
	var cookieBuilder = new CookieBuilder();
	cookieBuilder.Name = "MembershipAppCookie";

	options.LoginPath = new PathString("/Home/SignIn");
	options.LogoutPath = new PathString("/Member/Logout");
	options.Cookie = cookieBuilder;
	options.ExpireTimeSpan = TimeSpan.FromDays(60);
	options.SlidingExpiration = true;


});


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
app.UseAuthentication();
app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
	endpoints.MapControllerRoute(
		name: "areas",
		pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
	);
});



app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
