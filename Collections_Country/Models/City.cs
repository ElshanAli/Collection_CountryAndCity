using System;
using System.Collections.Generic;
using System.Text;

namespace Collections_Country
{
    class City
    {
        public string Name;  
        public int Population;



        public City(string name, int population)
        {
            Name = name;
            Population = population;
        }

        public override string ToString()
        {
            return $" Name: {Name} Population: {Population}"; 
        }
    }
}
