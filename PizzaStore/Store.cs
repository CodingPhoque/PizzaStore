using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class Store
    {
        public void Start()
        {
            // Insert the desired pizza's and their price
            Pizza p1 = new Pizza("Calzone", 80);
            Pizza p2 = new Pizza("Italiana", 75);
            Pizza p3 = new Pizza("Sole", 78);


            // Insert the name and the customer id of each customer
            Customer c1 = new Customer("James", 1);
            Customer c2 = new Customer("Marcus", 2);
            Customer c3 = new Customer("BigBoy", 3);
            

            // Placing the order using the information from Pizza and Customer
            Order o1 = new Order(p1, c1);
            Order o2 = new Order(p2, c2);
            Order o3 = new Order(p3, c3);

            // Displaying which customer have ordered which pizza and with a total price
            Console.WriteLine($"{c1} have ordered {p1}");
            Console.WriteLine($"{c1} The total price for the {o1}");
            Console.WriteLine();

            Console.WriteLine($"{c2} have ordered {p2}");
            Console.WriteLine($"{c2} The total price for the {o2}");
            Console.WriteLine();

            Console.WriteLine($"{c3} have ordered {p3}");
            Console.WriteLine($"{c3} The total price for the {o3}");
            Console.WriteLine();
            
           
        }
    }
}
