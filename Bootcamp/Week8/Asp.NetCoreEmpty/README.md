# ASP.NET Core Empty

This project is created using the **ASP.NET Core Empty** template and structured according to the **MVC (Model-View-Controller)** pattern.

## 📂 Project Structure

- **Controllers/** → Handles user requests and returns responses.
- **Models/** → Represents and processes data.
- **Views/** → Contains the HTML pages shown to the user.
- **wwwroot/** → Stores static files like CSS, JavaScript, and images.

## 🔧 Configuration

### 1️⃣ Add MVC Services
MVC services are added to the project in **Program.cs**:
```csharp
builder.Services.AddControllersWithViews();
```

### 2️⃣ Enable Static Files
Static files in the `wwwroot` folder are enabled with this setting:
```csharp
app.UseStaticFiles();
```

### 3️⃣ Default Routing
Requests are routed to the `HomeController` and its `Index` action by default:
```csharp
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
```

