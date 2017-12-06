using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand1
{
    public class Player
    {
        public double cash;
        public double profit;
        public double expenses;
        public double lemonadePrice;
        public int numberOfBuyers;
        public int amountSold;
        public Inventory inventory = new Inventory();
        public Wallet wallet = new Wallet();
        public void SetLemonadePrice()
        {
            Console.WriteLine("Set the price for your lemonade: ");
            lemonadePrice = Convert.ToDouble(Console.ReadLine());
        }
        public double CalculateLemonadeBuyers(Customer customer)
        {
            double buyerPercentage = (customer.chanceOfPurchase1 + customer.chanceOfPurchase2 + customer.chanceOfPurchase3) / 3;
            numberOfBuyers = Convert.ToInt32(buyerPercentage * 100);
            return numberOfBuyers;
        }
        public double CalculateLemonadeSold(Recipe recipe, Inventory inventory)
        {
            if (8*(recipe.pitcherNumber) < numberOfBuyers)
            {
                amountSold = 8 * recipe.pitcherNumber;
            }

            else if (8*(recipe.pitcherNumber) >= numberOfBuyers)
            {
                amountSold = numberOfBuyers;
            }

            return amountSold;
        }
        public void CheckSupplyDemandRatio(Recipe recipe, Inventory inventory)
        {
            if(numberOfBuyers > 8*(recipe.pitcherNumber))
            {
                Console.WriteLine("You ran out of lemonade!");
                Console.ReadLine();
            }

            else if(numberOfBuyers < 8*(recipe.pitcherNumber))
            {
                Console.WriteLine("You didn't sell all your lemonade");
                Console.ReadLine();
            }
        }
        //public double CalculateExpenses(Wallet wallet)
        //{
        //   double expenses = wallet.SubtractMoney();
        //}
        //public double CalculateProfits(Wallet wallet)
        //{
        //    profit = wallet.AddMoney();
        //}
    }
}
