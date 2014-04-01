using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PcapDotNet.Core;
using PcapDotNet.Base;
using PcapDotNet.Packets;

namespace NetworkAnalzyer
{
    class TransportLayer
    {
        private Byte[] segment;
        private int sourcePort;
        private int destinationPort;
        private bool rstFlag;
        private bool synFlag;
        private bool finFlag;
        private bool ackFlag;
        private int sequenceNumber;
        private int acknowledgementNumber;

        public int SourcePort { get { return sourcePort; } }
        public int DestinationPort { get { return destinationPort; } }
        public bool RstFlag { get { return rstFlag; } }
        public bool AckFlag { get { return ackFlag; } }
        public bool SynFlag { get { return synFlag; } }
        public bool FinFlag { get { return finFlag; } }

        public int SequenceNumber { get { return sequenceNumber; } }
        public int AcknowledgementNumber { get { return acknowledgementNumber; } }


        public TransportLayer(Byte[] segment, int protocol)
        {
            if (protocol == -1)
            {
                destinationPort = -1;
                sourcePort = -1;
            }
            
            this.segment = segment;
            switch(protocol)
            {
                case 6:
                    TCP();
                    break;
                case 17:
                    UDP();
                    break;
            }
        }

        private void UDP()
        {
            sourcePort = segment[0] * 256 + segment[1];
            destinationPort = segment[2] * 256 + segment[3];
        }

        private void TCP()
        {
            sourcePort = segment[0] * 256 + segment[1];
            destinationPort = segment[2] * 256 + segment[3];

            //sequenceNumber = segment[3] * 256 + segment[4];
            //acknowledgementNumber = segment[4] * 256 + segment[5];

            finFlag = (segment[13] & 1) != 0;
            synFlag = (segment[13] & 2) != 0;
            rstFlag = (segment[13] & 4) != 0;
            ackFlag = (segment[13] & 16) != 0;
        }

    }
}
