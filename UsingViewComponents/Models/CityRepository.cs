using System.Collections.Generic;



namespace UsingViewComponents.Models
{
    public interface ICityRepository
    {
        IEnumerable<City> Cities { get; }

        void AddCity(City newCity);
    }

    public class MemoryCityRepository : ICityRepository
    {
        private List<City> cities = new List<City>
       {
           new City{Name = "London", Location = "UK", Population = 8539000},
           new City{Name = "New York", Location= "USA", Population = 8406000},
           new City{Name = "San Jose", Location = "USA", Population = 998537},
           new City{Name = "Paris", Location = "France", Population = 2244000}
       };

        public IEnumerable<City> Cities => cities;
        public void AddCity(City newCity)
        {
            cities.Add(newCity);
        }
            

    }
}
