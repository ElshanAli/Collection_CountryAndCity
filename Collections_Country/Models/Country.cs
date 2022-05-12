using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Collections_Country
{
    class Country
    {
        public string CountryName;
        public  int TotalPopulation;
        public ArrayList Cities;

        public Country(string name)
        {
            CountryName = name;
            Cities = new ArrayList();
        }
         public void Add(City city)
        {
            Cities.Add(city);
        }
       
       
        public void FindByAllPopulation(int min, int max)
        {
            foreach (City item in Cities)
            {
                if (item.Population>min&&item.Population<max)
                {
                    Console.WriteLine(item);
                }
            }
        }
        public void Total()
        {
            
            foreach (City city in Cities)
            {
                TotalPopulation += city.Population;
            }
            Console.WriteLine($" \n {CountryName} has a population of {TotalPopulation} people") ;
        }
       

       
    }
}
