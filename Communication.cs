using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAnalzyer
{
    public enum CommunicationStates {Listen, SynRecived, PartiallyEstablished, Established, WaitForAck, Closed}
    public enum Layers { NetworkInterface, Internet, Transport, Application }

    class Communication
    {
        public int incomplete = 0;
        private int id;
        private int type;
        private int serverPort;
        private int clientPort;
        private string serverIP;
        private string clientIP;
        private int protocol;
        private Layers layer;
        private bool isClosed1;
        private bool isClosed2;
        private string arpIP;
        private string arpMAC;
        private int icmpType;
        private CommunicationStates state;
        private List<Frame> frames = new List<Frame>();

        public int Id { get { return id; } }
        public int ServerPort { get { return serverPort; } }
        public int ClientPort { get { return clientPort; } }
        public string ServerIP { get { return serverIP; } }
        public string ClientIP { get { return clientIP; } }
        public string ArpIP { get { return arpIP; } }
        public int IcmpType { get { return icmpType; } }
        public string ArpMAC { get { return arpMAC; } }
        public int Protocol { get { return protocol; } }
        public Layers Layer { get { return layer; } }
        public CommunicationStates State { get { return state; } }
        public List<Frame> Frames { get { return frames; } }
        public int Type { get { return type; } }

        public Communication(int id, string serverIP, string clientIP, int serverPort, int clientPort, int protocol)
        {
            this.id = id;
            state = CommunicationStates.Listen;
            layer = Layers.Application;
            isClosed1 = false;
            isClosed2 = false;
            this.serverIP = serverIP;
            this.clientIP = clientIP;
            this.serverPort = serverPort;
            this.clientPort = clientPort;
            this.protocol = protocol;

            type = -1;

            if (clientPort == -1 && serverPort == -1)
                type = protocol;

            switch (serverPort)
            {
                case 20:
                case 21:
                case 22:
                case 23:
                case 80:
                case 433:
                case 69:
                    type = serverPort;
                    break;
                default:
                    break;
            }

            switch (clientPort)
            {
                case 20:
                case 21:
                case 22:
                case 23:
                case 80:
                case 443:
                case 69:
                    type = clientPort;
                    break;
                default:
                    break;
            }
        }

        public void addTCP(Frame f)
        {
            if (f.transport.SynFlag && !f.transport.AckFlag && state == CommunicationStates.Listen)
            {
                state = CommunicationStates.SynRecived;
                f.akykolvekText = CommunicationStates.SynRecived.ToString();
            }
            else if (f.transport.SynFlag && f.transport.AckFlag && state == CommunicationStates.SynRecived)
            {
                state = CommunicationStates.PartiallyEstablished;
                f.akykolvekText = CommunicationStates.PartiallyEstablished.ToString();
            }
            else if (!f.transport.SynFlag && f.transport.AckFlag && state == CommunicationStates.PartiallyEstablished)
            {
                state = CommunicationStates.Established;
                f.akykolvekText = CommunicationStates.Established.ToString();
            }


            if (f.transport.RstFlag)
            {
                state = CommunicationStates.Closed;
                f.akykolvekText += "Reset ";
                if (incomplete == 1)
                    incomplete = 2;
            }
            else if (f.transport.AckFlag && state == CommunicationStates.WaitForAck)
            {
                state = CommunicationStates.Closed;
                f.akykolvekText += "Closed ";
            }
            else
            {
                if (f.transport.FinFlag && f.internet.SourceIP == serverIP)
                {
                    isClosed1 = true;
                    f.akykolvekText += "Closed1stNode ";
                }
                else if (f.transport.FinFlag && f.internet.SourceIP == clientIP)
                {
                    isClosed2 = true;
                    f.akykolvekText += "Closed2ndNode ";
                }

                if (isClosed1 && isClosed2)
                {
                    state = CommunicationStates.WaitForAck;
                    f.akykolvekText += "WaitForAck";
                }
            }

            layer = Layers.Application;
            if (state == CommunicationStates.Listen)
            {
                state = CommunicationStates.Established;
                f.akykolvekText += "Established";
                incomplete = 1;
            }
            frames.Add(f);
        }

        public void addARP(Frame f)
        {
            if (f.internet.Protocol==-1)
            {
                if (f.internet.Operation == 1)
                {
                    arpIP = f.internet.DestinationIP;
                    state = CommunicationStates.Established;
                    frames.Add(f);
                }

                if (f.internet.Operation == 2 && state == CommunicationStates.Established)
                {
                    arpMAC = f.networkInterface.SourceMAC;
                    state = CommunicationStates.Closed;
                    arpMAC = f.internet.FoundMAC;
                    frames.Add(f);
                }
                type = 2054;
                layer = Layers.NetworkInterface;
            }
        }

        public void addICMP(Frame f)
        {
            state = CommunicationStates.Closed;
            type  = 1;
            layer = Layers.Internet;
            icmpType = f.transport.IcmpType;
            frames.Add(f);
        }

        public void addUDP(Frame f)
        {
            state = CommunicationStates.Closed;
            layer = Layers.Application;
            frames.Add(f);
        }
    }


    class Communication2
    {
        private int id;
        private int type;
        private int serverPort;
        private int clientPort;
        private string serverIP;
        private string clientIP;
        private int protocol;
        private Layers layer;
        private bool isClosed1;
        private bool isClosed2;
        private string arpIP;
        private string arpMAC;
        private int icmpType;
        public bool IsIncomplete;
        private CommunicationStates state;
        private List<Frame> frames = new List<Frame>();

        public int Id { get { return id; } }
        public int ServerPort { get { return serverPort; } }
        public int ClientPort { get { return clientPort; } }
        public string ServerIP { get { return serverIP; } }
        public string ClientIP { get { return clientIP; } }
        public string ArpIP { get { return arpIP; } }
        public int IcmpType { get { return icmpType; } }
        public string ArpMAC { get { return arpMAC; } }
        public int Protocol { get { return protocol; } }
        public Layers Layer { get { return layer; } }
        public CommunicationStates State { get { return state; } }
        public List<Frame> Frames { get { return frames; } }
        public int Type { get { return type; } }

        public Communication2(int id, string serverIP, string clientIP, int serverPort, int clientPort, int protocol)
        {
            this.id = id;
            state = CommunicationStates.Listen;
            layer = Layers.Application;
            isClosed1 = false;
            isClosed2 = false;
            this.serverIP = serverIP;
            this.clientIP = clientIP;
            this.serverPort = serverPort;
            this.clientPort = clientPort;
            this.protocol = protocol;

            type = -1;

            if (clientPort == -1 && serverPort == -1)
                type = protocol;

            switch (serverPort)
            {
                case 20:
                case 21:
                case 22:
                case 23:
                case 80:
                case 433:
                case 69:
                    type = serverPort;
                    break;
                default:
                    break;
            }

            switch (clientPort)
            {
                case 20:
                case 21:
                case 22:
                case 23:
                case 80:
                case 443:
                case 69:
                    type = clientPort;
                    break;
                default:
                    break;
            }
        }

        public void addTCP(Frame f)
        {
            if (f.transport.SynFlag && !f.transport.AckFlag && state == CommunicationStates.Listen)
            {
                state = CommunicationStates.SynRecived;
                f.akykolvekText = CommunicationStates.SynRecived.ToString();
            }


            if (f.transport.SynFlag && f.transport.AckFlag && state == CommunicationStates.SynRecived)
            {
                state = CommunicationStates.PartiallyEstablished;
                f.akykolvekText = CommunicationStates.PartiallyEstablished.ToString();
            }

            if (!f.transport.SynFlag && f.transport.AckFlag && state == CommunicationStates.PartiallyEstablished)
            {
                state = CommunicationStates.Established;
                f.akykolvekText = CommunicationStates.Established.ToString();
            }


            if (f.transport.RstFlag)
            {
                state = CommunicationStates.Closed;
                IsIncomplete = false;
                f.akykolvekText += "Reset ";
            }
            else if (f.transport.AckFlag && state == CommunicationStates.WaitForAck)
            {
                state = CommunicationStates.Closed;
                f.akykolvekText += "Closed ";
            }
            else
            {
                if (f.transport.FinFlag && f.internet.SourceIP == serverIP)
                {
                    isClosed1 = true;
                    f.akykolvekText += "Closed1stNode ";
                }
                else if (f.transport.FinFlag && f.internet.SourceIP == clientIP)
                {
                    isClosed2 = true;
                    f.akykolvekText += "Closed2ndNode ";
                }

                if (isClosed1 && isClosed2)
                {
                    state = CommunicationStates.WaitForAck;
                    f.akykolvekText += "WaitForAck";
                }
            }

            layer = Layers.Application;
            frames.Add(f);
        }
    }
}
