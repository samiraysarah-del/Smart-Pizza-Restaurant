using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Pizza_Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            string productName1 = "Pizza Margherita";
            string pizzaType1 = "Pizza Focaccia";
            string customerName1 = "Malania";
            int customerAge1 = 30;
            string coldDrink1 = "Sod-Cola";
            string saladType1 = "Greek Salad";
            string friesType1 = "French Fries";
            int priceColdDrink1 = 50;
            int priceSaladType1 = 100;
            int priceFriesType1 = 210;
            int countPizzaType1 = 1;
            int countColdDrink1 = 2;
            int countSaladType1 = 1;
            int countFriesType1 = 3;
            int price1 = 502;
            int pricePizza1 = 110;
            int discount1 = 70;
            bool isAvailable1 = true;



            string productName2 = "Pizza Romana";
            string pizzaType2 = "Sicilian Pizza";
            string customerName2 = "Tom";
            int customerAge2 = 29;
            string coldDrink2 = "Coke";
            string saladType2 = "Garden Salad";
            string friesType2 = "French Fries";
            int priceColdDrink2 = 30;
            int priceSaladType2 = 90;
            int priceFriesType2 = 100;
            int countPizzaType2 = 1;
            int countColdDrink2 = 1;
            int countSaladType2 = 1;
            int countFriesType2 = 1;
            int price2 = 402;
            int pricePizza2 = 330;
            int discount2 = 30;
            bool isAvailable2 = true;



            string productName3 = "Life Pizzeria Bio";
            string pizzaType3 = "Pizza Tonno";
            string customerName3 = "Arjon";
            int customerAge3 = 20;
            string coldDrink3 = "Classic Malt";
            string saladType3 = "Garden Salad";
            string friesType3 = "Potato Wedges";
            int priceColdDrink3 = 50;
            int priceSaladType3 = 40;
            int priceFriesType3 = 120;
            int countPizzaType3 = 1;
            int countColdDrink3 = 1;
            int countSaladType3 = 1;
            int countFriesType3 = 1;
            int price3 = 312;
            int pricePizza3 = 320;
            int discount3 = 50;
            bool isAvailable3 = true;



            if (isAvailable1)
            {
                Console.WriteLine("Pizza Margherita is Available.");
            }
            else
            {
                Console.WriteLine("Pizza Margherita is Not Available.");
            }



            if (isAvailable2)
            {
                Console.WriteLine("Pizza Romana is Available.");
            }
            else
            {
                Console.WriteLine("Pizza Romana is Not Available.");
            }



            if (isAvailable3)
            {
                Console.WriteLine("Life Pizzeria Bio is Available.");
            }
            else
            {
                Console.WriteLine("Life Pizzeria Bio is Not Available.");
            }



            int choice = 0;

            while(choice != 5)
            {
                Console.WriteLine("☆◈◉◆⋱Smart Pizza Restaurant⋰◆◉◈☆");
                Console.WriteLine("1. Pizza Margherita");
                Console.WriteLine("2. Pizza Romana");
                Console.WriteLine("3. Life Pizzeria Bio");
                Console.WriteLine("4. Show All pizzas");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter Your Choice");
                int.TryParse(Console.ReadLine(),out choice);


                switch (choice)
                {
                    case 1:

                        Console.WriteLine("Pizza Margherita");
                        Console.WriteLine($"Product Name1: {productName1}");
                        Console.WriteLine($"Pizza Type1: {pizzaType1}");
                        Console.WriteLine($"Customer Name1: {customerName1}");
                        Console.WriteLine($"Customer Age1: {customerAge1}");
                        Console.WriteLine($"Cold Drink1: {coldDrink1}");
                        Console.WriteLine($"Salad Type1: {saladType1}");
                        Console.WriteLine($"Fries Type1: {friesType1}");
                        Console.WriteLine($"Price Cold Drink1: ${priceColdDrink1}");
                        Console.WriteLine($"Price Salad Type1: ${priceSaladType1}");
                        Console.WriteLine($"Price Fries Type1: ${priceFriesType1}");
                        Console.WriteLine($"Count Pizza Type1: {countPizzaType1}");
                        Console.WriteLine($"Count Cold Drink1: {countColdDrink1}");
                        Console.WriteLine($"Count Salad Type1: {countSaladType1}");
                        Console.WriteLine($"Count Fries Type1: {countFriesType1}");
                        Console.WriteLine($"Price1: ${price1}");
                        Console.WriteLine($"Price Pizza1: ${pricePizza1}");
                        Console.WriteLine($"Discount1: ${discount1}");
                        Console.WriteLine($"Is Available1: {isAvailable1}");

                        break;

                    case 2:

                        Console.WriteLine("Pizza Romana");
                        Console.WriteLine($"Product Name2: {productName2}");
                        Console.WriteLine($"Pizza Type2: {pizzaType2}");
                        Console.WriteLine($"Customer Name2: {customerName2}");
                        Console.WriteLine($"Customer Age2: {customerAge2}");
                        Console.WriteLine($"Cold Drink2: {coldDrink2}");
                        Console.WriteLine($"Salad Type2: {saladType2}");
                        Console.WriteLine($"Fries Type2: {friesType2}");
                        Console.WriteLine($"Price Cold Drink2: ${priceColdDrink2}");
                        Console.WriteLine($"Price Salad Type2: ${priceSaladType2}");
                        Console.WriteLine($"Price Fries Type2: ${priceFriesType2}");
                        Console.WriteLine($"Count Pizza Type2: {countPizzaType2}");
                        Console.WriteLine($"Count Cold Drink2: {countColdDrink2}");
                        Console.WriteLine($"Count Salad Type2: {countSaladType2}");
                        Console.WriteLine($"Count Fries Type2: {countFriesType2}");
                        Console.WriteLine($"Price2: ${price2}");
                        Console.WriteLine($"Price Pizza2: ${pricePizza2}");
                        Console.WriteLine($"Discount2: ${discount2}");
                        Console.WriteLine($"Is Available2: {isAvailable2}");

                        break;

                    case 3:

                        Console.WriteLine("Life Pizzeria Bio");
                        Console.WriteLine($"Product Name3: {productName3}");
                        Console.WriteLine($"Pizza Type3: {pizzaType3}");
                        Console.WriteLine($"Customer Name3: {customerName3}");
                        Console.WriteLine($"Customer Age3: {customerAge3}");
                        Console.WriteLine($"Cold Drink3: {coldDrink3}");
                        Console.WriteLine($"Salad Type3: {saladType3}");
                        Console.WriteLine($"Fries Type3: {friesType3}");
                        Console.WriteLine($"Price Cold Drink3: ${priceColdDrink3}");
                        Console.WriteLine($"Price Salad Type3: ${priceSaladType3}");
                        Console.WriteLine($"Price Fries Type3: ${priceFriesType3}");
                        Console.WriteLine($"Count Pizza Type3: {countPizzaType3}");
                        Console.WriteLine($"Count Cold Drink3: {countColdDrink3}");
                        Console.WriteLine($"Count Salad Type3: {countSaladType3}");
                        Console.WriteLine($"Count Fries Type3: {countFriesType3}");
                        Console.WriteLine($"Price3: ${price3}");
                        Console.WriteLine($"Price Pizza3: ${pricePizza3}");
                        Console.WriteLine($"Discount3: ${discount3}");
                        Console.WriteLine($"Is Available3: {isAvailable3}");

                        break;

                    case 4:

                        Console.WriteLine("Show all Pizzas");


                        Console.WriteLine("☆◈◉◆••⋱Pizza Margherita⋰••◆◉◈☆");
                        Console.WriteLine($"Product Name1: {productName1}");
                        Console.WriteLine($"Pizza Type1: {pizzaType1}");
                        Console.WriteLine($"Customer Name1: {customerName1}");
                        Console.WriteLine($"Customer Age1: {customerAge1}");
                        Console.WriteLine($"Cold Drink1: {coldDrink1}");
                        Console.WriteLine($"Salad Type1: {saladType1}");
                        Console.WriteLine($"Fries Type1: {friesType1}");
                        Console.WriteLine($"Price Cold Drink1: ${priceColdDrink1}");
                        Console.WriteLine($"Price Salad Type1: ${priceSaladType1}");
                        Console.WriteLine($"Price Fries Type1: ${priceFriesType1}");
                        Console.WriteLine($"Count Pizza Type1: {countPizzaType1}");
                        Console.WriteLine($"Count Cold Drink1: {countColdDrink1}");
                        Console.WriteLine($"Count Salad Type1: {countSaladType1}");
                        Console.WriteLine($"Count Fries Type1: {countFriesType1}");
                        Console.WriteLine($"Price1: ${price1}");
                        Console.WriteLine($"Price Pizza1: ${pricePizza1}");
                        Console.WriteLine($"Discount1: ${discount1}");
                        Console.WriteLine($"Is Available1: {isAvailable1}");


                        Console.WriteLine("☆◈◉◆••⋱Pizza Romana⋰••◆◉◈☆");
                        Console.WriteLine($"Product Name2: {productName2}");
                        Console.WriteLine($"Pizza Type2: {pizzaType2}");
                        Console.WriteLine($"Customer Name2: {customerName2}");
                        Console.WriteLine($"Customer Age2: {customerAge2}");
                        Console.WriteLine($"Cold Drink2: {coldDrink2}");
                        Console.WriteLine($"Salad Type2: {saladType2}");
                        Console.WriteLine($"Fries Type2: {friesType2}");
                        Console.WriteLine($"Price Cold Drink2: ${priceColdDrink2}");
                        Console.WriteLine($"Price Salad Type2: ${priceSaladType2}");
                        Console.WriteLine($"Price Fries Type2: ${priceFriesType2}");
                        Console.WriteLine($"Count Pizza Type2: {countPizzaType2}");
                        Console.WriteLine($"Count Cold Drink2: {countColdDrink2}");
                        Console.WriteLine($"Count Salad Type2: {countSaladType2}");
                        Console.WriteLine($"Count Fries Type2: {countFriesType2}");
                        Console.WriteLine($"Price2: ${price2}");
                        Console.WriteLine($"Price Pizza2: ${pricePizza2}");
                        Console.WriteLine($"Discount2: ${discount2}");
                        Console.WriteLine($"Is Available2: {isAvailable2}");


                        Console.WriteLine("☆◈◉◆••⋱Life Pizzeria Bio⋰••◆◉◈☆");
                        Console.WriteLine($"Product Name3: {productName3}");
                        Console.WriteLine($"Pizza Type3: {pizzaType3}");
                        Console.WriteLine($"Customer Name3: {customerName3}");
                        Console.WriteLine($"Customer Age3: {customerAge3}");
                        Console.WriteLine($"Cold Drink3: {coldDrink3}");
                        Console.WriteLine($"Salad Type3: {saladType3}");
                        Console.WriteLine($"Fries Type3: {friesType3}");
                        Console.WriteLine($"Price Cold Drink3: ${priceColdDrink3}");
                        Console.WriteLine($"Price Salad Type3: ${priceSaladType3}");
                        Console.WriteLine($"Price Fries Type3: ${priceFriesType3}");
                        Console.WriteLine($"Count Pizza Type3: {countPizzaType3}");
                        Console.WriteLine($"Count Cold Drink3: {countColdDrink3}");
                        Console.WriteLine($"Count Salad Type3: {countSaladType3}");
                        Console.WriteLine($"Count Fries Type3: {countFriesType3}");
                        Console.WriteLine($"Price3: ${price3}");
                        Console.WriteLine($"Price Pizza3: ${pricePizza3}");
                        Console.WriteLine($"Discount3: ${discount3}");
                        Console.WriteLine($"Is Available3: {isAvailable3}");

                        break;

                    case 5:

                        Console.WriteLine("GoodBye!");

                        break;

                    default:

                        Console.WriteLine("Invalid Choice");

                        break;

                }

            }


            for (int j = 1; j <= 3; j++)
            {
                if (j == 1)
                {
                    Console.WriteLine(pizzaType1);
                }
                else if (j == 2)
                {
                    Console.WriteLine(pizzaType2);
                }
                else if (j == 3)
                {
                    Console.WriteLine(pizzaType3);
                }
            }

        }
    }
}
