using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapDotNet.Core;
using PcapDotNet.Base;
using PcapDotNet.Packets;

namespace NetworkAnalzyer
{
    class InternetLayer
    {
        Data data;

        public InternetLayer(Data d)
        {
            data = d;
        }
        int cislo = 0;
        public void analyzuj(Packet paket)
        {
            string retazec = "";
            int i = 1;
            foreach(Byte bajt in paket)
            {
                retazec += bajt.ToString("X2");
                
                if (i % 8 == 0)
                {
                    retazec += "    ";
                    
                }
                else if (i % 1 == 0)
                    retazec += "_";
                i++;
               
            }
            data.vlozZaznam(cislo++, "", "", "", "", "", retazec);
        }
    }
}
