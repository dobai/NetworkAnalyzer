using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapDotNet.Packets;
using PcapDotNet.Core;

namespace NetworkAnalzyer
{
    class Analysis
    {
        int count;
        public ArrayList communication;

        public Analysis()
        {
            communication = new ArrayList();
            count = 0;
        }

        public void analyse(int count)
        {

            using (PacketCommunicator komunikator = LivePacketDevice.AllLocalMachine[0].Open(6553, PacketDeviceOpenAttributes.Promiscuous, 1500))
            {
                komunikator.ReceivePackets(count, analyzuj);
            }
            count = 0;
        }

        public void analyse(string cesta, int count)
        {
            using (PacketCommunicator komunikator = new OfflinePacketDevice(cesta).Open(65536, PacketDeviceOpenAttributes.Promiscuous, 0))
            {
                komunikator.ReceivePackets(count, analyzuj);
            }
            count = 0;
        }

        public void analyzuj(Packet packet)
        {
            communication.Add(new Frame(packet, count));
        }

    }
}
