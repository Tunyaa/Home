using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class Controller
    {


        public void Menu()
        {
            Button button = new Button();
            PortCheck port = new PortCheck();
            

            while (true)
            {
                Console.WriteLine("\nМеню");
                Console.WriteLine("Выбрать телевизор - 't' \nВыбрать кондиционер - 'a' \nВыбрать Свет - 'l'");
                char key = button.CheckButton();
                if (key =='t')//tv
                {
                            Console.WriteLine("\nТелевизор\nВкл. - '1'\nВыкл. - '2'\nГромкость - -/+\nПерекльчить канал - <3/4>\nВернуться в меню - q");
                    int chekTv = 0;
                    int vol = 10;
                    
                    while (true)
                    {
                        key = button.CheckButton();

                        if (key  == '1')
                        {
                            chekTv = 1;
                            Console.WriteLine("Телевитзор включен");
                            port.PortSend(0x01);
                            continue;
                        }
                        if (key  == '2')
                        {
                            chekTv = 2;
                            Console.WriteLine("Теливизор выключен");
                            continue;
                        }
                        if (key =='=')
                        {
                            if (vol == 30)
                            {
                                Console.WriteLine("Максимальная громкость");
                                continue;
                            }
                            if (chekTv == 1 && vol <30)
                            {
                                vol++;
                                Console.WriteLine("Volume {0}", vol);
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\nТелевизор выключен");
                                continue;
                            }
                            
                            
                        }
                        if (key == '-')
                        {
                            if (vol ==0)
                            {
                                Console.WriteLine("Звук выключен");
                                continue;    
                            }
                            if (vol>0 && chekTv == 1)
                            {
                                vol--;
                                Console.WriteLine("Volume {0}", vol);
                                continue;
                            }
                            else
                            {
                                Console.WriteLine("\nТелевизор выключен!");
                                continue;
                            }
                            
                        }
                        if (key =='3')
                        {
                            if (chekTv==1)
                            {
                                port.PortSend(0x7f);
                            }
                            else
                            {
                                Console.WriteLine("Телевизор выключен");
                            }
                            
                            continue;
                        }
                        if (key == '4')
                        {
                            if (chekTv==1)
                            {
                                port.PortSend(0x80);
                            }
                            else
                            {
                                Console.WriteLine("Телевизор выключен");
                            }
                            
                            continue;
                        }
                        if (key == 'q')
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\nВкл. - '1'\nВыкл. - '2'\nГромкость - -/+\nПерекльчить канал - <3/4>\nВернуться в меню - q");
                        }
                    }
                }//tv
                if (key == 'a')//air
                {
                    Console.WriteLine("\nВключить кондиционер - '1'\nВыключить кондиционер - '2'\nИзменить темрпературу - '-/+'\nВернуться в меню -'q'");
                    while (true)
                    {
                        key = button.CheckButton();
                        if (key =='1')// air on
                        {
                            port.PortSend(0x02);
                        }
                        if (key =='2')//air off
                        {
                            port.PortSend(0xfd);
                        }
                        if (key =='-')//air+
                        {
                            port.PortSend(0xdf);
                        }
                        if (key =='=')//air-
                        {
                            
                            port.PortSend(0x20);
                        }
                        if (key =='q')//qq
                        {
                            break;
                        }
                    }
                }//air
                if (key == 'l') //Light
                {
                    Console.WriteLine("\nВключить всет -'1'\nВыключить свет - '2'\nВернуться в меню - 'q' ");
                    while (true)
                    {
                        key = button.CheckButton();
                        if (key == '1')
                        {
                            
                            port.PortSend(0x08);
                            Console.WriteLine("Вкл\nВыйти в меню - 'q'");
                            continue;
                        }
                        if (key == '2')
                        {
                            
                            port.PortSend(0xF7);
                            Console.WriteLine("Выкл\nВыйти в меню - 'q'");
                            continue;
                        }
                        if (key == 'q')
                        {
                            break;
                        }
                    }

                } //Light
            }
            Console.ReadLine();



        }
    }
}
