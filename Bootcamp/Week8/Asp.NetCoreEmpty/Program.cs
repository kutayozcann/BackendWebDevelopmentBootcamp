var builder = WebApplication.CreateBuilder(args);

// MVC servislerini ekleme
builder.Services.AddControllersWithViews(); 

var app = builder.Build();

// Geliştirme ortamı dışındaysa hata yönetimi ve HSTS etkinleştirilir
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

// HTTPS yönlendirmesi etkinleştirilir
app.UseHttpsRedirection(); 

// Routing konfigürasyonu etkinleştirilir
app.UseRouting(); 

// wwwroot klasörü (Static dosyalar) kullanımını etkinleştirme
app.UseStaticFiles();

// Yetkilendirme mekanizmasını etkinleştirme
app.UseAuthorization();

// Varsayılan routing yapılandırması
app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.Run();

/*
    Controller: Kullanıcıdan istekleri alır ve uygun yanıtı hazırlar.
    Action: Controller içindeki, belirli istekleri işleyen metottur.
    Model: Verileri tutan ve işleyen yapıdır.
    View: Kullanıcıya gösterilecek sayfanın tasarımını içerir.
    Razor: HTML içerisine C# kodu yazmayı sağlayan yapıdır.
    RazorView: Razor ile oluşturulan ve kullancıya gösterilen sayfadır.
    wwwroot: CSS, JS, resim gibi statik dosyaların sakladığı yerdir.
    
    builder.Build(): Uygulamanın tüm yapılandırmalarını tamamlayarak çalıştırmaya hazır hale getirir.
    app.Run(): Uygulamayı başlatır ve gelen isteklere karşılık ilgili işlemleri yürütür.
*/