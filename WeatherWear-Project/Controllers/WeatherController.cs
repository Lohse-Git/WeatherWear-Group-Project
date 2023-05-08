using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using WeatherWear_Project.Models;
using WeatherWear_Project.Repositories;

namespace WeatherWear_Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        public WeatherController()

        {
            weatherrepositories = new WeatherRepositories();



        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType] (StatusCodes.Status400BadRequest)]
        [HttpGet]

        public ActionResult<IEnumerable<ClothingReco>> Index()
       
         try
        {

         var list = WeatherRepositories.getAll().ToList();
        Return OK(list);

    }
         catch (ArgumentNullException ex)
        {


        }

         

    }
}
