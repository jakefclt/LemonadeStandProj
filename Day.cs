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
        public List<Customer> customers;
       
        public string day;


        public Day(string day)
        {
            weather = new Weather();
            
           
            this.day = day;
            

        }
        public Day()
        {
            customers = new List<Customer>();
        }
        public void CurrentWeather()
        {

            Console.WriteLine(weather.condition);
            Console.WriteLine(weather.temperature);

        }

        public int RandomNumberOfCustomer(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
        public void AddCustomersToList(int numberOfCustomers)
        {
            for (int i = 0; i < numberOfCustomers; i++)
            {
                Customer customer = new Customer();
                customers.Add(customer);
            }
        }
    }
}