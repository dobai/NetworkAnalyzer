using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using PcapDotNet.Base;
using PcapDotNet.Core;

namespace SietovyAnalyzator
{
    class Vrstva1
    {
        Data data;
        private OfflinePacketDevice zariadenie;
        private Vrstva2 vrstva2;

        public Vrstva1(Data d)
        {
            data = d;
            vrstva2 = new Vrstva2(data);
        }

        public void otvorZariadenie(string cesta)
        {
                zariadenie = new OfflinePacketDevice(cesta);
                analyzuj(0);
        }

        public void analyzuj(int pocet)
        {
            using (PacketCommunicator komunikator = zariadenie.Open(65536, PacketDeviceOpenAttributes.Promiscuous, 0))
            {
                komunikator.ReceivePackets(pocet, vrstva2.analyzuj);
            }
        }
    }
}
