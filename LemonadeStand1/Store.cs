using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand1
{
    public class Store
    {
        Player player;
        public int choice;

        List<string> crateLemons = new List<string> { "1) Small 10-Lemon Crate: $2.50", "2) Medium 30-Lemon Crate: $5.00", "3) Large 60-Lemon Crate: $7.50" };
        List<string> bagsSugar = new List<string> { "1) 4-lb. sugar bag (12 cups): $2.50", "2) 10-lb. sugar bag (30 cups): $4.00", "3) 25-lb. sugar bag (75 cups): $6.00" };
        List<string> iceBags = new List<string> { "1) Small ice bag (100 cubes): $1.50", "2) Medium ice bag (250 cubes): $2.50", "3) Large ice bag (500 cubes): $3.50" };
        List<string> numberCups = new List<string> { "1) Small bag (50 cups): $1.75", "2) Medium bag (100 cups): $2.50", "3) Large bag (250 cups): $4.25" };

        List<double> priceLemons = new List<double> { 2.50, 5.00, 7.50 };
        List<double> priceSugar = new List<double> { 2.50, 4.00, 6.00 };
        List<double> icePriceBaby = new List<double> { 1.50, 2.50, 3.50 };
        List<double> priceofCups = new List<double> { 1.75, 2.50, 4.25 };
        public Store(Player player)
        {
            this.player = player;
        }
        public void SellLemons()
        {
            foreach (string crate in crateLemons)
            {
                Console.WriteLine(crate);
            }
            Console.WriteLine("How many lemons would you like to purchase? Please type in your choice number. Press 0 if you don't want to purchase any lemons.");
            string userInput = Console.ReadLine();
            choice = Convert.ToInt32(userInput);
            if (choice == 1)
            {
                BuyingLemons(10);
            }
            else if (choice == 2)
            {
                BuyingLemons(30);
            }
            else if (choice == 3)
            {
                BuyingLemons(60);
            }
            else if(choice != 0 && choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("Answer does not compute. Please enter a valid choice number.");
                SellLemons();
            }

        }
        public void SellSugar()
        {

            foreach (string sugarbag in bagsSugar)
            {
                Console.WriteLine(sugarbag);
            }
            Console.WriteLine("How much sugar would you like? Please type in your choice number. Press 0 if you don't want any sugar.");
            string userInput = Console.ReadLine();
            choice = Convert.ToInt32(userInput);
            if (choice == 1)
            {
                BuyingSugar(12);
            }
            else if (choice == 2)
            {
                BuyingSugar(30);
            }
            else if (choice == 3)
            {
                BuyingSugar(75);
            }
            else if (choice != 0 && choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("Answer does not compute. Please enter a valid choice number.");
                SellSugar();
            }
        }

        public void SellIce()
        {
            foreach (string ibag in iceBags)
            {
                Console.WriteLine(ibag);
            }
            Console.WriteLine("How much ice would you like? Please type in your choice number. Press 0 if you don't want any ice.");
            string userInput = Console.ReadLine();
            choice = Convert.ToInt32(userInput);
            if (choice == 1)
            {
                PurchaseIce(100);
            }
            else if (choice == 2)
            {
                PurchaseIce(250);
            }
            else if (choice == 3)
            {
                PurchaseIce(500);
            }
            else if (choice != 0 && choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("Answer does not compute. Please enter a valid choice number.");
                SellIce();
            }
        }

        public void SellCups()
        {
            foreach (string cupamount in numberCups)
            {
                Console.WriteLine(cupamount);
            }
            Console.WriteLine("How many cups would you like to purchase? Please type in your choice number. Press 0 if you don't want to buy any cups.");
            string userInput = Console.ReadLine();
            choice = Convert.ToInt32(userInput);
            if (choice == 1)
            {
                PurchaseCups(50);
            }
            else if (choice == 2)
            {
                PurchaseCups(100);
            }
            else if (choice == 3)
            {
                PurchaseCups(250);
            }
            else if (choice != 0 && choice != 1 && choice != 2 && choice != 3)
            {
                Console.WriteLine("Answer does not compute. Please enter a valid choice number.");
                SellCups();
            }
        }

        public void BuyingLemons(double lemonsPurchased)
        {
            for (double i = 1; i <= lemonsPurchased; i++)
            {
                Lemon lemon = new Lemon();
                player.inventory.Lemons.Add(lemon);
            }
            if (lemonsPurchased == 10)
            {
                player.wallet.SubtractMoney(2.5);
            }

            else if (lemonsPurchased == 30)
            {
                player.wallet.SubtractMoney(5.0);
            }

            else if (lemonsPurchased == 60)
            {
                player.wallet.SubtractMoney(7.5);
            }
            
        }

        public void BuyingSugar(double sugarPurchased)
        {
            for (double i = 1; i <= sugarPurchased; i++)
            {
                Sugar sugar = new Sugar();
                player.inventory.Sugar.Add(sugar);
            }
                if (sugarPurchased == 12)
                {
                    player.wallet.SubtractMoney(2.5);
                }

                else if (sugarPurchased == 30)
                {
                    player.wallet.SubtractMoney(4.0);
                }

                else if (sugarPurchased == 75)
                {
                    player.wallet.SubtractMoney(6.0);
                }

        }
        public void PurchaseIce(double icePurchased)
        {
            for (double i = 1; i <= icePurchased; i++)
            {
                Ice ice = new Ice();
                player.inventory.Ice.Add(ice);
            }
                if (icePurchased == 100)
                {
                    player.wallet.SubtractMoney(1.5);
                }

                else if (icePurchased == 250)
                {
                    player.wallet.SubtractMoney(2.5);
                }

                else if (icePurchased == 500)
                {
                    player.wallet.SubtractMoney(3.5);
                }
        }

        public void PurchaseCups(double cupsPurchased)
        {
            for (double i = 1; i <= cupsPurchased; i++)
            {
                Cup cup = new Cup();
                player.inventory.Cups.Add(cup);
            }
                if (cupsPurchased == 50)
                {
                    player.wallet.SubtractMoney(1.75);
                }

                else if (cupsPurchased == 100)
                {
                    player.wallet.SubtractMoney(2.5);
                }

                else if (cupsPurchased == 250)
                {
                    player.wallet.SubtractMoney(4.25);
                }
        }
    }
}
