using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p247_ex1
{
    class WaterHeater
    {
        protected int temperature;

        public void SetTemperature(int temperature)
        {
            if (temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }

            this.temperature = temperature;
        }
        internal void Turn0NWater()
        {
            Console.WriteLine($"Turn0NWater on water : { temperature}");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();
                heater.SetTemperature(20);
                heater.Turn0NWater();

                heater.SetTemperature(-2);
                heater.Turn0NWater();

                heater.SetTemperature(50);
                heater.Turn0NWater();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

     
