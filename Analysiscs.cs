using System;
using System.IO;
using System.Windows.Forms;
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

    class keyValue
    {
        private int id;
        private string name;
        public keyValue(int id, string name)
        {
            this.id=id;
            this.name=name;
        }
        public int Id { get { return id; } }
        public string Name { get { return name; } }
    }

    class Analysis
    {
        int countFrame = 1;
        int countCommunication = 1;
        private ArrayList frames;
        private ArrayList communication;
        private ArrayList ethernetProtocols;
        private ArrayList ipProtocols;
        private ArrayList wellKnownPorts;

        public Analysis()
        {
            frames = new ArrayList();
            communication = new ArrayList();
            ethernetProtocols = new ArrayList();
            ipProtocols = new ArrayList();
            wellKnownPorts = new ArrayList();

            try
            {
                using (StreamReader file = new StreamReader(Properties.Settings.Default.EthernetProtocolCodes))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        int id = Convert.ToInt32(line.Split(';')[0], 16);
                        string name = line.Split(';')[1];
                        ethernetProtocols.Add(new keyValue(id, name));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Súbor nie je možné načítať.\n\n" + e.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                using (StreamReader file = new StreamReader(Properties.Settings.Default.IPProtocolCodes))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        int id = Convert.ToInt32(line.Split(';')[0], 16);
                        string name = line.Split(';')[1];
                        ipProtocols.Add(new keyValue(id, name));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Súbor nie je možné načítať.\n\n" + e.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                using (StreamReader file = new StreamReader(Properties.Settings.Default.WellKnownPorts))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        int id = Convert.ToInt32(line.Split(';')[0], 16);
                        string name = line.Split(';')[1];
                        wellKnownPorts.Add(new keyValue(id, name));
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Súbor nie je možné načítať.\n\n" + e.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void analyse(int cnt)
        {
            countFrame = 1;
            using (PacketCommunicator komunikator = LivePacketDevice.AllLocalMachine[0].Open(6553, PacketDeviceOpenAttributes.Promiscuous, 1500))
            {
                komunikator.ReceivePackets(cnt, analyseFrame);
            }
            
        }

        public void analyse(string cesta, int cnt)
        {
            countFrame = 1;
            using (PacketCommunicator komunikator = new OfflinePacketDevice(cesta).Open(65536, PacketDeviceOpenAttributes.Promiscuous, 0))
            {
                komunikator.ReceivePackets(cnt, analyseFrame);
            }
        }

        private void analyseFrame(Packet packet)
        {
            bool vlozene = false;
            Frame f = new Frame(packet, countFrame++);
            frames.Add(f);
            if (f.networkInterface.Protocol != -1)
            {
                foreach (Communication c in communication)
                {
                    if (((c.ClientIP == f.internet.SourceIP && c.ServerIP == f.internet.DestinationIP)
                    || (c.ServerIP == f.internet.SourceIP && c.ClientIP == f.internet.DestinationIP))
                    && ((c.ClientPort == f.transport.SourcePort && c.ServerPort == f.transport.DestinationPort)
                    || (c.ServerPort == f.transport.SourcePort && c.ClientPort == f.transport.DestinationPort))
                    && c.Protocol == f.internet.Protocol
                    && c.State!=CommunicationStates.Closed)
                    {
                        if (f.networkInterface.Protocol == 2054)
                            c.addARP(f);
                        else if (f.internet.Protocol == 1)
                            c.addICMP(f);
                        else if (f.internet.Protocol == 6)
                            c.addTCP(f);
                        else if (f.internet.Protocol == 17)
                            c.addUDP(f);
                        vlozene = true;
                        break;
                    }
                }
                if (!vlozene)
                {
                    Communication c = new Communication(countCommunication++, f.internet.SourceIP, f.internet.DestinationIP, f.transport.SourcePort, f.transport.DestinationPort, f.internet.Protocol);
                    if (f.networkInterface.Protocol == 2054)
                        c.addARP(f);
                    else if (f.internet.Protocol == 1)
                        c.addICMP(f);
                    else if (f.internet.Protocol == 6)
                        c.addTCP(f);
                    else if (f.internet.Protocol == 17)
                        c.addUDP(f);
                    communication.Add(c);
                }
            }
        }

        public Frame getFrame(int number)
        {
            return (Frame)frames[number];
        }

        public Communication getCommunication(int number)
        {
            return (Communication)communication[number];
        }
        
        public string getFrameInfo(int number)
        {
            Frame f = getFrame(number);
            string s;
            s = "rámec " + f.Id + Environment.NewLine + Environment.NewLine;
            s += "dĺžka rámca (logická)        - " + f.networkInterface.Lenght + " B" + Environment.NewLine;
            s += "dĺžka rámca (fyzická)        - " + f.networkInterface.PhysicalLenght + " B" + Environment.NewLine;
            s += "typ rámca                    - " + f.networkInterface.Type + Environment.NewLine;
            s += "zdrojová MAC adresa          - " + f.networkInterface.SourceMAC + Environment.NewLine;
            s += "cieľová MAC adresa           - " + f.networkInterface.DestinationMAC + Environment.NewLine;
            s += "Protokol sieťovej vrstvy     - " + getEthernetProtocolName(f.networkInterface.Protocol) + Environment.NewLine;
            s += "zdrojová IP adresa           - " + f.internet.DestinationIP + Environment.NewLine;
            s += "cieľová IP adresa            - " + f.internet.SourceIP + Environment.NewLine;
            s += "Protokol transportnej vrstvy - " + getIPProtocolName(f.internet.Protocol) + Environment.NewLine;
            s += "cieľový port                 - " + getPortName(f.transport.DestinationPort) + Environment.NewLine;
            s += "zrojový port                 - " + getPortName(f.transport.SourcePort) + Environment.NewLine;
            s += "fin                 - " + f.transport.FinFlag + Environment.NewLine;
            s += "syn                 - " + f.transport.SynFlag + Environment.NewLine;
            s += "rst                 - " + f.transport.RstFlag + Environment.NewLine;
            s += "ack                 - " + f.transport.AckFlag + Environment.NewLine;
            return s;
        }

        public string getHistogram(Communication c)
        {
            int i;
            string histogram = "";
            int[,] fromTo = new int[10, 2];
            int[] hist = new int[10];
            for (i = 0; i < fromTo.Length/2; i++)
            {
                fromTo[i, 0] = (int)Math.Pow(2, i) * 10;
                fromTo[i, 1] = (int)Math.Pow(2, i + 1) * 10 - 1;
            }


            foreach (Frame f in c.Frames)
            {
                for (int j = 0; j < fromTo.Length/2; j++)
                {
                    if (f.networkInterface.Lenght >= fromTo[j, 0] && f.networkInterface.Lenght <= fromTo[j, 1])
                        hist[j]++;
                }
            }

            i=0;
            foreach(int n in hist)
            {
                histogram += "\t<" + Math.Pow(2, i) * 10 + ", " + (Math.Pow(2, i+1) * 10 - 1) + ">: \t" + n + Environment.NewLine;
                i++;
            }
            return histogram;
        }

        public string getCommunicationInfo(int number)
        {
            string s="";
            Communication c = getCommunication(number);
            switch (c.Type)
            {

                case 2054:
                    s = "";
                    s += "Komunikácia " + c.Id + Environment.NewLine + Environment.NewLine;
                    s += "typ komunikácie                         - " + getEthernetProtocolName(c.Type) + Environment.NewLine;
                    s += "IP adresa ku ktorej sa hľadá MAC adresa - " + c.ArpIP + Environment.NewLine;
                    s += "Nájdená MAC adresa                      - " + c.ArpMAC + Environment.NewLine;
                    s += "Komunikácia je kompletná:               - " + ((c.State == CommunicationStates.Closed) ? "Áno" : "Nie") + Environment.NewLine;
                    break;
                case 1:
                    s = "";
                    s += "Komunikácia " + c.Id + Environment.NewLine + Environment.NewLine;
                    s += "typ komunikácie - " + getIPProtocolName(c.Type) + Environment.NewLine;
                    s += "typ správy      - " + c.IcmpType + Environment.NewLine;
                    break;
                case 80:
                case 443:
                case 23:
                case 22:
                case 21:
                case 20:
                    s = "";
                    s += "Komunikácia " + c.Id + Environment.NewLine + Environment.NewLine;
                    s += "Kyp komunikácie           - " + getPortName(c.Type) + Environment.NewLine;
                    s += "Komunikácia je kompletná: - " + ((c.State == CommunicationStates.Closed) ? "Áno" : "Nie") + Environment.NewLine;
                    if (c.State == CommunicationStates.Closed)
                    {
                        s += "Štatistika výskytu rámcov:" + Environment.NewLine;
                        s += getHistogram(c);
                    }
                    break;
                case 69:
                    s += "Komunikácia " + c.Id + Environment.NewLine + Environment.NewLine;
                    s += "typ komunikácie - " + getPortName(c.Type) + Environment.NewLine;
                    break;
            }
            return s;
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

        public DataTable getDataTableCommunications(int protocol, bool all)
        {
            bool complete = false;
            bool incomplete = false;
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Typ", typeof(string));
            table.Columns.Add("Zdrojová IP", typeof(string));
            table.Columns.Add("Cieľová IP", typeof(string));
            table.Columns.Add("Zdrojový port", typeof(string));
            table.Columns.Add("Cieľový port", typeof(string));
            table.Columns.Add("Transportný protokol", typeof(string));
            table.Columns.Add("Kompletná komunikácia", typeof(bool));
            table.Columns.Add(" ", typeof(string));

            foreach (Communication c in communication)
            {
                string Type = "";
                switch(c.Layer)
                {
                    case Layers.NetworkInterface:
                        Type = getEthernetProtocolName(c.Type);
                        break;
                    case Layers.Internet:
                        getIPProtocolName(c.Type);
                        break;
                    case Layers.Transport:
                        break;
                    case Layers.Application:
                        Type = getPortName(c.Type);
                        break;
                }
                string ServerIP =c.ServerIP;
                string ClientIP = c.ClientIP;
                string ServerPort = getPortName(c.ServerPort);
                string ClientPort = getPortName(c.ClientPort);
                string TransportProtocol = getIPProtocolName(c.Protocol);

                if (c.Type == protocol)
                {
                    if (!all)
                    {
                        if (!complete && c.State == CommunicationStates.Closed)
                        {
                            table.Rows.Add(c.Id, Type, ServerIP, ClientIP, ServerPort, ClientPort, TransportProtocol, c.State == CommunicationStates.Closed);
                            complete = true;
                        }
                        else if (!incomplete && c.State != CommunicationStates.Closed)
                        {
                            table.Rows.Add(c.Id, Type, ServerIP, ClientIP, ServerPort, ClientPort, TransportProtocol, c.State == CommunicationStates.Closed);
                            incomplete = true;
                        }
                    }
                    else 
                    {
                        table.Rows.Add(c.Id, Type, ServerIP, ClientIP, ServerPort, ClientPort, TransportProtocol, c.State == CommunicationStates.Closed);

                    }
                }
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

        public DataTable getFrameList(int communication)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Typ", typeof(string));
            table.Columns.Add("Dĺźka", typeof(string));
            table.Columns.Add("Stav", typeof(string));
            table.Columns.Add(" ", typeof(string));

            Communication c = getCommunication(communication);

            foreach (Frame f in c.Frames)
            {
                table.Rows.Add(f.Id, f.networkInterface.Type, f.networkInterface.Lenght, f.akykolvekText);
            }
            return table;
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

        public string getEthernetProtocolName(int id)
        {
            foreach (keyValue p in ethernetProtocols)
            {
                if (p.Id == id)
                    return p.Name + " (" + p.Id + ")";
            }
            return "";
        }

        public string getIPProtocolName(int id)
        {
            foreach (keyValue p in ipProtocols)
            {
                if (p.Id == id)
                    return p.Name + " (" + p.Id + ")";
            }
            if (id == -1)
                return "";
            else
                return "(" + id + ")";
        }

        public string getPortName(int id)
        {
            foreach (keyValue p in wellKnownPorts)
            {
                if (p.Id == id)
                    return p.Name + " (" + p.Id + ")";
            }
            if (id == -1)
                return "";
            else
                return "(" + id + ")";
        }
    }
}
