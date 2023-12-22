var builder = WebApplication.CreateBuilder(args);
 
builder.Services.AddControllersWithViews();

var app = builder.Build();
 
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); 
    app.UseHsts();
}

//builder.Services.Configure<FormOptions>(x =>
//{
//    x.ValueLengthLimit = int.MaxValue;
//    x.MultipartBodyLengthLimit = long.MaxValue; // Dosya boyutu limiti
//});

//builder.Services.Configure<KestrelServerOptions>(options =>
//{
//    options.Limits.MaxRequestBodySize = null; // Sýnýrsýz
//});

//builder.Services.Configure<IISServerOptions>(options =>
//{
//    options.MaxRequestBodySize = int.MaxValue; // 2GB üzeri için
//});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();