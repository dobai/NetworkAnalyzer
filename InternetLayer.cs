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
        private string sourceIP;
        private string destinationIP;

        public string SourceIP { get { return sourceIP; } }
        public string DestinationIP { get { return destinationIP; } }
        public InternetLayer(Byte[] packet, int protocol)
        {
            this.packet = packet;
            if (protocol == 2048)
            {
                destinationIP = getDestinationIP();
                sourceIP = getSourceIP();
            }
        }
        private string getSourceIP()
        {
            string IP = "";
            IP += packet[13].ToString("D") + ".";
            IP += packet[14].ToString("D") + ".";
            IP += packet[15].ToString("D") + ".";
            IP += packet[16].ToString("D");
            return IP;
        }
        private string getDestinationIP()
        {
            string IP = "";
            IP += packet[17].ToString("D") + ".";
            IP += packet[18].ToString("D") + ".";
            IP += packet[19].ToString("D") + ".";
            IP += packet[20].ToString("D");
            return IP;
        }

    }
}
