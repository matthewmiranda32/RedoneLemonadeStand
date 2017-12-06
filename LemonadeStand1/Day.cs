using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand1
{
    public class Day
    {
        List<Customer> customer = new List<Customer>();

        public void GenerateCustomers()
        {
            for (int i = 0; i < 101; i++)
            {
                customer.Add(new Customer());
            }
        }
        public void DayGoesBy(Game game)
        {
            Console.WriteLine("It's a new day! Check your supplies and wallet, we're selling lemonade again!");
            int newDay = 7;
            for (int i = 0; i <= newDay; i++)
            {
                game.PlayTheGame(game);
            }
        }
    }
}
