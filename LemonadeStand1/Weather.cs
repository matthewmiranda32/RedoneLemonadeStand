using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand1
{
    public class Weather
    {
        public int temperature;
        public string weatherType;
        public double demandLevel;
        // member variables

        //constructor

        // member methods
        public Weather()
        {
            Random random = new Random();
            this.temperature = random.Next(40, 100);
            int conditions = random.Next(0, 4);
            if (conditions == 0)
            {
                this.weatherType = "Humid";
            }
            else if (conditions == 1)
            {
                this.weatherType = "Rainy";
            }
            else if (conditions == 2)
            {
                this.weatherType = "Stormy";
            }
            else if (conditions == 3)
            {
                this.weatherType = "Sunny";
            }
            else if (conditions == 4)
            {
                this.weatherType = "Windy";
            }
            if (this.weatherType == "Sunny")
            {
                this.demandLevel = 100;
            }
            else if (this.weatherType == "Humid")
            {
                this.demandLevel = 80;
            }
            else if (this.weatherType == "Windy")
            {
                this.demandLevel = 60;
            }
            else if (this.weatherType == "Rainy")
            {
                this.demandLevel = 40;
            }
            else if (this.weatherType == "Stormy")
            {
                this.demandLevel = 20;
            }
        }
        public int Temperature
        {
            get
            {
                return temperature;
            }

        }
        public string Conditions
        {
            get
            {
                return weatherType;
            }
        }

        public double Demand
        {
            get
            {
                return demandLevel;
            }
        }
    }
}
