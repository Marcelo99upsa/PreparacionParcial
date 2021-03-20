using System.Data.Entity;

namespace ApiCountry.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")          //ctor tab tab
        {

        }

        public System.Data.Entity.DbSet<ApiCountry.Models.Currency> Currencies { get; set; }

        public System.Data.Entity.DbSet<ApiCountry.Models.Country> Countries { get; set; }
    }
}