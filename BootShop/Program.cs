using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddSession();
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
app.UseSession();
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
    name: "ProductList",
    pattern: "/produkty",
    defaults: new
    {
        Controller = "ProductList",
        Action = "Index",
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
    name: "AdminHome",
    pattern: "/admin",
    defaults: new
    {
        Controller = "AdminHome",
        Action = "AdminHome"
    }
    );

app.MapControllerRoute(
    name: "Size",
    pattern: "/admin/size",
    defaults: new
    {
        Controller = "Size",
        Action = "Index"
    }
    );

app.MapControllerRoute(
    name: "SizeDelete",
    pattern: "/admin/size/{id}/delete",
    defaults: new
    {
        Controller = "Size",
        Action = "Delete"
    }
    );

app.MapControllerRoute(
    name: "Color",
    pattern: "/admin/color",
    defaults: new
    {
        Controller = "Color",
        Action = "Index"
    }
    );

app.MapControllerRoute(
    name: "ColorDelete",
    pattern: "/admin/color/{id}/delete",
    defaults: new
    {
        Controller = "Color",
        Action = "Delete"
    }
    );

app.MapControllerRoute(
    name: "ColorEdit",
    pattern: "/admin/color/{id}/edit",
    defaults: new
    {
        Controller = "Color",
        Action = "Edit"
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
    name: "CategoryDelete",
    pattern: "/admin/category/{id}/delete",
    defaults: new
    {
        Controller = "Category",
        Action = "Delete"
    }
    );

app.MapControllerRoute(
    name: "CategoryEdit",
    pattern: "/admin/category/{id}/edit",
    defaults: new
    {
        Controller = "Category",
        Action = "Edit"
    }
    );

app.MapControllerRoute(
    name: "Subcategory",
    pattern: "/admin/subcategory",
    defaults: new
    {
        Controller = "Subcategory",
        Action = "Index"
    }
    );

app.MapControllerRoute(
    name: "SubcategoryDelete",
    pattern: "/admin/subcategory/{id}/delete",
    defaults: new
    {
        Controller = "Subcategory",
        Action = "Delete"
    }
    );

app.MapControllerRoute(
    name: "SubcategoryEdit",
    pattern: "/admin/subcategory/{id}/edit",
    defaults: new
    {
        Controller = "Subcategory",
        Action = "Edit"
    }
    );

app.MapControllerRoute(
    name: "Product",
    pattern: "/admin/product",
    defaults: new
    {
        Controller = "Product",
        Action = "Index"
    }
    );

app.MapControllerRoute(
    name: "ProductDelete",
    pattern: "/admin/product/{id}/delete",
    defaults: new
    {
        Controller = "Product",
        Action = "Delete"
    }
    );

app.MapControllerRoute(
    name: "ProductEdit",
    pattern: "/admin/product/{id}/edit",
    defaults: new
    {
        Controller = "Product",
        Action = "Edit"
    }
    );

app.MapControllerRoute(
    name: "ProductVariant",
    pattern: "/admin/product-variant",
    defaults: new
    {
        Controller = "ProductVariant",
        Action = "Index"
    }
    );

app.MapControllerRoute(
    name: "ProductVariantDelete",
    pattern: "/admin/product-variant/{id}/delete",
    defaults: new
    {
        Controller = "ProductVariant",
        Action = "Delete"
    }
    );

app.MapControllerRoute(
    name: "ProductVariantEdit",
    pattern: "/admin/product-variant/{id}/edit",
    defaults: new
    {
        Controller = "ProductVariant",
        Action = "Edit"
    }
    );

app.MapControllerRoute(
    name: "AdminLogin",
    pattern: "/admin/login",
    defaults: new
    {
        Controller = "AdminLogin",
        Action = "Index"
    });

app.MapControllerRoute(
    name: "AdminLogout",
    pattern: "/admin/logout",
    defaults: new
    {
        Controller = "AdminLogout",
        Action = "Logout"
    });

app.Run();