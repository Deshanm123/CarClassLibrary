using System;
using System.Collections.Generic;
using System.Text;

namespace CarClassLibrary
{
    public class carStore
    {
        public List<Car> carList { get; set; }
        public List<Car> shoppingList { get; set; }

        public carStore()
        {
            carList = new List<Car>();
            shoppingList = new List<Car>();
        }
        public decimal CheckOut()
        {
            //initialize 
            decimal totalCost = 0;

            foreach (var  c in shoppingList)
            {
                totalCost += c.price;
            }
            //empty shopping list
            shoppingList.Clear();
            return totalCost;

        }
    }
}