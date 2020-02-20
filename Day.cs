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
        Player thePlayer;
        public double cupsSold;
        public string day;


        public Day(string day, Player player)
        {
            thePlayer = player ;
            weather = new Weather();
            customers = new List<Customer>();
            this.day = day;
            cupsSold = 0;
        }
        public Day()
        {

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
        public void CustomerBuysLemonade()
        {
            for (int i = 0; i < customers.Count; i++)
            {
                bool soldCup = customers[i].BuyLemonade(thePlayer, weather);

                if (soldCup == true)
                {
                    cupsSold++;
                }
            }


        }

       

    }
}