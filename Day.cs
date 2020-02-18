using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        public Weather weather;
        public List<Customer> customer;
        public Customer randomCustomer;
        public string day;
        
        
        public Day(string day)
        {
            weather = new Weather();
            customer = new List<Customer>();
            randomCustomer = new Customer();
            this.day = day;

        }
        public void CurrentWeather()
        {
            
            Console.WriteLine(weather.condition);
            Console.WriteLine(weather.temperature);

        }

        public void RandomCustomer()
        {
            Console.WriteLine(randomCustomer.name);
        }
    }
}
