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

        private Byte[] packet;
        private Byte[] raw;
        private string sourceIP;
        private string destinationIP;
        private int operation;
        private int protocol;
        private string foundMAC;

        public string SourceIP { get { return sourceIP; } }
        public string DestinationIP { get { return destinationIP; } }
        public string FoundMAC { get { return foundMAC; } }
        public int Operation { get { return operation; } }
        public int Protocol { get { return protocol; } }
        public Byte[] Raw { get { return raw; } }


        public InternetLayer(Byte[] packet, int protocol)
        {
            if(protocol == -1)
                this.protocol = -1;
            
            this.packet = packet;
            switch(protocol)
            {
                case 2048:
                    IP();
                    break;
                case 2054:
                    ARP();
                    break;

            }
        }

        private void IP()
        {
            destinationIP = "";
            destinationIP += packet[12].ToString("D") + ".";
            destinationIP += packet[13].ToString("D") + ".";
            destinationIP += packet[14].ToString("D") + ".";
            destinationIP += packet[15].ToString("D");

            sourceIP = "";
            sourceIP += packet[16].ToString("D") + ".";
            sourceIP += packet[17].ToString("D") + ".";
            sourceIP += packet[18].ToString("D") + ".";
            sourceIP += packet[19].ToString("D");

            protocol = packet[9];

            int lenght = (packet[0] % 16) * 4;
            raw = new Byte[packet.Length - lenght];
            Buffer.BlockCopy(packet, lenght, raw, 0, packet.Length - lenght);
        }

        private void ARP()
        {
            destinationIP = "";
            destinationIP += packet[24].ToString("D") + ".";
            destinationIP += packet[25].ToString("D") + ".";
            destinationIP += packet[26].ToString("D") + ".";
            destinationIP += packet[27].ToString("D");

            sourceIP = "";
            sourceIP += packet[14].ToString("D") + ".";
            sourceIP += packet[15].ToString("D") + ".";
            sourceIP += packet[16].ToString("D") + ".";
            sourceIP += packet[17].ToString("D");

            operation = packet[06] + packet[07];

            foundMAC = "";
            for (int i = 8; i < 14; i++)
                foundMAC += packet[i].ToString("X2") + " ";
            foundMAC.TrimEnd(' ');

            protocol = -1;
        }
        
        /*
        private string getDestinationIP()
        {
            string IP = "";
            IP += packet[12].ToString("D") + ".";
            IP += packet[13].ToString("D") + ".";
            IP += packet[14].ToString("D") + ".";
            IP += packet[15].ToString("D");
            return IP;

        }
        private string getSourceIP()
        {
            string IP = "";
            IP += packet[16].ToString("D") + ".";
            IP += packet[17].ToString("D") + ".";
            IP += packet[18].ToString("D") + ".";
            IP += packet[19].ToString("D");
            return IP;
        }*/

    }
}
