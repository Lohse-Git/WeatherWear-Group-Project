namespace WeatherWear_Project.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;

    public class TempData
    {
        [tempdata]
        public int ID { get; set; } 
        public double TemperatureC { get; set; }

        public double ToDouble()
        {
            return TemperatureC;
        }
    }
public class DataContext : Dbcontext { }

