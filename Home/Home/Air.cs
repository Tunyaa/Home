using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Air
    {
        int checkAir = 0;
        int airTemp = 23;
        public void SetAir(byte x)
        {
            
            if (x == 1)
            {
                Console.WriteLine("Кондиционер включен");
                checkAir = 1;
            }
            if (x == 0)
            {
                Console.WriteLine("Кондиционер выключен");
                checkAir = 0;
            }
            if (x == 3)
            {

                
                if (airTemp ==25)
                {
                    Console.WriteLine("Максимальная температура");
                }
                if (checkAir == 1 && airTemp < 25)
                {
                    airTemp++;
                    Console.WriteLine("{0} Градусов",airTemp);
                    
                }
                
            }


            if (x == 4)
            {
                if (airTemp == 5)
                {
                    Console.WriteLine("Минимальная температура");
                }
                if (checkAir == 1 && airTemp > 5)
                {
                    airTemp--;
                    Console.WriteLine("{0} Градусов", airTemp);
                }
            }
        }
	}
}
