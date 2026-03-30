using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobportal_system
{
    internal class coffeeshop
    {
        public static void coffee()
        {
            double totalbill = 0;
            string ordermore="";
            do
            {
                Console.WriteLine("WELCOME TO OUR COFFEE SHOP");
                Console.WriteLine("You can select your favourite coffee");
                Console.WriteLine("1.Espresso - 90/-RS");
                Console.WriteLine("2.Cappuccino - 120/-RS");
                Console.WriteLine("3.Latte - 130/-RS");
                Console.WriteLine("4.Mocha - 140/-RS");
                Console.WriteLine("5.Cold Coffee - 150/-RS");
                Console.WriteLine("Choose your Coffee 1-5:");
                int choice=Convert.ToInt32(Console.ReadLine());

                double coffeeprice = 0;
                string coffeename;

                switch (choice) { 
                case 1 :
                        coffeeprice = 90;
                        coffeename = "Espresso";
                        break;
                 case 2:
                        coffeeprice = 120;
                        coffeename = "Cappuccino";
                        break;
                case 3:
                        coffeeprice = 130;
                        coffeename = "Latte";
                        break;
                case 4:
                        coffeeprice = 140;
                        coffeename = "Mocha";
                        break;
                case 5:
                        coffeeprice = 150;
                        coffeename = "Cold Coffee";
                        break;
                default:
                        Console.WriteLine("invalid choice. Try Again");
                        continue;
                }
                Console.WriteLine("Enter Quantity:");
                int quantity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Here is the Toppings Menu");
                Console.WriteLine("1. Milk - 20/-RS");
                Console.WriteLine("2. Sugar - 10/-RS");
                Console.WriteLine("3. Whipped Cream - 25/-RS");
                Console.WriteLine("4. Chocolate Syrup - 30/-RS");
                Console.WriteLine("5. No Toppings - 0/-RS");
                Console.WriteLine("Choose your Toppings 1-5");
                int topping=Convert.ToInt32(Console.ReadLine());

                double toppingprice = 0;
                string toppingname;

      

                switch (topping)
                {
                    case 1:
                        toppingprice = 20;
                        toppingname = "Milk";
                        break;
                    case 2:
                        toppingprice = 10;
                        toppingname = "Sugar";
                        break;
                    case 3:
                        toppingprice = 25;
                        toppingname = "Whipped Cream";
                        break;
                    case 4:
                        toppingprice = 30;
                        toppingname = "Chocolate syrup";
                        break;
                    case 5:
                        toppingprice = 0;
                        toppingname = "No Topping";
                        break;
                    default:
                        Console.WriteLine("Invalid choice. No topping added");
                        continue;



                }

               

                double itemtotal=(coffeeprice+toppingprice)*quantity;
                totalbill = totalbill + itemtotal;

                Console.WriteLine("you ordered" +""+ quantity +""+ "*" +""+ coffeename+ "with" + toppingname);
                Console.WriteLine("your current total is" + itemtotal);

                Console.WriteLine("Do you want to order another Coffee- yes/no:");
               ordermore=Console.ReadLine();

            } while (ordermore=="yes");

            Console.WriteLine("Your Final bill is"+totalbill);
            Console.WriteLine("Thank You for your order, Stay Healthy");

        }

    }
}
