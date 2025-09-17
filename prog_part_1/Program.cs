namespace prog_part_1
{


    // Microsoft. (2025) ASP.NET Core MVC overview. Available at: https://learn.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-8.0 (Accessed: 17 September 2025).

    // W3Schools. (n.d.) Bootstrap 5 Tutorial. Available at: https://www.w3schools.com/bootstrap5/ (Accessed: 17 September 2025).

    // Visual Paradigm. (n.d.) UML Class Diagram Tutorial. Available at: https://www.visual-paradigm.com/guide/uml-unified-modeling-language/uml-class-diagram-tutorial/ (Accessed: 17 September 2025).

    // Microsoft. (2025) Working with Controllers and Views in ASP.NET Core MVC. Available at: https://learn.microsoft.com/en-us/aspnet/core/mvc/controllers/actions?view=aspnetcore-8.0 (Accessed: 17 September 2025).

    // GetBootstrap. (n.d.) Theming Bootstrap. Available at: https://getbootstrap.com/docs/5.3/customize/overview/ (Accessed: 17 September 2025).

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Home}/{id?}");

            app.Run();
        }
    }
}
