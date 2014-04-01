using System;
using System.Data;
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
        int count = 1;
        private ArrayList frames;
        private ArrayList communication;

        public Analysis()
        {
            frames = new ArrayList();
            communication = new ArrayList();
            count = 0;
        }

        public void analyse(int cnt)
        {
            count = 1;
            using (PacketCommunicator komunikator = LivePacketDevice.AllLocalMachine[0].Open(6553, PacketDeviceOpenAttributes.Promiscuous, 1500))
            {
                komunikator.ReceivePackets(cnt, analyseFrame);
            }
            
        }

        public void analyse(string cesta, int cnt)
        {
            count = 1;
            using (PacketCommunicator komunikator = new OfflinePacketDevice(cesta).Open(65536, PacketDeviceOpenAttributes.Promiscuous, 0))
            {
                komunikator.ReceivePackets(cnt, analyseFrame);
            }
        }

        private void analyseFrame(Packet packet)
        {
            bool vlozene = false;
            Frame f = new Frame(packet, count++);
            frames.Add(f);
            foreach (Communication c in communication)
            {
                if (((c.ClientIP == f.internet.SourceIP && c.ServerIP == f.internet.DestinationIP)
                || (c.ServerIP == f.internet.SourceIP || c.ClientIP == f.internet.DestinationIP))
                && ((c.ClientPort == f.transport.SourcePort && c.ServerPort == f.transport.DestinationPort)
                || (c.ServerPort == f.transport.SourcePort || c.ClientPort == f.transport.DestinationPort))
                && c.Protocol == f.internet.Protocol)
                {
                    c.addTCP(0, 0, -1, -1);
                    vlozene = true;
                    break;
                }
            }
            if (!vlozene)
            {
                Communication c = new Communication(f.internet.SourceIP, f.internet.DestinationIP, f.transport.SourcePort, f.transport.DestinationPort, f.internet.Protocol);
                c.addTCP(0, 0, -1, -1);
                communication.Add(c);
            }
        }

        public Frame getFrame(int number)
        {
            return (Frame)frames[number];
        }

        public DataTable getDataTableFrames()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Typ", typeof(string));
            table.Columns.Add("Zdrojová MAC", typeof(string));
            table.Columns.Add("Cieľová MAC", typeof(string));
            table.Columns.Add("Dĺźka", typeof(string));
            table.Columns.Add("Fyzická dĺžka", typeof(string));
            table.Columns.Add(" ", typeof(string));

            foreach(Frame f in frames)
            {
                table.Rows.Add(f.Id, f.networkInterface.Type, f.networkInterface.SourceMAC, f.networkInterface.DestinationMAC, f.networkInterface.Lenght, f.networkInterface.PhysicalLenght);
            }
            return table;
        }

        public DataTable getDataTableCommunications()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Typ", typeof(string));
            table.Columns.Add("Zdrojová IP", typeof(string));
            table.Columns.Add("Cieľová IP", typeof(string));
            table.Columns.Add("Zdrojový port", typeof(string));
            table.Columns.Add("Cieľový port", typeof(string));
            table.Columns.Add("Transportný protokol", typeof(string));
            table.Columns.Add(" ", typeof(string));

            foreach (Communication c in communication)
            {
                table.Rows.Add(c.Type, c.ServerIP, c.ClientIP, c.ServerPort, c.ClientPort, c.Protocol);
                
            }
            return table;
        }

        public List<string> getIPList()
        {
            List<string> list = new List<string>();
            foreach(Frame f in frames )
            {
                if (!list.Contains(f.internet.SourceIP) && f.internet.SourceIP != null)
                    list.Add(f.internet.SourceIP);
            }
            return list;
        }

        public List<string> getProtocols()
        {
            List<string> list = new List<string>();
            list.Add("HTTP komunikácie");
            list.Add("HTTPS komunikácie");
            list.Add("TELNET komunikácie");
            list.Add("SSH komunikácie");
            list.Add("FTP riadiace komunikácie");
            list.Add("FTP dátové komunikácie");
            list.Add("TFTP komunikácie");
            list.Add("ICMP komunikácie");
            list.Add("ARP komunikácie");
            return list;
        }
        
        public string getMaxIP()
        {
            List<string> list = getIPList();
            Int32[] bytes = new Int32[list.Count];
            foreach (Frame f in frames)
            {
                if (f.internet.SourceIP != null)
                    //bytes[list.FindIndex(x => x.StartsWith(f.internet.SourceIP))] += f.networkInterface.Lenght;
                    bytes[list.FindIndex(item => item == f.internet.SourceIP)] += f.networkInterface.Lenght;
            }
            return list[bytes.ToList().IndexOf(bytes.Max())] + "    (" + bytes.Max() + " B)";
        }
    }
}
