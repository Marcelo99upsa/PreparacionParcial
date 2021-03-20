using System.Data.Entity;

namespace ApiCountry.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")          //ctor tab tab
        {

        }
    }
}