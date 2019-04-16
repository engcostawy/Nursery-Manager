using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace NurseryManager.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Nursery> Nurseries { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactNumbers> ContactNumbers { get; set; }
        public DbSet<Drink> Drink { get; set; }
        public DbSet<Events> Events { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Hygine> Hygines { get; set; }
        public DbSet<Images> Images { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Mood> Moods { get; set; }
        public DbSet<Notes> Notes { get; set; }
        public DbSet<Sleep> Sleeps { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}