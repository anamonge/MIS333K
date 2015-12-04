using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace SafariBooks.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
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

        
        public System.Data.Entity.DbSet<SafariBooks.Models.Book> Books { get; set; }
        public System.Data.Entity.DbSet<SafariBooks.Models.Customer> Customers { get; set; }
        public System.Data.Entity.DbSet<SafariBooks.Models.Employee> Employees { get; set; }
        public System.Data.Entity.DbSet<SafariBooks.Models.Genre> Genres { get; set; }
        public System.Data.Entity.DbSet<SafariBooks.Models.OrderDetail> OrderDetails { get; set; }
        public System.Data.Entity.DbSet<SafariBooks.Models.Order> Orders { get; set; }
        public System.Data.Entity.DbSet<SafariBooks.Models.Promotion> Promotions { get; set; }
        public System.Data.Entity.DbSet<SafariBooks.Models.ReorderDetails> ReorderDetails { get; set; }
        public System.Data.Entity.DbSet<SafariBooks.Models.Reorders> Reorders { get; set; }
        public System.Data.Entity.DbSet<SafariBooks.Models.Review> Reviews { get; set; }

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