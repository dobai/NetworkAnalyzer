using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapDotNet.Packets;
using PcapDotNet.Core;

namespace NetworkAnalzyer
{
    class NetworkInterfaceLayer
    {
        private Packet packet;
        private Byte[] raw;
        private int lenght;
        private int physicalLenght;
        private string type;
        private string sourceMAC;
        private string destinationMAC;

        public byte[] Raw { get { return raw; } }
        public int Lenght { get { return lenght; } }
        public int PhysicalLenght { get { return physicalLenght; } }
        public string Type { get { return type; } }
        public string SourceMAC { get { return sourceMAC; } }
        public string DestinationMAC { get { return destinationMAC; } }

        public NetworkInterfaceLayer(Packet packet)
        {
            this.packet = packet;
            raw = new Byte[packet.Count];
            packet.CopyTo(raw, 0);
            lenght = packet.Count;
            physicalLenght = determinePhysicalLenght();
            type = getTypeOfFrame();
            destinationMAC = getDestinationMAC();
            sourceMAC = getSourceMAC();
        }
        private int determinePhysicalLenght()
        {
            BitArray bity = new BitArray(raw);
            int i = 0;
            int j = 0;
            foreach (bool bit in bity )
            {
                if (bit) j++; else j = 0;
                if (j != 5) i++; else j = 0;
            }
            return i/8;
        }
        private string getTypeOfFrame()
        {
            if (packet[13] * 256 + packet[14] < 1500)
                return "Ethernet II";
            else if(packet[15] * 256 + packet[16] == 65535)
                return "IEEE 802.3 - RAW";
            else if (packet[15] * 256 + packet[16] == 43690)
                return "IEEE 802.3 - LLC - SNAP";
            else
                return "IEEE 802.3 - LLC";
        }
        private string getSourceMAC()
        {
            string MAC = "";
            for (int i = 7; i < 12; i++)
                MAC += packet[i].ToString("X2") + " ";
            return MAC.TrimEnd(' ');
        }
        private string getDestinationMAC()
        {
            string MAC = "";
            for (int i = 0; i < 6; i++)
                MAC += packet[i].ToString("X2") + " ";
            return MAC.TrimEnd(' ');
        }
    }
}
