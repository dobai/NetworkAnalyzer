using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetworkAnalzyer
{
    public enum CommunicationStates {Listen, SynRecived, PartiallyEstablished, Established, CloseWait, PartiallyClosed, TimeWait, Closed}

    class Communication
    {
        private int type;
        private int serverPort;
        private int clientPort;
        private string serverIP;
        private string clientIP;
        private int protocol;
        private bool isClosed;
        private CommunicationStates states;
        private List<Frame> frames = new List<Frame>();

        public int ServerPort { get { return serverPort; } }
        public int ClientPort { get { return clientPort; } }
        public string ServerIP { get { return serverIP; } }
        public string ClientIP { get { return clientIP; } }
        public int Protocol { get { return protocol; } }
        public bool IsClosed { get { return isClosed; } }
        public CommunicationStates States { get { return states; } }
        public List<Frame> Frames { get { return frames; } }
        public int Type { get { return type; } }

        public Communication(string serverIP, string clientIP, int serverPort, int clientPort, int protocol)
        {
            states = CommunicationStates.Listen;
            isClosed = false;
            this.serverIP = serverIP;
            this.clientIP = clientIP;
            this.serverPort = serverPort;
            this.clientPort = clientPort;
            this.protocol = protocol;

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
                    type = clientPort;
                    break;
            }

        }

        public void addTCP(int syn, int ack, int fin, int rst)
        {

        }
    }
}
