using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ApiCountry.Models
{
    public class Country
    {
        [Key]
        public string Name { get; set; }
        [Required]
        public string Capital { get; set; }
        public int Population { get; set; }
        public List<double> Latlng { get; set; }
        public List<string> Timezones { get; set; }
        public List<Currency> Currencies { get; set; }
        public string Flag { get; set; }
    }
}