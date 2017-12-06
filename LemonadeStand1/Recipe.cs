using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand1
{
    public class Recipe
    {
        public int numberLemons;
        public int sugarAmount;
        public int amountIce;
        public int pitcherNumber;

        public void AddLemons(Inventory inventory)
        {
            Console.WriteLine("How many lemons would you like to use?");
            numberLemons = Convert.ToInt32(Console.ReadLine());
        }

        public void AddSugar(Inventory inventory)
        {
            Console.WriteLine("How many cups of sugar would you like to use?");
            sugarAmount = Convert.ToInt32(Console.ReadLine());
        }

        public void AddIce(Inventory inventory)
        {
            Console.WriteLine("How many ice cubes would you like to add?");
            amountIce = Convert.ToInt32(Console.ReadLine());
        }

        public int MakePitcher(Inventory inventory)
        {
            Console.WriteLine("How many pitchers would you like to make? There are 8 cups per pitcher.");
            pitcherNumber = Convert.ToInt32(Console.ReadLine());
            inventory.SubtractCups(8*pitcherNumber);
            inventory.SubtractLemons(numberLemons * pitcherNumber);
            inventory.SubtractSugar(sugarAmount * pitcherNumber);
            inventory.SubtractIce(amountIce * pitcherNumber);
            return pitcherNumber;
        }
    }
}
