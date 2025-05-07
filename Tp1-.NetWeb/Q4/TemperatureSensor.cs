using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    public delegate void AlertaHandler (String mensagem);
    public class TemperatureSensor
    {
        public event AlertaHandler alertTemperatureExceeded;

        public void CheckTemperature(double temperature)
        {
            if (temperature > 100)
            {
                alertTemperatureExceeded?.Invoke("ALERTA: Temperatura muito alta!");
            }
            else if (temperature < 0)
            {
                alertTemperatureExceeded?.Invoke("ALERTA: Temperatura muito baixa!");
            }
            else
            {
                Console.WriteLine("Temperatura normal.");
            }
        }
    }
}
