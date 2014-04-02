using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAnalzyer
{
    public enum CommunicationStates {Listen, SynRecived, PartiallyEstablished, Established, CloseWait, PartiallyClosed, TimeWait, Closed}
    public enum Layers { NetworkInterface, Internet, Transport, Application }

    class Communication
    {
        private int id;
        private int type;
        private int serverPort;
        private int clientPort;
        private string serverIP;
        private string clientIP;
        private int protocol;
        private Layers layer;
        private bool isClosed;
        private CommunicationStates state;
        private List<Frame> frames = new List<Frame>();

        public int Id { get { return id; } }
        public int ServerPort { get { return serverPort; } }
        public int ClientPort { get { return clientPort; } }
        public string ServerIP { get { return serverIP; } }
        public string ClientIP { get { return clientIP; } }
        public int Protocol { get { return protocol; } }
        public bool IsClosed { get { return isClosed; } }
        public Layers Layer { get { return layer; } }
        public CommunicationStates State { get { return state; } }
        public List<Frame> Frames { get { return frames; } }
        public int Type { get { return type; } }

        public Communication(int id, string serverIP, string clientIP, int serverPort, int clientPort, int protocol)
        {
            this.id = id;
            state = CommunicationStates.Listen;
            layer = Layers.Application;
            isClosed = false;
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
            if (f.transport.SynFlag && !f.transport.AckFlag && state==CommunicationStates.Listen)
                state = CommunicationStates.SynRecived;

            if (f.transport.SynFlag && f.transport.AckFlag && state == CommunicationStates.SynRecived)
                state = CommunicationStates.PartiallyEstablished;

            if (!f.transport.SynFlag && !f.transport.AckFlag && state == CommunicationStates.PartiallyEstablished)
                state = CommunicationStates.Established;

            layer = Layers.Application;
            frames.Add(f);
        }

        public void addARP(Frame f)
        {
            if (f.internet.Protocol==-1)
            {
                if (f.internet.Operation == 1)
                {
                    state = CommunicationStates.Established;
                    frames.Add(f);
                }

                if (f.internet.Operation == 2 && state == CommunicationStates.Established)
                {
                    state = CommunicationStates.Closed;
                    frames.Add(f);
                }
                type = 2054;
                layer = Layers.NetworkInterface;
                frames.Add(f);
            }
        }

        public void addICMP(Frame f)
        {
            state = CommunicationStates.Closed;
            type  = 1;
            layer = Layers.Internet;
            frames.Add(f);
        }

        public void addUDP(Frame f)
        {
            state = CommunicationStates.Closed;
            layer = Layers.Application;
            frames.Add(f);
        }
    }
}
