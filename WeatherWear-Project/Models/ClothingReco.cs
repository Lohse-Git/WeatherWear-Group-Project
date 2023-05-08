namespace WeatherWear_Project.Models
{
    public class ClothingReco
    {
        public DateOnly Date { get; set; }

        public int TemperatureC { get; set; }


        public int Windspeeds { get; set; }


          

        

        


        




        public string? Summary { get; set; }

        public override string ToString()
        {
            return Date + ", " + Summary + ", " + TemperatureC;
        }
    }
}
