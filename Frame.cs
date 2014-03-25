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
            internet = new InternetLayer(networkInterface.Raw, networkInterface.ProtocolID);
        }

        public string getInfo()
        {
            string s;
            s = "rámec " + id + Environment.NewLine + Environment.NewLine;
            s += "dĺžka rámca (logická) - " + networkInterface.Lenght + " B" + Environment.NewLine;
            s += "dĺžka rámca (fyzická) - " + networkInterface.PhysicalLenght + " B" + Environment.NewLine;
            s += "typ rámca             - " + networkInterface.Type + Environment.NewLine;
            s += "zdrojová MAC adresa   - " + networkInterface.SourceMAC + Environment.NewLine;
            s += "cieľová MAC adresa    - " + networkInterface.DestinationMAC + Environment.NewLine;
            s += "zdrojová IP adresa    - " + internet.DestinationIP + Environment.NewLine;
            s += "cieľová IP adresa     - " + internet.SourceIP;
            return s;
        }
    }
}
