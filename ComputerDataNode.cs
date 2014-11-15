using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerStructure
{
    public class ComputerNode
    {
        private string hostBlock;
        private string dataBlock;
        private string city;
        private string country;
        private string hostName;
        private string ip;
        private string latitude;
        private string longitude;
        private string port;
        private List<string> ports;
        private string os;
        private string isp;
        private int onlineStatus = 0;
        private int id;
        //ONLINE STATUS Values:
        //0= not checked yet
        //1 = online
        //-1 = offline
        //--------------------------------------------MAKE NODES---------------------------------------------------//
        /// <summary>
        /// Used for making XML Nodes
        /// </summary>
        /// <param name="HostBlock"></param>
        /// <param name="DataBlock"></param>
        public ComputerNode(string HostBlock, string DataBlock)
        {
            hostBlock = HostBlock;
            dataBlock = DataBlock;
        }

        /// <summary>
        /// Used to Make node from a Search
        /// </summary>
        public ComputerNode()
        {
            hostBlock = hostName;
        }

        //-----------------------------------------------PROPERTYS OF EACH NODE-------------------------------------------------------------------//
        public string HostISP
        {
            get { return isp; }
            set { isp = value; }
        }//tells isp
        public string HostOS
        {
            get { return os; }
            set { os = value; }
        }//tells os
        public string HostName//gives the unfiltered string for host name
        {
            get
            {
                if (hostName != null)
                {
                    return hostName;
                }
                else
                    return HostIP;
            }
            set
            {
                hostName = value;
            }

        }
        public string HostCity//gives sorted out city
        {
            get { return city; }
            set
            {
                city = value;
            }
        }
        public string HostCountry//gives sorted out country
        {
            get { return country; }
            set
            {
                country = value;
            }
        }
        public string HostIP//gives sorted out ip
        {
            get
            {
                if (ip == null)
                {
                    return ip = "NO IP";
                }
                else
                    return ip;
            }
            set
            {
                ip = value;
            }
        }
        public string HostLatitude//gives sorted out lat
        {
            get { return latitude; }
            set
            {
                latitude = value;
            }
        }
        public string HostLongitude//gives sorted out long
        {
            get { return longitude; }
            set
            {
                longitude = value;
            }
        }
        public string HostPorts//gives sorted out port
        {
            get { return port; }
            set
            {
                port = value;
            }
        }
        public List<string> HostPort
        {
            get
            {
                return ports;
            }
            set
            {
                ports = value;
            }
        }
        public string DataBlock//gives unsorted and un filtered datablock
        {
            get { return dataBlock; }
            set { dataBlock = value; }
        }
        public int OnlineStatus//is the device Verified to be online
        {
            get
            {
                return onlineStatus;
            }
            set
            {
                onlineStatus = value;
            }
        }
        public int Device_ID
        { get; set; }
    }
    public class sortOnonlineStatus : IComparer<ComputerNode>
        {
            public int Compare(ComputerNode a, ComputerNode b)
            {
                if (a.onlineStatus > b.onlineStatus) return 1;
                else if (a.onlineStatus < b.onlineStatus) return -1;
                else return 0;
            }
        }
}
