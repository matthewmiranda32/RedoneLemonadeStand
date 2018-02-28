using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand1
{
    public class Game
    {
        Player player = new Player();
        public void RulesDisplay()
        {
            Console.WriteLine("Welcome to the Lemonade Stand Training Program. Here, you will learn how to make and sell lemonade, along with making some serious bank.");
            Console.ReadLine();
            Console.WriteLine("You need to buy your supplies first. You have 30 dollars right now. Spend it wisely.");
            Console.ReadLine();
        }

        public void PlayTheGame(Game game)
        {
            Store store = new Store(player);
            Weather weather = new Weather();
            Day day = new Day();
            Customer customer = new Customer();
            Recipe recipe = new Recipe();
            Console.WriteLine("You have $" +player.wallet.GetBalance());
            Console.WriteLine("You have " + player.inventory.Lemons.Count + " lemons, " + player.inventory.Sugar.Count + " cups of sugar, " + player.inventory.Ice.Count + " ice cubes, and " + player.inventory.Cups.Count + " cups. ");
            store.SellLemons();
            store.SellSugar();
            store.SellIce();
            store.SellCups();
            int lemonCount = player.inventory.Lemons.Count;
            int sugarAmount = player.inventory.Sugar.Count;
            int iceCount = player.inventory.Ice.Count;
            int cupAmount = player.inventory.Cups.Count;
            Console.WriteLine("You have $" + player.wallet.SubtractMoney(player.wallet.amount) + " left.");
            Console.WriteLine("Now, it's time to make some lemonade! Create your recipie as you see fit. You have " + lemonCount + " lemons, " + sugarAmount + " cups of sugar, " + iceCount + " ice cubes and " + cupAmount + " cups. ");
            Console.WriteLine("The weather tomorrow will be " + weather.temperature + " and " + weather.weatherType + ".");
            Console.ReadLine();
            recipe.AddLemons(player.inventory);
            recipe.AddSugar(player.inventory);
            recipe.AddIce(player.inventory);
            recipe.MakePitcher(player.inventory);
            recipe.subtractLemons(player.inventory);
            recipe.subtractSugar(player.inventory);
            recipe.subtractIce(player.inventory);
            recipe.subtractCups(player.inventory);
            player.SetLemonadePrice();
            day.GenerateCustomers();
            customer.LikeTheTaste(recipe);
            customer.PayBasedOnPrice(player);
            customer.PayAccordingtoWeather(weather);
            player.CalculateLemonadeBuyers(customer);
            Console.WriteLine(player.CalculateLemonadeBuyers(customer) + " people want lemonade!");
            player.CheckSupplyDemandRatio(recipe, player.inventory);
            player.CalculateLemonadeSold(recipe, player.inventory);
            Console.WriteLine("You made $" + customer.PurchaseLemonade(player.wallet, player.cash, player) + " today.");
            Console.ReadLine();
            day.DayGoesBy(game);
        }
    }
}
