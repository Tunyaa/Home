using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Channel
    {
        int channel = 1;
        public void Show(int x)
        {
            if (x==1)
            {
                Console.WriteLine("Канал 1\nОРТ - Прогноз погоды: Москва -20, Минск -8, Одесса +15");
            }
            if (x==2)
            {
                Console.WriteLine("Канал 2\nНТВ - Следствие ведут Колобки");  
            }
            if (x==3)
            {
                Console.WriteLine("Канал 3\nКультура - Концерт 50-летия Октября");  
            }
            if (x==4)
            {
                Console.WriteLine("Канал 4\nСпорт- Биатлон");  
            }
            if (x==5)
            {
                Console.WriteLine("Канал 5\nКухняТВ - Рецепт макарон от Шоколатье");  
            }
            if (x==6)
            {
                Console.WriteLine("Канал 6\n~~Помехи~~~");  
            }

        }
        public void SetChannel(byte x)
        {
            if (x==3)
            {
                channel++;
                if (channel>6)
                {
                    channel = 1;
                }
                Show(channel);
            }
            if (x==4)
            {
                channel--;
                if (channel<1)
                {
                    channel = 6;
                }
                Show(channel);
            }
        }
    }
}
