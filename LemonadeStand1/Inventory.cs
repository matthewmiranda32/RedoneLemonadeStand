using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand1
{
    public class Inventory
    {
        public int LemonQuantity;
        public int SugarQuantity;
        public int CupQuantity;
        public int IceQuantity;

        public List<Lemon> Lemons = new List<Lemon>();
        public List<Sugar> Sugar = new List<Sugar>();
        public List<Cup> Cups = new List<Cup>();
        public List<Ice> Ice = new List<Ice>();

        public void AddLemons(int amount)
        {
            for (double i = 0; i < amount; i++)
            {
                Lemons.Add(new Lemon());
            }
        }

        public void AddSugar(double amount)
        {
            for (double i = 0; i < amount; i++)
            {
                Sugar.Add(new Sugar());
            }
        }

        public void AddIce(int amount)
        {
            for (double i = 0; i < amount; i++)
            {
                Ice.Add(new Ice());
            }

        }

        public void AddCups(int amount)
        {
            for (double i = 0; i < amount; i++)
            {
                Cups.Add(new Cup());
            }
        }

        public void SubtractLemons(int amount)
        {
            if (amount >= 0)
            {
                for (int i = amount; i > 0; i--)
                {
                    Lemons.RemoveAt(0);
                }
            }
        }

        public void SubtractSugar(int amount)
        {
            if (amount >= 0)
            {
                for (int i = amount; i > 0; i--)
                {
                    Sugar.RemoveAt(0);
                }
            }
        }

        public void SubtractIce(int amount)
        {
            if (amount >= 0)
            {
                for (int i = amount; i > 0; i--)
                {
                    Ice.RemoveAt(0);
                }
            }
        }

        public void SubtractCups(int amount)
        {
            if (amount >= 0)
            {
                for (int i = amount; i > 0; i--)
                {
                    Cups.RemoveAt(0);
                }
            }
        }
    }
}

