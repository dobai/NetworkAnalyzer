using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapDotNet.Packets;
using PcapDotNet.Core;

namespace NetworkAnalzyer
{
    class Frame
    {
        private int id;
        private byte[] raw;
        public NetworkInterfaceLayer networkInterface;
        public InternetLayer internet;
        public TransportLayer transport;
        public ApplicationLayer application;

        public int Id { get { return id; } }
        public byte[] Raw { get { return raw; } }
    
        public Frame(Packet packet, int id)
        {
            this.id = id;
            raw = new Byte[packet.Count];
            packet.CopyTo(raw, 0);
            networkInterface = new NetworkInterfaceLayer(packet);
            internet = new InternetLayer(networkInterface.Raw, networkInterface.Protocol);
            transport = new TransportLayer(internet.Raw, internet.Protocol);
        }
    }
}
