using System.Security.Cryptography.X509Certificates;
using WeatherWear_Project.Models;

namespace WeatherWear_Project.Repositories
{
    public class WeatherRepositories
    {
        public int _NextId;
        public List<ClothingReco> clothingReco;

        public WeatherRepositories() 
        {
            
        }

        public IEnumerable<ClothingReco> GetAll()
        {
            if (clothingReco == null || clothingReco.Count() <= 0) throw new ArgumentNullException("No Weather Records found");
            return clothingReco;
        }



    }
}
