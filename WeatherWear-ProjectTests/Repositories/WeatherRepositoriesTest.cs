using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherWear_Project.Repositories;

namespace WeatherWear_ProjectTests.Repositories
{
    [TestClass()]
    class WeatherRepositoriesTest
    {
        WeatherRepositoriesTest repository;

        [TestMethod()]
        public void WeatherRepositoryTest()
        {
            repository = new WeatherRepositoriesTest();
        }

        [TestMethod()]
        public void GetAllTest()
        {
            repository = new WeatherRepositories();
            var listOfWeather = repository.GetAll();
            Assert.IsNotNull(listOfWeather);
            Assert.AreEqual(3, countInList);
        }
    }
}
