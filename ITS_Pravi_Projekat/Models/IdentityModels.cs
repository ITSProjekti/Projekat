using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ITS_Pravi_Projekat.Models
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
        public DbSet<Osoba> Osobe { get; set; }
        public DbSet<Pol> Pol { get; set; }
        public DbSet<Mesto> Mesto { get; set; }
        //public DbSet<TipKontaktTelefon> TipKontaktTelefon{ get; set; }
        //public DbSet<KontaktTelefon> KontaktTelefon { get; set; }
        //public DbSet<Opstina> Opstine { get; set; }
        //public DbSet<Mejl> Mejlovi { get; set; }
        //public DbSet<TipMejlAdresa> TipoviMejla { get; set; }
        //public DbSet<PostanskaAdresa> PostanskeAdrese { get; set; }
        //public DbSet<TipPostanskaAdresa> TipoviPostanseAdrese { get; set; }

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