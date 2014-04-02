using System;
using System.IO;
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
        private int protocol;
        private string type;
        private string sourceMAC;
        private string destinationMAC;

        public int Protocol { get { return protocol; } }
        public Byte[] Raw { get { return raw; } }
        public int Lenght { get { return lenght; } }
        public int PhysicalLenght { get { return physicalLenght; } }
        public string Type { get { return type; } }
        public string SourceMAC { get { return sourceMAC; } }
        public string DestinationMAC { get { return destinationMAC; } }

        public NetworkInterfaceLayer(Packet packet)
        {
            this.packet = packet;
            getRaw();
            lenght = packet.Count;
            physicalLenght = determinePhysicalLenght();
            type = getTypeOfFrame();
            destinationMAC = getDestinationMAC();
            sourceMAC = getSourceMAC();
        }
        private int determinePhysicalLenght()
        {
                if (lenght < 60)
                    return 64;
                else
                    return lenght+4;
        }  
        private void getRaw()
        {
            Byte[] p = new Byte[packet.Count];
            packet.CopyTo(p, 0);
            if (packet[12] * 256 + packet[13] > 1500)
            {
                raw = new Byte[packet.Count-14];
                Buffer.BlockCopy(p, 14, raw, 0, packet.Count - 14);
            }
            else
            {
                raw = new Byte[packet.Count - 17];
                Buffer.BlockCopy(p, 17, raw, 0, packet.Count - 17);
            }
        }
        private string getTypeOfFrame()
        {
            if (packet[12] * 256 + packet[13] > 1500)
            {
                protocol = packet[12] * 256 + packet[13];
                return "Ethernet II";
            }
            else if (packet[14] * 256 + packet[15] == 65535)
            {
                protocol = -1;
                return "IEEE 802.3 - RAW";
            }
            else if (packet[14] * 256 + packet[15] == 43690)
            {
                protocol = -1;
                return "IEEE 802.3 - LLC - SNAP";
            }
            else
            {
                protocol = -1;
                return "IEEE 802.3 - LLC";
            }
        }
        private string getSourceMAC()
        {
            string MAC = "";
            for (int i = 6; i < 12; i++)
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
