using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "home",
    pattern: "/",
    defaults: new
    {
        Controller = "Home",
        Action = "Index"
    }
    );

app.MapControllerRoute(
    name: "ProductDetail",
    pattern: "/produkty/{id}",
    defaults: new
    {
        Controller = "ProductDetail",
        Action = "ProductDetail",
    }
    );

app.MapControllerRoute(
    name: "Size",
    pattern: "/admin/size",
    defaults: new
    {
        Controller = "Size",
        Action = "Size"
    }
    );

app.MapControllerRoute(
    name: "Color",
    pattern: "/admin/color",
    defaults: new
    {
        Controller = "Color",
        Action = "Color"
    }
    );

app.MapControllerRoute(
    name: "Category",
    pattern: "/admin/category",
    defaults: new
    {
        Controller = "Category",
        Action = "Index"
    }
    );

app.MapControllerRoute(
    name: "AdminHome",
    pattern: "/admin",
    defaults: new
    {
        Controller = "AdminHome",
        Action = "AdminHome"
    }
    );
app.Run();