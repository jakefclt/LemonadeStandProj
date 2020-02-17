using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        public List<string> names;
        public string name;
        Random randomName = new Random();
        
        public Customer()
        {
            names = new List<string>() { "Customer 1", "Customer 2", "Customer 3", "Customer 4" };
            name = names[randomName.Next(0, 3)];
        }
        public void Customer1()
        {
            string customer1 = names[0];

        }

      
    }      
    
    
            
    
}
