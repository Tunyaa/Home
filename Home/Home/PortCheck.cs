using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home
{
    class PortCheck
    {
        ///                                              1 2 3 4   5 6 7 8 
        /// /////////////////////////////////////////   |_|_|_|_| |_|_|_|_|   /////////////////1-канал+ 2-канал- 3-градус+ 4-градус- 5- свет вкл\выкл 6- ТВ вкл\выкл 7-кондей 8-
        /// 
        Light lamp = new Light();
        Air air = new Air();
        Channel channel = new Channel();
        private byte port;
        public byte Port
        {
            set
            {
                port = value;
            }
            get
            {
                return port;
            }
        }

        public void PortSend(byte port)
        {
            if (port == 0x08)
            {
                lamp.SwitchLight(1);
                
            }
            if (port == 0xF7)
            {
                lamp.SwitchLight(0);
            }
            if (port == 0x02)//air on
            {
                air.SetAir(1);
            }
            if (port == 0xfd)//air off
            {
                air.SetAir(0);
            }
            if (port == 0x20)//air+
            {
                air.SetAir(3);
            }
            if (port == 0xdf)//air-
            {
                air.SetAir(4);
            }
            if (port == 0x80)//ch+
            {
                channel.SetChannel(3);
            }
            if (port == 0x7f)//ch-
            {
                channel.SetChannel(4);
            }
            if (port == 0x01)
            {
                channel.Show(1);
            }
        }

    }
}
