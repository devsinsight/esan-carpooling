using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace AmbienteWeb.Proyecto.Carpooling.Web.Models
{
    public class SeedDataInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            context.Roles.Add(new IdentityRole { Name = "ADMINISTRATOR" });
            context.Roles.Add(new IdentityRole { Name = "COMPANY" });
            context.Roles.Add(new IdentityRole { Name = "EMPLOYEE" });

            ApplicationUserManager manager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));
            ApplicationUser administrator = new ApplicationUser
            {
                FirstName = "José Luis",
                LastName = "Olivares Rojas",
                Email = "admin@admin.com",
                UserName = "admin@admin.com"
            };

            ApplicationUser company = new ApplicationUser
            {
                FirstName = "José Luis",
                LastName = "Olivares Rojas",
                Email = "company@company.com",
                UserName = "company@company.com"
            };

            manager.Create(administrator, "Pass@w0rd1");
            manager.AddToRole(administrator.Id, "ADMINISTRATOR");

            manager.Create(company, "Pass@w0rd1");
            manager.AddToRole(company.Id, "COMPANY");

            base.Seed(context);
        }
    }
}