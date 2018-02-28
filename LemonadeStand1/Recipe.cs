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
            if (numberLemons > inventory.Lemons.Count)
            {
                Console.WriteLine("You don't have that many lemons. Please put in a lower number.");
                AddLemons(inventory);
            }
        }

        public void AddSugar(Inventory inventory)
        {
            Console.WriteLine("How many cups of sugar would you like to use?");
            sugarAmount = Convert.ToInt32(Console.ReadLine());
            if (sugarAmount > inventory.Sugar.Count)
            {
                Console.WriteLine("You don't have that much sugar. Please enter a lower number.");
                AddSugar(inventory);
            }
        }

        public void AddIce(Inventory inventory)
        {
            Console.WriteLine("How many ice cubes would you like to add?");
            amountIce = Convert.ToInt32(Console.ReadLine());
            if (amountIce > inventory.Ice.Count)
            {
                Console.WriteLine("You don't have that much ice. Please enter a lower number.");
                AddIce(inventory);
            }
        }
        public int MakePitcher(Inventory inventory)
        {
            Console.WriteLine("How many pitchers would you like to make? There are 8 cups per pitcher.");
            pitcherNumber = Convert.ToInt32(Console.ReadLine());
            return pitcherNumber;
        }

        public void subtractLemons(Inventory inventory)
        {
            if (pitcherNumber * numberLemons > inventory.Lemons.Count)
            {
                Console.WriteLine("You don't have enough lemons to make that much lemonade.");
                MakePitcher(inventory);
            }
            else
            {
                inventory.SubtractLemons(numberLemons * pitcherNumber);
            }
        }

        public void subtractSugar(Inventory inventory)
        {
            if (pitcherNumber * sugarAmount > inventory.Sugar.Count)
            {
                Console.WriteLine("You don't have enough sugar to make that much lemonade.");
                MakePitcher(inventory);
            }
            else
            {
                inventory.SubtractSugar(sugarAmount * pitcherNumber);
            }
        }

        public void subtractIce(Inventory inventory)
        {
            if (pitcherNumber * amountIce > inventory.Ice.Count)
            {
                Console.WriteLine("You don't have enough ice to make that much lemonade.");
                MakePitcher(inventory);
            }
            else 
            {
                inventory.SubtractIce(amountIce * pitcherNumber);
            }
        }

        public void subtractCups(Inventory inventory)
        {
            if(pitcherNumber*8 > inventory.Cups.Count)
            {
                Console.WriteLine("You don't have enough cups to make that much lemonade");
                MakePitcher(inventory);
            }
            else
            {
                inventory.SubtractCups(8 * pitcherNumber);
            }
            
        }
    }
}
