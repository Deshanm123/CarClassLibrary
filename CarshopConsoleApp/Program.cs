using CarClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarshopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create Car inventory,Add some cars to cart to checkout");

            int action = chooseAction();
            carStore garage = new carStore();


           while (action != 0)
            {
                Console.WriteLine("You chose " + action);
                //giving options
                switch (action)
                {
                   //Add to inventory
                    case 1:
                        Console.WriteLine("\n***Adding a new car to inventory***");
                        string carMake;
                        string carModel;
                        decimal carPrice;
                        Console.Write("\tEnter Car Make :");
                        carMake = Console.ReadLine();
                        Console.Write("\tEnter Carmodel :");
                        carModel = Console.ReadLine();
                        Console.Write("\tEnter Car  Price :");
                        carPrice = decimal.Parse(Console.ReadLine());

                       Car newCar = new Car(carMake,carModel,carPrice);
                        garage.carList.Add(newCar);
                        printInventory(garage);
                        break;
                        //add to cart
                    case 2:
                        {
                            Console.WriteLine("\nSelect a Car to purchase");
                            printInventory(garage);
                            Console.WriteLine("Enter the relevant car number");
                            int carChosen = int.Parse(Console.ReadLine());
                            //insert to shopping list
                            garage.shoppingList.Add(garage.carList[carChosen]);
                            printShoppingCart(garage); 
                        }
                        break;
                    case 3:
                        {

                            printShoppingCart(garage);
                            Console.WriteLine("The total cost of your item is :"+garage.CheckOut()+"Million");
                            

                        }
                         break;
                    default:{ }
                        break;
                }

                action = chooseAction();
            }
            /*

            carStore s = new carStore();
            { 
                s.shoppingList.Add(i8);
                s.shoppingList.Add(jeep);

                decimal total = s.CheckOut();
                {
                    Console.WriteLine("Store value is " +total+ " million.");
                }
                */
        int chooseAction()
            {
                Console.WriteLine("Choose an action \n (0) To quit \n (1) Add a New Car to Inventory \n (2) Add car to Cart \n (3) Checkout ");
                int choice = int.Parse(Console.ReadLine());
                return choice;
            }

            Console.ReadLine();
            }
       static private void printInventory(carStore garage)
        {
            //foreach (Car c in garage.carList)
            for(int i=0;i<garage.carList.Count;i++)//length is not supported in list in c#
            {
                // Console.WriteLine("{0} {1} {2}", c.make, c.model, c.price);
                //creating to string to print c
                //Console.WriteLine(c.ToStrings());
                //latest method forloop
                Console.WriteLine( i +" : " +garage.carList[i].ToStrings());
            }
        }
        static private void printShoppingCart(carStore garage)
        {
            for(int i= 0;i< garage.shoppingList.Count; i++)
            {
                Console.Write("you have chosen : ");
                Console.WriteLine(garage.shoppingList[i].ToStrings());
            }
        }

        }
    }

