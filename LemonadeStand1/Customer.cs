using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand1
{
    public class Customer
    {
        public string response;
        public string reply;
        public double buyingChance1 = 1;
        public double buyingChance2 = 0.8;
        public double buyingChance3 = 0.6;
        public double buyingchance4 = 0.4;
        public double buyingChance5 = 0.2;
        public double chanceOfPurchase1;
        public double chanceOfPurchase2;
        public double chanceOfPurchase3;
        
        
        public double LikeTheTaste(Recipe recipie)
        {
            string response = "";
            if (recipie.numberLemons > 6 && recipie.sugarAmount < 2)
            {
                Console.WriteLine("This lemonade is too sour!");
                response = Console.ReadLine();
                chanceOfPurchase1 = buyingchance4;
            }

            else if (recipie.numberLemons < 4 && recipie.sugarAmount > 4)
            {
                Console.WriteLine("This lemonade is too sweet!");
                response = Console.ReadLine();
                chanceOfPurchase1 = buyingchance4;
            }

            else if (recipie.amountIce < 6)
            {
                Console.WriteLine("Could use more ice.");
                response = Console.ReadLine();
                chanceOfPurchase1 = buyingChance3;
            }

            else if (recipie.numberLemons > 6 && recipie.sugarAmount > 4)
            {
                Console.WriteLine("There's too much of everything.");
                response = Console.ReadLine();
                chanceOfPurchase1 = buyingChance5;
            }
            else if (recipie.numberLemons < 3 && recipie.sugarAmount < 1)
            {
                Console.WriteLine("That's some light lemonade...Blech!!");
                response = Console.ReadLine();
                chanceOfPurchase1 = buyingChance5;
            }
            else
            {
                Console.WriteLine("That's some tasty lemonade!");
                response = Console.ReadLine();
                chanceOfPurchase1 = buyingChance1;
            }
            return chanceOfPurchase1;

        }
        public double PayBasedOnPrice(Player player)
        {
            string reply = "";
            if (player.lemonadePrice > 0.45)
            {
                Console.WriteLine("I won't pay that much for lemonade. That's highway robbery!");
                reply = Console.ReadLine();
                chanceOfPurchase2 = buyingChance3;
            }
            return chanceOfPurchase2;
        }

        public string PayAccordingtoWeather(Weather weather)
        {
            string comeback = "";
            if (weather.temperature <= 50)
            {
                Console.WriteLine("It's rather cold. Why are you selling lemonade?");
                comeback = Console.ReadLine();
                chanceOfPurchase3 = buyingchance4;
            }

            else if (weather.temperature > 50 && weather.temperature <= 75)
            {
                Console.WriteLine("Nice day out, isn't it?");
                comeback = Console.ReadLine();
                chanceOfPurchase3 = buyingChance2;
            }

            else if (weather.temperature > 75)
            {
                Console.WriteLine("Hey, lemonade sounds good on a hot day.");
                comeback = Console.ReadLine();
                chanceOfPurchase3 = buyingChance1;
            }

            if (weather.weatherType == "Humid")
            {
                Console.WriteLine("Whew! Darn humidity!");
                comeback = Console.ReadLine();
                chanceOfPurchase3 = buyingChance2;
            }

            else if (weather.weatherType == "Rainy")
            {
                Console.WriteLine("Rain, Rain, Go Away.");
                comeback = Console.ReadLine();
                chanceOfPurchase3 = buyingchance4;
            }

            else if (weather.weatherType == "Windy")
            {
                Console.WriteLine("Windy out today, huh?");
                comeback = Console.ReadLine();
                chanceOfPurchase3 = buyingChance3;
            }

            else if (weather.weatherType == "Sunny")
            {
                Console.WriteLine("Ah, bright and sunny! The perfect weather for lemonade!");
                comeback = Console.ReadLine();
                chanceOfPurchase3 = buyingChance1;
            }
            else if (weather.weatherType == "Stormy")
            {
                Console.WriteLine("You gotta be crazy selling lemonade in weather like this.");
                comeback = Console.ReadLine();
                chanceOfPurchase3 = buyingChance5;
            }
            return comeback;
        }
        
        public double PurchaseLemonade(Wallet wallet, double cash, Player player)
        {
            double totalEarnings = player.lemonadePrice * player.amountSold;
            player.wallet.AddMoney(totalEarnings);
            return totalEarnings;
        }

    }
}
