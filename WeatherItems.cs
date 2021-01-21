using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFWeather
{
    public class WeatherItems
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public DateTime Datum{ get; set; }
        public string Utrymme { get; set; }
        public decimal Temp { get; set; }
        public decimal Fuktighet { get; set; }
    }
    public class WeatherDBContext : DbContext
    {
        public WeatherDBContext() : base("name=WeatherDBConn") { }
        public DbSet<WeatherItems> WeatherProp { get; set; }
    }
}
