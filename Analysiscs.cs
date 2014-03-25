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
        private ArrayList communication;

        public Analysis()
        {
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
            communication.Add(new Frame(packet, count++));
        }

        public Frame getFrame(int number)
        {
            return (Frame)communication[number];
        }

        public DataTable getDataTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Typ", typeof(string));
            table.Columns.Add("Zdrojová MAC", typeof(string));
            table.Columns.Add("Cieľová MAC", typeof(string));
            table.Columns.Add("Dĺźka", typeof(string));
            table.Columns.Add("Fyzická Dĺžka", typeof(string));
            foreach(Frame f in communication)
            {
                table.Rows.Add(f.Id, f.networkInterface.Type, f.networkInterface.SourceMAC, f.networkInterface.DestinationMAC, f.networkInterface.Lenght, f.networkInterface.PhysicalLenght);
            }
            return table;
        }

        public List<string> getIPList()
        {
            List<string> list = new List<string>();
            foreach(Frame f in communication )
            {
                if (!list.Contains(f.internet.SourceIP) && f.internet.SourceIP!=null)
                    list.Add(f.internet.SourceIP);
            }
            return list;
        }
    }
}
